using System.Collections;
namespace Roleplay
{
    public class Hechizo
    {
        public string Nombre{get;}
        public int Daño{get;}
        public int Defensa{get;}
        public Hechizo(string nombre, int daño, int defensa)
        {
            this.Nombre = nombre;
            this.Daño = daño;
            this.Defensa = defensa;
        }
    }
}