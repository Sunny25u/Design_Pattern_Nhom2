using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
namespace DPM225470_NguyenNgocTam_Myworld_14_Command
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Tạo đối tượng TextDocument (Receiver)
            TextDocument document = new TextDocument();

            // Tạo Invoker (EditorInvoker)
            EditorInvoker editorInvoker = new EditorInvoker();

            while (true)
            {
                // Hiển thị menu cho người dùng
                Console.Clear();
                Console.WriteLine("-------- Menu --------");
                Console.WriteLine("1. Gõ chữ");
                Console.WriteLine("2. Sao chép");
                Console.WriteLine("3. Dán");
                Console.WriteLine("4. Hoàn tác");
                Console.WriteLine("5. Làm lại");
                Console.WriteLine("6. Hiển thị nội dung tài liệu");
                Console.WriteLine("7. Thoát");
                Console.Write("Chọn một lệnh (1-7): ");

                // Nhận lựa chọn từ người dùng
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Nhập nội dung cần gõ: ");
                        string textToType = Console.ReadLine();
                        editorInvoker.ExecuteCommand(new TypeCommand(document, textToType));
                        break;

                    case "2":
                        Console.Write("Nhập nội dung cần sao chép: ");
                        string textToCopy = Console.ReadLine();
                        editorInvoker.ExecuteCommand(new CopyCommand(document, textToCopy));
                        break;

                    case "3":
                        Console.Write("Nhập nội dung cần dán: ");
                        string textToPaste = Console.ReadLine();
                        editorInvoker.ExecuteCommand(new PasteCommand(document, textToPaste));
                        break;

                    case "4":
                        editorInvoker.UndoLastCommand();
                        break;

                    case "5":
                        editorInvoker.RedoLastCommand();
                        break;

                    case "6":
                        document.ShowContent();
                        break;

                    case "7":
                        Console.WriteLine("Thoát chương trình...");
                        return;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }

                // Dừng lại để người dùng xem kết quả
                Console.WriteLine("\nNhấn bất kỳ phím nào để tiếp tục...");
                Console.ReadKey();
            }
        }
    }
}