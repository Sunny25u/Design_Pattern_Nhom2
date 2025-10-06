using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225470_NguyenNgocTam_Myworld_14_Command
{
    public class CopyCommand : Command
    {
        private string textToCopy;

        public CopyCommand(TextDocument document, string text) : base(document)
        {
            this.textToCopy = text;
        }

        public override void Execute()
        {
            document.Copy(textToCopy);
        }

        public override void Undo()
        {
            Console.WriteLine($"Hoàn Tác Sao Chép : {textToCopy}");
        }
    }
}
