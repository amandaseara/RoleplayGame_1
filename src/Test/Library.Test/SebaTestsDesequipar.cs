using NUnit.Framework;
using Roleplay;

namespace Test.Library
{

    [TestFixture]
    public class TestDesequipar
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
        public void DesequiparElfo0()
        {
            elfoTest.EquiparYelmo(yelmoTest);
            elfoTest.DesequiparYelmo(yelmoTest);
            int expected = 0;
            int busqueda = elfoTest.equipamiento[0];
            Assert.AreEqual(expected, busqueda);
        }
        [Test]
        public void DesequiparElfo1()
        {
            elfoTest.EquiparPechera(pecheraTest);
            elfoTest.DesequiparPechera(pecheraTest);
            int expected = 1;
            Pechera busqueda = elfoTest.equipamiento[1];
            Assert.AreEqual(expected, busqueda);
        }
        [Test]
        public void DesequiparElfo2()
        {
            elfoTest.EquiparGrebas(grebasTest);
            elfoTest.DesequiparGrebas(grebasTest);
            int expected = 2;
            Grebas busqueda = elfoTest.equipamiento[2];
            Assert.AreEqual(expected, busqueda);
        }
        [Test]
        public void DesequiparElfo3()
        {
            elfoTest.EquiparBotas(botasTest);
            elfoTest.DesequiparBotas(botasTest);
            int expected = 3;
            Botas busqueda = elfoTest.equipamiento[3];
            Assert.AreEqual(expected, busqueda);
        }
        [Test]
        public void DesequiparElfo4()
        {
            elfoTest.EquiparEspada(espadaTest);
            elfoTest.DesequiparEspada(espadaTest);
            int expected = 4;
            Espada busqueda = elfoTest.equipamiento[4];
            Assert.AreEqual(expected, busqueda);
        }
        [Test]
        public void DesequiparElfo5()
        {
            elfoTest.EquiparArco(arcoTest);
            elfoTest.DesequiparArco(arcoTest);
            int expected = 5;
            Arco busqueda = elfoTest.equipamiento[5];
            Assert.AreEqual(expected, busqueda);
        }

        [Test]
        public void DesequiparEnano0()
        {
            enanoTest.EquiparYelmo(yelmoTest);
            enanoTest.DesequiparYelmo(yelmoTest);
            int expected = 0;
            int busqueda = enanoTest.equipamiento[0];
            Assert.AreEqual(expected, busqueda);
        }
        [Test]
        public void DesequiparEnano1()
        {
            enanoTest.EquiparPechera(pecheraTest);
            enanoTest.DesequiparPechera(pecheraTest);
            int expected = 1;
            Pechera busqueda = enanoTest.equipamiento[1];
            Assert.AreEqual(expected, busqueda);
        }
        [Test]
        public void DesequiparEnano2()
        {
            enanoTest.EquiparGrebas(grebasTest);
            enanoTest.DesequiparGrebas(grebasTest);
            int expected = 2;
            Grebas busqueda = enanoTest.equipamiento[2];
            Assert.AreEqual(expected, busqueda);
        }
        [Test]
        public void DesequiparEnano3()
        {
            enanoTest.EquiparBotas(botasTest);
            enanoTest.DesequiparBotas(botasTest);
            int expected = 3;
            Botas busqueda = enanoTest.equipamiento[3];
            Assert.AreEqual(expected, busqueda);
        }
        [Test]
        public void DesequiparEnano4()
        {
            enanoTest.EquiparEspada(espadaTest);
            enanoTest.DesequiparEspada(espadaTest);
            int expected = 4;
            Espada busqueda = enanoTest.equipamiento[4];
            Assert.AreEqual(expected, busqueda);
        }
        [Test]
        public void DesequiparEnano5()
        {
            enanoTest.EquiparHacha(hachaTest);
            enanoTest.DesequiparHacha(hachaTest);
            int expected = 5;
            Hacha busqueda = enanoTest.equipamiento[5];
            Assert.AreEqual(expected, busqueda);
        }

        [Test]
        public void DesequiparHumano0()
        {
            humanoTest.EquiparYelmo(yelmoTest);
            humanoTest.DesequiparYelmo(yelmoTest);
            int expected = 0;
            int busqueda = humanoTest.equipamiento[0];
            Assert.AreEqual(expected, busqueda);
        }
        [Test]
        public void DesequiparHumano1()
        {
            humanoTest.EquiparPechera(pecheraTest);
            humanoTest.DesequiparPechera(pecheraTest);
            int expected = 1;
            Pechera busqueda = humanoTest.equipamiento[1];
            Assert.AreEqual(expected, busqueda);
        }
        [Test]
        public void DesequiparHumano2()
        {
            humanoTest.EquiparGrebas(grebasTest);
            humanoTest.DesequiparGrebas(grebasTest);
            int expected = 2;
            Grebas busqueda = humanoTest.equipamiento[2];
            Assert.AreEqual(expected, busqueda);
        }
        [Test]
        public void DesequiparHumano3()
        {
            humanoTest.EquiparBotas(botasTest);
            humanoTest.DesequiparBotas(botasTest);
            int expected = 3;
            Botas busqueda = humanoTest.equipamiento[3];
            Assert.AreEqual(expected, busqueda);
        }
        [Test]
        public void DesequiparHumano4()
        {
            humanoTest.EquiparEspada(espadaTest);
            humanoTest.DesequiparEspada(espadaTest);
            int expected = 4;
            Espada busqueda = humanoTest.equipamiento[4];
            Assert.AreEqual(expected, busqueda);
        }
        [Test]
        public void DesequiparHumano5()
        {
            humanoTest.EquiparEscudo(escudoTest);
            humanoTest.DesequiparEscudo(escudoTest);
            int expected = 5;
            Escudo busqueda = humanoTest.equipamiento[5];
            Assert.AreEqual(expected, busqueda);
        }

        [Test]
        public void DesequiparHechicero0()
        {
            hechiceroTest.EquiparYelmo(yelmoTest);
            hechiceroTest.DesequiparYelmo(yelmoTest);
            int expected = 0;
            int busqueda = hechiceroTest.equipamiento[0];
            Assert.AreEqual(expected, busqueda);
        }
        [Test]
        public void DesequiparHechicero1()
        {
            hechiceroTest.EquiparPechera(pecheraTest);
            hechiceroTest.DesequiparPechera(pecheraTest);
            int expected = 1;
            Pechera busqueda = hechiceroTest.equipamiento[1];
            Assert.AreEqual(expected, busqueda);
        }
        [Test]
        public void DesequiparHechicero2()
        {
            hechiceroTest.EquiparGrebas(grebasTest);
            hechiceroTest.DesequiparGrebas(grebasTest);
            int expected = 2;
            Grebas busqueda = hechiceroTest.equipamiento[2];
            Assert.AreEqual(expected, busqueda);
        }
        [Test]
        public void DesequiparHechicero3()
        {
            hechiceroTest.EquiparBotas(botasTest);
            hechiceroTest.DesequiparBotas(botasTest);
            int expected = 3;
            Botas busqueda = hechiceroTest.equipamiento[3];
            Assert.AreEqual(expected, busqueda);
        }
        [Test]
        public void DesequiparHechicero4()
        {
            hechiceroTest.EquiparBaculo(baculoTest);
            hechiceroTest.DesequiparBaculo(baculoTest);
            int expected = 4;
            Espada busqueda = hechiceroTest.equipamiento[4];
            Assert.AreEqual(expected, busqueda);
        }
    }
}
