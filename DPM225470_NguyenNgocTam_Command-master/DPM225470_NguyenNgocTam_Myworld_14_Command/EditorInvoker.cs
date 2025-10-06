using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225470_NguyenNgocTam_Myworld_14_Command
{
    public class EditorInvoker
    {
        private Stack<Command> undoStack = new Stack<Command>(); // Stack lưu các lệnh Undo
        private Stack<Command> redoStack = new Stack<Command>(); // Stack lưu các lệnh Redo

        // Thực thi lệnh
        public void ExecuteCommand(Command command)
        {
            command.Execute();  // Thực hiện lệnh
            undoStack.Push(command); // Lưu lệnh vào Undo Stack
            redoStack.Clear(); // Xóa sạch Redo Stack vì có lệnh mới
        }

        // Hoàn tác (Undo) lệnh cuối cùng
        public void UndoLastCommand()
        {
            if (undoStack.Count > 0)
            {
                var lastCommand = undoStack.Pop();  // Lấy lệnh cuối cùng từ Undo Stack
                lastCommand.Undo(); // Thực hiện Undo
                redoStack.Push(lastCommand); // Lưu lệnh vào Redo Stack
            }
            else
            {
                Console.WriteLine("Không có lệnh nào để hoàn tác.");
            }
        }

        // Làm lại (Redo) lệnh đã Undo
        public void RedoLastCommand()
        {
            if (redoStack.Count > 0)
            {
                var lastCommand = redoStack.Pop();  // Lấy lệnh cuối cùng từ Redo Stack
                lastCommand.Execute(); // Thực hiện lại lệnh
                undoStack.Push(lastCommand); // Lưu lại vào Undo Stack
            }
            else
            {
                Console.WriteLine("Không có lệnh nào để làm lại.");
            }
        }
    }
}
