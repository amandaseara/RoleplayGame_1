using System;
using System.Collections;
using System.Collections.Generic;


namespace Roleplay
{
    public class Hacha
    {
        private int daño;
        public int GetDaño()
        {
            return this.daño;
        }
        private int defensa;
        public int GetDefensa()
        {
            return this.defensa;
        }
        public Hacha()
        {
            this.daño = 100;
            this.defensa = 0;
        }
    }
}