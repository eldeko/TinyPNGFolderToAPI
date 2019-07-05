using Rich_Console;
using System;
using System.Windows.Forms;
using TinyBackend;
using TinyPng;

namespace UserInterface
{
    public partial class UserInterface
    {
        
        RichConsole richConsole = null;
        MiddleService middleService = null;
        public UserInterface()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            middleService = new MiddleService();
            richConsole = new RichConsole(rtbOutput);
            Console.SetOut(richConsole);            
        }

        private void FolderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            
        }

        private void ButtonSelectSource_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browserDialogSource = new FolderBrowserDialog();
            browserDialogSource.RootFolder = Environment.SpecialFolder.Desktop;
            browserDialogSource.Description = "Select Source Folder";
            browserDialogSource.ShowNewFolderButton = false;
            if (browserDialogSource.ShowDialog() == DialogResult.OK)
            {
                SourceFolder.Text = browserDialogSource.SelectedPath;
            }
        }

        private void ButtonSelectOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browserDialogTarget = new FolderBrowserDialog();
            browserDialogTarget.ShowNewFolderButton = true;
            browserDialogTarget.RootFolder = Environment.SpecialFolder.Desktop;
            browserDialogTarget.Description = "Select Source Folder";
            browserDialogTarget.ShowNewFolderButton = true;
            if (browserDialogTarget.ShowDialog() == DialogResult.OK)
            {
                TargetFolder.Text = browserDialogTarget.SelectedPath;
            }
        }

        private async void StartButton_ClickAsync(object sender, EventArgs e)
        {
           bool  rootFolderOpt = optionsList.GetItemChecked(0);
           bool  onlyImageOpt  = optionsList.GetItemChecked(1);

            if (StartButton.Enabled)
            {
                StartButton.Enabled = false;
                StartButton.Update();    
                
             //  await middleService.CallService(SourceFolder.Text, TargetFolder.Text);

                Application.DoEvents();                
              
                StartButton.Enabled = true;
                StartButton.Update();
                Console.WriteLine("Done");
            }            
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            monthConvNumber.Text = MiddleService.monthConvs.ToString();
        }

        private void TargetFolder_Click(object sender, EventArgs e)
        {
            ButtonSelectOutput_Click(sender, e);
        }

        private void SourceFolder_Click(object sender, EventArgs e)
        {
            ButtonSelectSource_Click(sender, e);
        }

        private void ClearLogButton(object sender, EventArgs e)
        {
            rtbOutput.Clear();            
        }

        private void cfgButtonClick(object sender, EventArgs e)
        {
            CfgForm cfgForm = new CfgForm();
            cfgForm.ShowDialog();
        }

        private void GlobantLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
