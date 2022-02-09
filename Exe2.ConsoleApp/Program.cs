using System;

namespace Exe2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercico 2 lista 1");

            const decimal PrecoDoPao = 0.12m;
            const decimal PrecoDaBroa = 1.50m;
            decimal valorPaes, valorBroas, total = 0.0m;
            decimal poupanca;

            Console.Write("Por favor, digite a quantidade de pães vendidos 0,12?");
            int paesVendidos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Por favor, digite a quantidade de broas vendidas 1,50?");
            int broasVendidas = Convert.ToInt32(Console.ReadLine());

            valorPaes = paesVendidos * PrecoDoPao;
            valorBroas = broasVendidas * PrecoDaBroa;

            total = valorPaes + valorBroas;
            poupanca = total * 0.1m;

            Console.Write("O valor total foi" + total);
            Console.Write("O valor que vai para a poupança é" + poupanca);

        }


    }


    
}
