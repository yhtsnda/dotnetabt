using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AUI
{
    public partial class NewProject : Form
    {
        public NewProject()
        {
            InitializeComponent();
        }

        string path;
        string duongdan
        {
            set
            {
                path = value;
            }
        }

        public string duongdanproject;
        public string returnduongdanproject
        {
            set
            {
                duongdanproject = value;
            }
        }
        private void buttonBrown_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Chonduongdan = new FolderBrowserDialog();
            Chonduongdan.RootFolder = Environment.SpecialFolder.MyComputer;
            if (Chonduongdan.ShowDialog() == DialogResult.OK)
            {
                duongdan = Chonduongdan.SelectedPath;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DirectoryNew DN = new DirectoryNew();
            DN.PathProject = path;
            DN.NameProject = textBoxNameProject.Text;
            returnduongdanproject = DN.CreateDir();
            this.Close();

        }

    }
}
