using System.Collections;
using System;

namespace Roleplay
{
    public static class AtaquesconHechizo
    {
        public static void AtaqueconHechizo(Hechicero atacante,string nombredeHechizo, Hechicero defensor)
        {
            int dañodehechizo = atacante.UsarHechizoparaAtaque(nombredeHechizo);
            if (dañodehechizo==0)
            {
                Console.WriteLine($"El hechizo seleccionado era defensivo /n");
            }
            else
            {
                defensor.Defender(dañodehechizo);
            }
        }
        
    }
}