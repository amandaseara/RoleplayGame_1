using System;
using System.Collections;
using System.Collections.Generic;


namespace Roleplay
{
    public class Escudo
    {
        private int daño;
        private int defensa;
        public int Daño{get{return daño;}}
        public int Defensa{get{return defensa;}}

        public Escudo(int daño, int defensa)
        {
            this.daño = daño;
            this.defensa = defensa;
        }
    }
}