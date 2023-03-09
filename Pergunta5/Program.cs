using System;
using System.Text;

namespace Pergunta5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma palavra: ");
            string p = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            for (var i = p.Length - 1; i >= 0; i--)
            {
                sb.Append(p[i]);

            }
            Console.WriteLine(sb.ToString());
        }
    }
}
