using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_New_Talent
{
    public class Calculator
    {
        private List<string> _history;

        public Calculator() { 

            _history = new List<string>();
        }

        public List<string> History()
        {
            return _history;
        }

        public double Sum(double num1, double num2) {
            var sum = num1 + num2;
            _history.Add($"Sum {num1} + {num2} = " + sum.ToString());
            return sum; 
        }

        public double Subtraction(double num1, double num2){
            var sub = num1 - num2;
            _history.Add($"Sub {num1} - {num2} = " + sub.ToString());
            return sub;
        }

        public double Multiply(double num1, double num2)
        {
            var mult = num1 * num2;
            _history.Add($"Sub {num1} * {num2} = " + mult.ToString());
            return mult;
        }

        public string Division(double num1, double num2)
        {
            if (num2 == 0) {
                _history.Add("Can't divide by zero.");
                return "Can't divide by zero."; 
            }

            var div = num1 / num2;
            _history.Add($"Div {num1} / {num2} = " + div.ToString());

            return div.ToString();
        }
    }
}
