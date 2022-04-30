using System.Collections;
namespace Roleplay
{
    public class Hechizo
    {

        public string nombre;
        public string Nombre{get{return nombre;}}
        public int daño;  
        public int Daño{get{return daño;}}
        public int defensa;
        public int Defensa{get{return defensa;}}
        public Hechizo(string nombre, int daño, int defensa)
        {
            this.nombre = nombre;
            this.daño = daño;
            this.defensa = defensa;
        }
    }
}