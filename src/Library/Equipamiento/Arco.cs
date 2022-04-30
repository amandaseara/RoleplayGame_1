using System;
using System.Collections;
using System.Collections.Generic;


namespace Roleplay
{
    public class Arco
    {
        // se utilizan atributos de ataque y de defensa en todos los items porque la letra lo pide asi
        private int daño;
        // daño del arco
        private int defensa;
        // defensa del arco
        public int Daño{get{return daño;}}
        // get del daño del arco
        public int Defensa{get{return defensa;}}
        // get de la defensa del arco

        public Arco(int daño, int defensa)
        {
            this.daño = daño;
            this.defensa = defensa;
        }
    }
}