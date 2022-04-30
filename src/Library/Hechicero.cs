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
            this.defensa += yelmo.Defensa;
        }
        public void EquiparPechera(Pechera pechera)
        {
            //this.equipamiento.Add(pechera);
            foreach (int posicion in equipamiento)
                if (posicion == 1)
                    equipamiento[posicion] = pechera;
            this.defensa += pechera.Defensa;
        }
        public void EquiparGrebas(Grebas grebas)
        {
            //this.equipamiento.Add(grebas);
            foreach (int posicion in equipamiento)
                if (posicion == 2)
                    equipamiento[posicion] = grebas;
            this.defensa += + grebas.Defensa;
        }
        public void EquiparBotas(Botas botas)
        {
            //this.equipamiento.Add(botas);
            foreach (int posicion in equipamiento)
                if (posicion == 3)
                    equipamiento[posicion] = botas;
            this.defensa += botas.Defensa;
        }
        public void EquiparEspada(Espada espada)
        {
            //this.equipamiento.Add(espada);
            foreach (int posicion in equipamiento)
                if (posicion == 4)
                    equipamiento[posicion] = espada;
            this.defensa += espada.Defensa;
        }
        public void EquiparArco(Arco arco)
        {
            foreach (int posicion in equipamiento)
                if (posicion == 5)
                    equipamiento[posicion] = arco;
            this.defensa += arco.Defensa;
        }

        public void DesequiparYelmo()
        {
            int i = 0;
            int defensaYelmo = 0;
            foreach (Yelmo yelmo in equipamiento)
            {
                i++;
                if (i == 0)
                {
                    equipamiento[i] = 0;
                    defensaYelmo = yelmo.getDefensa();
                }
            }
            this.defensa -= defensaYelmo;
        }
        public void DesequiparPechera()
        {
            int i = 0;
            int defensaPechera = 0;
            foreach (Pechera pechera in equipamiento)
            {
                i++;
                if (i == 1)
                {
                    equipamiento[i] = 1;
                    defensaPechera = pechera.GetDefensa();
                }
            }
            this.defensa -= defensaPechera;
        }
        public void DesequiparGrebas()
        {
            int i = 0;
            int defensaGrebas = 0;
            foreach (Grebas grebas in equipamiento)
            {
                i++;
                if (i == 2)
                {
                    equipamiento[i] = 2;
                    defensaGrebas = grebas.GetDefensa();
                }
            }
            this.defensa -= defensaGrebas;
        }
        public void DesequiparBotas()
        {
            int i = 0;
            int defensaBotas = 0;
            foreach (Botas botas in equipamiento)
            {
                i++;
                if (i == 3)
                {
                    equipamiento[i] = 3;
                    defensaBotas = botas.Defensa;
                }
            }
            this.defensa -= defensaBotas;
        }
        public void DesequiparBaculo()
        {
            int i = 0;
            foreach (Baculo baculo in equipamiento)
            {
                i++;
                if (i == 4)
                {
                    equipamiento[i] = 4;
                }
            }
        }
        public void DesequiparLibro()
        {
            int i = 0;
            foreach (Arco arco in equipamiento)
            {
                i++;
                if (i == 5)
                    equipamiento[i] = 5;
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
        public void EquiparBaculo(Baculo baculo)
        {   
            foreach (int posicion in equipamiento)
                if (posicion == 6)
                    equipamiento[posicion] = baculo;
            this.poder += baculo.Poder;  
        }
        public void RemoverBaculo(Baculo baculo)
        {
            int i = 0;
            foreach (Baculo item in equipamiento)
            {
                i++;
                if (i == 6)
                    equipamiento[i] = 6;
            }
            this.poder -= baculo.Poder;      
        }
    }
}