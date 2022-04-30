using System;
using System.Collections;
using System.Collections.Generic;

namespace Roleplay
{
    public class Elfo
    {
        private string nombre;
        // nombre del personaje
        public string Nombre{get{return nombre;}}
        private ArrayList equipamiento;
        // ArrayList de equipamiento, dentro esta la armadura, y dos armas, una principal y una secundaria
        private int ataque = 500;
        // ataque base del elfo, a este ataque se le suman todas las bonificaciones de daño, proveniente de todas las fuentes, a la hora de atacar (por ejemplo un item (arma por ejemplo) o un hechizo. Si el elfo tiene un arco equipado, se le suma el ataque del arco al ataque base). Este atributo se crea para diferenciar el daño del personaje con el daño proveniente de otras fuentes (como un arma, o un posible hechizo que potencie el daño), porque si se acumulan bonificaciones en una sola variable, no se sabe de donde proviene el daño (por ejemplo, si aparece que el daño es 60, no se sabe cual es el daño del arma y cual es el daño del personaje, pero si aparece (500)+100, se sabe que el daño del personaje es 500 y el daño del arma es 100. Esto sirve por ejemplo a la hora de elegir que arma usar, ya que se pueden hacer calculos de forma mas sencilla)
        public int Ataque { get { return ataque;}}
        public int VidaActual{get{return vidaActual;}}
        private int vidaActual = 500;
        // vida base del elfo, a esta vida se le suman todas las bonificaciones de salud, proveniente de todas las fuentes, a la hora de defender (por ejemplo un item (armadura por ejemplo) o un hechizo. Si el elfo tiene un yelmo equipado, se le suma la vida del yelmo a la vida base). Este atributo se crea por la misma razon que el daño base.
        private int vidaMax = 500;
        // vida maxima del elfo, este atributo se crea para saber cuanta vida debe curar el elfo, ya que la curacion se define como recuperar la vida
        private int defensa = 0;
        public int Defensa{get{return defensa;}}
        // defensa base del elfo, a esta defensa se le suman todas las bonificaciones de defensa, proveniente de todas las fuentes, a la hora de defender (por ejemplo un item o un hechizo (un posible hechizo que potencie defensa por ejemplo). Si al elfo lo llegaran a potenciar con un hechizo por ejemplo, se le suma la defensa del hechizo a la defensa base). Este atributo se crea por la misma razon que el daño base.
        public Elfo(string nombre)
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
            // Si esta vacio, equipo intem
            if (this.equipamiento[0].GetType() == 0.GetType())
            {
                this.equipamiento[0] = yelmo;
                this.ataque += yelmo.Daño;
                this.defensa += yelmo.Defensa;
            }
        }
        public void EquiparPechera(Pechera pechera)
        {
            // Si esta vacio, equipo intem
            if (this.equipamiento[1].GetType() == 0.GetType())
            {
                this.equipamiento[1] = pechera;
                this.ataque += pechera.Daño;
                this.defensa += pechera.Defensa;
            }
        }
        public void EquiparGrebas(Grebas grebas)
        {
            // Si esta vacio, equipo intem
            if (this.equipamiento[2].GetType() == 0.GetType())
            {
                this.equipamiento[2] = grebas;
                this.ataque += grebas.Daño;
                this.defensa += grebas.Defensa;
            }
        }
        public void EquiparBotas(Botas botas)
        {
            // Si esta vacio, equipo intem
            if (this.equipamiento[3].GetType() == 0.GetType())
            {
                this.equipamiento[3] = botas;
                this.ataque += botas.Daño;
                this.defensa += botas.Defensa;
            }
        }
        public void EquiparEspada(Espada espada)
        {
            // Si esta vacio, equipo intem
            if (this.equipamiento[4].GetType() == 0.GetType())
            {
                this.equipamiento[4] = espada;
                this.ataque += espada.Daño;
                this.defensa += espada.Defensa;
            }
        }
        public void EquiparArco(Arco arco)
        {
            // Si esta vacio, equipo intem
            if (this.equipamiento[5].GetType() == 0.GetType())
            {
                this.equipamiento[5] = arco;
                this.ataque += arco.Daño;
                this.defensa += arco.Defensa;
            }
        }

        //DESEQUIPAR
        public void DesequiparYelmo(Yelmo yelmo)
        {
            if (yelmo == this.equipamiento[0])
            {
                this.defensa -= yelmo.Defensa;
                this.ataque -= yelmo.Daño;
                this.equipamiento[0] = 0;
            }
        }
        public void DesequiparPechera(Pechera pechera)
        {
            if (pechera == this.equipamiento[1])
            {
                this.defensa -= pechera.Defensa;
                this.ataque -= pechera.Daño;
                this.equipamiento[1] = 1;
            }
        }
        public void DesequiparGrebas(Grebas grebas)
        {
            if (grebas == this.equipamiento[2])
            {
                this.defensa -= grebas.Defensa;
                this.ataque -= grebas.Daño;
                this.equipamiento[2] = 2;
            }
        }
        public void DesequiparBotas(Botas botas)
        {
            if (botas == this.equipamiento[3])
            {
                this.defensa -= botas.Defensa;
                this.ataque -= botas.Daño;
                this.equipamiento[3] = 3;
            }
        }
        public void DesequiparEspada(Espada espada)
        {
            if (espada == this.equipamiento[4])
            {
                this.ataque -= espada.Daño;
                this.defensa -= espada.Defensa;
                this.equipamiento[4] = 4;
            }
        }
        public void DesequiparArco(Arco arco)
        {
            if (arco == this.equipamiento[5])
            {
                this.defensa -= arco.Defensa;
                this.ataque -= arco.Daño;
                this.equipamiento[5] = 5;
            }
        }
        public static void CurarElfo(Elfo elfo)
        {
            elfo.SerCurado();
        }
        public static void CurarHechicero(Hechicero hechicero)
        {
            hechicero.SerCurado();
        }
        public static void CurarHumano(Humano humano)
        {
            humano.SerCurado();
        }
        public static void CurarEnano(Enano enano)
        {
            enano.SerCurado();
        }

        public void SerCurado()
        {
            this.vidaActual = this.vidaMax;
        }
        public void Defender(int dañoEntrante)
        {
            if ((dañoEntrante - this.defensa) > 0)
            {
                int dañoRecibido = dañoEntrante - this.defensa;
                this.vidaActual -= dañoRecibido;
            }
        }
    }
}