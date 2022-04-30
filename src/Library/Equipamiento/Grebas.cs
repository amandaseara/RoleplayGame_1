using System;
using System.Collections;
using System.Collections.Generic;


namespace Roleplay
{
    public class Grebas
    {
        // se utilizan atributos de ataque y de defensa en todos los items porque la letra lo pide asi
        private int daño;
        // daño de las grebas
        private int defensa;
        // defensa de las grebas
        public int Daño{get{return daño;}}
        // get del daño de las grebas
        public int Defensa{get{return defensa;}}
        // get de la defensa de las grebas

        public Grebas(int daño, int defensa)
        {
            this.daño = daño;
            this.defensa = defensa;
        }
    }
}