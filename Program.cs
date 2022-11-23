using System;
using System.Threading;

namespace Cronometro
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length -1,1));
            int tempo = int.Parse(data.Substring(0, data.Length-1));
            int multiplicador = 1;

            if (type == 'm')
                multiplicador = 60;

            if (tempo == 0)
                System.Environment.Exit(0);

            preComecar(tempo * multiplicador);

        }
        static void preComecar(int tempo)
        {
            Console.Clear();
            Console.WriteLine("Preparar...");
            Thread.Sleep(1000);
            Console.WriteLine("Apontar...");
            Thread.Sleep(1000);
            Console.WriteLine("Fogo...");
            Thread.Sleep(2500);

            Comecar(tempo);
        }
        static void Comecar(int tempo)
        {
            int horaAtual = 0;

            while (horaAtual != tempo) 
                {                    
                    horaAtual++;
                    Console.WriteLine(horaAtual);
                    Thread.Sleep(1000); 


                }
            Console.Clear();
            Console.WriteLine("Cronômetro finalizado...");
            Thread.Sleep(2500);
            Menu();

           
        }
        
    }
}