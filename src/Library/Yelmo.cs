using System;

namespace Roleplay
{
    public class Yelmo
    {
        public Yelmo(string nombre, string descripcion, int defensa, string material)
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