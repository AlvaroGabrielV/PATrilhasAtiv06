using System;

namespace att01
{
	class Program
	{
		public static void Main()
		{			
			int x;
			
			for (x = 0; x <= 100 ; x++) {			
			
				if (x % 2 == 0) {
					Console.WriteLine(x);
				}
				
			}			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}		
