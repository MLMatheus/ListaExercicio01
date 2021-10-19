using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro número: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo número: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o terceiro número: ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            int maior = 0;
            if(n1 > n2)
            {
                maior = n1;
            }
            else
            {
                maior = n2;
            }
            if(n3 > maior)
            {
                maior = n3;
            }

            Console.WriteLine("O maior valor digitado foi: " + maior);

            int menor = maior;
            if(n1 < maior)
            {
                menor = 1;
            }
            if(n2 < menor)
            {
                menor = n2;
            }
            if(n3 < menor)
            {
                menor = n3;
            }
            Console.WriteLine("O menor valor digitado foi: " + menor);
        }
    }
}
