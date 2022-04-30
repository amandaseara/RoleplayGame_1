using System;
using System.Collections;
using System.Collections.Generic;

namespace Roleplay
{
    public class Enano
    {
        private string nombre;
        private ArrayList equipamiento;
        private int ataqueBase = 500;
        private int vidaMax = 500;
        public int vidaBase = 500;
        private int defensaBase = 0;

        public Enano(string nombre)
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
            foreach (int posicion in equipamiento)
            {
                if (posicion == 0)
                {
                    equipamiento[posicion] = yelmo;
                }
            }
            this.defensaBase = this.defensaBase + yelmo.getDefensa();
        }
        public void EquiparPechera(Pechera pechera)
        {
            foreach (int posicion in equipamiento)
            {
                if (posicion == 1)
                {
                    equipamiento[posicion] = pechera;
                }
            }
            this.defensaBase = this.defensaBase + pechera.Defensa;
        }
        public void EquiparGrebas(Grebas grebas)
        {
            foreach (int posicion in equipamiento)
            {
                if (posicion == 2)
                {
                    equipamiento[posicion] = grebas;
                }
            }
            this.defensaBase = this.defensaBase + grebas.Defensa;
        }
        public void EquiparBotas(Botas botas)
        {
            foreach (int posicion in equipamiento)
            {
                if (posicion == 3)
                {
                    equipamiento[posicion] = botas;
                }
            }
            this.defensaBase = this.defensaBase + botas.Defensa;
        }
        public void EquiparEspada(Espada espada)
        {
            foreach (int posicion in equipamiento)
            {
                if (posicion == 4)
                {
                    equipamiento[posicion] = espada;
                }
            }
            this.defensaBase = this.defensaBase + espada.Defensa;
        }
        public void EquiparEscudo(Escudo escudo)
        {
            foreach (int posicion in equipamiento)
            {
                if (posicion == 5)
                {
                    equipamiento[posicion] = escudo;
                }
            }
            this.defensaBase = this.defensaBase + escudo.Defensa;
        }

        //DESEQUIPAR
        public void DesequiparYelmo(Yelmo yelmo)
        {
            foreach (Yelmo yelmo in equipamiento)
            {
                yelmo = 0;
            }
            this.defensaBase = this.defensaBase - yelmo.Defensa;
        }
        public void DesequiparPechera(Pechera pechera)
        {
            foreach (Pechera pechera in equipamiento)
            {
                pechera = 1;
            }
            this.defensaBase = this.defensaBase - pechera.Defensa;
        }
        public void DesequiparGrebas(Grebas grebas)
        {
            foreach (Grebas grebas in equipamiento)
            {
                grebas = 2;
            }
            this.defensaBase = this.defensaBase - grebas.Defensa;
        }
        public void DesequiparBotas(Botas botas)
        {
            foreach (Botas botas in equipamiento)
            {
                botas = 3;
            }
            this.defensaBase = this.defensaBase - botas.Defensa;
        }
        public void DesequiparEspada(Espada espada)
        {
            foreach (Espada espada in equipamiento)
            {
                espada = 4;
            }
            this.defensaBase = this.defensaBase - espada.Defensa;
        }
        public void DesequiparEscudo(Escudo escudo)
        {
            foreach (Escudo escudo in equipamiento)
            {
                escudo = 5;
            }
            this.defensaBase = this.defensaBase - escudo.Defensa;
        }

        //ATAQUES
        public void AtacarHechicero(Hechicero hechicero)
        {
            int dañoTotal = this.ataqueBase;
            foreach (Espada espada in equipamiento)
            {
                dañoTotal = dañoTotal + espada.Daño();
            }

            hechicero.defender(dañoTotal);
        }
        public void AtacarElfo(Elfo elfo)
        {
            int dañoTotal = this.ataqueBase;
            foreach (Espada espada in equipamiento)
            {
                dañoTotal = dañoTotal + espada.Daño();
            }

            elfo.defender(dañoTotal);
        }
        public void AtacarEnano(Enano enano)
        {
            int dañoTotal = this.ataqueBase;
            foreach (Espada espada in equipamiento)
            {
                dañoTotal = dañoTotal + espada.Daño();
            }

            enano.defender(dañoTotal);
        }
        public void AtacarHumano(Humano humano)
        {
            int dañoTotal = this.ataqueBase;
            foreach (Espada espada in equipamiento)
            {
                dañoTotal = dañoTotal + espada.Daño;
            }

            humano.defender(dañoTotal);
        }



        //RECIBIR ATAQUE
        public void defender(int dañoEntrante)
        {
            if ((dañoEntrante - this.defensaBase) > 0)
            {
                int dañoRecibido = dañoEntrante - this.defensaBase;
                this.vidaBase -= dañoRecibido;
                Console.WriteLine($"{this.nombre} recibio {dañoRecibido} pts de daño y su nueva vida es {vidaBase}");
            }
            else
            {
                Console.WriteLine("Ataque Repelido");
            }
        }

        //RECIBIR CURACION
        public void SerCurado()
        {
            this.vidaBase = this.vidaMax;
        }
    }
}