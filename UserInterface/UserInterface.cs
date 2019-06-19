using Rich_Console;
using System;
using System.Windows.Forms;
using TinyBackend;
using TinyPng;

namespace UserInterface
{
    public partial class UserInterface : MetroFramework.Forms.MetroForm
    {
        TinyBackend.Converter convertRobert;
        RichConsole richConsole = null;
       
        public UserInterface()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            convertRobert = new Converter();
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
            if (StartButton.Enabled)
            {
                StartButton.Enabled = false;
                StartButton.Update();
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Calling service with:");
                Console.WriteLine("Source Folder: " + SourceFolder.Text);
                Console.WriteLine("Output Folder: " + TargetFolder.Text);
                Console.WriteLine("-------------------------------------------------");
                try
                {
                    await convertRobert.CopyFolderAsync(SourceFolder.Text, TargetFolder.Text);
                }
                catch (TinyPngApiException ex)
                {
                    if (ex.Message.Contains("monthly limit"))
                    {
                        Console.WriteLine("Monthly limit exceed exception");
                        Console.WriteLine("Retry after changing API Key");
                    }                   
                }
                Application.DoEvents();
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Finished");
              
                StartButton.Enabled = true;
                StartButton.Update();
            }            
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TargetFolder_Click(object sender, EventArgs e)
        {

        }

        private void SourceFolder_Click(object sender, EventArgs e)
        {

        }

        private void ClearLogButton(object sender, EventArgs e)
        {
            rtbOutput.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {

        }

        private void cfgButtonClick(object sender, EventArgs e)
        {
            CfgForm cfgForm = new CfgForm();
            cfgForm.ShowDialog();
        }
    }
}
