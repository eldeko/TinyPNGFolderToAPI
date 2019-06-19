using MetroFramework;
using TinyBackend;

namespace UserInterface

{
   public partial class CfgForm 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CfgForm));
            this.ApiKeyTextBox = new System.Windows.Forms.TextBox();
            this.ApiKeyLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ApiKeyTextBox
            // 
            this.ApiKeyTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.ApiKeyTextBox.Location = new System.Drawing.Point(222, 82);
            this.ApiKeyTextBox.MaxLength = 32;
            this.ApiKeyTextBox.Name = "ApiKeyTextBox";
            this.ApiKeyTextBox.Size = new System.Drawing.Size(517, 30);
            this.ApiKeyTextBox.TabIndex = 0;
            this.ApiKeyTextBox.Text = SaveData.ReadApiKey();

            // 
            // ApiKeyLabel
            // 
            this.ApiKeyLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ApiKeyLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ApiKeyLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ApiKeyLabel.Location = new System.Drawing.Point(29, 82);
            this.ApiKeyLabel.Name = "ApiKeyLabel";
            this.ApiKeyLabel.Padding = new System.Windows.Forms.Padding(5);
            this.ApiKeyLabel.Size = new System.Drawing.Size(187, 32);
            this.ApiKeyLabel.TabIndex = 1;
            this.ApiKeyLabel.Text = "TinyPNG Api Key:";
            this.ApiKeyLabel.UseCompatibleTextRendering = true;
            this.ApiKeyLabel.Click += new System.EventHandler(this.ApiKeyLabel_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveButton.Location = new System.Drawing.Point(418, 363);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(109, 43);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelButton.Location = new System.Drawing.Point(570, 363);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(109, 43);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Close";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CfgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ApiKeyLabel);
            this.Controls.Add(this.ApiKeyTextBox);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CfgForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "CONFIG";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ApiKeyLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.TextBox ApiKeyTextBox;
    }
}