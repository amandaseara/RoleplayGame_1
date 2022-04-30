using System;
using System.Collections;
using System.Collections.Generic;


namespace Roleplay
{
    public class Botas
    {
        // se utilizan atributos de ataque y de defensa en todos los items porque la letra lo pide asi
        private int daño;
        // daño de las botas
        private int defensa;
        // defensa de las botas
        public int Daño{get{return daño;}}
        // get del daño de las botas
        public int Defensa{get{return defensa;}}
        // get de la defensa de las botas
        
        public Botas(int daño, int defensa)
        {
            this.daño = daño;
            this.defensa = defensa;
        }
    }
}