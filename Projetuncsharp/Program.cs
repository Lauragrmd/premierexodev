using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetuncsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 8, b = 4;

            String add = "Addition";
            String sub = "Soustraction";

            Addition(a, b);
            Soustraction(a, b);

            Console.ReadLine();

        }

        static void Addition(int val1, int val2)
        {
            String add = "Addition";
            Console.WriteLine("L'" + add + " entre " + val1 + " et " + val2 + " vaut " + (val1 + val2));

        }
        static void Soustraction(int val1, int val2)
        {
            String sub = "Soustraction";
            Console.WriteLine("La " + sub + " entre " + val1 + " et " + val2 + " vaut " + (val1 - val2));
        }
    }
}
