using System.Collections;
using System;

namespace Roleplay
{
    public static class Curaciones
    {
        public static void Ataque(Hechicero atacante, Hechicero defensor)
        {
            defensor.Defender(atacante.Ataque);
        }    
    }
}