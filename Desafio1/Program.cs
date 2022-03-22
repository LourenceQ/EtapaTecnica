/*
Elabore um algoritmo para mostrar os números ímpares existentes em um intervalo.
O usuário deverá fornecer os valores inicial (inicial > 0) e final (inicial < final) e os
números ímpares existentes no intervalo ([inicial, final]) devem ser separados por um
espaço em branco.
Exemplo:
Entrada: 2 13
Saída: 3 5 7 9 11 13
*/
using System;
using static System.Console;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            OddNumbers();
        }

        public static void OddNumbers()
        {
            bool isValid = false;
            int inicial = 0, final = 0;

            while (isValid == false)
            {
                WriteLine("Informe um número inicial maior que 0 (zero)");
                inicial = int.Parse(ReadLine());

                WriteLine("Informe um número final maior que o número inicial");
                final = int.Parse(ReadLine());
                
                if (inicial > 0 && final > inicial)
                {
                    for (int i = inicial; i <= final; i++)
                    {
                        if (i % 2 != 0)
                        {
                            Write($"{i} ");
                        }
                    }
                    isValid = true;

                }
                else { System.Console.WriteLine("Numero incial deve ser maior que 0 (zero)");}
                

            }
        }
    }
}