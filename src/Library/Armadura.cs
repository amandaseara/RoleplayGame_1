using System;

namespace Program
{
    public class Armadura
    {
        public Armadura(string nombre, string descripcion, int defensa, string material)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Defensa = defensa;
            this.Material = material;
        }
        public string Nombre{get;set;}
       
        public string Descripcion
        {
            get
            {
                return this.Descripcion;
            }

            set
            {
                this.Descripcion = value;
            }
        }
        public int Defensa
        {
            get
            {
                return this.Defensa;
            }

            set
            {
                this.Defensa = value;
            }
        }
         public string Material
        {
            get
            {
                return this.Material;
            }

            set
            {
                this.Material = value;
            }
        } 
    }
}