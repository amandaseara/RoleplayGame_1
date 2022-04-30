using System.Collections;
using System;

namespace Roleplay
{
    public static class AtaquesconHechizo
    {
        public static void AtaqueconHechizoaHechicero(Hechicero atacante,string nombredeHechizo, Hechicero defensor)
        {
            int dañodehechizo = atacante.UsarHechizoparaAtaque(nombredeHechizo);
                Console.WriteLine($"El hechizo seleccionado era defensivo /n");
                defensor.Defender(dañodehechizo);
        }
        public static void AtaqueconHechizoaElfo(Hechicero atacante,string nombredeHechizo, Elfo defensor)
        {
            int dañodehechizo = atacante.UsarHechizoparaAtaque(nombredeHechizo);
            defensor.Defender(dañodehechizo);
        }
        public static void AtaqueconHechizoaEnano(Hechicero atacante,string nombredeHechizo, Enano defensor)
        {
            int dañodehechizo = atacante.UsarHechizoparaAtaque(nombredeHechizo);
            defensor.Defender(dañodehechizo);
        }
        public static void AtaqueconHechizoaHumano(Hechicero atacante,string nombredeHechizo, Humano defensor)
        {
            int dañodehechizo = atacante.UsarHechizoparaAtaque(nombredeHechizo);
            defensor.Defender(dañodehechizo);
        }
        
    }
}