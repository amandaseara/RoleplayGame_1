using NUnit.Framework;
using Roleplay;

namespace Test.Library
{


    public class ExampleTest
    {

        [Test]
        public void dañoHacha()
        {
            Hacha hacha = new Hacha();
            int dañoHacha = hacha.GetDaño();
            int expected = 100;
            Assert.AreEqual(expected, dañoHacha);
        }
        [Test]
        public void defensaEspada()
        {
            Espada espada = new Espada();
            int defensaEspada = espada.GetDefensa();
            int expected = 0;
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
            Escudo escudo = new Escudo();
            int defensaEscudo = escudo.Defensa;
            int expected = 200;
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
    }


}
