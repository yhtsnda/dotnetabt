using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QiHe.CodeLib;
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.BinaryDrawingFormat;
using ExcelLibrary.BinaryFileFormat;
using ExcelLibrary.SpreadSheet;
using System.Windows.Forms;
using System.IO;
using System.Drawing;


namespace AUI
{
    public sealed class SourceLine
    {

   
        IFileParser Parserfile = new IFileParser();

        public SourceLine()
        {
            Columns = new List<string>();
        }


        string data;
        int current;

        public int currentline
        {
            get
            {
                current = 1;
                return current;
            }

            set
            {
                current = value;
            }
        }

        public List<string> Columns
        {
            get
            {
                int c = CountColmsv(Parserfile.pathlines);
                for (int i = 0; i <= c; i++)
                {
                    string cell = Parserfile.ValueCell(Parserfile.pathlines, currentline, i);
                    data = data + cell + " ";
                    Columns.Add(data);
                }
                return Columns;

            }

            set
            {

            }
        }

        
        public string  Cols (string Path, int line)
        {
                
                int c = CountColmsv(Path);
                for (int i = 0; i <= c; i++)
                {
                    string cell = Parserfile.ValueCell(Path, line, i);
                    data = data + cell + " ";
                }
                return data;
        }
        
        //
        public int CountColmsv (string path)            
        {
           int cot =  Parserfile.CountCoulum(path);
           return cot;
        }

        

        
    }

}
