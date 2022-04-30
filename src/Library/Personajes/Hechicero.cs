using System.Collections;
using System;

namespace Roleplay
{
    public class Hechicero
    {
        private string nombre;
        public string Nombre{get{return nombre;}}
        private int vidaMax = 500;
        private int vidaActual = 500;
        public int VidaActual{get{return vidaActual;}}
        private int ataque = 500;
        private int poder = 500;
        public int Poder{get {return poder;}}
        public int Ataque {get{return ataque;}}
        private int defensa = 0;
        public int Defensa{get {return defensa;}}
        private ArrayList equipamiento;
        private LibroDeHechizos libro = new LibroDeHechizos();
        public Hechicero(string name)
        {
            this.nombre = name;
            this.equipamiento = new ArrayList();
            
            int i = 0;
            while (i != 6)
            {
                this.equipamiento.Add(i);
                i++;
            }
        }

        public void EquiparYelmo(Yelmo yelmo)
        {
            // Si esta vacio, equipo item
            if (this.equipamiento[0].GetType() == 0.GetType())
            {
                this.equipamiento[0] = yelmo;
                this.ataque+=yelmo.Daño;
                this.defensa += yelmo.Defensa;
            }
        }
        public void EquiparPechera(Pechera pechera)
        {
            // Si esta vacio, equipo item
            if (this.equipamiento[1].GetType() == 0.GetType())
            {
                this.equipamiento[1] = pechera;
                this.ataque+=pechera.Daño;
                this.defensa += pechera.Defensa;
            }
        }
        public void EquiparGrebas(Grebas grebas)
        {
            // Si esta vacio, equipo item
            if (this.equipamiento[2].GetType() == 0.GetType())
            {
                this.equipamiento[2] = grebas;
                this.ataque+=grebas.Daño;
                this.defensa += grebas.Defensa;
            }
        }
        public void EquiparBotas(Botas botas)
        {
            // Si esta vacio, equipo item
            if (this.equipamiento[3].GetType() == 0.GetType())
            {
                this.equipamiento[3] = botas;
                this.ataque+=botas.Daño;
                this.defensa += botas.Defensa;
            }
        }
        public void EquiparBaculo(Baculo baculo)
        {
            // Si esta vacio, equipo item
            if (this.equipamiento[4].GetType() == 0.GetType())
            {
                this.equipamiento[4] = baculo;
                this.poder +=baculo.Poder;
            }
        }


        public void DesequiparYelmo(Yelmo yelmo)
        {
            if (yelmo == this.equipamiento[0])
            {
                this.defensa -= yelmo.Defensa;
                this.ataque -= yelmo.Daño;
                this.equipamiento[0] = 0;
            }
        }
        public void DesequiparPechera(Pechera pechera)
        {
            if (pechera == this.equipamiento[1])
            {
                this.defensa -= pechera.Defensa;
                this.ataque -= pechera.Daño;
                this.equipamiento[1] = 1;
            }
        }
        public void DesequiparGrebas(Grebas grebas)
        {
            if (grebas == this.equipamiento[2])
            {
                this.defensa -= grebas.Defensa;
                this.ataque -= grebas.Daño;
                this.equipamiento[2] = 2;
            }
        }
        public void DesequiparBotas(Botas botas)
        {
            if (botas == this.equipamiento[3])
            {
                this.defensa -= botas.Defensa;
                this.ataque -= botas.Daño;
                this.equipamiento[3] = 3;
            }
        }
        public void DesequiparBaculo(Baculo baculo)
        {
            if (baculo==this.equipamiento[4])
            {
                this.poder-=baculo.Poder;
                this.equipamiento[4]=4;
            }
        }
        public void AprenderHechizo(string name, int daño, int defensa)
        {
            libro.AprenderNuevoHechizo(name,daño,defensa);
        }
        public int UsarHechizoparaAtaque(String nombredeHechizo)
        {
            int dañoSaliente = libro.UsarHechizodeAtaque(nombredeHechizo) + this.poder;
            return dañoSaliente;
        }
        public void UsarHechizoparaDefensa(String nombredeHechizo)
        {
            this.defensa += libro.UsarHechizodeDefensa(nombredeHechizo) + this.poder;
        }
        public void Defender(int dañoEntrante)
        {
            if ( (dañoEntrante-this.defensa) > 0)
            {
                int dañoRecibido = dañoEntrante-this.defensa;
                this.vidaActual-=dañoRecibido;
            }
        }
        public static void CurarElfo(Elfo elfo)
        {
            elfo.SerCurado();
        }
        public static void CurarHechicero(Hechicero hechicero)
        {
            hechicero.SerCurado();
        }
        public static void CurarHumano(Humano humano)
        {
            humano.SerCurado();
        }
        public static void CurarEnano(Enano enano)
        {
            enano.SerCurado();
        }

        public void SerCurado()
        {
            this.vidaActual=this.vidaMax;
        }
    }
}