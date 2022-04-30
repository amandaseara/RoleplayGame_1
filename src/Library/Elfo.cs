using System;
using System.Collections;
using System.Collections.Generic;


namespace clases
{
    public class Elfo
    {
        private ArrayList equipamiento;
        private int ataqueBase;
        private int vidaBase;
        private int defensaBase;
        private int curacionBase;

        public ArrayList GetEquipamiento()
        {
            return this.equipamiento;
        }

        public int GetAtaqueBase()
        {
            return this.ataqueBase;
        }
        public int GetVidaBase()
        {
            return this.vidaBase;
        }
        public int GetDefensaBase()
        {
            return this.defensaBase;
        }
        public int GetCuracionBase()
        {
            return this.curacionBase;
        }
        public Elfo(ArrayList equipamiento, int ataqueBase, int vidaBase, int defensaBase, int curacionBase)
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
        public void EquiparArma2(Arma2 arma2)
        {
            this.equipamiento[5] = arma2;
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
        public void DesequiparArma2()
        {
            this.equipamiento[5] = 5;
        }
        public void Curar()
        {
            this.vidaBase = 500;
        }
        public void Atacar()
        {
            int dañoTotal;
            foreach(Espada espada in equipamiento)
            {
                int dañoEspada = espada.GetDaño();
            }
            dañoTotal = this.ataqueBase + dañoEspada;
            // atacar con dañoTotal
        }
        public void Defender()
        {
            int defensaTotal;
            foreach(Yelmo yelmo in equipamiento)
            {
                int defensaYelmo = yelmo.GetDefensa();
                defensaTotal += defensaYelmo;
            }
            foreach(Pechera pechera in equipamiento)
            {
                int defensaPechera = pechera.GetDefensa();
            }
            foreach(Grebas grebas in equipamiento)
            {
                int defensaGrebas = grebas.GetDefensa();
            }
            foreach(Botas botas in equipamiento)
            {
                int defensaBotas = botas.GetDefensa();
            }
            defensaTotal = this.defensaBase + defensaYelmo + defensaPechera + defensaGrebas + defensaBotas;
            // atacar con defensaTotal
        }
    }
}