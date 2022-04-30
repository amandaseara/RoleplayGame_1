using System.Collections.Generic;
namespace Roleplay
{
    public class LibroDeHechizos
    {
        private List<Hechizo> listadehechizos;
        /// <summary>
        /// En el constructor de libro de hechizos se crea la lista que contiene cada libro de hechizos
        /// junto con el hechizo inicial que se pide tener en la letra del problema
        /// </summary>
        public LibroDeHechizos()
        {
            Hechizo nuevohechizo = new Hechizo("Hechizo inicial",1000,2000);
            this.listadehechizos= new List<Hechizo>();
        }
        public int UsarHechizodeDefensa(string nombredeHechizo)
        {
            int defensa=0;
            foreach (Hechizo i in listadehechizos)
            {
                if (i.Nombre==nombredeHechizo)
                {
                    defensa= i.Defensa;
                }
            }
            return defensa;
        }
        /// <summary>
        /// Aprender nuevo hechizo se ocupa de crear un hechizo y añadirlo a la lista siempre y cuando este no exista
        /// ya que queremos que cada libro contenga un hechizo unico, ya que no nos interesa que tenga el mismo hechizo duplicado
        /// </summary>
        /// <param name="name"></param>
        /// <param name="daño"></param>
        /// <param name="defensa"></param>
        public void AprenderNuevoHechizo(string name, int daño, int defensa)
        {
            bool existe=false;
            foreach (Hechizo i in listadehechizos)
            {
                if (i.Nombre==name)
                {
                    existe=true;
                }
            }
            if (!existe)
            {
                Hechizo nuevohechizo = new Hechizo(name,daño,defensa);
                listadehechizos.Add(nuevohechizo);
            }
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