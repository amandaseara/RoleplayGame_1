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
        private int ataqueBase = 500;
        // ataque base del elfo, a este ataque se le suman todas las bonificaciones de daño, proveniente de todas las fuentes, a la hora de atacar (por ejemplo un item (arma por ejemplo) o un hechizo. Si el elfo tiene un arco equipado, se le suma el ataque del arco al ataque base). Este atributo se crea para diferenciar el daño del personaje con el daño proveniente de otras fuentes (como un arma, o un posible hechizo que potencie el daño), porque si se acumulan bonificaciones en una sola variable, no se sabe de donde proviene el daño (por ejemplo, si aparece que el daño es 60, no se sabe cual es el daño del arma y cual es el daño del personaje, pero si aparece (500)+100, se sabe que el daño del personaje es 500 y el daño del arma es 100. Esto sirve por ejemplo a la hora de elegir que arma usar, ya que se pueden hacer calculos de forma mas sencilla)
        private int vidaBase = 500;
        // vida base del elfo, a esta vida se le suman todas las bonificaciones de salud, proveniente de todas las fuentes, a la hora de defender (por ejemplo un item (armadura por ejemplo) o un hechizo. Si el elfo tiene un yelmo equipado, se le suma la vida del yelmo a la vida base). Este atributo se crea por la misma razon que el daño base.
        private int vidaMax = 500;
        // vida maxima del elfo, este atributo se crea para saber cuanta vida debe curar el elfo, ya que la curacion se define como recuperar la vida
        private int defensaBase = 500;
        // defensa base del elfo, a esta defensa se le suman todas las bonificaciones de defensa, proveniente de todas las fuentes, a la hora de defender (por ejemplo un item o un hechizo (un posible hechizo que potencie defensa por ejemplo). Si al elfo lo llegaran a potenciar con un hechizo por ejemplo, se le suma la defensa del hechizo a la defensa base). Este atributo se crea por la misma razon que el daño base.
        public Elfo(string nombre, ArrayList equipamiento)
        {
            this.nombre = nombre;
            this.equipamiento = new ArrayList();
            for (int i = 0; i == 6; i++)
            {
                this.equipamiento.Add(i);
            }
        }
        public void EquiparYelmo(Yelmo yelmo)
        {
            //this.equipamiento.Add(yelmo);
            foreach (int posicion in equipamiento)
                if (posicion == 0)
                    equipamiento[posicion] = yelmo;
            this.defensaBase += yelmo.Defensa;
        }
        public void EquiparPechera(Pechera pechera)
        {
            //this.equipamiento.Add(pechera);
            foreach (int posicion in equipamiento)
                if (posicion == 1)
                    equipamiento[posicion] = pechera;
            this.defensaBase += pechera.Defensa;
        }
        public void EquiparGrebas(Grebas grebas)
        {
            //this.equipamiento.Add(grebas);
            foreach (int posicion in equipamiento)
                if (posicion == 2)
                    equipamiento[posicion] = grebas;
            this.defensaBase += + grebas.Defensa;
        }
        public void EquiparBotas(Botas botas)
        {
            //this.equipamiento.Add(botas);
            foreach (int posicion in equipamiento)
                if (posicion == 3)
                    equipamiento[posicion] = botas;
            this.defensaBase += botas.Defensa;
        }
        public void EquiparEspada(Espada espada)
        {
            //this.equipamiento.Add(espada);
            foreach (int posicion in equipamiento)
                if (posicion == 4)
                    equipamiento[posicion] = espada;
            this.defensaBase += espada.Defensa;
        }
        public void EquiparArco(Arco arco)
        {
            foreach (int posicion in equipamiento)
                if (posicion == 5)
                    equipamiento[posicion] = arco;
            this.defensaBase += arco.Defensa;
        }

        public void DesequiparYelmo()
        {
            foreach (Yelmo yelmo in equipamiento)
                equipamiento[yelmo] = 0;
            this.defensaBase -= yelmo.Defensa;
        }
        public void DesequiparPechera()
        {
            foreach (Pechera pechera in equipamiento)
                equipamiento[pechera] = 1;
            this.defensaBase -= pechera.Defensa;
        }
        public void DesequiparGrebas()
        {
            foreach (Grebas grebas in equipamiento)
                equipamiento[grebas] = 2;
            this.defensaBase -= grebas.Defensa;
        }
        public void DesequiparBotas()
        {
            foreach (Botas botas in equipamiento)
                equipamiento[botas] = 3;
            this.defensaBase -= botas.Defensa;
        }
        public void DesequiparEspada()
        {
            foreach (Espada espada in equipamiento)
                equipamiento[espada] = 4;
            this.defensaBase -= espada.Defensa;
        }
        public void DesequiparArco()
        {
            foreach (Arco arco in equipamiento)
                equipamiento[arco] = 5;
            this.defensaBase -= arco.Defensa;
        }
        public void SerCurado()
        {
            this.vidaBase = 500;
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
            int dañoTotal = this.ataqueBase;
            foreach(Espada espada in equipamiento)
            {
                int dañoEspada = espada.GetDaño();
                dañoTotal += dañoEspada;
            }
            Hechicero.defender(dañoTotal);
        }
        public void AtacarHumano()
        {
            int dañoTotal = this.ataqueBase;
            foreach(Espada espada in equipamiento)
            {
                int dañoEspada = espada.GetDaño();
                dañoTotal += dañoEspada;
            }
            Humano.defender(dañoTotal);
        }
        public void AtacarEnano()
        {
            int dañoTotal = this.ataqueBase;
            foreach(Espada espada in equipamiento)
            {
                int dañoEspada = espada.GetDaño();
                dañoTotal += dañoEspada;
            }
            Enano.defender(dañoTotal);
        }
        public void AtacarElfo()
        {
            int dañoTotal = this.ataqueBase;
            foreach(Espada espada in equipamiento)
            {
                int dañoEspada = espada.GetDaño();
                dañoTotal += dañoEspada;
            }
            this.Defender(dañoTotal);
        }
        public void Defender(int ataqueRecibido)
        {
            int defensaTotal = this.defensaBase;
            foreach(Yelmo yelmo in equipamiento)
            {
                int defensaYelmo = yelmo.GetDefensa();
                defensaTotal += defensaYelmo;
            }
            foreach(Pechera pechera in equipamiento)
            {
                int defensaPechera = pechera.GetDefensa();
                defensaTotal += defensaPechera;
            }
            foreach(Grebas grebas in equipamiento)
            {
                int defensaGrebas = grebas.GetDefensa();
                defensaTotal += defensaGrebas;
            }
            foreach(Botas botas in equipamiento)
            {
                int defensaBotas = botas.GetDefensa();
                defensaTotal += defensaBotas;
            }
            this.vidaBase = vidaBase - ataqueRecibido - defensaTotal;
        }
    }
}