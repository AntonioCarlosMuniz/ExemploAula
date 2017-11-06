using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (mes)
            {
                case "Janeiro":
                case "Março":
                case "Maio":
                case "Julho":
                case "Agosto":
                case "Outubro":
                case "Dezembro":
                    Console.WriteLine("Este mês tem 31 dias");
                    break;
                case "Fevereiro":
                    Console.WriteLine("Este mês tem 28 ou 29 dias");
                    break;
                default:
                    Console.WriteLine("Este mês tem 30 dias");
                    break;
            }
        }
    }
}
