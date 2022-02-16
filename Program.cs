using System;

namespace Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três numero ");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int resultado = maior(n1, n2, n3);

            Console.WriteLine("maior  =" + resultado);

        static int maior(int a, int b, int c)
            {
                int m;
                if (a > b && a > c)
                {
                    m = a;
                }
                else if (b > c)
                
                { m = b;  }

                else { m = c; }

                return m;// o que retorna a função para quem à chamou
            }
        }
    }
}
