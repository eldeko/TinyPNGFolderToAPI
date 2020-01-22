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
    public partial class CfgForm : Form
    {
        public CfgForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {            
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveData.SaveCfg(ApiKeyTextBox.Text);
        }

        private void ApiKeyLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
