﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abt
{
    public class Interface : SourceFile
    {
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="parser">the file parser</param>
        public Interface(IFileParser parser)
            : base(parser)
        {
            Properties = new Dictionary<string, string>();
            Controls = new Dictionary<string, Dictionary<string, string>>();
            Parser.WorkingDir = Parser.WorkingDir + Constants.Directory.InterfaceDir;
        }

        /// <summary>
        /// properties of the interface (window)
        /// </summary>
        public Dictionary<string, string> Properties { get; private set; }

        /// <summary>
        /// properties of a control within the window
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public Dictionary<string, Dictionary<string, string>> Controls { get; private set; }

        /// <summary>
        /// process interface data from parser
        /// </summary>
        protected override void ProcessData()
        {
            base.ProcessData();

            foreach (SourceLine line in Parser.Lines)
            {
                if (line.ColumnCount > 0)
                {
                    if (Constants.KeywordWindow.Equals(line.Columns[0], StringComparison.CurrentCultureIgnoreCase))
                    {
                        this.Name = line.Columns[1].ToLower();
                        for (int i = 2; i < line.ColumnCount; i++)
                        {
                            string[] pairs = line.Columns[i].Split(Constants.PropertyDelimeter.ToCharArray(), 2);
                            if (pairs.Length != 2)
                                throw new FormatException(Constants.Messages.Error_Parsing_Interface_InvalidWindow);
                            Properties[pairs[0].ToLower()] = pairs[1];
                        }
                    }
                    else if (Constants.KeywordControl.Equals(line.Columns[0], StringComparison.CurrentCultureIgnoreCase))
                    {
                        string controlName = line.Columns[1].ToLower();
                        for (int i = 2; i < line.ColumnCount; i++)
                        {
                            string[] pairs = line.Columns[i].Split(Constants.PropertyDelimeter.ToCharArray(), 2);
                            if (pairs.Length != 2)
                                throw new FormatException(Constants.Messages.Error_Parsing_Interface_InvalidControl);
                            Controls[controlName] = new Dictionary<string, string>();
                            Controls[controlName][pairs[0].ToLower()] = pairs[1];
                        }
                    }
                }
            }
        }
    }
}
