using System;
using System.Collections;
using System.Collections.Generic;


namespace Roleplay
{
     public class Espada
    {
        // se utilizan atributos de ataque y de defensa en todos los items porque la letra lo pide asi
        private int daño;
        // daño de la espada
        private int defensa;
        // defensa de la espada
        public int Daño{get{return daño;}}
        // get del daño de la espada
        public int Defensa{get{return defensa;}}
        // get de la defensa de la espada

        public Espada(int daño, int defensa)
        {
            this.daño = daño;
            this.defensa = defensa;
        }
    }
}