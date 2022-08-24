using System.IO;

namespace mksheet_vtex_gui
{
    public partial class MainForm : Form
    {
        private string tf2Folder;
        private string frameFolder;
        private string fileName;
        private string mksFile;
        private List<string> frames = new List<string>();

        public MainForm()
        {
            tf2Folder = Properties.Settings.Default.TeamFortressFolder;
            frameFolder = Properties.Settings.Default.FrameFolder;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tf2FolderTextBox.Text = tf2Folder;
            frameTextBox.Text = frameFolder;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = folderBrowserDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                tf2Folder = folderBrowserDialog1.SelectedPath;

                //Save to settings
                Properties.Settings.Default.TeamFortressFolder = tf2Folder;
                Properties.Settings.Default.Save();

                tf2FolderTextBox.Text = tf2Folder;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tf2Folder = tf2FolderTextBox.Text;

            //Save to settings
            Properties.Settings.Default.TeamFortressFolder = tf2Folder;
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = folderBrowserDialog2.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                frameFolder = folderBrowserDialog2.SelectedPath;

                //Save to settings
                Properties.Settings.Default.FrameFolder = frameFolder;
                Properties.Settings.Default.Save();

                frameTextBox.Text = frameFolder;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Filter out illegal characters
            prefixTextBox.Text = CleanFileName(prefixTextBox.Text);
            prefixTextBox.SelectionStart = prefixTextBox.Text.Length;
        }

        public string CleanFileName(string name)
        {
            //Removes invalid file name characters from given string
            return string.Concat(name.Split(Path.GetInvalidFileNameChars()));
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //Filter out illegal characters
            nameTextBox.Text = CleanFileName(nameTextBox.Text);
            nameTextBox.SelectionStart = nameTextBox.Text.Length;
        }

        private void makeMKS_Click(object sender, EventArgs e)
        {
            fileName = nameTextBox.Text;

            //Validate file names
            if (fileName == "")
            {
                MessageBox.Show("Please enter a desired name for your VTF.");
                return;
            }
            if (!Directory.Exists(tf2Folder))
            {
                MessageBox.Show(tf2Folder+" is not a valid directory.");
                return;
            }
            if (!Directory.Exists(frameFolder))
            {
                MessageBox.Show(frameFolder + " is not a valid directory.");
                return;
            }

            statusLabel.Text = "Creating MKS file...";

            //Find all TGA files with the appropriate prefix
            string[] files = Directory.GetFiles(frameFolder);
            frames.Clear();
            foreach (string file in files) //Find all tga files beginning with provided prefix
            {
                if (Path.GetFileName(file).StartsWith(prefixTextBox.Text) && Path.GetExtension(file).ToLower().Equals(".tga"))
                {
                    frames.Add(Path.GetFileName(file));
                    if (Path.GetFileName(file).Contains(" "))
                    {
                        MessageBox.Show("Error: mksheet.exe breaks when frame names contain spaces. Rename and try again.");
                        return;
                    }
                }
            }
            
            if(frames.Count == 0)
            {
                MessageBox.Show("No frames with prefix " + prefixTextBox.Text + " found.");
                return;
            }

            frames.Sort(); //Sort frames. Assumption is that frames are provided with ascending numerical suffixes.

            bool splitSequences = sequenceSplitBox.Checked; //If checked, each frame will get its own sequence.

            //Create mks file
            mksFile = frameFolder + "\\" + fileName + ".mks";
            using FileStream fs = File.Create(mksFile);
            string mks = "";
            //Iterate through frames
            for(int i = 0; i < frames.Count; i++)
            {
                string frame = frames[i];

                if(i == 0) //Always create sequence 0
                {
                    mks += "sequence 0";
                    if (loopBox.Checked)
                    {
                        mks += "\r\nLOOP";
                    }
                }
                else if (splitSequences) //If splitSequences is true, create a sequence for each frame.
                {
                    mks += "\r\n\r\nsequence " + i.ToString();
                    if (loopBox.Checked)
                    {
                        mks += "\r\nLOOP";
                    }
                }

                mks += "\r\nframe " + frame + " 1";
            }

            fs.Write(System.Text.Encoding.UTF8.GetBytes(mks)); //Write to file

            //Enable "Create VTF File" button
            makeVTF.Enabled = true;
            statusLabel.Text = "Done! " + fileName + ".mks created. Make any changes now.";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            frameFolder = frameTextBox.Text;
            //Save to settings
            Properties.Settings.Default.FrameFolder = frameFolder;
            Properties.Settings.Default.Save();
        }

        private void makeVTF_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "Creating SHT and TGA files...";
            makeVTF.Enabled = false;

            //Copy/move all relevant files to /bin
            string tf2Bin = tf2Folder + "\\bin\\";
            foreach(string frame in frames)
            {
                File.Copy(frameFolder + "\\" + frame, tf2Bin + frame);
            }
            File.Move(mksFile, tf2Bin + fileName+".mks");

            //Create SHT and TGA
            var processStartInfo = new System.Diagnostics.ProcessStartInfo();
            processStartInfo.WorkingDirectory = tf2Folder+"\\bin";
            processStartInfo.FileName = "cmd.exe";
            processStartInfo.Arguments = "/C mksheet.exe "+fileName+".mks";
            System.Diagnostics.Process mksheet = System.Diagnostics.Process.Start(processStartInfo);
            mksheet.WaitForExit();

            //Delete files that are no longer needed
            foreach (string frame in frames) 
            {
                File.Delete(tf2Bin + frame);
            }
            File.Delete(tf2Bin + fileName + ".mks");

            //If materialsrc does not yet exist, create it
            if (!File.Exists(tf2Folder + "\\tf\\materialsrc"))
            {
                _ = Directory.CreateDirectory(tf2Folder + "\\tf\\materialsrc");
            }

            //Move tga and sht files to materialsrc
            File.Move(tf2Bin + fileName + ".sht", tf2Folder + "\\tf\\materialsrc\\" + fileName + ".sht");
            File.Move(tf2Bin + fileName + ".tga", tf2Folder + "\\tf\\materialsrc\\" + fileName + ".tga");

            processStartInfo.WorkingDirectory = Environment.GetEnvironmentVariable("SYSTEMROOT");

            statusLabel.Text = "Creating VTF file...";

            //Create a config file if there are saved vtex parameters
            string vtexParams = Properties.Settings.Default.VTEXConfig;
            if(vtexParams.Length > 0)
            {
                using FileStream fs = File.Create(tf2Folder + "\\tf\\materialsrc\\" + fileName + ".txt");
                fs.Write(System.Text.Encoding.UTF8.GetBytes(vtexParams));
            }

            //Set envars and run vtex
            processStartInfo.Arguments = "/C set VGAME="+tf2Folder + "&set VPROJECT=" + tf2Folder + "\\tf" + "&\""+ tf2Bin + "vtex.exe\" -nopause \"" + tf2Folder + "\\tf\\materialsrc\\" + fileName + ".sht\"";
            System.Diagnostics.Process vtex = System.Diagnostics.Process.Start(processStartInfo);
            vtex.WaitForExit();

            //Delete files that are no longer needed
            File.Delete(tf2Folder + "\\tf\\materialsrc\\" + fileName + ".sht");
            File.Delete(tf2Folder + "\\tf\\materialsrc\\" + fileName + ".tga");
            if(vtexParams.Length > 0)
            {
                //Clean up config file if needed
                File.Delete(tf2Folder + "\\tf\\materialsrc\\" + fileName + ".txt");
            }

            //Move completed vtf to the original directory
            string vtfLocation = frameFolder + "\\" + fileName + ".vtf";

            if (File.Exists(vtfLocation)) //If the file already exists, delete it
            {
                File.Delete(vtfLocation);
            }
            File.Move(tf2Folder + "\\tf\\materials\\" + fileName + ".vtf", vtfLocation);

            statusLabel.Text = "Done! " + fileName + ".vtf created.";
        }

        private void vtexCfgButton_Click(object sender, EventArgs e)
        {
            var vtexConfig = new VTEXConfig();
            vtexConfig.Show();
        }

        private void pngToTgaButton_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "Converting PNG files with prefix " + prefixTextBox.Text+"...";
            //Convert all png files with given prefix to tga
            //First, find all png files with the appropriate prefix
            string[] files = Directory.GetFiles(frameFolder);
            TGASharpLib.TGA T;
            foreach (string file in files) //Find all tga files beginning with provided prefix
            {
                if (Path.GetFileName(file).StartsWith(prefixTextBox.Text) && Path.GetExtension(file).ToLower().Equals(".png"))
                {
                    //From https://stackoverflow.com/questions/52682630/c-sharp-how-to-convert-png-jpg-to-tga-32bit
                    using (Bitmap clone = new Bitmap(file))
                    using (Bitmap newbmp = clone.Clone(new Rectangle(0, 0, clone.Width, clone.Height), System.Drawing.Imaging.PixelFormat.Format32bppArgb))
                    T = (TGASharpLib.TGA)newbmp;
                    T.Save(Path.GetDirectoryName(file) + "\\" + Path.GetFileNameWithoutExtension(file) + ".tga");
                }
            }

            statusLabel.Text = "Conversion complete.";
        }

        private void makeVMT_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "Generating VMT file...";
            //Generate a VMT file
            fileName = nameTextBox.Text;

            using FileStream fs = File.Create(frameFolder+"\\"+fileName+".vmt");
            //Generate VMT contents
            fs.Write(System.Text.Encoding.UTF8.GetBytes("\"SpriteCard\"\r\n{\r\n"));
            fs.Write(System.Text.Encoding.UTF8.GetBytes("\t\"$basetexture\" \""+fileName+"\"\r\n"));
            fs.Write(System.Text.Encoding.UTF8.GetBytes("\t\"$blendframes\" " + (blendFramesBox.Checked ? "1" : "0") + "\r\n"));
            fs.Write(System.Text.Encoding.UTF8.GetBytes("\t\"$depthblend\" " + (depthBlendBox.Checked ? "1" : "0") + "\r\n"));
            fs.Write(System.Text.Encoding.UTF8.GetBytes("\t\"$additive\" " + (additiveBox.Checked ? "1" : "0") + "\r\n}"));

            statusLabel.Text = "Done! " + fileName + ".vmt created.";
        }
    }
}