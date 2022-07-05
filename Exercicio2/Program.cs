using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes, dia, ano, c;
            string data = null;
            Console.WriteLine("Exercicio 2: ");
            Console.WriteLine("1 - Atibaia \n2 - Bragança Paulista \n3 - Mairiporã \n4 - Nazaré \n5 - Terra Preta \n6 - Extrema \n7 - Vargem \nColoque o número da cidade desejada:  ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite uma data: \n[Formato: DD/MM/AAAA]");
            var numero1 = Convert.ToDateTime(Console.ReadLine());

            mes = numero1.Month;
            dia = numero1.Day;
            ano = numero1.Year;


            switch (mes)
            {
                case 1:
                    data = ("Janeiro");
                    break;
                case 2:
                    data = ("Fevereiro");
                    break;
                case 3:
                    data = ("Março");
                    break;
                case 4:
                    data = ("Abril");
                    break;
                case 5:
                    data = ("Maio");
                    break;
                case 6:
                    data = ("Junho");
                    break;
                case 7:
                    data = ("Julho");
                    break;
                case 8:
                    data = ("Agosto");
                    break;
                case 9:
                    data = ("Setembro");
                    break;
                case 10:
                    data = ("Outubro");
                    break;
                case 11:
                    data = ("Novembro");
                    break;
                case 12:
                    data = ("Dezembro");
                    break;
            }

            if (c == 1)
            {
                Console.WriteLine("\nAtibaia, " + dia + " de " + data + " de " + ano);
            }
            else if (c == 2)
            {
                Console.WriteLine("\nBragança Paulista," + dia + " de " + data + " de " + ano);
            }

            else if (c == 3)
            {
                Console.WriteLine("\nMairiporã," + dia + " de " + data + " de " + ano);
            }

            else if (c == 4)
            {
                Console.WriteLine("\nNazaré, " + dia + " de " + data + " de " + ano);
            }

            else if (c == 5)
            {
                Console.WriteLine("\nTerra preta, " + dia + " de " + data + " de " + ano);
            }

            else if (c == 6)
            {
                Console.WriteLine("\nExtrema, " + dia + " de " + data + " de " + ano);
            }

            else if (c == 7)
            {
                Console.WriteLine("\nVargem, " + dia + " de " + data + " de " + ano);
            }


            Console.ReadKey();
        }
    }
}
