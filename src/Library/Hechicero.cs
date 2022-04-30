using System.Collections;
using System;

namespace Roleplay
{
    public class Hechicero
    {
        private string nombre;
        public string Nombre{get{return nombre;}}
        private int vidaMax = 500;
        private int vidaActual = 500;
        private int ataque = 500;
        private int poder = 500;
        public int Ataque {get{return ataque;}}
        private int defensa = 500;
        private ArrayList equipamiento;
        private LibroDeHechizos libro = new LibroDeHechizos();
        public Hechicero(string name)
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

        public void EquiparYelmo(Yelmo yelmo)
        {
            this.equipamiento[0] = yelmo;
            this.defensa +=yelmo.Defensa;
        }
        public void EquiparPechera(Pechera pechera)
        {
            this.equipamiento[1] = pechera;
            this.defensa +=pechera.Defensa;
        }
        public void EquiparGrebas(Grebas grebas)
        {
            this.equipamiento[2] = grebas;
            this.defensa +=grebas.Defensa;
        }
        public void EquiparBotas(Botas botas)
        {
            this.equipamiento[3] = botas;
            this.defensa +=botas.Defensa;
        }
        public void EquiparBaculo(Baculo baculo)
        {
            this.equipamiento[4] = baculo;
            this.poder +=baculo.Poder;
        }


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
                this.defensa-=pechera.Defensa;
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
        public void DesequiparBaculo(Baculo baculo)
        {
            if (baculo==this.equipamiento[4])
            {
                this.poder-=baculo.Poder;
                this.equipamiento[4]=4;
            }
        }
        public void AprenderHechizo(string name, int daño, int defensa)
        {
            libro.AprenderNuevoHechizo(name,daño,defensa);
        }
        public int UsarHechizoparaAtaque(String nombredeHechizo)
        {
            int dañoEntrante = libro.UsarHechizodeAtaque(nombredeHechizo);
            return dañoEntrante;
        }
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
        public void SerCurado()
        {
            this.vidaActual=this.vidaMax;
        }
    }
}