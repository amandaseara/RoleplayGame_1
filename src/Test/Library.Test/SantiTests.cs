/*using NUnit.Framework;


namespace Roleplay
{


    public class SantiTests
    {

        [Test]
        public void dañoHacha()
        {
            Hacha hacha = new Hacha(100,55);
            int dañoHacha = hacha.Daño;
            int expected = 100;
            Assert.AreEqual(expected, dañoHacha);
        }
        [Test]
        public void defensaEspada()
        {
            Espada espada = new Espada(150,75);
            int defensaEspada = espada.Defensa;
            int expected = 75;
            Assert.AreEqual(expected, defensaEspada);
        }
        [Test]
        public void dañoHechizo()
        {
            Hechizo hechizo = new Hechizo("Abracadabra",100,50);
            int dañoHechizo = hechizo.daño;
            int expected = 100;
            Assert.AreEqual(expected, dañoHechizo);
        }
        [Test]
        public void defensaHechizo()
        {
            Hechizo hechizo = new Hechizo("Abracadabra",100,50);
            int defensaHechizo = hechizo.Defensa;
            int expected = 50;
            Assert.AreEqual(expected, defensaHechizo);
        }
        [Test]
        public void defensaEscudo()
        {
            Escudo escudo = new Escudo(50,100);
            int defensaEscudo = escudo.Defensa;
            int expected = 100;
            Assert.AreEqual(expected, defensaEscudo);
        }
        [Test]
        public void NameHechicero()
        {
            Hechicero hechicero = new Hechicero("Merlin");
            string nombreHechicero = hechicero.Nombre;
            string expected = "Merlin";
            Assert.AreEqual(expected, nombreHechicero);
        }
        [Test]
        public void NameHechizo()
        {
            Hechizo hechizo = new Hechizo("Curación",150,0);
            string nombreHechizo = hechizo.Nombre;
            string expected = "Curación";
            Assert.AreEqual(expected, nombreHechizo);
        }
        [Test]
        public void TestVActualhumano()
        {
            Humano humano = new Humano("Matias");
            int vidabase = humano.vidaActual;
            int expected = 500;
            Assert.AreEqual(expected, vidabase);
        }
    }


}*/