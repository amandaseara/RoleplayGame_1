using NUnit.Framework;
using Roleplay;

namespace Test.Library
{

    [TestFixture]
    public class TestEquipar
    {
        private Arco arcoTest;
        private Baculo baculoTest;
        private Botas botasTest;
        private Escudo escudoTest;
        private Espada espadaTest;
        private Grebas grebasTest;
        private Pechera pecheraTest;
        private Yelmo yelmoTest;
        private Elfo elfoTest;
        private Humano humanoTest;
        private Enano enanoTest;
        private Hechicero hechiceroTest;


        [SetUp]
        public void Setup()
        {
            arcoTest = new Arco(100,0);
            baculoTest = new Baculo(100);
            botasTest = new Botas(0,200);
            escudoTest =new Escudo(0,200);
            espadaTest = new Espada(100,200);
            grebasTest = new Grebas(0,200);
            pecheraTest = new Pechera(0,200);
            yelmoTest = new Yelmo(0,200);
            elfoTest = new Elfo("Raul");
            humanoTest = new Humano("Tusam");
            hechiceroTest = new Hechicero("Richy");
            enanoTest = new Enano("Amanda");
        }

        [Test]
        public void equiparElfo0()
        {
            elfoTest.EquiparYelmo(yelmoTest);
            yelmoTest2 = new Yelmo(0,200);
            elfoTest.EquiparYelmo(yelmoTest2);
            Yelmo expected = yelmoTest;
            Yelmo busqueda = elfoTest.;
            Assert.AreEqual(expected, dañoYelmo);
        }
        [Test]
        public void equiparElfo1()
        {
            Botas botas = new Botas(100, 0);
            int dañoBotas = botas.Daño;
            int expected = 100;
            Assert.AreEqual(expected, dañoBotas);
        }
        [Test]
        public void equiparElfo2()
        {
            Botas botas = new Botas(100, 0);
            int dañoBotas = botas.Daño;
            int expected = 100;
            Assert.AreEqual(expected, dañoBotas);
        }
        [Test]
        public void equiparElfo3()
        {
            Botas botas = new Botas(100, 0);
            int dañoBotas = botas.Daño;
            int expected = 100;
            Assert.AreEqual(expected, dañoBotas);
        }
        [Test]
        public void equiparElfo4()
        {
            Botas botas = new Botas(100, 0);
            int dañoBotas = botas.Daño;
            int expected = 100;
            Assert.AreEqual(expected, dañoBotas);
        }
        [Test]
        public void equiparElfo5()
        {
            Botas botas = new Botas(100, 0);
            int dañoBotas = botas.Daño;
            int expected = 100;
            Assert.AreEqual(expected, dañoBotas);
        }
    }
}
