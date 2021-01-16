using NUnit.Framework;
using ProyectoCalculadora.Properties.controllers;

namespace NUnitTestCalculadora
{
    public class TestCalculadora
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSuma1()
        {
            //Arrange=preparacion
            int num1 = 5;
            int num2 = 7;
            int esperado = 12;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.sumapost(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestSuma2()
            {
                //Arrange=preparacion
                int num1 = 10;
                int num2 = -4;
                int esperado = 6;
                CalculadoraController calc = new CalculadoraController();

                //Act=ejecucion
                int resultado = calc.sumapost(num1, num2);

                //Assert=verificacion
                Assert.AreEqual(esperado, resultado);
            }
        [Test]
        public void TestSuma3()
        {
            //Arrange=preparacion
            int num1 = 100;
            int num2 = -200;
            int esperado = -100;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.sumapost(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestSuma4()
        {
            //Arrange=preparacion
            int num1 = 150;
            int num2 = -200;
            int esperado = -50;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.sumaget(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestSuma5()
        {
            //Arrange=preparacion
            int num1 = -40;
            int num2 = 50;
            int esperado = 10;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.sumaget(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestSuma6()
        {
            //Arrange=preparacion
            int num1 = -5;
            int num2 = 7;
            int esperado = 2;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.sumaget(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }

    }
}