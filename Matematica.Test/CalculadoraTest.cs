using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matematica.Logica;
using System;

namespace Matematica.Test
{
    [TestClass]
    public class CalculadoraTest
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

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
        public void ObtenerUnNumeroConDosDecimal()
        {
            // Arrange -> Preparacion
            var numeroPiCon5Decimales = 3.14159;
            var numeroPiCon2Decimales = 3.14;

            // act -> Esta la parte de Ejecución 
            var calculadora = new Calculadora();
            var resultado = calculadora.TomarDosDecimales(numeroPiCon5Decimales);

            // assert -> Verificación
            Assert.AreEqual(numeroPiCon2Decimales, resultado);

        }

        [TestMethod]
        public void ObtenerUnNumeroCon3Decimal()
        {
            // Arrange -> Preparacion
            var numeroPiConDecimales = 3.141592653589793238462643383;
            var numeroPiCon3Decimales = 3.141;

            // act -> Esta la parte de Ejecución 
            var calculadora = new Calculadora();
            var resultado = calculadora.TomarTresDecimales(numeroPiConDecimales);

            // assert -> Verificación
            Assert.AreEqual(numeroPiCon3Decimales, resultado);

        }
        [TestMethod]

        public void ObtenerDecimales()
        {
            var numeroAureo = 1.61803398874989;
            var numeroDeDecimales = 5;

            var esperado = 1.61803;

            var calculadora = new Calculadora();
            var resultado = calculadora.TomarDecimales(numeroAureo, numeroDeDecimales);

            Assert.AreEqual(esperado, resultado);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]

        public void ObtenerDecimalesNegativos()
        {
            var numeroAureo = 1.61803398874989;
            var numeroDeDecimales = -5;

            var calculadora = new Calculadora();
            _ = calculadora.TomarDecimales(numeroAureo, numeroDeDecimales);

        }

        [TestMethod]
        [DataSource(@"Provider=Microsoft.SqlServerCe.Client.4.0; Data Source=C:\Data\MathsData.sdf;", "Numbers")]

        public void AñadirEnteros()
        {
            //int x = Convert.ToInt32(TestContext.DataRow["FirstNumber"]);
            var numeroEntero1 = 12;
            var numeroEntero2 = 3;
            var esperado = 15;

            var calculadora = new Calculadora();
            int resultado = calculadora.AumentarEnteros(numeroEntero1, numeroEntero2);
            Assert.AreEqual(esperado, resultado);

        }

        [TestMethod]
        public void LimitarDecimales()
        {
            var numeroDecimal = 1.61803398874989;
            var numeroLimitado = (Math.Round(numeroDecimal, 3));
            var espera = 1.618;

            var calculadora = new Calculadora();
            var resultado = calculadora.LimitarDecimales(numeroDecimal, numeroLimitado);

            Assert.AreEqual(espera, resultado);

        }
    }
}

