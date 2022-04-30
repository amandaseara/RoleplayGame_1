using System;

namespace Roleplay
{
    public class Hacha
    {
        public Hacha(string nombre, string descripcion, int dano, string material)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Dano = dano;
        }
        public string Nombre{get; set;} 
        public string Descripcion{get; set;}
        public int Dano{get; set;}
       
    }
}