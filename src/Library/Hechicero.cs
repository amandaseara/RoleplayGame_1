using System.Collections;
using System.Collections.Generic;

namespace Roleplay
{
    public class Hechicero
    {
        private string nombre;
        private int vidaMax = 500;
        private int vidaActual = 500;
        private int ataquebase = 500;
        private int defensa = 500;
        private ArrayList equipo;
        private LibroDeHechizos libro;
        public Hechicero(string name)
        {
            this.nombre = name;
        }
        public void AprenderHechizo(string name, int daño, int defensa)
        {
            libro.AprenderNuevoHechizo(name,daño,defensa);
        }
        public void Defender(int dañorecivido)
        {
            this.vidaActual-=dañorecivido-defensa;
        }
        public void SerCurado()
        {
            this.vidaActual=this.vidaMax;
        }
    }
}