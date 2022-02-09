//Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui.
//Considere sempre anos completos, e que um ano possui 365 dias.
// Ex: uma pessoa com 19 anos possui 6935 dias de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS

using System;

namespace Exe3.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercico 3 lista 1");

            string nome;
            int idade;
            int diasVida;

            Console.Write("Digite seu nome");
            nome = Console.ReadLine();

            Console.Write("Digite sua idade");
            idade = Convert.ToInt32(Console.ReadLine());

            diasVida = idade * 365;

            Console.WriteLine(nome + ", você já viveu " + diasVida + " dias");

 
        }
    }
}
