using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225407_NguyenHuuDuy_MyWord_14_Command
{
    class User
    {
        private readonly Calculator _calc = new();
        private readonly List<ICommand> _history = new();
        private int _current = 0;

        public void Compute(char op, int num)
        {
            var cmd = new CalculatorCommand(_calc, op, num);
            cmd.Execute();
            _history.Add(cmd);
            _current++;
        }

        public void Undo(int levels)
        {
            Console.WriteLine($"\nUndo {levels} step(s)");
            for (int i = 0; i < levels && _current > 0; i++)
                _history[--_current].Undo();
        }

        public void Redo(int levels)
        {
            Console.WriteLine($"\nRedo {levels} step(s)");
            for (int i = 0; i < levels && _current < _history.Count; i++)
                _history[_current++].Execute();
        }
    }
}
