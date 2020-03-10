using System;
using System.Collections.Generic;
using System.Text;
using Notepod.Models;

namespace Notepod
{
    /// <summary>
    /// Edit Layout Format.
    /// </summary>
    /// <author>Kenneth McSKimming</author>
    public class EditLayoutFormat : BaseGenerator
    {
        public EditLayoutFormat(string[] inputLines)
            : base(inputLines)
        {
        }

        public override void Import()
        {
            ImportLines();
        }

        public override string[] Generate()
        {
            return GenerateLines();
        }

        private void ImportLines()
        {
        }

        private string[] GenerateLines()
        {
            StringBuilder xml = new StringBuilder();
            foreach (string inputLine in _inputLines)
            {
                xml.AppendLine(inputLine);
            }
            LayoutFormatter parser = new LayoutFormatter(4);
            string formattedXml = parser.Format(xml.ToString());
            string[] lines = formattedXml.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            List<string> output = new List<string>();
            foreach (string outputLine in lines)
            {
                output.Add(outputLine);
            }
            return output.ToArray();
        }
    }
}