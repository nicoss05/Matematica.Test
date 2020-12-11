using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matematica.Logica;
using System;

namespace Matematica.Test
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void SumaDosNumeros()
        {

            // arrange-->preparacion
            var numero1 = 7;
            var numero2 = 10;
            var esperado = 17;

            // Act---> Ejecución
            var calculadora = new Calculadora();
            var resultado = calculadora.Sumar(numero1, numero2);

            //Assert---> verificación
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void ObtenerDivision()
        {

            var dividendo = 30;
            var divisor = 2;
            var esperado = 15;

            var calculadora = new Calculadora();
            var resultado = calculadora.Dividir(dividendo, divisor);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DividirEntreCero()
        {
            var dividendo = 10;
            var divisor = 0;

            var calculadora = new Calculadora();
            var resultadoObtenido = calculadora.Dividir(dividendo, divisor);
            // Assert.IsTrue(double.IsInfinity(resultadoObtenido);
        }

        [TestMethod]
        public void DividirCeroParaUnNumero()
        {
            var dividendo = 0;
            var divisor = 6;
            var resultado = 0;

            var calculadora = new Calculadora();
            var resultadoObtenido = calculadora.Dividir(dividendo, divisor);

            Assert.AreEqual(resultado, resultadoObtenido);
        }

        [TestMethod]
        public void DividirDecimals()
        {
            var dividendo = 30;
            var divisor = 4;
            var resultado = 7.5;

            var calculadora = new Calculadora();
            var resultadoObtenido = calculadora.Dividir(dividendo, divisor);

            Assert.AreEqual(resultado, resultadoObtenido);
        }

        [TestMethod]
        public void ObtenerUnNumeroConDosDecimales()
        {
            var numeroPiCon5Decimales = 3.14159;
            var numeroPiCon2Decimales = 3.14;

            var calculadora = new Calculadora();
            var resultado = calculadora.TomarDosDecimales(numeroPiCon5Decimales);

            Assert.AreEqual(numeroPiCon2Decimales, resultado);


        }

    }
}
