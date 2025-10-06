using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMP225492_NguyenHoangTri_Real_18_Memento_SoanThaoVb
{
    public class History
    {
        private readonly Stack<Memento> undoStack = new Stack<Memento>();
        private readonly Stack<Memento> redoStack = new Stack<Memento>();
        private readonly Originator originator;

        public History(Originator originator)
        {
            this.originator = originator;
        }

        public void Save()
        {
            undoStack.Push(originator.SaveToMemento());
            redoStack.Clear(); // mỗi khi có state mới thì redo reset
        }

        public void Undo()
        {
            if (undoStack.Count > 1)
            {
                redoStack.Push(undoStack.Pop());
                originator.RestoreFromMemento(undoStack.Peek());
            }
        }

        public void Redo()
        {
            if (redoStack.Count > 0)
            {
                var memento = redoStack.Pop();
                undoStack.Push(memento);
                originator.RestoreFromMemento(memento);
            }
        }
    }
}
