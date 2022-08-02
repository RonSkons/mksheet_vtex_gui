namespace mksheet_vtex_gui
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tf2FolderTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.frameTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.prefixTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.makeMKS = new System.Windows.Forms.Button();
            this.loopBox = new System.Windows.Forms.CheckBox();
            this.makeVTF = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Team Fortress 2 folder:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tf2FolderTextBox
            // 
            this.tf2FolderTextBox.Location = new System.Drawing.Point(184, 6);
            this.tf2FolderTextBox.Name = "tf2FolderTextBox";
            this.tf2FolderTextBox.Size = new System.Drawing.Size(384, 23);
            this.tf2FolderTextBox.TabIndex = 2;
            this.tf2FolderTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Folder containing TGA frames:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frameTextBox
            // 
            this.frameTextBox.Location = new System.Drawing.Point(184, 35);
            this.frameTextBox.Name = "frameTextBox";
            this.frameTextBox.Size = new System.Drawing.Size(384, 23);
            this.frameTextBox.TabIndex = 4;
            this.frameTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(574, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Frame filename prefix:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // prefixTextBox
            // 
            this.prefixTextBox.Location = new System.Drawing.Point(184, 64);
            this.prefixTextBox.Name = "prefixTextBox";
            this.prefixTextBox.Size = new System.Drawing.Size(421, 23);
            this.prefixTextBox.TabIndex = 7;
            this.prefixTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Desired sprite name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(184, 93);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(298, 23);
            this.nameTextBox.TabIndex = 9;
            this.nameTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // makeMKS
            // 
            this.makeMKS.Location = new System.Drawing.Point(12, 122);
            this.makeMKS.Name = "makeMKS";
            this.makeMKS.Size = new System.Drawing.Size(593, 23);
            this.makeMKS.TabIndex = 10;
            this.makeMKS.Text = "Create MKS file";
            this.makeMKS.UseVisualStyleBackColor = true;
            this.makeMKS.Click += new System.EventHandler(this.button3_Click);
            // 
            // loopBox
            // 
            this.loopBox.AutoSize = true;
            this.loopBox.Location = new System.Drawing.Point(488, 97);
            this.loopBox.Name = "loopBox";
            this.loopBox.Size = new System.Drawing.Size(117, 19);
            this.loopBox.TabIndex = 11;
            this.loopBox.Text = "Loop Animation?";
            this.loopBox.UseVisualStyleBackColor = true;
            this.loopBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // makeVTF
            // 
            this.makeVTF.Enabled = false;
            this.makeVTF.Location = new System.Drawing.Point(12, 151);
            this.makeVTF.Name = "makeVTF";
            this.makeVTF.Size = new System.Drawing.Size(470, 23);
            this.makeVTF.TabIndex = 12;
            this.makeVTF.Text = "Create VTF file";
            this.makeVTF.UseVisualStyleBackColor = true;
            this.makeVTF.Click += new System.EventHandler(this.button4_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 190);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 15);
            this.statusLabel.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(488, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "VTEX Config";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 214);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.makeVTF);
            this.Controls.Add(this.loopBox);
            this.Controls.Add(this.makeMKS);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prefixTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.frameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tf2FolderTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Animated Sprite Utility 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private Button button1;
        private Label label1;
        private TextBox tf2FolderTextBox;
        private FolderBrowserDialog folderBrowserDialog2;
        private Label label2;
        private TextBox frameTextBox;
        private Button button2;
        private Label label3;
        private TextBox prefixTextBox;
        private Label label4;
        private TextBox nameTextBox;
        private Button makeMKS;
        private CheckBox loopBox;
        private Button makeVTF;
        private Label statusLabel;
        private Button button3;
    }
}