//A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo
//para ler as dimensões de um terreno e depois exibir a área do terreno


using System;

namespace Lista1.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 1 lista 1");

            float area;
            float base;
            float altura;

            Console.WriteLine("Digite o valor da base do terreno:");
            string strBase = Console.ReadLine();

            Console.WriteLine("Digite o valor da altura do terreno:");
            string strAltura = Console.ReadLine();

            double valorBase = System.Convert.ToDouble(strBase);
            double valorAltura = System.Convert.ToDouble(strAltura);

            double areaRetangulo = valorBase * valorAltura;

            Console.WriteLine("Resultado:");
            Console.WriteLine("Valor da base: " + valorBase);
            Console.WriteLine("Valor da altura: " + valorAltura);
            Console.WriteLine("Valor da área: " + areaRetangulo);

            Console.WriteLine("Deseja realizar o cálculo novamente?(s/n)");
            opcao = Console.ReadLine();


            //deu tudo errado aqui.

        }
    }
}
