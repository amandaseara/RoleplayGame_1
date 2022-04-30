using System;
using System.Collections;
using System.Collections.Generic;


namespace Roleplay
{
    public class Hacha
    {
        // se utilizan atributos de ataque y de defensa en todos los items porque la letra lo pide asi
        private int daño;
        // daño del hacha
        private int defensa;
        // defensa del hacha
        public int Daño{get{return daño;}}
        // get del daño del hacha
        public int Defensa{get{return defensa;}}
        // get de la defensa del hacha

        public Hacha(int daño, int defensa)
        {
            this.daño = daño;
            this.defensa = defensa;
        }
    }
}