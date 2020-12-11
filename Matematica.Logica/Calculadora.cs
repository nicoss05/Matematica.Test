
using System;

namespace Matematica.Logica
{
    public class Calculadora
    {
        public int Sumar(int sumando1, int sumando2)
        {
            return sumando1 + sumando2;
        }

        public double Dividir(double dividendo, double divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException();
            return dividendo / divisor;
        }

        public double TomarDosDecimales(double numeroConDecimales)
        {
         var numeroPaso1 = MoverLaComaALaDerecha2Veces(numeroConDecimales);
        var numeroPaso2 = TomarParteEntera(numeroPaso1);
        var numeroPaso3 = MoverLaComaALaIzquierda2Veces(numeroPaso2);
        return numeroPaso3;
        }
    }
}