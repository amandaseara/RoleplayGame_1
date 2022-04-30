using NUnit.Framework;
using Roleplay;


namespace Test.Library
{

    [TestFixture]
    public class ExampleTest
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
        public void TestCreacionElfoNombre()
        {
            Assert.AreEqual("Raul",elfoTest.Nombre);
        }
        [Test]
        public void TestCreacionElfoDaño()
        {
            Assert.AreEqual(500,elfoTest.Ataque);
        }
        [Test]
        public void Testdañoarco()
        {
            Assert.AreEqual(100,arcoTest.Daño);
        }

        [Test]
        public void Testdefensaarco()
        {
            Assert.AreEqual(0,arcoTest.Defensa);
        }
        [Test]
        public void TestEquipar()
        {
            int dañoDeArco= arcoTest.Daño;
            int dañoEsperado = elfoTest.Ataque + dañoDeArco;
            elfoTest.EquiparArco(arcoTest);
            Assert.AreEqual(dañoEsperado,elfoTest.Ataque);
            Assert.AreEqual(0,elfoTest.Defensa);
        }
        [Test]
        public void TestDesequipar()
        {
            int dañoEsperado = elfoTest.Ataque;
            elfoTest.EquiparArco(arcoTest);
            elfoTest.DesequiparArco(arcoTest);
            Assert.AreEqual(dañoEsperado,elfoTest.Ataque);
            Assert.AreEqual(0,elfoTest.Defensa);
        }
        [Test]
        public void TestAtaque()
        {
            int dañoDeEntrada=elfoTest.Ataque;
            int dañoEsperado =elfoTest.Ataque  - hechiceroTest.Defensa;
            int nuevaVidadeHechicero =hechiceroTest.VidaActual- dañoEsperado;
            Atacar.AtaquedeElfoaHechicero(elfoTest,hechiceroTest);
            Assert.AreEqual(nuevaVidadeHechicero,hechiceroTest.VidaActual);
        }
        [Test]
        public void TestAtaqueConHechizo()
        {
            int dañoDeEntrada = hechiceroTest.UsarHechizoparaAtaque("Hechizo inicial");
            int dañoEsperado  = dañoDeEntrada  - elfoTest.Defensa;
            int nuevaVidadeElfo =elfoTest.VidaActual- dañoEsperado;
            AtaquesconHechizo.AtaqueaElfo(hechiceroTest,"Hechizo inicial",elfoTest);
            Assert.AreEqual(nuevaVidadeElfo,elfoTest.VidaActual);
        }
    }
}