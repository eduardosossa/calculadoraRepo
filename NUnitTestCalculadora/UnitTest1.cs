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
        [Test]
        public void TestResta1()
        {
            //Arrange=preparacion
            int num1 = -5;
            int num2 = 5;
            int esperado = -10;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.restapost(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestResta2()
        {
            //Arrange=preparacion
            int num1 = 25;
            int num2 = 5;
            int esperado = 20;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.restapost(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestResta3()
        {
            //Arrange=preparacion
            int num1 = 30;
            int num2 = 40;
            int esperado = -10;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.restapost(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestResta4()
        {
            //Arrange=preparacion
            int num1 = -3;
            int num2 = 3;
            int esperado = -6;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.restaget(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestResta5()
        {
            //Arrange=preparacion
            int num1 = 15;
            int num2 = 4;
            int esperado = 11;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.restaget(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestResta6()
        {
            //Arrange=preparacion
            int num1 = 666;
            int num2 = 66;
            int esperado = 600;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.restaget(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void Testmulti1()
        {
            //Arrange=preparacion
            int num1 = 6;
            int num2 = 9;
            int esperado = 54;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.multipost(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void Testmulti2()
        {
            //Arrange=preparacion
            int num1 = -5;
            int num2 = 3;
            int esperado = -15;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.multipost(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void Testmulti3()
        {
            //Arrange=preparacion
            int num1 = 10;
            int num2 = 10;
            int esperado = 100;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.multipost(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void Testmulti4()
        {
            //Arrange=preparacion
            int num1 = 100;
            int num2 = 100;
            int esperado = 10000;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.multiget(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void Testmulti5()
        {
            //Arrange=preparacion
            int num1 = 69;
            int num2 = -420;
            int esperado = -28980;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.multiget(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void Testmulti6()
        {
            //Arrange=preparacion
            int num1 = -6;
            int num2 = -9;
            int esperado = 54;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.multipost(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void Testdiv1()
        {
            //Arrange=preparacion
            float num1 = 4;
            float num2 = 2;
            float esperado = 2;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            float resultado = calc.divpost(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void Testdiv2()
        {
            //Arrange=preparacion
            float num1 = 20;
            float num2 = 2;
            float esperado = 10;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            float resultado = calc.divpost(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void Testdiv3()
        {
            //Arrange=preparacion
            float num1 = 420;
            float num2 = 6;
            float esperado = 70;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            float resultado = calc.divpost(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void Testdiv4()
        {
            //Arrange=preparacion
            float num1 = 420;
            float num2 = 6;
            float esperado = 70;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            float resultado = calc.divget(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void Testdiv5()
        {
            //Arrange=preparacion
            float num1 = 60;
            float num2 = -2;
            float esperado = -30;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            float resultado = calc.divget(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void Testdiv6()
        {
            //Arrange=preparacion
            float num1 = 80;
            float num2 = -2;
            float esperado = -40;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            float resultado = calc.divget(num1, num2);

            //Assert=verificacions
            Assert.AreEqual(esperado, resultado);
        }
    }
}