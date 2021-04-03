using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many rows?");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("how many colluns");
            int c = int.Parse(Console.ReadLine());

            int[,] matriz = new int[r, c];

            for (int i = 0; i < r; i++)
            {
                string[] valor = Console.ReadLine().Split(' ');
                for (int j = 0; j < c; j++)
                {
                    matriz[i, j] = int.Parse(valor[j]);
                }
            }

            for (int i = 0; i < r; i++)
            {
                Console.WriteLine(" ");
                for (int j = 0; j < c; j++)
                {
                    Console.Write(" " + matriz[i, j]);
                }
            }

            Console.WriteLine("DIGITE UM NUMERO DA MATRIZ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < r; i++)
            {

                for (int j = 0; j < c; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        if (j > 0)
                            Console.WriteLine("esquerda = " + matriz[i, j - 1]);
                        if (j < c-1)
                            Console.WriteLine("direita = " + matriz[i, j + 1]);
                        if (i > 0)
                            Console.WriteLine("cima = " + matriz[i - 1, j]);
                        if (i < r-1)
                            Console.WriteLine("baixo = " + matriz[i + 1, j]);
                    }
                }
            }



        }
    }
}
