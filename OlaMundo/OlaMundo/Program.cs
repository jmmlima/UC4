using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaMundo
{
    class Program
    {
        static void Main(string[] args)
        //tipo>nome>atribuição
        {
            //---------------------------------------------primeiros passos--------------------------------
            /*
            
            string nome = "João Manoel Montini de Lima";
            //string idade = "30";
            Int16 idade = 30;
            Console.WriteLine("Olá Mundo, eu sou o "+ nome+ " tenho: " + idade + " anos");
           // Console.WriteLine() // pula linha
            //Console.WriteLine (idade);
            */

            //------------------------------------------final-------------------------------------------------------------


            //-----------------------------------------------------------calculos---------------------------------------------
            /*
            //int num1 = 0;
            //int num2 = 5;
            //Console.WriteLine("" + num1, "" + num2); //converte inteiro em string


            //soma
             int num1 = 5, num2 = 13;            
             int soma = num1 + num2;
             Console.WriteLine($"Soma do valor1: {num1} + valor2: {num2} é: {soma}");

            //Multiplicação
             int multiplica = num1 * num2;
            Console.WriteLine($"A multiplicação do valor1: {num1} * valor2: {num2} é: {multiplica}");

            //Divisão double
            double divisao = (double)num2 / (double)num1;
            Console.WriteLine($"A divisão do valor1: {num2} / valor2: {num1} é: {divisao}");

            //Divisão só inteiro
                    //int divisao = num2 / num1;
                    //Console.WriteLine($"A divisão do valor1: {num2} / valor2: {num1} é: {divisao}");

            //Divisão Float
            float divisaof = (float)num2 / (float)num1;
            Console.WriteLine($"A divisão do valor1: {num2} / valor2: {num1} é: {divisaof}");

            //Resto
            int resto = num2 % num1;
            Console.WriteLine($"Resto divisão do valor1: {num2} / valor2: {num1} é: {resto}");

            //Subtração
            int subtracao = num1 - num2;
            Console.WriteLine($"A subtração do valor1: {num1} - valor2: {num2} é: {subtracao}");

            

            //atenção no final, usar f no final do float e d no final do double se não ira dar erros
                float cordenadaX = 0.50f;
            Console.WriteLine(cordenadaX);
                double cordenaday = 0.30d;
            Console.WriteLine(cordenaday); 
            */

            //----------------------------------------finalsoma-------------------------------------------------




            //---------------------------------------entrada de dados-------------------------------------

            /*Console.Write("Digite o número1: ");

            string numero1 = Console.ReadLine();
            Console.Write("Digite o número2: ");
            */


            //-------------entrada 2 numeros e retornar resultado subtracao---------------------
            //------------Parse tambem serve-----------------

            /*
                Console.Write("Digite o número1: ");

                     string numero1 = Console.ReadLine();

                Console.Write("Digite o número2: ");


                     int num_var1 = Int32.Parse(numero1);

                Console.Write("Digite o número2: ");

                      string numero2 = Console.ReadLine();

                      int num_var2 = Int32.Parse(numero2);


                      int subtracao = num_var1 - num_var2;
                 Console.WriteLine($"A subtração do valor1: {num_var1} - o valor2: {num_var2} é: {subtracao}");

            
            //Console.WriteLine("Numero digitado foram: " + numero1 + " e " + numero2);

             */


            //-------------entrada 2 numeros e retornar resultado subtracao---------------------
            /*

             Console.Write("Digite o número1: ");
             string numero1 = Console.ReadLine();
             Console.Write("Digite o número2: ");
             string numero2 = Console.ReadLine();
             int subtracao = Convert.ToInt32(numero1) - Convert.ToInt32(numero2);
             Console.Write("Resultado da subtração: " + subtracao);

             */
            //------------------fim sub--------------------------------------------

            //-------------------- quem é maior------------------------


            Console.Write("Digite o número1: ");
            int numero1 =Int32.Parse (Console.ReadLine());
            Console.Write("Digite o número2: ");
            int numero2 = Int32.Parse(Console.ReadLine()); 

            if (numero1 > numero2)
            {
                Console.WriteLine(numero1 + " é maio.");
            }
            else 
            {
                Console.WriteLine(numero2 + " é menor.");
            }


            Console.ReadKey();
        }
    }
}
