using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Msimago KSI
namespace TernaryOperatorsApp
{
    class Program
    {
        //ternary operator in action using C#
        static void Main(string[] args)
        {
            //first
            string color = "blue";
            string result = (color == "blue") ? "blue" : "NOT blue";

            Console.WriteLine(result);

            //Second
            int pepperLength = 2;
            string message = (pepperLength >= 3.5) ? "Ready!" : "Wait a little longer";

            Console.WriteLine(message);
        }
    }
}
