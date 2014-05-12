using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUI
{
    class Interface : SourceFile
    {
        
        public Interface(IFileParser parser) : base(parser)
        {
            Properties = new Dictionary<string, string>();
            Controls = new Dictionary<string, Dictionary<string, string>>();
            Parser.WorkingDir = Parser.pathworkingdir + Constants.Directory.InterfaceDir;
        }

       
        public Dictionary<string, string> Properties { get; private set; }

       
        public Dictionary<string, Dictionary<string, string>> Controls { get; private set; }

        
        protected override void ProcessData()
        {
          // Lay Dc Windown - Control
        }
    

    }
}
