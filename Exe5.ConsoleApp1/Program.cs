using System;

namespace Exe5.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

            string opcao;
            do
        {
            Console.WriteLine("Exercicio 5 lista 1");

            Console.WriteLine("Digite o valor do salário: ");
            string strSalario = Console.ReadLine();

            double salario = System.Convert.ToDouble(strSalario);

            double salarioAumento = salario + (salario * 0.15);
            double salarioFinal = salarioAumento - (salarioAumento * 0.08);


            Console.WriteLine("Salário: " + salario + " R$");
            Console.WriteLine("Salário com aumento: " + salarioAumento + "R$");
            Console.WriteLine("Salário final: " + salarioFinal + "R$");



            Console.WriteLine("Deseja realizar a operação novamente?(s/n)");
            opcao = Console.ReadLine();
        }
    }
}
