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
            for (int i = 0; i == 10; i++)
            {
                this.equipamiento.Add(i);
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
            this.equipamiento.Insert(6,baculo);
            this.poder += baculo.Poder;  
        }
        public void RemoverBaculo(Baculo baculo)
        {
            this.poder -= baculo.Poder;      
        }


    }
}