using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225407_NguyenHuuDuy_MyWord_14_Command
{
    class CalculatorCommand : ICommand
    {
        private readonly Calculator _calculator;
        private readonly char _op;
        private readonly int _num;

        public CalculatorCommand(Calculator calc, char op, int num)
        {
            _calculator = calc;
            _op = op;
            _num = num;
        }

        public void Execute() => _calculator.Operation(_op, _num);
        public void Undo() => _calculator.Operation(Reverse(_op), _num);

        private static char Reverse(char op) => op switch
        {
            '+' => '-',
            '-' => '+',
            '*' => '/',
            '/' => '*',
            _ => throw new ArgumentException("Invalid operator")
        };
    }
}
