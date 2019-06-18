namespace UserInterface
{
    partial class UserInterface
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
            this.ButtonSelectSource = new MetroFramework.Controls.MetroButton();
            this.ButtonSelectOutput = new MetroFramework.Controls.MetroButton();
            this.SourceFolder = new MetroFramework.Controls.MetroTextBox();
            this.TargetFolder = new MetroFramework.Controls.MetroTextBox();
            this.StartButton = new MetroFramework.Controls.MetroButton();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ButtonSelectSource
            // 
            this.ButtonSelectSource.Location = new System.Drawing.Point(24, 61);
            this.ButtonSelectSource.Name = "ButtonSelectSource";
            this.ButtonSelectSource.Size = new System.Drawing.Size(200, 43);
            this.ButtonSelectSource.Style = MetroFramework.MetroColorStyle.Teal;
            this.ButtonSelectSource.TabIndex = 0;
            this.ButtonSelectSource.Text = "Select Source Folder";
            this.ButtonSelectSource.Click += new System.EventHandler(this.ButtonSelectSource_Click);
            // 
            // ButtonSelectOutput
            // 
            this.ButtonSelectOutput.Location = new System.Drawing.Point(24, 179);
            this.ButtonSelectOutput.Name = "ButtonSelectOutput";
            this.ButtonSelectOutput.Size = new System.Drawing.Size(200, 43);
            this.ButtonSelectOutput.Style = MetroFramework.MetroColorStyle.Purple;
            this.ButtonSelectOutput.TabIndex = 1;
            this.ButtonSelectOutput.Text = "Select Output Folder";
            this.ButtonSelectOutput.Click += new System.EventHandler(this.ButtonSelectOutput_Click);
            // 
            // SourceFolder
            // 
            this.SourceFolder.Location = new System.Drawing.Point(24, 111);
            this.SourceFolder.Name = "SourceFolder";
            this.SourceFolder.Size = new System.Drawing.Size(560, 30);
            this.SourceFolder.TabIndex = 2;
            this.SourceFolder.Text = "Source Folder";
            this.SourceFolder.Click += new System.EventHandler(this.SourceFolder_Click);
            // 
            // TargetFolder
            // 
            this.TargetFolder.Location = new System.Drawing.Point(24, 228);
            this.TargetFolder.Name = "TargetFolder";
            this.TargetFolder.Size = new System.Drawing.Size(560, 30);
            this.TargetFolder.TabIndex = 3;
            this.TargetFolder.Text = "TargetFolder";
            this.TargetFolder.Click += new System.EventHandler(this.TargetFolder_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(645, 152);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(132, 59);
            this.StartButton.Style = MetroFramework.MetroColorStyle.Teal;
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "START";
            this.StartButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.StartButton.Click += new System.EventHandler(this.StartButton_ClickAsync);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(5, 298);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(792, 462);
            this.rtbOutput.TabIndex = 5;
            this.rtbOutput.Text = "";
            this.rtbOutput.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(800, 764);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.TargetFolder);
            this.Controls.Add(this.SourceFolder);
            this.Controls.Add(this.ButtonSelectOutput);
            this.Controls.Add(this.ButtonSelectSource);
            this.Name = "UserInterface";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton ButtonSelectSource;
        private MetroFramework.Controls.MetroButton ButtonSelectOutput;
        private MetroFramework.Controls.MetroTextBox SourceFolder;
        private MetroFramework.Controls.MetroTextBox TargetFolder;
        private MetroFramework.Controls.MetroButton StartButton;
        public System.Windows.Forms.RichTextBox rtbOutput;
    }
}

