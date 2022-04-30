using System;
using System.Collections;
using System.Collections.Generic;

namespace Roleplay
{
    public class Enano
    {
        private string nombre;
        private ArrayList equipamiento;
        private int ataque = 500;
        public int Ataque { get { return ataque; } }
        private int vidaMax = 500;
        private int vidaActual = 500;
        public int VidaActual { get { return vidaActual; } }
        private int defensa = 0;
        public int Defensa { get { return defensa; } }

        public Enano(string name)
        {
            this.nombre = name;
            this.equipamiento = new ArrayList();
            int i = 0;
            while (i != 6)
            {
                this.equipamiento.Add(i);
                i++;
            }
        }

        //EQUIPAR
        public void EquiparYelmo(Yelmo yelmo)
        {
            // Si esta vacio, equipo item
            if (this.equipamiento[0].GetType() == 0.GetType())
            {
                this.equipamiento[0] = yelmo;
                this.ataque += yelmo.Daño;
                this.defensa += yelmo.Defensa;
            }
        }
        public void EquiparPechera(Pechera pechera)
        {
            // Si esta vacio, equipo item
            if (this.equipamiento[1].GetType() == 0.GetType())
            {
                this.equipamiento[1] = pechera;
                this.ataque += pechera.Daño;
                this.defensa += pechera.Defensa;
            }
        }
        public void EquiparGrebas(Grebas grebas)
        {
            // Si esta vacio, equipo item
            if (this.equipamiento[2].GetType() == 0.GetType())
            {
                this.equipamiento[2] = grebas;
                this.ataque += grebas.Daño;
                this.defensa += grebas.Defensa;
            }
        }
        public void EquiparBotas(Botas botas)
        {
            // Si esta vacio, equipo item
            if (this.equipamiento[3].GetType() == 0.GetType())
            {
                this.equipamiento[3] = botas;
                this.ataque += botas.Daño;
                this.defensa += botas.Defensa;
            }
        }
        public void EquiparEspada(Espada espada)
        {
            // Si esta vacio, equipo item
            if (this.equipamiento[4].GetType() == 0.GetType())
            {
                this.equipamiento[4] = espada;
                this.ataque += espada.Daño;
                this.defensa += espada.Defensa;
            }
        }
        public void EquiparHacha(Hacha hacha)
        {
            // Si esta vacio, equipo item
            if (this.equipamiento[5].GetType() == 0.GetType())
            {
                this.equipamiento[5] = hacha;
                this.ataque += hacha.Daño;
                this.defensa += hacha.Defensa;
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
        public void DesequiparHacha(Hacha hacha)
        {
            if (hacha == this.equipamiento[5])
            {
                this.defensa -= hacha.Defensa;
                this.ataque -= hacha.Daño;
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


        //RECIBIR ATAQUE
        public void Defender(int dañoEntrante)
        {
            if ((dañoEntrante - this.defensa) > 0)
            {
                int dañoRecibido = dañoEntrante - this.defensa;
                this.vidaActual -= dañoRecibido;
            }
        }

        //RECIBIR CURACION
        public void SerCurado()
        {
            this.vidaActual = this.vidaMax;
        }
    }
}