using System;

namespace FlaviusJosephus.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira quantas vezes quer repetir:");
            int n = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("Insira a quantidade de pessoas no circulo(entre 1 e 10000):");
                int numeroPessoas = Convert.ToInt32(Console.ReadLine());
                int[] numeroPessoasArray = new int[numeroPessoas];

                Console.WriteLine("Insira o número de saltos que serão dados até chegar na proxima pessoa(entre 1 e 10000):");
                int numeroSaltos = Convert.ToInt32(Console.ReadLine());

                int contadorSaltos = 0;
                int valor = 1;

                for (int i = 0; i < numeroPessoasArray.Length; i++)
                {

                    numeroPessoasArray[i] = valor;
                    valor++;
                }

                for (int i = 0; i < numeroPessoasArray.Length; i++)
                {

                    if (contadorSaltos == numeroSaltos)
                    {

                    }
                    else
                    {

                        numeroPessoasArray[i] = 0;

                    }

                    contadorSaltos++;

                }

                for (int i = 0; i < numeroPessoasArray.Length; i++)
                {

                    if (numeroPessoasArray[i] != 0)
                    {

                        Console.WriteLine(numeroPessoasArray[i]);

                    }

                }

                n--;
            } while (n > 0);

            Console.ReadKey();
        }
    }
}
