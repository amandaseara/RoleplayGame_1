using System.Collections;
using System;

namespace Roleplay
{
    public static class Atacar
    {
        public static void AtaquedeHechiceroaHechicero(Hechicero atacante, Hechicero defensor)
        {
            defensor.Defender(atacante.Ataque);
        }
        public static void AtaquedeHechiceroaElfo(Hechicero atacante, Elfo defensor)
        {
            defensor.Defender(atacante.Ataque);
        }
        public static void AtaquedeHechiceroaEnano(Hechicero atacante, Enano defensor)
        {
            defensor.Defender(atacante.Ataque);
        }
        public static void AtaquedeHechiceroaHumano(Hechicero atacante, Humano defensor)
        {
            defensor.Defender(atacante.Ataque);
        }
        public static void AtaquedeElfoaElfo(Elfo atacante, Elfo defensor)
        {
            defensor.Defender(atacante.Ataque);
        }
        public static void AtaquedeElfoaEnano(Elfo atacante, Enano defensor)
        {
            defensor.Defender(atacante.Ataque);
        }
        public static void AtaquedeElfoaHechicero(Elfo atacante, Hechicero defensor)
        {
            defensor.Defender(atacante.Ataque);
        }
        public static void AtaquedeElfoaHumano(Elfo atacante, Humano defensor)
        {
            defensor.Defender(atacante.Ataque);
        }
        /// <summary>
        /// Ataque de Humanos a otras clases y a si misma
        /// </summary>
        /// <param name="atacante"></param>
        /// <param name="defensor"></param>
        public static void AtaquedeHumanoaHumano(Humano atacante, Humano defensor)
        {
            defensor.Defender(atacante.Ataque);
        }
        public static void AtaquedeHumanoaElfo(Humano atacante, Elfo defensor)
        {
            defensor.Defender(atacante.Ataque);
        }
        public static void AtaquedeHumanoaEnano(Humano atacante, Enano defensor)
        {
            defensor.Defender(atacante.Ataque);
        }
        public static void AtaquedeHumanoaHechicero(Humano atacante, Hechicero defensor)
        {
            defensor.Defender(atacante.Ataque);
        }
        public static void AtaquedeEnanoaEnano(Enano atacante, Enano defensor)
        {
            defensor.Defender(atacante.Ataque);
        }
        public static void AtaquedeEnanoaElfo(Enano atacante, Elfo defensor)
        {
            defensor.Defender(atacante.Ataque);
        }
        public static void AtaquedeEnanoaHumano(Enano atacante, Humano defensor)
        {
            defensor.Defender(atacante.Ataque);
        }
        public static void AtaquedeEnanoaHechicero(Enano atacante, Hechicero defensor)
        {
            defensor.Defender(atacante.Ataque);
        }


    }
}