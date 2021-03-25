using System;

namespace Milhas
{

    public class Program 
    {
        public static void Main(string [] args)
        {
			double Milhas;
			double Resultado;
			
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Conversão de Milhas para Km");
			Console.ResetColor();
			
			Console.Write("Insira o valor em Milhas: ");
			Milhas = Convert.ToDouble(Console.ReadLine());
			
			Resultado = Milhas * 1.609;
			
			Console.WriteLine("Resultado: " + Resultado + " Km");
        }
    }
}