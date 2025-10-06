using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225470_NguyenNgocTam_Myworld_14_Command
{
    public class TypeCommand : Command
    {
        private string textToType;

        public TypeCommand(TextDocument document, string text) : base(document)
        {
            this.textToType = text;
        }

        public override void Execute()
        {
            document.Type(textToType);
        }

        public override void Undo()
        {
            Console.WriteLine($"Hoàn Tác Nhập : {textToType}");
        }

    }
}
