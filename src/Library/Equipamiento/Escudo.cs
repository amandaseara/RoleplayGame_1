using System;
using System.Collections;
using System.Collections.Generic;


namespace Roleplay
{
    // El principio utilizado para el equipamiento es SRP, ya que tienen la unica responsabilidad de crearse a sí mismos.
    public class Escudo
    {
        // se utilizan atributos de ataque y de defensa en todos los items porque la letra lo pide asi
        private int daño;
        // daño del escudo
        private int defensa;
        // defensa del escudo
        public int Daño{get{return daño;}}
        // get del daño del escudo
        public int Defensa{get{return defensa;}}
        // get de la defensa del escudo

        public Escudo(int daño, int defensa)
        {
            this.daño = daño;
            this.defensa = defensa;
        }
    }
}