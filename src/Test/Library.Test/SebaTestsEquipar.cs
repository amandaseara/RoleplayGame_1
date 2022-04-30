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
    }
    }
/*
        [Test]
        public void equiparElfo0()
        {
            elfoTest.EquiparYelmo(yelmoTest);
            Yelmo yelmoTest2 = new Yelmo(0, 400);
            elfoTest.EquiparYelmo(yelmoTest2);
            Yelmo expected = yelmoTest2;
            Yelmo busqueda = elfoTest.equipamiento[0];
            Assert.AreEqual(expected, yelmoTest2);
        }
        [Test]
        public void equiparElfo1()
        {
            elfoTest.EquiparPechera(pecheraTest);
            Pechera pecheraTest2 = new Pechera(0, 400);
            elfoTest.EquiparPechera(pecheraTest2);
            Pechera expected = pecheraTest2;
            Pechera busqueda = elfoTest.equipamiento[1];
            Assert.AreEqual(expected, pecheraTest2);
        }
        [Test]
        public void equiparElfo2()
        {
            elfoTest.EquiparGrebas(grebasTest);
            Grebas grebasTest2 = new Grebas(0, 400);
            elfoTest.EquiparGrebas(grebasTest2);
            Grebas expected = grebasTest2;
            Grebas busqueda = elfoTest.equipamiento[2];
            Assert.AreEqual(expected, grebasTest2);
        }
        [Test]
        public void equiparElfo3()
        {
            elfoTest.EquiparBotas(botasTest);
            Botas botasTest2 = new Botas(0,400);
            elfoTest.EquiparBotas(botasTest2);
            Botas expected = botasTest2;
            Botas busqueda = elfoTest.equipamiento[3];
            Assert.AreEqual(expected, botasTest2);
        }
        [Test]
        public void equiparElfo4()
        {
            elfoTest.EquiparEspada(espadaTest);
            Espada espadaTest2 = new Espada(100,200);
            elfoTest.EquiparEspada(espadaTest2);
            Espada expected = espadaTest2;
            Espada busqueda = elfoTest.equipamiento[4];
            Assert.AreEqual(expected, espadaTest2);
        }
        [Test]
        public void equiparElfo5()
        {
            elfoTest.EquiparArco(arcoTest);
            Arco arcoTest2 = new Arco(100,200);
            elfoTest.EquiparArco(arcoTest2);
            Arco expected = arcoTest2;
            Arco busqueda = elfoTest.equipamiento[5];
            Assert.AreEqual(expected, arcoTest2);
        }



        public void equiparEnano0()
        {
            enanoTest.EquiparYelmo(yelmoTest);
            Yelmo yelmoTest2 = new Yelmo(0, 400);
            enanoTest.EquiparYelmo(yelmoTest2);
            Yelmo expected = yelmoTest2;
            Yelmo busqueda = enanoTest.equipamiento[0];
            Assert.AreEqual(expected, yelmoTest2);
        }
        [Test]
        public void equiparEnano1()
        {
            enanoTest.EquiparPechera(pecheraTest);
            Pechera pecheraTest2 = new Pechera(0, 400);
            enanoTest.EquiparPechera(pecheraTest2);
            Pechera expected = pecheraTest2;
            Pechera busqueda = enanoTest.equipamiento[1];
            Assert.AreEqual(expected, pecheraTest2);
        }
        [Test]
        public void equiparEnano2()
        {
            enanoTest.EquiparGrebas(grebasTest);
            Grebas grebasTest2 = new Grebas(0, 400);
            enanoTest.EquiparGrebas(grebasTest2);
            Grebas expected = grebasTest2;
            Grebas busqueda = enanoTest.equipamiento[2];
            Assert.AreEqual(expected, grebasTest2);
        }
        [Test]
        public void equiparEnano3()
        {
            enanoTest.EquiparBotas(botasTest);
            Botas botasTest2 = new Botas(0,400);
            enanoTest.EquiparBotas(botasTest2);
            Botas expected = botasTest2;
            Botas busqueda = enanoTest.equipamiento[3];
            Assert.AreEqual(expected, botasTest2);
        }
        [Test]
        public void equiparEnano4()
        {
            enanoTest.EquiparEspada(espadaTest);
            Espada espadaTest2 = new Espada(100,200);
            enanoTest.EquiparEspada(espadaTest2);
            Espada expected = espadaTest2;
            Espada busqueda = enanoTest.equipamiento[4];
            Assert.AreEqual(expected, espadaTest2);
        }
        [Test]
        public void equiparEnano5()
        {
            enanoTest.EquiparHacha(hachaTest);
            Hacha hachaTest2 = new Hacha(100,200);
            enanoTest.EquiparHacha(hachaTest2);
            Hacha expected = hachaTest2;
            Hacha busqueda = enanoTest.equipamiento[5];
            Assert.AreEqual(expected, hachaTest2);
        }

        public void equiparHumano0()
        {
            humanoTest.EquiparYelmo(yelmoTest);
            Yelmo yelmoTest2 = new Yelmo(0, 400);
            humanoTest.EquiparYelmo(yelmoTest2);
            Yelmo expected = yelmoTest2;
            Yelmo busqueda = humanoTest.equipamiento[0];
            Assert.AreEqual(expected, yelmoTest2);
        }
        [Test]
        public void equiparHumano1()
        {
            humanoTest.EquiparPechera(pecheraTest);
            Pechera pecheraTest2 = new Pechera(0, 400);
            humanoTest.EquiparPechera(pecheraTest2);
            Pechera expected = pecheraTest2;
            Pechera busqueda = humanoTest.equipamiento[1];
            Assert.AreEqual(expected, pecheraTest2);
        }
        [Test]
        public void equiparHumano2()
        {
            humanoTest.EquiparGrebas(grebasTest);
            Grebas grebasTest2 = new Grebas(0, 400);
            humanoTest.EquiparGrebas(grebasTest2);
            Grebas expected = grebasTest2;
            Grebas busqueda = humanoTest.equipamiento[2];
            Assert.AreEqual(expected, grebasTest2);
        }
        [Test]
        public void equiparHumano3()
        {
            humanoTest.EquiparBotas(botasTest);
            Botas botasTest2 = new Botas(0,400);
            humanoTest.EquiparBotas(botasTest2);
            Botas expected = botasTest2;
            Botas busqueda = humanoTest.equipamiento[3];
            Assert.AreEqual(expected, botasTest2);
        }
        [Test]
        public void equiparHumano4()
        {
            humanoTest.EquiparEspada(espadaTest);
            Espada espadaTest2 = new Espada(100,200);
            humanoTest.EquiparEspada(espadaTest2);
            Espada expected = espadaTest2;
            Espada busqueda = humanoTest.equipamiento[4];
            Assert.AreEqual(expected, espadaTest2);
        }
        [Test]
        public void equiparHumano5()
        {
            humanoTest.EquiparEscudo(escudoTest);
            Escudo escudoTest2 = new Escudo(100,200);
            humanoTest.EquiparEscudo(escudoTest2);
            Escudo expected = escudoTest2;
            Escudo busqueda = humanoTest.equipamiento[5];
            Assert.AreEqual(expected, escudoTest2);
        }

        public void equiparHechicero0()
        {
            hechiceroTest.EquiparYelmo(yelmoTest);
            Yelmo yelmoTest2 = new Yelmo(0, 400);
            hechiceroTest.EquiparYelmo(yelmoTest2);
            Yelmo expected = yelmoTest2;
            Yelmo busqueda = hechiceroTest.equipamiento[0];
            Assert.AreEqual(expected, yelmoTest2);
        }
        [Test]
        public void equiparHechicero1()
        {
            hechiceroTest.EquiparPechera(pecheraTest);
            Pechera pecheraTest2 = new Pechera(0, 400);
            hechiceroTest.EquiparPechera(pecheraTest2);
            Pechera expected = pecheraTest2;
            Pechera busqueda = hechiceroTest.equipamiento[1];
            Assert.AreEqual(expected, pecheraTest2);
        }
        [Test]
        public void equiparHechicero2()
        {
            hechiceroTest.EquiparGrebas(grebasTest);
            Grebas grebasTest2 = new Grebas(0, 400);
            hechiceroTest.EquiparGrebas(grebasTest2);
            Grebas expected = grebasTest2;
            Grebas busqueda = hechiceroTest.equipamiento[2];
            Assert.AreEqual(expected, grebasTest2);
        }
        [Test]
        public void equiparHechicero3()
        {
            hechiceroTest.EquiparBotas(botasTest);
            Botas botasTest2 = new Botas(0,400);
            hechiceroTest.EquiparBotas(botasTest2);
            Botas expected = botasTest2;
            Botas busqueda = hechiceroTest.equipamiento[3];
            Assert.AreEqual(expected, botasTest2);
        }
        [Test]
        public void equiparHechicero4()
        {
            hechiceroTest.EquiparBaculo(baculoTest);
            Baculo baculoTest2 = new Baculo(100);
            hechiceroTest.EquiparBaculo(baculoTest2);
            Baculo expected = baculoTest2;
            Baculo busqueda = hechiceroTest.equipamiento[4];
            Assert.AreEqual(expected, baculoTest2);
        }

    }
}
*/