using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero de 1 a 4 ");
            int num1 = int.Parse(Console.ReadLine());
            switch (num1)
            {
                case 1:
                    Console.WriteLine(" 1 - UM ");
                    break;

                case 2:
                    Console.WriteLine(" 2 - DOIS ");
                    break;

                case 3:
                    Console.WriteLine(" 3 - TRÊS");
                    break;

                case 4:
                    Console.WriteLine(" 4 - QUATRO ");
                    break;

                default:

                    Console.WriteLine(" VALOR INVÁLIDO ");
                    break;


            }
            Console.ReadKey();
        }
    }
}
