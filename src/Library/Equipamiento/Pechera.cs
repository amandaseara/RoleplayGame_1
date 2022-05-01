using System;
using System.Collections;
using System.Collections.Generic;


namespace Roleplay
{
    // El principio utilizado para el equipamiento es SRP, ya que tienen la unica responsabilidad de crearse a sí mismos.
    public class Pechera
    {
        // se utilizan atributos de ataque y de defensa en todos los items porque la letra lo pide asi
        private int daño;
        // daño de la pechera
        private int defensa;
        // defensa de la pechera
        public int Daño{get{return daño;}}
        // get del daño de la pechera
        public int Defensa{get{return defensa;}}
        // get de la defensa de la pechera

        public Pechera(int daño, int defensa)
        {
            this.daño = daño;
            this.defensa = defensa;
        }
    }
}