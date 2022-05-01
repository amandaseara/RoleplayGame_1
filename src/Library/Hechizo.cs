using System.Collections;
namespace Roleplay
{
    public class Hechizo
    {

        // se utilizan atributos de ataque y de defensa en todos los items porque pueden ser hechizos tanto de potenciacion de ataques como de potenciacion de defensa
        public string nombre;
        // nombre del hechizo
        public string Nombre{get{return nombre;}}
        // get del nombre del hechizo
        public int daño;
        // daño brindado por el hechizo
        public int Daño{get{return daño;}}
        // get del daño brindado por el hechizo
        public int defensa;
        // defensa brindada por el hechizo
        public int Defensa{get{return defensa;}}
        // get de la defensa brindada por el hechizo

        public Hechizo(string nombre, int daño, int defensa)
        {
            this.nombre = nombre;
            this.daño = daño;
            this.defensa = defensa;
        }
    }
}