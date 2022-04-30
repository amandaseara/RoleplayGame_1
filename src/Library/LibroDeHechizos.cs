using System.Collections.Generic;
namespace Roleplay
{
    public class LibroDeHechizos
    {
        public List<Hechizo> Listadehechisos;
        public void AprenderNuevoHechizo(string name, int daño, int defensa)
        {
            Hechizo nuevohechizo = new Hechizo(name,daño,defensa);
            Listadehechisos.Add(nuevohechizo);
        }
    }
}