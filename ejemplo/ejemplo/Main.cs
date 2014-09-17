using System;

namespace ejemplo
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Operaciones operaciones=new Operaciones();
			int resultadoSuma=operaciones.sumarDosNumeros(10,34);
			int resultadoResta=operaciones.restarDosNumeros(50,1);
			Console.WriteLine("Sumar: " + resultadoSuma);
			Console.WriteLine("Restar: " + resultadoResta);
		}
	}
}
