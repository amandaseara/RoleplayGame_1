using System;
using System.Collections;
using System.Collections.Generic;

namespace Roleplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Humano pepe = new Humano("Pepe");
            Humano pedro = new Humano("Pedro");
            Console.WriteLine(pedro.vidaBase);
            Escudo esc = new Escudo();
            pepe.EquiparEscudo(esc);
            pedro.EquiparEscudo(esc);
            pepe.AtacarHumano(pedro);
            Console.WriteLine(pedro.vidaBase);
        }
    }
}
