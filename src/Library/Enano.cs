using System;

namespace Program
{
    public class Enano
    {
        
        public Enano(string nombre, int salud, string item)
        {
            this.Nombre = nombre;
            this.Salud = 500;
            this.Item = item;
        }
    public string Nombre{get;set;}
        /*{
            get
            {
                return this.Nombre;
            }

            set
            {
                this.Nombre = value;
            }
        }*/
    public int Salud{get;set;}
       
    public string Item{get;set;}
    } 
}