using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUI
{
    public class SourceFile
    {
        // Muc dich cua cai nay dung de doc du lieu INF, DATA, SCRIPT lên 
        // cái Process data là trong moi cai no doc len va co cai gi va dua vao bo du lieu


        // Contructor
        public SourceFile(IFileParser parser)
        {
            Parser = parser;
            ProcessData();
        }

        // duong dan cua một file 
        public string PathFile
        {
            get { return Parser.WorkingDir; }
            set
            {
               Parser.WorkingDir = value;
            }
        }

        // xac dinh cái nay là interface ha script ha data
        string namesl;
        public string Name
        {
            get
            {
                return namesl;
            }


            protected set
            {
                namesl = value;
            }
        }

        // Lây ra bo du lieu tung dong
        protected List<SourceLine> Lines { get; private set; }

        //Parser
        public IFileParser Parser { get; private set; }

        // Tien trinh lay du lieu
        protected virtual void ProcessData()
        {
            //Lines = Parser.Lines;
        }
    }

}
