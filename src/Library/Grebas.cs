using System;
using System.Collections;
using System.Collections.Generic;


namespace Roleplay
{
    public class Grebas
    {
        private int ataque = 0;
        private int defensa;
        public int GetDefensa()
        {
            return this.defensa;
        }
        public Grebas()
        {
            this.defensa = 100;
        }
    }
}