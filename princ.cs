using System;
using System.Collections;

namespace practica_3
{
	class princ
	{
		public static void Main(string[] args)
		{
			
			Captura cap = new Captura();
			cap.inicia();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}