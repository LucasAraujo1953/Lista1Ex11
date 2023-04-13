using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double z;

            Console.WriteLine("Precisamos calcular a operação: X^y");
            Console.Write("Qual o valor de X: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Qual o valor de Y: ");
            y = double.Parse(Console.ReadLine());

            z = Math.Pow(x, y);

            Console.WriteLine   ("O valor da operação X elevado a Y é {0}",z);

        }
    }
}
