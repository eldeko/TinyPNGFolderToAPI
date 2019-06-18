using Rich_Console;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyBackend;

namespace UserInterface
{
    public partial class UserInterface : MetroFramework.Forms.MetroForm
    {
        RichConsole richConsole = null;
        Logger logger = LoggerService.GetLogger();
        

        public UserInterface()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richConsole = new RichConsole(rtbOutput);
            Console.SetOut(richConsole);

            Console.WriteLine("Hello World!");
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

        private void StartButton_ClickAsync(object sender, EventArgs e)
        {
            
            TinyBackend.Converter convertRobert = new TinyBackend.Converter();
                Console.WriteLine("Started Converter");
           
            convertRobert.CopyFolderAsync(SourceFolder.Text, TargetFolder.Text);           

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
    }
}
