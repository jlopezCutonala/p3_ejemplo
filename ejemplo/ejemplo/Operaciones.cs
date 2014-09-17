using System;

namespace ejemplo
{
	public class Operaciones
	{
		public Operaciones ()
		{
		}

		public int sumarDosNumeros(int operandoA, int operandoB){
			int resultado=operandoA+operandoB;
			return resultado;
		}

		public int restarDosNumeros(int operandoA, int operandoB){
			if(operandoA<operandoB){
				return 0;
			}
			int resultado=operandoA-operandoB;
			return resultado;
		}
	}
}

