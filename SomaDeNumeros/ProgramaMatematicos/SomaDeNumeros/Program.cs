using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaDeNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * string -> texto
             * int -> Numeros inteiros
             * Double e Float -> decimais 1, 1.2, 5.7,-7, -8.9,...
             * 
             */


            Double n1 = 0;
            Double n2 = 0;
            Double total = 0;
            string pergunta = "";

            Console.WriteLine("Programa que soma dois números");

            Console.Write("Informe o primeiro numero: ");
            pergunta = Console.ReadLine();
            n1 = Convert.ToDouble(pergunta);

            Console.Write("Informe o segundo numero: ");
            pergunta = Console.ReadLine();
            n2 = Convert.ToDouble(pergunta);
            total = n1 + n2;
            //---------------------------------Adolfo-------------------------------------------
            Console.WriteLine($"O valor {n1} mais o valor {n2} deu um total de:  {total}");
            //---------------------------------FimAdolfo----------------------------------------

            //---------------------------------Danilo-------------------------------------------
            /*            
                 total = n1 + n2;
                 Console.WriteLine(n1 + " + " + n2 + "=" + total);
            */

            //---------------------------------FimDanilo-----------------------------------------


            Console.ReadKey();
        }
    }
}
