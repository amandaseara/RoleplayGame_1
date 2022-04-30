using System.Collections;
using System.Collections.Generic;

namespace Roleplay
{
    public class Hechicero
    {
        private string nombre;
        public string Nombre{get{return nombre;}}
        private int vidaMax = 500;
        private int vidaActual = 500;
        private int ataqueBase = 500;
        private int defensa = 500;
        private ArrayList equipamiento;
        private LibroDeHechizos libro;
        public Hechicero(string name)
        {
            this.nombre = name;
            for (int i = 0; i == 5; i++)
            {
                this.equipamiento.Add(i);
            }
        }
        public void AprenderHechizo(string name, int daño, int defensa)
        {
            libro.AprenderNuevoHechizo(name,daño,defensa);
        }
        public void Defender(int dañorecivido)
        {
            this.vidaActual-=dañorecivido-this.defensa;
        }
        public void SerCurado()
        {
            this.vidaActual=this.vidaMax;
        }

    }
}