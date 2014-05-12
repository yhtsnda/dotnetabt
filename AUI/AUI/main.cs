using System.IO;
using System.Runtime.InteropServices;
//-------------------------------------------
using QiHe.CodeLib;
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.BinaryDrawingFormat;
using ExcelLibrary.BinaryFileFormat;
using ExcelLibrary.SpreadSheet;
//-------------------------------------------
using System.Linq;
using System.Text;
using White.Core.Factory;
using White.Core.UIItems.Finders;
using White.Core.InputDevices;
using System.Threading;

//-------------------------------------------

using UITimer = System.Windows.Forms.Timer;
using System.Management;
using System.Management;
using System.Windows.Forms;
using System;


//-------------------------------------------

namespace AUI
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();            
        }

        private void getLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = FileSelector.BrowseFile(FileType.Excel97);
            SourceLine SL = new SourceLine();
            int line = SL.currentline;
            textBoxTest.Text = SL.Cols(file,line);
            textBoxlinkopenline.Text = file;

        }

        
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = FileSelector.BrowseFile(FileType.Excel97);
            DirectoryTabcontrol RanString = tabControlViewData as DirectoryTabcontrol;
            RanString.Dir = file;
            RanString.Run();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IFileParser WorkDir = new IFileParser();
            NewProject _NewProject = new NewProject();
            _NewProject.ShowDialog();
            DirectoryTreeview NewDir = treeView as DirectoryTreeview;
            textBoxPathproject.Text= NewDir.PathTree = _NewProject.duongdanproject;
            string Pathproject = textBoxPathproject.Text;
            WorkDir.WorkingDir = Pathproject;
            DirectoryTreeview Tree = treeView as DirectoryTreeview;
            Tree.PathTree = Pathproject;
            Tree.Runother();

        }

        private void buttonRunTreeview_Click(object sender, EventArgs e)
        {
            string Pathproject = textBoxPathproject.Text;
            DirectoryTreeview Tree =   treeView as DirectoryTreeview;
            Tree.PathTree = Pathproject;
            Tree.Runother();
            
        }

        int line = 1;
        private void buttonNextline_Click(object sender, EventArgs e)
        {
            
            SourceLine S = new SourceLine();           
            string path = textBoxlinkopenline.Text;
            line = line + 1;
            textBoxTest.Text = S.Cols(@path,line);

        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Pathproject = textBoxPathproject.Text;
            DirectoryTreeview Tree = treeView as DirectoryTreeview;
            Tree.PathTree = Pathproject;
            Tree.Runother();
            
        }

       


        

        
    }
}
