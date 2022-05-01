using System.Collections;
using System;

namespace Roleplay
{
    // El principio utilizado para los ataques con hechizos es SRP, ya que tienen la unica responsabilidad de realizar el ataque.
    public static class AtaquesconHechizo
    {
        // En esta clase se realizan los ataques con hechizos
        public static void AtaqueaHechicero(Hechicero atacante,string nombredeHechizo, Hechicero defensor)
        {
            int dañodehechizo = atacante.UsarHechizoparaAtaque(nombredeHechizo);
            defensor.Defender(dañodehechizo);
        }
        public static void AtaqueaElfo(Hechicero atacante,string nombredeHechizo, Elfo defensor)
        {
            int dañodehechizo = atacante.UsarHechizoparaAtaque(nombredeHechizo);
            defensor.Defender(dañodehechizo);
        }
        public static void AtaqueaEnano(Hechicero atacante,string nombredeHechizo, Enano defensor)
        {
            int dañodehechizo = atacante.UsarHechizoparaAtaque(nombredeHechizo);
            defensor.Defender(dañodehechizo);
        }
        public static void AtaqueaHumano(Hechicero atacante,string nombredeHechizo, Humano defensor)
        {
            int dañodehechizo = atacante.UsarHechizoparaAtaque(nombredeHechizo);
            defensor.Defender(dañodehechizo);
        }
        
    }
}