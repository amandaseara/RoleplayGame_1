using System;
using System.Collections;
using System.Collections.Generic;

namespace Roleplay
{
    public class Elfo
    {
        private string nombre;
        // nombre del personaje
        private ArrayList equipamiento;
        // ArrayList de equipamiento, dentro esta la armadura, y dos armas, una principal y una secundaria
        private int ataque = 500;
        // ataque base del elfo, a este ataque se le suman todas las bonificaciones de daño, proveniente de todas las fuentes, a la hora de atacar (por ejemplo un item (arma por ejemplo) o un hechizo. Si el elfo tiene un arco equipado, se le suma el ataque del arco al ataque base). Este atributo se crea para diferenciar el daño del personaje con el daño proveniente de otras fuentes (como un arma, o un posible hechizo que potencie el daño), porque si se acumulan bonificaciones en una sola variable, no se sabe de donde proviene el daño (por ejemplo, si aparece que el daño es 60, no se sabe cual es el daño del arma y cual es el daño del personaje, pero si aparece (500)+100, se sabe que el daño del personaje es 500 y el daño del arma es 100. Esto sirve por ejemplo a la hora de elegir que arma usar, ya que se pueden hacer calculos de forma mas sencilla)
        private int vidaActual = 500;
        // vida base del elfo, a esta vida se le suman todas las bonificaciones de salud, proveniente de todas las fuentes, a la hora de defender (por ejemplo un item (armadura por ejemplo) o un hechizo. Si el elfo tiene un yelmo equipado, se le suma la vida del yelmo a la vida base). Este atributo se crea por la misma razon que el daño base.
        private int vidaMax = 500;
        // vida maxima del elfo, este atributo se crea para saber cuanta vida debe curar el elfo, ya que la curacion se define como recuperar la vida
        private int defensa = 500;
        // defensa base del elfo, a esta defensa se le suman todas las bonificaciones de defensa, proveniente de todas las fuentes, a la hora de defender (por ejemplo un item o un hechizo (un posible hechizo que potencie defensa por ejemplo). Si al elfo lo llegaran a potenciar con un hechizo por ejemplo, se le suma la defensa del hechizo a la defensa base). Este atributo se crea por la misma razon que el daño base.
        public Elfo(string nombre, ArrayList equipamiento)
        {
            this.nombre = nombre;
            this.equipamiento = new ArrayList();
            int i = 0;
            while (i != 6)
            {
                this.equipamiento.Add(i);
                i++;
            }
        }
        public void EquiparYelmo(Yelmo yelmo)
        {
            this.equipamiento[0] = yelmo;
            this.defensa += yelmo.Defensa;
        }
        public void EquiparPechera(Pechera pechera)
        {
            this.equipamiento[1] = pechera;
            this.defensa += pechera.Defensa;
        }
        public void EquiparGrebas(Grebas grebas)
        {
            this.equipamiento[2] = grebas;
            this.defensa += grebas.Defensa;
        }
        public void EquiparBotas(Botas botas)
        {
            this.equipamiento[3] = botas;
            this.defensa += botas.Defensa;
        }
        public void EquiparEspada(Espada espada)
        {
            this.equipamiento[4] = espada;
            this.ataque += espada.Daño;
        }
        public void EquiparArco(Arco arco)
        {
            this.equipamiento[5] = arco;
            this.ataque += arco.Daño;
        }

        public void DesequiparYelmo(Yelmo yelmo)
        {
            if (yelmo == this.equipamiento[0])
            {
                this.defensa -= yelmo.Defensa;
                this.equipamiento[0] = 0;
            }
        }
        public void DesequiparPechera(Pechera pechera)
        {
            if (pechera == this.equipamiento[1])
            {
                this.defensa -= pechera.Defensa;
                this.equipamiento[1] = 1;
            }
        }
        public void DesequiparGrebas(Grebas grebas)
        {
            if (grebas == this.equipamiento[2])
            {
                this.defensa -= grebas.Defensa;
                this.equipamiento[2] = 2;
            }
        }
        public void DesequiparBotas(Botas botas)
        {
            if (botas == this.equipamiento[3])
            {
                this.defensa -= botas.Defensa;
                this.equipamiento[3] = 3;
            }
        }
        public void DesequiparEspada(Espada espada)
        {
            if (espada == this.equipamiento[4])
            {
                this.ataque -= espada.Daño;
                this.equipamiento[4] = 4;
            }
        }
        public void DesequiparArco(Arco arco)
        {
            if (arco == this.equipamiento[5])
            {
                this.ataque -= arco.Daño;
                this.equipamiento[5] = 5;
            }
        }
        public void SerCurado()
        {
            this.vidaActual = 500;
        }
        public void CurarHechicero()
        {
            Hechicero.SerCurado();
        }
        public void CurarHumano()
        {
            Humano.SerCurado();
        }
        public void CurarEnano()
        {
            Enano.SerCurado();
        }
        public void AtacarHechicero()
        {
            int dañoTotal = this.ataque;
            foreach(Espada espada in equipamiento)
            {
                int dañoEspada = espada.Daño;
                dañoTotal += dañoEspada;
            }
            Hechicero.Defender(dañoTotal);
        }
        public void AtacarHumano()
        {
            int dañoTotal = this.ataque;
            foreach(Espada espada in equipamiento)
            {
                int dañoEspada = espada.Daño;
                dañoTotal += dañoEspada;
            }
            Humano.defender(dañoTotal);
        }
        public void AtacarEnano()
        {
            int dañoTotal = this.ataque;
            foreach(Espada espada in equipamiento)
            {
                int dañoEspada = espada.Daño;
                dañoTotal += dañoEspada;
            }
            Enano.defender(dañoTotal);
        }
        public void AtacarElfo()
        {
            int dañoTotal = this.ataque;
            foreach(Espada espada in equipamiento)
            {
                int dañoEspada = espada.Daño;
                dañoTotal += dañoEspada;
            }
            this.Defender(dañoTotal);
        }
        public void Defender(int ataqueRecibido)
        {
            int defensaTotal = this.defensa;
            this.vidaActual = vidaActual - ataqueRecibido - defensaTotal;
        }
    }
}