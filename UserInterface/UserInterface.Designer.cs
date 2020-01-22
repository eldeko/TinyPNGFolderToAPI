using System.Windows.Forms;

namespace UserInterface
{
    partial class UserInterface : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.ButtonSelectOutput = new MetroFramework.Controls.MetroButton();
            this.SourceFolder = new MetroFramework.Controls.MetroTextBox();
            this.TargetFolder = new MetroFramework.Controls.MetroTextBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.ClearButton = new MetroFramework.Controls.MetroButton();
            this.ButtonSelectSource = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.monthConvNumber = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.optionsList = new System.Windows.Forms.CheckedListBox();
            this.GlobantLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cfgButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GlobantLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSelectOutput
            // 
            this.ButtonSelectOutput.Location = new System.Drawing.Point(40, 247);
            this.ButtonSelectOutput.Name = "ButtonSelectOutput";
            this.ButtonSelectOutput.Size = new System.Drawing.Size(170, 29);
            this.ButtonSelectOutput.Style = MetroFramework.MetroColorStyle.Purple;
            this.ButtonSelectOutput.TabIndex = 1;
            this.ButtonSelectOutput.Text = "Select &Output Folder";
            this.ButtonSelectOutput.Click += new System.EventHandler(this.ButtonSelectOutput_Click);
            // 
            // SourceFolder
            // 
            this.SourceFolder.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.SourceFolder.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.SourceFolder.Location = new System.Drawing.Point(94, 179);
            this.SourceFolder.Name = "SourceFolder";
            this.SourceFolder.ReadOnly = true;
            this.SourceFolder.Size = new System.Drawing.Size(370, 40);
            this.SourceFolder.Style = MetroFramework.MetroColorStyle.Blue;
            this.SourceFolder.TabIndex = 2;
            this.SourceFolder.Text = "c:\\TestImage";
            this.SourceFolder.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SourceFolder.Click += new System.EventHandler(this.SourceFolder_Click);
            // 
            // TargetFolder
            // 
            this.TargetFolder.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TargetFolder.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.TargetFolder.Location = new System.Drawing.Point(94, 296);
            this.TargetFolder.Name = "TargetFolder";
            this.TargetFolder.Size = new System.Drawing.Size(370, 40);
            this.TargetFolder.Style = MetroFramework.MetroColorStyle.Blue;
            this.TargetFolder.TabIndex = 3;
            this.TargetFolder.Text = "c:\\Output";
            this.TargetFolder.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TargetFolder.Click += new System.EventHandler(this.TargetFolder_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.BackColor = System.Drawing.Color.LightGray;
            this.rtbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbOutput.DetectUrls = false;
            this.rtbOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rtbOutput.Location = new System.Drawing.Point(12, 407);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbOutput.Size = new System.Drawing.Size(779, 193);
            this.rtbOutput.TabIndex = 5;
            this.rtbOutput.Text = "";
            this.rtbOutput.TextChanged += new System.EventHandler(this.rtbOutput_TextChanged);
            // 
            // ClearButton
            // 
            this.ClearButton.Highlight = true;
            this.ClearButton.Location = new System.Drawing.Point(717, 606);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(61, 32);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.Click += new System.EventHandler(this.ClearLogButton);
            // 
            // ButtonSelectSource
            // 
            this.ButtonSelectSource.Location = new System.Drawing.Point(40, 130);
            this.ButtonSelectSource.Name = "ButtonSelectSource";
            this.ButtonSelectSource.Size = new System.Drawing.Size(170, 29);
            this.ButtonSelectSource.TabIndex = 0;
            this.ButtonSelectSource.Text = "Select &Source Folder";
            this.ButtonSelectSource.Click += new System.EventHandler(this.ButtonSelectSource_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(586, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Compress Count: ";
            // 
            // monthConvNumber
            // 
            this.monthConvNumber.AutoSize = true;
            this.monthConvNumber.ForeColor = System.Drawing.Color.CadetBlue;
            this.monthConvNumber.Location = new System.Drawing.Point(715, 384);
            this.monthConvNumber.Name = "monthConvNumber";
            this.monthConvNumber.Size = new System.Drawing.Size(24, 20);
            this.monthConvNumber.TabIndex = 9;
            this.monthConvNumber.Text = "---";
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StartButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartButton.Location = new System.Drawing.Point(590, 179);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(116, 60);
            this.StartButton.TabIndex = 12;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_ClickAsync);
            // 
            // optionsList
            // 
            this.optionsList.BackColor = System.Drawing.SystemColors.Menu;
            this.optionsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.optionsList.CausesValidation = false;
            this.optionsList.CheckOnClick = true;
            this.optionsList.FormattingEnabled = true;
            this.optionsList.Items.AddRange(new object[] {
            "All files to root output folder",
            "Process only PNG & JPG files"});
            this.optionsList.Location = new System.Drawing.Point(537, 266);
            this.optionsList.Name = "optionsList";
            this.optionsList.Size = new System.Drawing.Size(241, 46);
            this.optionsList.TabIndex = 13;
            this.optionsList.ThreeDCheckBoxes = true;
            this.optionsList.UseTabStops = false;
            // 
            // GlobantLogo
            // 
            this.GlobantLogo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GlobantLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GlobantLogo.Image = global::UserInterface.Properties.Resources.logo_xpod__1_;
            this.GlobantLogo.Location = new System.Drawing.Point(12, 12);
            this.GlobantLogo.Name = "GlobantLogo";
            this.GlobantLogo.Size = new System.Drawing.Size(778, 84);
            this.GlobantLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GlobantLogo.TabIndex = 14;
            this.GlobantLogo.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(53, 296);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // cfgButton
            // 
            this.cfgButton.BackColor = System.Drawing.Color.Transparent;
            this.cfgButton.BackgroundImage = global::UserInterface.Properties.Resources.CfgIcon;
            this.cfgButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cfgButton.Location = new System.Drawing.Point(740, 115);
            this.cfgButton.Name = "cfgButton";
            this.cfgButton.Size = new System.Drawing.Size(50, 44);
            this.cfgButton.TabIndex = 7;
            this.cfgButton.UseCompatibleTextRendering = true;
            this.cfgButton.UseVisualStyleBackColor = false;
            this.cfgButton.Click += new System.EventHandler(this.cfgButtonClick);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(802, 650);
            this.Controls.Add(this.GlobantLogo);
            this.Controls.Add(this.optionsList);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.monthConvNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cfgButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.TargetFolder);
            this.Controls.Add(this.SourceFolder);
            this.Controls.Add(this.ButtonSelectOutput);
            this.Controls.Add(this.ButtonSelectSource);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserInterface";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assets Converter Utility";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GlobantLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton ButtonSelectSource;
        private MetroFramework.Controls.MetroButton ButtonSelectOutput;
        private MetroFramework.Controls.MetroTextBox SourceFolder;
        private MetroFramework.Controls.MetroTextBox TargetFolder;
        public System.Windows.Forms.RichTextBox rtbOutput;
        private MetroFramework.Controls.MetroButton ClearButton;
        private System.Windows.Forms.Button cfgButton;
        private Label label1;
        public Label monthConvNumber;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button StartButton;
        public CheckedListBox optionsList;
        private PictureBox GlobantLogo;
    }
}

