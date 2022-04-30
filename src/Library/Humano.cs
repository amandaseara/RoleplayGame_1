using System;
using System.Collections;
using System.Collections.Generic;

namespace Roleplay
{
    public class Humano
    {
        private string nombre;
        private ArrayList equipamiento;
        private int ataque = 500;
        private int vidaMax = 500;
        public int vidaActual = 500;
        private int defensa = 0;

        public Humano(string nombre)
        {
            this.nombre = nombre;

            this.equipamiento = new ArrayList();
            for (int i = 0; i == 6; i++)
            {
                this.equipamiento.Add(i);
            }
        }

        //EQUIPAR
        public void EquiparYelmo(Yelmo yelmo)
        {
            foreach(int posicion in equipamiento)
            {
                if (posicion == 0)
                {
                    equipamiento[posicion] = yelmo;
                }
            }
            this.defensa = this.defensa + yelmo.Defensa;
        }
        public void EquiparPechera(Pechera pechera)
        {
            foreach(int posicion in equipamiento)
            {
                if (posicion == 1)
                {
                    equipamiento[posicion] = pechera;
                }
            }
            this.defensa = this.defensa + pechera.Defensa;
        }
        public void EquiparGrebas(Grebas grebas)
        {
            foreach(int posicion in equipamiento)
            {
                if (posicion == 2)
                {
                    equipamiento[posicion] = grebas;
                }
            }
            this.defensa = this.defensa + grebas.Defensa;
        }
        public void EquiparBotas(Botas botas)
        {
            foreach(int posicion in equipamiento)
            {
                if (posicion == 3)
                {
                    equipamiento[posicion] = botas;
                }
            }
            this.defensa = this.defensa + botas.Defensa;
        }
        public void EquiparEspada(Espada espada)
        {
            foreach(int posicion in equipamiento)
            {
                if (posicion == 4)
                {
                    equipamiento[posicion] = espada;
                }
            }
            this.defensa = this.defensa + espada.Defensa;
        }
        public void EquiparEscudo(Escudo escudo)
        {
            foreach(int posicion in equipamiento)
            {
                if (posicion == 5)
                {
                    equipamiento[posicion] = escudo;
                }
            }
            this.defensa = this.defensa + escudo.Defensa;
        }

        //DESEQUIPAR
        public void DesequiparYelmo(Yelmo yelmo)
        {
            foreach(Yelmo y in equipamiento)
            {
                equipamiento[yelmo] = 0;
            }
            this.defensa = this.defensa - yelmo.Defensa;
        }
        public void DesequiparPechera(Pechera pechera)
        {
            foreach(Pechera pechera in equipamiento)
            {
                equipamiento[pechera] = 1;
            }
            this.defensa = this.defensa - pechera.Defensa;
        }
        public void DesequiparGrebas(Grebas grebas)
        {
            foreach(Grebas grebas in equipamiento)
            {
                equipamiento[grebas] = 2;
            }
            this.defensa = this.defensa - grebas.Defensa;
        }
        public void DesequiparBotas(Botas botas)
        {
            foreach(Botas botas in equipamiento)
            {
                equipamiento[botas] = 3;
            }
            this.defensa = this.defensa - botas.Defensa;
        }
        public void DesequiparEspada(Espada espada)
        {
            foreach(Espada espada in equipamiento)
            {
                equipamiento[espada] = 4;
            }
            this.defensa = this.defensa - espada.Defensa;
        }
        public void DesequiparEscudo(Escudo escudo)
        {
            foreach(Escudo escudo in equipamiento)
            {
                equipamiento[escudo] = 5;
            }
            this.defensa = this.defensa - escudo.Defensa;
        }

        //ATAQUES
        public void AtacarHechicero(Hechicero hechicero)
        {
            int dañoTotal = this.ataque;
            foreach(Espada espada in equipamiento)
            {
                dañoTotal = dañoTotal + espada.Daño;
            }

            hechicero.Defender(dañoTotal); 
        }
        public void AtacarElfo(Elfo elfo)
        {
            int dañoTotal = this.ataque;
            foreach(Espada espada in equipamiento)
            {
                dañoTotal = dañoTotal + espada.Daño;
            }

            elfo.Defender(dañoTotal); 
        }
        public void AtacarEnano(Enano enano)
        {
            int dañoTotal = this.ataque;
            foreach(Espada espada in equipamiento)
            {
                dañoTotal = dañoTotal + espada.Daño;
            }

            enano.Defender(dañoTotal); 
        }
        public void AtacarHumano(Humano humano)
        {
            int dañoTotal = this.ataque;
            foreach(Espada espada in equipamiento)
            {
                dañoTotal = dañoTotal + espada.Daño;
            }

            humano.Defender(dañoTotal); 
        }



        //RECIBIR ATAQUE
        public void Defender(int dañoEntrante)
        {
            if ( (dañoEntrante-this.defensa) > 0)
            {
                int dañoRecibido = dañoEntrante-this.defensa;
                this.vidaActual-=dañoRecibido;
                Console.WriteLine($"{this.nombre} recibio {dañoRecibido} pts de daño y su nueva vida es {vidaActual}");
            }
            else
            {
                Console.WriteLine("Ataque Repelido");
            }
        }

        //RECIBIR CURACION
        public void SerCurado()
        {
            this.vidaActual = this.vidaMax;
        }
    }
}