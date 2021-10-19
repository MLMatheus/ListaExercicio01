using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor do salário: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            double porcentagem = 0;

            if(salario <= 2800)
            {
                porcentagem = 20;
            }
            else if(salario > 2800 && salario <= 7000)
            {
                porcentagem = 15;
            }
            else if(salario > 7000 && salario <= 15000)
            {
                porcentagem = 10;
            }
            else if(salario > 15000)
            {
                porcentagem = 5;
            }

            double aumento = salario * porcentagem / 100;
            double novoSalario = salario + aumento;
            Console.WriteLine("Salário antigo: " + salario);
            Console.WriteLine("Percentual aplicado: " + porcentagem + "%");
            Console.WriteLine("Valor do aumento: " + aumento);
            Console.WriteLine("Novo salário: " + novoSalario);
        }
    }
}
