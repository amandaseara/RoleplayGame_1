using System;
using System.Collections;
using System.Collections.Generic;


namespace clases
{
    public class Espada
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
        public Espada()
        {
            this.daño = 100;
            this.defensa = 0;
        }

    }
}