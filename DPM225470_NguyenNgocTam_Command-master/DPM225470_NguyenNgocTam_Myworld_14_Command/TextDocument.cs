using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225470_NguyenNgocTam_Myworld_14_Command
{

     public class TextDocument
    {
        private string content = "";

        public void Type(string text)
        {
            content += text;
            Console.WriteLine($"Nhập : {text}");
        }

        public void Copy(string text)
        {
            Console.WriteLine($"Sao Chép : {text}");
        }

        public void Paste(string text)
        {
            content += text;
            Console.WriteLine($"Dán : {text}");
        }

        public void ShowContent()
        {
            Console.WriteLine("Nội dung tài liệu đã thao tác  : " + content);
        }
    }
}
