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
            this.equipamiento = equipamiento;
            this.ataqueBase = 500; // base attack
            this.vidaBase = 500; // base health
            this.defensaBase = 500; // base defense
            this.curacionBase = 500; // base heal
        }
        
        public void Curar()
        {
            // if buff then curacionBase + buff
            this.vidaBase = curacionBase;
        }
        public void Atacar()
        {

        }
        public void Defender()
        {
            
        }
    }
}