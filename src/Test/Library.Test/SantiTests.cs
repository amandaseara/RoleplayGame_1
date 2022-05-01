using NUnit.Framework;


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
        public void CuraHechizo()
        {
            Hechizo hechizo = new Hechizo("Incendio",150,0);
            int DañoHechizo = hechizo.daño;
            int expected = 150;
            Assert.AreEqual(expected, DañoHechizo);
        }     
        [Test]
        public void TestVActualHumano()
        {
            Humano humano = new Humano("Matias");
            int vidabase = humano.vidaActual;
            int expected = 500;
            Assert.AreEqual(expected, vidabase);
        }
        [Test]
        public void TestVActualEnano()
        {
            Enano enano = new Enano("Rey Mysterio");
            int vidabase = enano.VidaActual;
            int expected = 500;
            Assert.AreEqual(expected, vidabase);
        }
        [Test]
        public void TestVActualElfo()
        {
            Elfo elfo = new Elfo("Link");
            int vidabase = elfo.VidaActual;
            int expected = 500;
            Assert.AreEqual(expected, vidabase);
        }
        [Test]
        public void TestVActualHechicero()
        {
            Hechicero hechicero = new Hechicero("Merlin");
            int vidabase = hechicero.VidaActual;
            int expected = 500;
            Assert.AreEqual(expected, vidabase);
        }
        [Test]
        public void TestDefensaHechicero()
        {
            Hechicero hechicero = new Hechicero("Merlin");
            int defensaHechicero = hechicero.Defensa;
            int expected = 500;
            Assert.AreEqual(expected, defensaHechicero);
        }
        [Test]
        public void TestDefensaElfo()
        {
            Elfo elfo = new Elfo("Link");
            int defensaElfo = elfo.Defensa;
            int expected = 0;
            Assert.AreEqual(expected, defensaElfo);
        }
        [Test]
        public void TestAtaqueElfo()
        {
            Elfo elfo = new Elfo("Link");
            int AtaqueElfo = elfo.Ataque;
            int expected = 500;
            Assert.AreEqual(expected, AtaqueElfo);
        }
        [Test]
        public void TestAtaqueEnano()
        {
            Enano enano = new Enano("Rey Mysterio");
            int AtaqueEnano = enano.Ataque;
            int expected = 500;
            Assert.AreEqual(expected, AtaqueEnano);
        }
        [Test]
        public void TestAtaqueHechicero()
        {
            Hechicero hechicero = new Hechicero("Merlin");
            int AtaqueHechicero = hechicero.Ataque;
            int expected = 500;
            Assert.AreEqual(expected, AtaqueHechicero);
        }
        [Test]
        public void TestAtaqueHumano()
        {
            Humano humano = new Humano("Matias");
            int AtaqueHumano = humano.Ataque;
            int expected = 500;
            Assert.AreEqual(expected, AtaqueHumano);
        }/*Los Tests se tratan de que coincidan tanto las cosas asignadas, Primero Creamos un personaje/hechizo/ataque, las llamamos a traves de 
        (<variable>.accion), Asignamos un expected, un int o string que se espera que sea con nuestra creación, 
        todas están hechas para que sean todas correctas. Se usa Assert.Equal para hacer la comparación para que coincida.*/
    }


}