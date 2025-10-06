using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225470_NguyenNgocTam_Myworld_14_Command
{
    public class PasteCommand : Command
    {
        private string textToPaste;

        public PasteCommand(TextDocument document, string text) : base(document)
        {
            this.textToPaste = text;
        }

        public override void Execute()
        {
            document.Paste(textToPaste);
        }

        public override void Undo()
        {
            Console.WriteLine($"Hoàn Tác dán : {textToPaste}");
        }
    }
}
