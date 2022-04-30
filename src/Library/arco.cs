using System;
using System.Collections;
using System.Collections.Generic;


namespace clases
{
    public class Arco
    {
        private int daño;
        public int GetDaño()
        {
            return this.daño;
        }
        public Arco(int daño)
        {
            this.daño = 100;
        }
    }
}