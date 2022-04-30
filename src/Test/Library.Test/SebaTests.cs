/*using NUnit.Framework;
using Roleplay;

namespace Test.Library
{


    public class TestsItems
    {

        [Test]
        public void poderBaculo()
        {
            Baculo baculo = new Baculo(100);
            int poderBaculo = baculo.Poder;
            int expected = 100;
            Assert.AreEqual(expected, poderBaculo);
        }

        [Test]
        public void dañoArco()
        {
            Arco arco = new Arco(100, 0);
            int dañoArco = arco.Daño;
            int expected = 100;
            Assert.AreEqual(expected, dañoArco);
        }

        [Test]
        public void defensaArco()
        {
            Arco arco = new Arco(100, 0);
            int defensaArco = arco.Defensa;
            int expected = 0;
            Assert.AreEqual(expected, defensaArco);
        }

        [Test]
        public void dañoEspada()
        {
            Espada espada = new Espada(100, 0);
            int dañoEspada = espada.Daño;
            int expected = 100;
            Assert.AreEqual(expected, dañoEspada);
        }

        [Test]
        public void defensaEspada()
        {
            Espada espada = new Espada(100, 0);
            int defensaEspada = espada.Defensa;
            int expected = 0;
            Assert.AreEqual(expected, defensaEspada);
        }

        [Test]
        public void dañoBotas()
        {
            Botas botas = new Botas(100, 0);
            int dañoBotas = botas.Daño;
            int expected = 100;
            Assert.AreEqual(expected, dañoBotas);
        }

        [Test]
        public void defensaBotas()
        {
            Botas botas = new Botas(100, 0);
            int defensaBotas = botas.Defensa;
            int expected = 0;
            Assert.AreEqual(expected, defensaBotas);
        }

        [Test]
        public void dañoEscudo()
        {
            Escudo escudo = new Escudo(100, 0);
            int dañoEscudo = escudo.Daño;
            int expected = 100;
            Assert.AreEqual(expected, dañoEscudo);
        }
        
        [Test]
        public void defensaEscudo()
        {
            Escudo escudo = new Escudo(100, 0);
            int defensaEscudo = escudo.Defensa;
            int expected = 0;
            Assert.AreEqual(expected, defensaEscudo);
        }

        [Test]
        public void dañoGrebas()
        {
            Grebas grebas = new Grebas(100, 0);
            int dañoGrebas = grebas.Daño;
            int expected = 100;
            Assert.AreEqual(expected, dañoGrebas);
        }
        
        [Test]
        public void defensaGrebas()
        {
            Grebas grebas = new Grebas(100, 0);
            int defensaGrebas = grebas.Defensa;
            int expected = 0;
            Assert.AreEqual(expected, defensaGrebas);
        }

        [Test]
        public void dañoHacha()
        {
            Hacha hacha = new Hacha(100, 0);
            int dañoHacha = hacha.Daño;
            int expected = 100;
            Assert.AreEqual(expected, dañoHacha);
        }
        
        [Test]
        public void defensaHacha()
        {
            Hacha hacha = new Hacha(100, 0);
            int defensaHacha = hacha.Defensa;
            int expected = 0;
            Assert.AreEqual(expected, defensaHacha);
        }

        [Test]
        public void dañoPechera()
        {
            Pechera pechera = new Pechera(100, 0);
            int dañoPechera = pechera.Daño;
            int expected = 100;
            Assert.AreEqual(expected, dañoPechera);
        }
        
        [Test]
        public void defensaPechera()
        {
            Pechera pechera = new Pechera(100, 0);
            int defensaPechera = pechera.Defensa;
            int expected = 0;
            Assert.AreEqual(expected, defensaPechera);
        }

        [Test]
        public void dañoYelmo()
        {
            Yelmo yelmo = new Yelmo(100, 0);
            int dañoYelmo = yelmo.Daño;
            int expected = 100;
            Assert.AreEqual(expected, dañoYelmo);
        }
        
        [Test]
        public void defensaYelmo()
        {
            Yelmo yelmo = new Yelmo(100, 0);
            int defensaYelmo = yelmo.Defensa;
            int expected = 0;
            Assert.AreEqual(expected, defensaYelmo);
        }

        [Test]
        public void nombreHechizo()
        {
            Hechizo hechizo = new Hechizo("Bola de fuego", 100, 0);
            string nombreHechizo = hechizo.Nombre;
            string expected = "Bola de fuego";
            Assert.AreEqual(expected, nombreHechizo);
        }

        [Test]
        public void nombreHechizo2()
        {
            Hechizo hechizo = new Hechizo("", 100, 0);
            string dañoHechizo = hechizo.Nombre;
            string expected = "";
            Assert.AreEqual(expected, dañoHechizo);
        }

        [Test]
        public void dañoHechizo()
        {
            Hechizo hechizo = new Hechizo("Bola de fuego", 100, 0);
            int dañoHechizo = hechizo.Daño;
            int expected = 100;
            Assert.AreEqual(expected, dañoHechizo);
        }
        
        [Test]
        public void defensaHechizo()
        {
            Hechizo hechizo = new Hechizo("Bola de fuego", 100, 0);
            int defensaHechizo = hechizo.Defensa;
            int expected = 0;
            Assert.AreEqual(expected, defensaHechizo);
        }

    }


}*/