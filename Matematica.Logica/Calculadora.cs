
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

        private double MoverLaComaALaDerecha2Veces(double numeroConDecimales)
        {
            return numeroConDecimales * 100;
        }

        private double TomarParteEntera(double numeroConDecimales)
        {
            return Math.Truncate(numeroConDecimales);
        }

        private double MoverLaComaALaIzquierda2Veces(double numero)
        {
            return numero / 100;
        }

        public double TomarTresDecimales(double numero)
        {
            var numeroPaso1 = MoverLaComaALaDerecha3Veces(numero);
            var numeroPaso2 = TomarParteEntera(numeroPaso1);
            var numeroPaso3 = MoverLaComaALaIzquierda3Veces(numeroPaso2);
            return numeroPaso3;
        }

        private double MoverLaComaALaDerecha3Veces(double numero)
        {
            return numero * 1000;
        }

        private double MoverLaComaALaIzquierda3Veces(double numero)
        {
            return numero / 1000;
        }
        public double TomarDecimales(double numeroAureo, int numeroDeDecimales)
        {
            if (numeroDeDecimales < 0)
                throw new ArgumentException("No se permite numero de decimales negativos");
            var numeroPaso1 = MoverLaComaALaDerecha(numeroAureo, numeroDeDecimales);
            var numeroPaso2 = TomarParteEntera(numeroPaso1);
            var numeroPaso3 = MoverLaComaALaIzquierda(numeroPaso2, numeroDeDecimales);
            return numeroPaso3;
        }

        private double MoverLaComaALaIzquierda(double numeroAureo, int numeroDeDecimales)
        {
            //1 --> 10
            //2 -->100
            //3 --> 1000

            return numeroAureo / Math.Pow(10,numeroDeDecimales);

        }

        private double MoverLaComaALaDerecha(double numeroAureo, int numeroDeDecimales)
        {
            return numeroAureo * Math.Pow(10,numeroDeDecimales);
        }




    }
}