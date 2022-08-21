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
            this.vtexCfgButton = new System.Windows.Forms.Button();
            this.pngToTgaButton = new System.Windows.Forms.Button();
            this.blendFramesBox = new System.Windows.Forms.CheckBox();
            this.depthBlendBox = new System.Windows.Forms.CheckBox();
            this.additiveBox = new System.Windows.Forms.CheckBox();
            this.makeVMT = new System.Windows.Forms.Button();
            this.sequenceSplitBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(618, 6);
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
            // 
            // tf2FolderTextBox
            // 
            this.tf2FolderTextBox.Location = new System.Drawing.Point(184, 6);
            this.tf2FolderTextBox.Name = "tf2FolderTextBox";
            this.tf2FolderTextBox.Size = new System.Drawing.Size(428, 23);
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
            // 
            // frameTextBox
            // 
            this.frameTextBox.Location = new System.Drawing.Point(184, 35);
            this.frameTextBox.Name = "frameTextBox";
            this.frameTextBox.Size = new System.Drawing.Size(428, 23);
            this.frameTextBox.TabIndex = 4;
            this.frameTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(618, 35);
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
            // 
            // prefixTextBox
            // 
            this.prefixTextBox.Location = new System.Drawing.Point(184, 64);
            this.prefixTextBox.Name = "prefixTextBox";
            this.prefixTextBox.Size = new System.Drawing.Size(298, 23);
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
            this.nameTextBox.Size = new System.Drawing.Size(208, 23);
            this.nameTextBox.TabIndex = 9;
            this.nameTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // makeMKS
            // 
            this.makeMKS.Location = new System.Drawing.Point(12, 122);
            this.makeMKS.Name = "makeMKS";
            this.makeMKS.Size = new System.Drawing.Size(637, 23);
            this.makeMKS.TabIndex = 10;
            this.makeMKS.Text = "Generate MKS file";
            this.makeMKS.UseVisualStyleBackColor = true;
            this.makeMKS.Click += new System.EventHandler(this.makeMKS_Click);
            // 
            // loopBox
            // 
            this.loopBox.AutoSize = true;
            this.loopBox.Location = new System.Drawing.Point(537, 97);
            this.loopBox.Name = "loopBox";
            this.loopBox.Size = new System.Drawing.Size(112, 19);
            this.loopBox.TabIndex = 11;
            this.loopBox.Text = "Loop Animation";
            this.loopBox.UseVisualStyleBackColor = true;
            // 
            // makeVTF
            // 
            this.makeVTF.Enabled = false;
            this.makeVTF.Location = new System.Drawing.Point(12, 151);
            this.makeVTF.Name = "makeVTF";
            this.makeVTF.Size = new System.Drawing.Size(470, 23);
            this.makeVTF.TabIndex = 12;
            this.makeVTF.Text = "Create VTF";
            this.makeVTF.UseVisualStyleBackColor = true;
            this.makeVTF.Click += new System.EventHandler(this.makeVTF_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 206);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 15);
            this.statusLabel.TabIndex = 14;
            // 
            // vtexCfgButton
            // 
            this.vtexCfgButton.Location = new System.Drawing.Point(488, 151);
            this.vtexCfgButton.Name = "vtexCfgButton";
            this.vtexCfgButton.Size = new System.Drawing.Size(161, 23);
            this.vtexCfgButton.TabIndex = 15;
            this.vtexCfgButton.Text = "VTEX Config";
            this.vtexCfgButton.UseVisualStyleBackColor = true;
            this.vtexCfgButton.Click += new System.EventHandler(this.vtexCfgButton_Click);
            // 
            // pngToTgaButton
            // 
            this.pngToTgaButton.Location = new System.Drawing.Point(488, 64);
            this.pngToTgaButton.Name = "pngToTgaButton";
            this.pngToTgaButton.Size = new System.Drawing.Size(161, 23);
            this.pngToTgaButton.TabIndex = 16;
            this.pngToTgaButton.Text = "Batch convert PNG to TGA";
            this.pngToTgaButton.UseVisualStyleBackColor = true;
            this.pngToTgaButton.Click += new System.EventHandler(this.pngToTgaButton_Click);
            // 
            // blendFramesBox
            // 
            this.blendFramesBox.AutoSize = true;
            this.blendFramesBox.Location = new System.Drawing.Point(12, 184);
            this.blendFramesBox.Name = "blendFramesBox";
            this.blendFramesBox.Size = new System.Drawing.Size(97, 19);
            this.blendFramesBox.TabIndex = 17;
            this.blendFramesBox.Text = "Blend Frames";
            this.blendFramesBox.UseVisualStyleBackColor = true;
            // 
            // depthBlendBox
            // 
            this.depthBlendBox.AutoSize = true;
            this.depthBlendBox.Checked = true;
            this.depthBlendBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.depthBlendBox.Location = new System.Drawing.Point(115, 184);
            this.depthBlendBox.Name = "depthBlendBox";
            this.depthBlendBox.Size = new System.Drawing.Size(88, 19);
            this.depthBlendBox.TabIndex = 18;
            this.depthBlendBox.Text = "Depthblend";
            this.depthBlendBox.UseVisualStyleBackColor = true;
            // 
            // additiveBox
            // 
            this.additiveBox.AutoSize = true;
            this.additiveBox.Location = new System.Drawing.Point(209, 184);
            this.additiveBox.Name = "additiveBox";
            this.additiveBox.Size = new System.Drawing.Size(70, 19);
            this.additiveBox.TabIndex = 19;
            this.additiveBox.Text = "Additive";
            this.additiveBox.UseVisualStyleBackColor = true;
            // 
            // makeVMT
            // 
            this.makeVMT.Location = new System.Drawing.Point(285, 180);
            this.makeVMT.Name = "makeVMT";
            this.makeVMT.Size = new System.Drawing.Size(364, 23);
            this.makeVMT.TabIndex = 20;
            this.makeVMT.Text = "Generate VMT";
            this.makeVMT.UseVisualStyleBackColor = true;
            this.makeVMT.Click += new System.EventHandler(this.makeVMT_Click);
            // 
            // sequenceSplitBox
            // 
            this.sequenceSplitBox.AutoSize = true;
            this.sequenceSplitBox.Location = new System.Drawing.Point(398, 97);
            this.sequenceSplitBox.Name = "sequenceSplitBox";
            this.sequenceSplitBox.Size = new System.Drawing.Size(129, 19);
            this.sequenceSplitBox.TabIndex = 21;
            this.sequenceSplitBox.Text = "Multiple Sequences";
            this.sequenceSplitBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 232);
            this.Controls.Add(this.sequenceSplitBox);
            this.Controls.Add(this.makeVMT);
            this.Controls.Add(this.additiveBox);
            this.Controls.Add(this.depthBlendBox);
            this.Controls.Add(this.blendFramesBox);
            this.Controls.Add(this.pngToTgaButton);
            this.Controls.Add(this.vtexCfgButton);
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
            this.Name = "MainForm";
            this.Text = "Animated Sprite Utility 1.2.2";
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
        private Button vtexCfgButton;
        private Button pngToTgaButton;
        private CheckBox blendFramesBox;
        private CheckBox depthBlendBox;
        private CheckBox additiveBox;
        private Button makeVMT;
        private CheckBox sequenceSplitBox;
    }
}