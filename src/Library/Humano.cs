using System;
using System.Collections;
using System.Collections.Generic;

namespace Roleplay
{
    public class Humano
    {
        private string nombre;
        private ArrayList equipamiento;
        private int ataqueBase = 500;
        private int vidaMax = 500;
        private int vidaBase = 500;
        private int defensaBase = 500;

        public Humano(string nombre, ArrayList equipamiento)
        {
            this.nombre = nombre;

            for (int i = 0; i == 5; i++)
            {
                this.equipamiento.Add(i);
            }
            this.equipamiento = equipamiento;
        }

        //EQUIPAR
        public void EquiparYelmo(Yelmo yelmo)
        {
            this.equipamiento[0] = yelmo;
        }
        public void EquiparPechera(Pechera pechera)
        {
            this.equipamiento[1] = pechera;
        }
        public void EquiparGrebas(Grebas grebas)
        {
            this.equipamiento[2] = grebas;
        }
        public void EquiparBotas(Botas botas)
        {
            this.equipamiento[3] = botas;
        }
        public void EquiparEspada(Espada espada)
        {
            this.equipamiento[4] = espada;
        }
        public void EquiparEscudo(Escudo escudo)
        {
            this.equipamiento[5] = escudo;
        }

        //DESEQUIPAR
        public void DesequiparYelmo()
        {
            this.equipamiento[0] = 0;
        }
        public void DesequiparPechera()
        {
            this.equipamiento[1] = 1;
        }
        public void DesequiparGrebas()
        {
            this.equipamiento[2] = 2;
        }
        public void DesequiparBotas()
        {
            this.equipamiento[3] = 3;
        }
        public void DesequiparEspada()
        {
            this.equipamiento[4] = 4;
        }
        public void DesequiparEscudo()
        {
            this.equipamiento[5] = 5;
        }

        //ATAQUES
        public void AtacarHechicero(Hechicero hechicero)
        {
            int dañoTotal;
            foreach(Espada espada in equipamiento)
            {
                int dañoEspada = espada.GetDaño();
            }
            dañoTotal = this.ataqueBase + dañoEspada;

            hechicero.defender(dañoTotal); 
        }
        public void AtacarElfo(Elfo elfo)
        {
            int dañoTotal;
            foreach(Espada espada in equipamiento)
            {
                int dañoEspada = espada.GetDaño();
            }
            dañoTotal = this.ataqueBase + dañoEspada;

            elfo.defender(dañoTotal); 
        }
        public void AtacarEnano(Enano enano)
        {
            int dañoTotal;
            foreach(Espada espada in equipamiento)
            {
                int dañoEspada = espada.GetDaño();
            }
            dañoTotal = this.ataqueBase + dañoEspada;

            Enano.defender(dañoTotal); 
        }
        public void AtacarHumano(Humano humano)
        {
            int dañoTotal;
            foreach(Espada espada in equipamiento)
            {
                int dañoEspada = espada.GetDaño();
            }
            dañoTotal = this.ataqueBase + dañoEspada;

            Enano.defender(dañoTotal); 
        }

        //RECIBIR ATAQUE
        public void defender(int daño)
        {
            int defensaTotal = this.defensaBase;
            foreach(Yelmo yelmo in equipamiento)
            {
                int defensaYelmo = yelmo.GetDefensa();
                defensaTotal = defensaTotal + defensaYelmo;
            }
            foreach(Pechera pechera in equipamiento)
            {
                int defensaPechera = pechera.GetDefensa();
                defensaTotal = defensaTotal + defensaPechera;
            }
            foreach(Grebas grebas in equipamiento)
            {
                int defensaGrebas = grebas.GetDefensa();
                defensaTotal = defensaTotal + defensaGrebas;
            }
            foreach(Botas botas in equipamiento)
            {
                int defensaBotas = botas.GetDefensa();
                defensaTotal = defensaTotal + defensaBotas;
            }

            this.vidaBase = vidaBase - (daño - defensaTotal);
        }

        //RECIBIR CURACION
        public void SerCurado()
        {
            this.vidaBase = this.vidaMax;
        }
    }
}