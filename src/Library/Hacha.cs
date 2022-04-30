using System;

namespace Roleplay
{
    public class Hacha
    {
        public Hacha(string nombre, string descripcion, int dano,int defensa)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Dano = 100;
            this.Defensa = 100;

        }
        public string Nombre{get; set;} 
        public string Descripcion{get; set;}
        public int Dano{get; set;}
        public int Defensa{get; set;}
       
    }
}