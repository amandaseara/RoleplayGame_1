using System;
using System.Collections;
using System.Collections.Generic;


namespace Roleplay
{
    public class Yelmo
    {
        // se utilizan atributos de ataque y de defensa en todos los items porque la letra lo pide asi
        private int daño;
        // daño del yelmo
        private int defensa;
        // defensa del yelmo
        public int Daño{get{return daño;}}
        // get del daño del yelmo
        public int Defensa{get{return defensa;}}
        // get de la defensa del yelmo

        public Yelmo(int daño, int defensa)
        {
            this.daño = daño;
            this.defensa = defensa;
        }
    }
}