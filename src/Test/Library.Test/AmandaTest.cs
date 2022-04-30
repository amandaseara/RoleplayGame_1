using NUnit.Framework;
using Roleplay;


namespace Test.Library
{
    [TestFixture]
    public class TestAtaque
    {
        private Arco arcoTest;
        private Baculo baculoTest;
        private Hacha hachaTest;
        private Espada espadaTest;
        private Botas botasTest;
        private Elfo elfoTest;
        private Elfo elfoTest2;
        private Humano humanoTest;
        private Humano humanoTest2;
        private Enano enanoTest;
        private Enano enanoTest2;
        private Hechicero hechiceroTest;
        private Hechicero hechiceroTest2;

        [SetUp]
        public void Setup()
        {
            arcoTest = new Arco(100,0);
            baculoTest = new Baculo(100);
            hachaTest = new Hacha(200,0);
            espadaTest = new Espada(100,200);
            botasTest = new Botas(0,200);
            elfoTest = new Elfo("Raul");
            elfoTest2 = new Elfo("Raul2");
            humanoTest = new Humano("Tusam");
            humanoTest2 = new Humano("Tusam2");
            hechiceroTest = new Hechicero("Richy");
            hechiceroTest2 = new Hechicero("Richy2");
            enanoTest = new Enano("Thomas");
            enanoTest2 = new Enano("Thomas2");
        }

        [Test]
        //Ambos sin items
        public void TestAtacarHechiceroHechicero()
        {
            int dañoEsperado = 0;
            if ((hechiceroTest.Ataque - hechiceroTest2.Defensa) > 0)
                dañoEsperado = hechiceroTest.Ataque - hechiceroTest2.Defensa;
            int vidaDespuesAtaque = hechiceroTest2.VidaActual - dañoEsperado;

            Atacar.AtaquedeHechiceroaHechicero(hechiceroTest,hechiceroTest2);

            Assert.AreEqual(vidaDespuesAtaque,hechiceroTest2.VidaActual);
        }

        [Test]
        //Defensor con item
        public void TestAtacarHechiceroHechiceroItemDefensa()
        {
            int dañoEsperado = 0;
            if ((hechiceroTest.Ataque - (hechiceroTest2.Defensa + botasTest.Defensa)) > 0)
                dañoEsperado = hechiceroTest.Ataque - (hechiceroTest2.Defensa + botasTest.Defensa);
            int vidaDespuesAtaque = hechiceroTest2.VidaActual - dañoEsperado;

            hechiceroTest2.EquiparBotas(botasTest);
            Atacar.AtaquedeHechiceroaHechicero(hechiceroTest,hechiceroTest2);

            Assert.AreEqual(vidaDespuesAtaque,hechiceroTest2.VidaActual);
        }

        [Test]
        //Ambos sin items
        public void TestAtacarHechiceroElfo()
        {
            int dañoEsperado = 0;
            if ((hechiceroTest.Ataque - elfoTest.Defensa) > 0)
                dañoEsperado = hechiceroTest.Ataque - elfoTest.Defensa;
            int vidaDespuesAtaque = elfoTest.VidaActual - dañoEsperado;

            Atacar.AtaquedeHechiceroaElfo(hechiceroTest,elfoTest);

            Assert.AreEqual(vidaDespuesAtaque,elfoTest.VidaActual);
        }

        [Test]
        //Defensor con item
        public void TestAtacarHechiceroElfoItemDefensa()
        {
            int dañoEsperado = 0;
            if ((hechiceroTest.Ataque - (elfoTest.Defensa + botasTest.Defensa)) > 0)
                dañoEsperado = hechiceroTest.Ataque - (elfoTest.Defensa + botasTest.Defensa);
            int vidaDespuesAtaque = elfoTest.VidaActual - dañoEsperado;

            elfoTest.EquiparBotas(botasTest);
            Atacar.AtaquedeHechiceroaElfo(hechiceroTest,elfoTest);

            Assert.AreEqual(vidaDespuesAtaque,elfoTest.VidaActual);
        }

        [Test]
        //Ambos sin items
        public void TestAtacarHechiceroEnano()
        {
            int dañoEsperado = 0;
            if ((hechiceroTest.Ataque - enanoTest.Defensa) > 0)
                dañoEsperado = hechiceroTest.Ataque - enanoTest.Defensa;
            int vidaDespuesAtaque = enanoTest.VidaActual - dañoEsperado;

            Atacar.AtaquedeHechiceroaEnano(hechiceroTest,enanoTest);

            Assert.AreEqual(vidaDespuesAtaque,enanoTest.VidaActual);
        }

        [Test]
        //Defensor con item
        public void TestAtacarHechiceroEnanoItemDefensa()
        {
            int dañoEsperado = 0;
            if ((hechiceroTest.Ataque - (enanoTest.Defensa + botasTest.Defensa)) > 0)
                dañoEsperado = hechiceroTest.Ataque - (enanoTest.Defensa + botasTest.Defensa);
            int vidaDespuesAtaque = enanoTest.VidaActual - dañoEsperado;

            enanoTest.EquiparBotas(botasTest);
            Atacar.AtaquedeHechiceroaEnano(hechiceroTest,enanoTest);

            Assert.AreEqual(vidaDespuesAtaque,enanoTest.VidaActual);
        }

        [Test]
        //Ambos sin items
        public void TestAtacarHechiceroHumano()
        {
            int dañoEsperado = 0;
            if ((hechiceroTest.Ataque - humanoTest.Defensa) > 0)
                dañoEsperado = hechiceroTest.Ataque - humanoTest.Defensa;
            int vidaDespuesAtaque = humanoTest.VidaActual - dañoEsperado;

            Atacar.AtaquedeHechiceroaHumano(hechiceroTest,humanoTest);

            Assert.AreEqual(vidaDespuesAtaque,humanoTest.VidaActual);
        }

        [Test]
        //Defensor con item
        public void TestAtacarHechiceroHumanoItemDefensa()
        {
            int dañoEsperado = 0;
            if ((hechiceroTest.Ataque - (humanoTest.Defensa + botasTest.Defensa)) > 0)
                dañoEsperado = hechiceroTest.Ataque - (humanoTest.Defensa + botasTest.Defensa);
            int vidaDespuesAtaque = humanoTest.VidaActual - dañoEsperado;

            humanoTest.EquiparBotas(botasTest);
            Atacar.AtaquedeHechiceroaHumano(hechiceroTest,humanoTest);

            Assert.AreEqual(vidaDespuesAtaque,humanoTest.VidaActual);
        }

        

        /*[Test]
        //Ataque con item
        public void TestAtacarElfoElfoItemAtaque()
        {
            int dañoEsperado = 0;
            int poderAtacante = hechiceroTest.Ataque + baculoTest.Poder;
            if ((hechiceroTest.Ataque - hechiceroTest2.Defensa) > 0)
                dañoEsperado = hechiceroTest.Ataque - hechiceroTest2.Defensa;
            int vidaDespuesAtaque = hechiceroTest2.VidaActual - dañoEsperado;

            hechiceroTest.EquiparBaculo(baculoTest);
            Atacar.AtaquedeHechiceroaHechicero(hechiceroTest,hechiceroTest2);

            Assert.AreEqual(vidaDespuesAtaque,hechiceroTest2.VidaActual);
        }*/
    }
}