using System.Collections.Generic;
namespace Roleplay
{
    public class LibroDeHechizos
    {
        private List<Hechizo> listadehechizos;
        public void AprenderNuevoHechizo(string name, int daño, int defensa)
        {
            Hechizo nuevohechizo = new Hechizo(name,daño,defensa);
            listadehechizos.Add(nuevohechizo);
        }
    }
}