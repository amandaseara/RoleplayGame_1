using System;
using System.Collections;
using System.Collections.Generic;


namespace clases
{
    public class Elfo
    {
        private string nombre;
        private ArrayList equipamiento;
        private int ataqueBase;
        private int vidaBase;
        private int vidaMax;
        private int defensaBase;
        public Elfo(ArrayList equipamiento, int ataqueBase, int vidaBase, int defensaBase)
        {
            for (int i = 0; i == 5; i++)
            {
                this.equipamiento.Add(i);
            }
            this.equipamiento = equipamiento;
            this.ataqueBase = 500; // base attack
            this.vidaBase = 500; // base health
            this.defensaBase = 500; // base defense
        }
        public void EquiparYelmo(Yelmo yelmo)
        {
            //this.equipamiento.Add(yelmo);
            this.equipamiento[0] = yelmo;
        }
        public void EquiparPechera(Pechera pechera)
        {
            //this.equipamiento.Add(pechera);
            this.equipamiento[1] = pechera;
        }
        public void EquiparGrebas(Grebas grebas)
        {
            //this.equipamiento.Add(grebas);
            this.equipamiento[2] = grebas;
        }
        public void EquiparBotas(Botas botas)
        {
            //this.equipamiento.Add(botas);
            this.equipamiento[3] = botas;
        }
        public void EquiparEspada(Espada espada)
        {
            //this.equipamiento.Add(espada);
            this.equipamiento[4] = espada;
        }
        public void EquiparArco(Arco arco)
        {
            this.equipamiento[5] = arco;
        }

        public void DesequiparYelmo()
        {
            this.equipamiento[0] = 0;
        }
        public void DesequiparPechera()
        {
            this.equipamiento[1] = 1;
        }
        public void DesequiparGrebas()
        {
            this.equipamiento[2] = 2;
        }
        public void DesequiparBotas()
        {
            this.equipamiento[3] = 3;
        }
        public void DesequiparEspada()
        {
            this.equipamiento[4] = 4;
        }
        public void DesequiparArco()
        {
            this.equipamiento[5] = 5;
        }
        public void SerCurado()
        {
            this.vidaBase = 500;
        }
        public void CurarHechicero()
        {
            Hechicero.SerCurado();
        }
        public void CurarHumano()
        {
            Humano.SerCurado();
        }
        public void CurarEnano()
        {
            Enano.SerCurado();
        }
        public void Atacar()
        {
            int dañoTotal = this.ataqueBase;
            foreach(Espada espada in equipamiento)
            {
                int dañoEspada = espada.GetDaño();
                dañoTotal += dañoEspada;
            }
            // atacar con dañoTotal
        }
        public void Defender()
        {
            int defensaTotal = this.defensaBase;
            foreach(Yelmo yelmo in equipamiento)
            {
                int defensaYelmo = yelmo.GetDefensa();
                defensaTotal += defensaYelmo;
            }
            foreach(Pechera pechera in equipamiento)
            {
                int defensaPechera = pechera.GetDefensa();
                defensaTotal += defensaPechera;
            }
            foreach(Grebas grebas in equipamiento)
            {
                int defensaGrebas = grebas.GetDefensa();
                defensaTotal += defensaGrebas;
            }
            foreach(Botas botas in equipamiento)
            {
                int defensaBotas = botas.GetDefensa();
                defensaTotal += defensaBotas;
            }
            // recibir ataque
            // this.vidaBase = ataqueRecibido - defensaTotal
        }
    }
}