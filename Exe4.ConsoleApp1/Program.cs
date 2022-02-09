//Alguns países medem temperaturas em graus Celsius, e outros em graus Fahrenheit.
//Faça um algoritmo para ler uma temperatura Celsius e imprimi-Ia em Fahrenheit(pesquise como fazer este tipo de conversão).

using System;

namespace Exe4.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 4 lista 1");

            string celsius;
            string fahrenheit;

            Console.WriteLine("Digite a temperatura em Celsius:");
            string Celsius = Console.ReadLine();

            double grausCelsius = System.Convert.ToDouble(Celsius);

            double grausFahrenheit = grausCelsius * 1.8 + 32;

            Console.WriteLine("Temperatura em Celsius" + grausCelsius);
            Console.WriteLine("Temperatura em Fahrenheit" + grausFahrenheit);

            Console.WriteLine("Deseja realizar a operação novamente?(s/n)");
            Console.ReadLine();

        }
    }
}
