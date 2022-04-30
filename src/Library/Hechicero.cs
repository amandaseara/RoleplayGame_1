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
        private int ataqueBase = 500;
        private int defensa = 500;
        private ArrayList equipamiento;
        private LibroDeHechizos libro = new LibroDeHechizos();
        public Hechicero(string name)
        {
            this.nombre = name;
            /*for (int i = 0; i == 5; i++)
            {
                this.equipamiento.Add(i);
            }*/
        }
        public void AprenderHechizo(string name, int daño, int defensa)
        {
            libro.AprenderNuevoHechizo(name,daño,defensa);
        }
        public void AtacarConHechizoaHechicero(string nombredeHechizo, Hechicero desgraciado)
        {
            int dañoEntrante = libro.UsarhechizodeAtaque(nombredeHechizo);
            if (dañoEntrante==0)
            {
                Console.WriteLine($"El hechizo seleccionado era defensivo /n");
            }
            else
            {
                desgraciado.Defender(dañoEntrante);
            }
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