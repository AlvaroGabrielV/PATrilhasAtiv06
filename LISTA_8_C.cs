using System;

namespace att01
{
	class Program
	{
		public static void Main()
		{			
			Console.Write("Digite uma palavra: ");
			string palavra = Console.ReadLine();
			
			for (int x = 0 ; x < palavra.Length ; x++) {			

					Console.WriteLine(palavra[x]);
				
			}			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}		
