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

        [Test]
        //Ambos sin items
        public void TestAtacarElfoElfo()
        {
            int dañoEsperado = 0;
            if ((elfoTest.Ataque - elfoTest2.Defensa) > 0)
                dañoEsperado = elfoTest.Ataque - elfoTest2.Defensa;
            int vidaDespuesAtaque = elfoTest2.VidaActual - dañoEsperado;

            Atacar.AtaquedeElfoaElfo(elfoTest,elfoTest2);

            Assert.AreEqual(vidaDespuesAtaque,elfoTest2.VidaActual);
        }

        [Test]
        //Defensor con item
        public void TestAtacarElfoElfoItemDefensa()
        {
            int dañoEsperado = 0;
            if ((elfoTest.Ataque - (elfoTest2.Defensa + botasTest.Defensa)) > 0)
                dañoEsperado = elfoTest.Ataque - (elfoTest2.Defensa + botasTest.Defensa);
            int vidaDespuesAtaque = elfoTest2.VidaActual - dañoEsperado;

            elfoTest2.EquiparBotas(botasTest);
            Atacar.AtaquedeElfoaElfo(elfoTest,elfoTest2);

            Assert.AreEqual(vidaDespuesAtaque,elfoTest2.VidaActual);
        }

        [Test]
        //Ataque con item
        public void TestAtacarElfoElfoItemAtaque()
        {
            int dañoEsperado = 0;
            int poderAtacante = elfoTest.Ataque + arcoTest.Daño;
            if ((poderAtacante - elfoTest2.Defensa) > 0)
                dañoEsperado = poderAtacante - elfoTest2.Defensa;
            int vidaDespuesAtaque = elfoTest2.VidaActual - dañoEsperado;

            elfoTest.EquiparArco(arcoTest);
            Atacar.AtaquedeElfoaElfo(elfoTest,elfoTest2);

            Assert.AreEqual(vidaDespuesAtaque,elfoTest2.VidaActual);
        }

        [Test]
        //Ambos sin items
        public void TestAtacarElfoEnano()
        {
            int dañoEsperado = 0;
            if ((elfoTest.Ataque - enanoTest.Defensa) > 0)
                dañoEsperado = elfoTest.Ataque - enanoTest.Defensa;
            int vidaDespuesAtaque = enanoTest.VidaActual - dañoEsperado;

            Atacar.AtaquedeElfoaEnano(elfoTest,enanoTest);

            Assert.AreEqual(vidaDespuesAtaque,enanoTest.VidaActual);
        }

        [Test]
        //Defensor con item
        public void TestAtacarElfoEnanoItemDefensa()
        {
            int dañoEsperado = 0;
            if ((elfoTest.Ataque - (enanoTest.Defensa + botasTest.Defensa)) > 0)
                dañoEsperado = elfoTest.Ataque - (enanoTest.Defensa + botasTest.Defensa);
            int vidaDespuesAtaque = enanoTest.VidaActual - dañoEsperado;

            enanoTest.EquiparBotas(botasTest);
            Atacar.AtaquedeElfoaEnano(elfoTest,enanoTest);

            Assert.AreEqual(vidaDespuesAtaque,enanoTest.VidaActual);
        }

        [Test]
        //Ataque con item
        public void TestAtacarElfoEnanoItemAtaque()
        {
            int dañoEsperado = 0;
            int poderAtacante = elfoTest.Ataque + arcoTest.Daño;
            if ((poderAtacante - enanoTest.Defensa) > 0)
                dañoEsperado = poderAtacante - enanoTest.Defensa;
            int vidaDespuesAtaque = enanoTest.VidaActual - dañoEsperado;

            elfoTest.EquiparArco(arcoTest);
            Atacar.AtaquedeElfoaEnano(elfoTest,enanoTest);

            Assert.AreEqual(vidaDespuesAtaque,enanoTest.VidaActual);
        }

        [Test]
        //Ambos sin items
        public void TestAtacarElfoHechicero()
        {
            int dañoEsperado = 0;
            if ((elfoTest.Ataque - hechiceroTest.Defensa) > 0)
                dañoEsperado = elfoTest.Ataque - hechiceroTest.Defensa;
            int vidaDespuesAtaque = hechiceroTest.VidaActual - dañoEsperado;

            Atacar.AtaquedeElfoaHechicero(elfoTest,hechiceroTest);

            Assert.AreEqual(vidaDespuesAtaque,hechiceroTest.VidaActual);
        }

        [Test]
        //Defensor con item
        public void TestAtacarElfoHechiceroItemDefensa()
        {
            int dañoEsperado = 0;
            if ((elfoTest.Ataque - (hechiceroTest.Defensa + botasTest.Defensa)) > 0)
                dañoEsperado = elfoTest.Ataque - (hechiceroTest.Defensa + botasTest.Defensa);
            int vidaDespuesAtaque = hechiceroTest.VidaActual - dañoEsperado;

            hechiceroTest.EquiparBotas(botasTest);
            Atacar.AtaquedeElfoaHechicero(elfoTest,hechiceroTest);

            Assert.AreEqual(vidaDespuesAtaque,hechiceroTest.VidaActual);
        }

        [Test]
        //Ataque con item
        public void TestAtacarElfoHechiceroItemAtaque()
        {
            int dañoEsperado = 0;
            int poderAtacante = elfoTest.Ataque + arcoTest.Daño;
            if ((poderAtacante - hechiceroTest.Defensa) > 0)
                dañoEsperado = poderAtacante - hechiceroTest.Defensa;
            int vidaDespuesAtaque = hechiceroTest.VidaActual - dañoEsperado;

            elfoTest.EquiparArco(arcoTest);
            Atacar.AtaquedeElfoaHechicero(elfoTest,hechiceroTest);

            Assert.AreEqual(vidaDespuesAtaque,hechiceroTest.VidaActual);
        }

        [Test]
        //Ambos sin items
        public void TestAtacarElfoHumano()
        {
            int dañoEsperado = 0;
            if ((elfoTest.Ataque - humanoTest.Defensa) > 0)
                dañoEsperado = elfoTest.Ataque - humanoTest.Defensa;
            int vidaDespuesAtaque = humanoTest.VidaActual - dañoEsperado;

            Atacar.AtaquedeElfoaHumano(elfoTest,humanoTest);

            Assert.AreEqual(vidaDespuesAtaque,humanoTest.VidaActual);
        }

        [Test]
        //Defensor con item
        public void TestAtacarElfoHumanoItemDefensa()
        {
            int dañoEsperado = 0;
            if ((elfoTest.Ataque - (humanoTest.Defensa + botasTest.Defensa)) > 0)
                dañoEsperado = elfoTest.Ataque - (humanoTest.Defensa + botasTest.Defensa);
            int vidaDespuesAtaque = humanoTest.VidaActual - dañoEsperado;

            humanoTest.EquiparBotas(botasTest);
            Atacar.AtaquedeElfoaHumano(elfoTest,humanoTest);

            Assert.AreEqual(vidaDespuesAtaque,humanoTest.VidaActual);
        }

        [Test]
        //Ataque con item
        public void TestAtacarElfoHumanoItemAtaque()
        {
            int dañoEsperado = 0;
            int poderAtacante = elfoTest.Ataque + arcoTest.Daño;
            if ((poderAtacante - humanoTest.Defensa) > 0)
                dañoEsperado = poderAtacante - humanoTest.Defensa;
            int vidaDespuesAtaque = humanoTest.VidaActual - dañoEsperado;

            elfoTest.EquiparArco(arcoTest);
            Atacar.AtaquedeElfoaHumano(elfoTest,humanoTest);

            Assert.AreEqual(vidaDespuesAtaque,humanoTest.VidaActual);
        }

        [Test]
        //Ambos sin items
        public void TestAtacarHumanoElfo()
        {
            int dañoEsperado = 0;
            if ((humanoTest.Ataque - elfoTest.Defensa) > 0)
                dañoEsperado = humanoTest.Ataque - elfoTest.Defensa;
            int vidaDespuesAtaque = elfoTest.VidaActual - dañoEsperado;

            Atacar.AtaquedeHumanoaElfo(humanoTest,elfoTest);

            Assert.AreEqual(vidaDespuesAtaque,elfoTest.VidaActual);
        }

        [Test]
        //Defensor con item
        public void TestAtacarHumanoElfoItemDefensa()
        {
            int dañoEsperado = 0;
            if ((humanoTest.Ataque - (elfoTest.Defensa + botasTest.Defensa)) > 0)
                dañoEsperado = humanoTest.Ataque - (elfoTest.Defensa + botasTest.Defensa);
            int vidaDespuesAtaque = elfoTest.VidaActual - dañoEsperado;

            elfoTest.EquiparBotas(botasTest);
            Atacar.AtaquedeHumanoaElfo(humanoTest,elfoTest);

            Assert.AreEqual(vidaDespuesAtaque,elfoTest.VidaActual);
        }

        [Test]
        //Ataque con item
        public void TestAtacarHumanoElfoItemAtaque()
        {
            int dañoEsperado = 0;
            int poderAtacante = humanoTest.Ataque + arcoTest.Daño;
            if ((poderAtacante - elfoTest.Defensa) > 0)
                dañoEsperado = poderAtacante - elfoTest.Defensa;
            int vidaDespuesAtaque = elfoTest.VidaActual - dañoEsperado;

            humanoTest.EquiparEspada(espadaTest);
            Atacar.AtaquedeHumanoaElfo(humanoTest,elfoTest);

            Assert.AreEqual(vidaDespuesAtaque,elfoTest.VidaActual);
        }

        [Test]
        //Ambos sin items
        public void TestAtacarHumanoEnano()
        {
            int dañoEsperado = 0;
            if ((humanoTest.Ataque - enanoTest.Defensa) > 0)
                dañoEsperado = humanoTest.Ataque - enanoTest.Defensa;
            int vidaDespuesAtaque = enanoTest.VidaActual - dañoEsperado;

            Atacar.AtaquedeHumanoaEnano(humanoTest,enanoTest);

            Assert.AreEqual(vidaDespuesAtaque,enanoTest.VidaActual);
        }

        [Test]
        //Defensor con item
        public void TestAtacarHumanoEnanoItemDefensa()
        {
            int dañoEsperado = 0;
            if ((humanoTest.Ataque - (enanoTest.Defensa + botasTest.Defensa)) > 0)
                dañoEsperado = humanoTest.Ataque - (enanoTest.Defensa + botasTest.Defensa);
            int vidaDespuesAtaque = enanoTest.VidaActual - dañoEsperado;

            enanoTest.EquiparBotas(botasTest);
            Atacar.AtaquedeHumanoaEnano(humanoTest,enanoTest);

            Assert.AreEqual(vidaDespuesAtaque,enanoTest.VidaActual);
        }

        [Test]
        //Ataque con item
        public void TestAtacarHumanoEnanoItemAtaque()
        {
            int dañoEsperado = 0;
            int poderAtacante = humanoTest.Ataque + arcoTest.Daño;
            if ((poderAtacante - enanoTest.Defensa) > 0)
                dañoEsperado = poderAtacante - enanoTest.Defensa;
            int vidaDespuesAtaque = enanoTest.VidaActual - dañoEsperado;

            humanoTest.EquiparEspada(espadaTest);
            Atacar.AtaquedeHumanoaEnano(humanoTest,enanoTest);

            Assert.AreEqual(vidaDespuesAtaque,enanoTest.VidaActual);
        }

        [Test]
        //Ambos sin items
        public void TestAtacarHumanoHechicero()
        {
            int dañoEsperado = 0;
            if ((humanoTest.Ataque - hechiceroTest.Defensa) > 0)
                dañoEsperado = humanoTest.Ataque - hechiceroTest.Defensa;
            int vidaDespuesAtaque = hechiceroTest.VidaActual - dañoEsperado;

            Atacar.AtaquedeHumanoaHechicero(humanoTest,hechiceroTest);

            Assert.AreEqual(vidaDespuesAtaque,hechiceroTest.VidaActual);
        }

        [Test]
        //Defensor con item
        public void TestAtacarHumanoHechiceroItemDefensa()
        {
            int dañoEsperado = 0;
            if ((humanoTest.Ataque - (hechiceroTest.Defensa + botasTest.Defensa)) > 0)
                dañoEsperado = humanoTest.Ataque - (hechiceroTest.Defensa + botasTest.Defensa);
            int vidaDespuesAtaque = hechiceroTest.VidaActual - dañoEsperado;

            hechiceroTest.EquiparBotas(botasTest);
            Atacar.AtaquedeHumanoaHechicero(humanoTest,hechiceroTest);

            Assert.AreEqual(vidaDespuesAtaque,hechiceroTest.VidaActual);
        }

        [Test]
        //Ataque con item
        public void TestAtacarHumanoHechiceroItemAtaque()
        {
            int dañoEsperado = 0;
            int poderAtacante = humanoTest.Ataque + arcoTest.Daño;
            if ((poderAtacante - hechiceroTest.Defensa) > 0)
                dañoEsperado = poderAtacante - hechiceroTest.Defensa;
            int vidaDespuesAtaque = hechiceroTest.VidaActual - dañoEsperado;

            humanoTest.EquiparEspada(espadaTest);
            Atacar.AtaquedeHumanoaHechicero(humanoTest,hechiceroTest);

            Assert.AreEqual(vidaDespuesAtaque,hechiceroTest.VidaActual);
        }

        [Test]
        //Ambos sin items
        public void TestAtacarHumanoHumano()
        {
            int dañoEsperado = 0;
            if ((humanoTest2.Ataque - humanoTest.Defensa) > 0)
                dañoEsperado = humanoTest2.Ataque - humanoTest.Defensa;
            int vidaDespuesAtaque = humanoTest.VidaActual - dañoEsperado;

            Atacar.AtaquedeHumanoaHumano(humanoTest2,humanoTest);

            Assert.AreEqual(vidaDespuesAtaque,humanoTest.VidaActual);
        }

        [Test]
        //Defensor con item
        public void TestAtacarHumanoHumanoItemDefensa()
        {
            int dañoEsperado = 0;
            if ((humanoTest2.Ataque - (humanoTest.Defensa + botasTest.Defensa)) > 0)
                dañoEsperado = humanoTest2.Ataque - (humanoTest.Defensa + botasTest.Defensa);
            int vidaDespuesAtaque = humanoTest.VidaActual - dañoEsperado;

            humanoTest.EquiparBotas(botasTest);
            Atacar.AtaquedeHumanoaHumano(humanoTest2,humanoTest);

            Assert.AreEqual(vidaDespuesAtaque,humanoTest.VidaActual);
        }

        [Test]
        //Ataque con item
        public void TestAtacarHumanoHumanoItemAtaque()
        {
            int dañoEsperado = 0;
            int poderAtacante = humanoTest2.Ataque + arcoTest.Daño;
            if ((poderAtacante - humanoTest.Defensa) > 0)
                dañoEsperado = poderAtacante - humanoTest.Defensa;
            int vidaDespuesAtaque = humanoTest.VidaActual - dañoEsperado;

            humanoTest2.EquiparEspada(espadaTest);
            Atacar.AtaquedeHumanoaHumano(humanoTest2,humanoTest);

            Assert.AreEqual(vidaDespuesAtaque,humanoTest.VidaActual);
        }

        [Test]
        //Ambos sin items
        public void TestAtacarEnanoElfo()
        {
            int dañoEsperado = 0;
            if ((enanoTest.Ataque - elfoTest.Defensa) > 0)
                dañoEsperado = enanoTest.Ataque - elfoTest.Defensa;
            int vidaDespuesAtaque = elfoTest.VidaActual - dañoEsperado;

            Atacar.AtaquedeEnanoaElfo(enanoTest,elfoTest);

            Assert.AreEqual(vidaDespuesAtaque,elfoTest.VidaActual);
        }

        [Test]
        //Defensor con item
        public void TestAtacarEnanoElfoItemDefensa()
        {
            int dañoEsperado = 0;
            if ((enanoTest.Ataque - (elfoTest.Defensa + botasTest.Defensa)) > 0)
                dañoEsperado = enanoTest.Ataque - (elfoTest.Defensa + botasTest.Defensa);
            int vidaDespuesAtaque = elfoTest.VidaActual - dañoEsperado;

            elfoTest.EquiparBotas(botasTest);
            Atacar.AtaquedeEnanoaElfo(enanoTest,elfoTest);

            Assert.AreEqual(vidaDespuesAtaque,elfoTest.VidaActual);
        }

        [Test]
        //Ataque con item
        public void TestAtacarEnanoElfoItemAtaque()
        {
            int dañoEsperado = 0;
            int poderAtacante = enanoTest.Ataque + hachaTest.Daño;
            if ((poderAtacante - elfoTest.Defensa) > 0)
                dañoEsperado = poderAtacante - elfoTest.Defensa;
            int vidaDespuesAtaque = elfoTest.VidaActual - dañoEsperado;

            enanoTest.EquiparHacha(hachaTest);
            Atacar.AtaquedeEnanoaElfo(enanoTest,elfoTest);

            Assert.AreEqual(vidaDespuesAtaque,elfoTest.VidaActual);
        }

        [Test]
        //Ambos sin items
        public void TestAtacarEnanoEnano()
        {
            int dañoEsperado = 0;
            if ((enanoTest2.Ataque - enanoTest.Defensa) > 0)
                dañoEsperado = enanoTest2.Ataque - enanoTest.Defensa;
            int vidaDespuesAtaque = enanoTest.VidaActual - dañoEsperado;

            Atacar.AtaquedeEnanoaEnano(enanoTest2,enanoTest);

            Assert.AreEqual(vidaDespuesAtaque,enanoTest.VidaActual);
        }

        [Test]
        //Defensor con item
        public void TestAtacarEnanoEnanoItemDefensa()
        {
            int dañoEsperado = 0;
            if ((enanoTest2.Ataque - (enanoTest.Defensa + botasTest.Defensa)) > 0)
                dañoEsperado = enanoTest2.Ataque - (enanoTest.Defensa + botasTest.Defensa);
            int vidaDespuesAtaque = enanoTest.VidaActual - dañoEsperado;

            enanoTest.EquiparBotas(botasTest);
            Atacar.AtaquedeEnanoaEnano(enanoTest2,enanoTest);

            Assert.AreEqual(vidaDespuesAtaque,enanoTest.VidaActual);
        }

        [Test]
        //Ataque con item
        public void TestAtacarEnanoEnanoItemAtaque()
        {
            int dañoEsperado = 0;
            int poderAtacante = enanoTest2.Ataque + hachaTest.Daño;
            if ((poderAtacante - enanoTest.Defensa) > 0)
                dañoEsperado = poderAtacante - enanoTest.Defensa;
            int vidaDespuesAtaque = enanoTest.VidaActual - dañoEsperado;

            enanoTest2.EquiparHacha(hachaTest);
            Atacar.AtaquedeEnanoaEnano(enanoTest2,enanoTest);

            Assert.AreEqual(vidaDespuesAtaque,enanoTest.VidaActual);
        }

        [Test]
        //Ambos sin items
        public void TestAtacarEnanoHechicero()
        {
            int dañoEsperado = 0;
            if ((enanoTest.Ataque - hechiceroTest.Defensa) > 0)
                dañoEsperado = enanoTest.Ataque - hechiceroTest.Defensa;
            int vidaDespuesAtaque = hechiceroTest.VidaActual - dañoEsperado;

            Atacar.AtaquedeEnanoaHechicero(enanoTest,hechiceroTest);

            Assert.AreEqual(vidaDespuesAtaque,hechiceroTest.VidaActual);
        }

        [Test]
        //Defensor con item
        public void TestAtacarEnanoHechiceroItemDefensa()
        {
            int dañoEsperado = 0;
            if ((enanoTest.Ataque - (hechiceroTest.Defensa + botasTest.Defensa)) > 0)
                dañoEsperado = enanoTest.Ataque - (hechiceroTest.Defensa + botasTest.Defensa);
            int vidaDespuesAtaque = hechiceroTest.VidaActual - dañoEsperado;

            hechiceroTest.EquiparBotas(botasTest);
            Atacar.AtaquedeEnanoaHechicero(enanoTest,hechiceroTest);

            Assert.AreEqual(vidaDespuesAtaque,hechiceroTest.VidaActual);
        }

        [Test]
        //Ataque con item
        public void TestAtacarEnanoHechiceroItemAtaque()
        {
            int dañoEsperado = 0;
            int poderAtacante = enanoTest.Ataque + hachaTest.Daño;
            if ((poderAtacante - hechiceroTest.Defensa) > 0)
                dañoEsperado = poderAtacante - hechiceroTest.Defensa;
            int vidaDespuesAtaque = hechiceroTest.VidaActual - dañoEsperado;

            enanoTest.EquiparHacha(hachaTest);
            Atacar.AtaquedeEnanoaHechicero(enanoTest,hechiceroTest);

            Assert.AreEqual(vidaDespuesAtaque,hechiceroTest.VidaActual);
        }

        [Test]
        //Ambos sin items
        public void TestAtacarEnanoHumano()
        {
            int dañoEsperado = 0;
            if ((enanoTest.Ataque - humanoTest.Defensa) > 0)
                dañoEsperado = enanoTest.Ataque - humanoTest.Defensa;
            int vidaDespuesAtaque = humanoTest.VidaActual - dañoEsperado;

            Atacar.AtaquedeEnanoaHumano(enanoTest,humanoTest);

            Assert.AreEqual(vidaDespuesAtaque,humanoTest.VidaActual);
        }

        [Test]
        //Defensor con item
        public void TestAtacarEnanoHumanoItemDefensa()
        {
            int dañoEsperado = 0;
            if ((enanoTest.Ataque - (humanoTest.Defensa + botasTest.Defensa)) > 0)
                dañoEsperado = enanoTest.Ataque - (humanoTest.Defensa + botasTest.Defensa);
            int vidaDespuesAtaque = humanoTest.VidaActual - dañoEsperado;

            humanoTest.EquiparBotas(botasTest);
            Atacar.AtaquedeEnanoaHumano(enanoTest,humanoTest);

            Assert.AreEqual(vidaDespuesAtaque,humanoTest.VidaActual);
        }

        [Test]
        //Ataque con item
        public void TestAtacarEnanoHumanoItemAtaque()
        {
            int dañoEsperado = 0;
            int poderAtacante = enanoTest.Ataque + hachaTest.Daño;
            if ((poderAtacante - humanoTest.Defensa) > 0)
                dañoEsperado = poderAtacante - humanoTest.Defensa;
            int vidaDespuesAtaque = humanoTest.VidaActual - dañoEsperado;

            enanoTest.EquiparHacha(hachaTest);
            Atacar.AtaquedeEnanoaHumano(enanoTest,humanoTest);

            Assert.AreEqual(vidaDespuesAtaque,humanoTest.VidaActual);
        }
    }
}