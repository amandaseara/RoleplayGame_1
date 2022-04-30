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
        public void EquiparEscudo(Escudo escudo)
        {
            this.equipamiento[5] = escudo;
            this.defensa += escudo.Defensa;
        }

        //DESEQUIPAR
        public void DesequiparYelmo(Yelmo yelmo)
        {
            if (yelmo==this.equipamiento[0])
            {
                this.defensa-=yelmo.Defensa;
                this.equipamiento[0]=0;
            }
        }
        public void DesequiparPechera(Pechera pechera)
        {
            if (pechera==this.equipamiento[1])
            {
                this.defensa -= pechera.Defensa;
                this.equipamiento[1]=1;
            }
        }
        public void DesequiparGrebas(Grebas grebas)
        {
            if (grebas==this.equipamiento[2])
            {
                this.defensa-=grebas.Defensa;
                this.equipamiento[2]=2;
            }
        }
        public void DesequiparBotas(Botas botas)
        {
            if (botas==this.equipamiento[3])
            {
                this.defensa-=botas.Defensa;
                this.equipamiento[3]=3;
            }
        }
        public void DesequiparEspada(Espada espada)
        {
            if (espada==this.equipamiento[4])
            {
                this.ataque-=espada.Daño;
                this.equipamiento[4]=4;
            }
        }
        public void DesequiparEscudo(Escudo escudo)
        {
            if (escudo==this.equipamiento[5])
            {
                this.defensa-=escudo.Defensa;
                this.equipamiento[5]=5;
            }
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