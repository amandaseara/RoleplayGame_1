using System;

namespace Roleplay
{
    public class Yelmo
    {
        public Yelmo(string nombre, string descripcion, int defensa)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Defensa = 100;
        }
        public string Nombre{get;set;}
        public string Descripcion{get; set;}
        public int Defensa{get; set;}
    }
}