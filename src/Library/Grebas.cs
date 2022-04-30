using System;

namespace Roleplay
{
    public class Grebas
    {
        public Grebas(string nombre, string descripcion, int defensa)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Defensa = defensa;
        }
        public string Nombre{get;set;}
        public string Descripcion{get; set;}
        public int Defensa{get; set;}
    }
}