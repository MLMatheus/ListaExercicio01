using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a primeira nota: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            double media = (n1 + n2)/2;
            if(media == 10)
            {
                Console.WriteLine("Aprovado com distinção");
            }
            else if(media >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
