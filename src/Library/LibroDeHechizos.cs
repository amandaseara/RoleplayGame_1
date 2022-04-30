using System.Collections.Generic;
namespace Roleplay
{
    public class LibroDeHechizos
    {
        private List<Hechizo> listadehechizos = new List<Hechizo>();
        
        public void AprenderNuevoHechizo(string name, int daño, int defensa)
        {
            Hechizo nuevohechizo = new Hechizo(name,daño,defensa);
            listadehechizos.Add(nuevohechizo);
        }
        public int UsarHechizodeAtaque(string nombredeHechizo)
        {
            int daño = 0;
            foreach (Hechizo i in listadehechizos)
            {
                if (i.Nombre==nombredeHechizo)
                {
                    daño= i.daño;
                }
            }
            return daño;
        }
    }
}