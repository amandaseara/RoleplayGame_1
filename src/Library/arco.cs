using System;
using System.Collections;
using System.Collections.Generic;


namespace Roleplay
{
    public class Arco
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
        public Arco()
        {
            this.daño = 100;
            this.defensa = 0;
        }
    }
}