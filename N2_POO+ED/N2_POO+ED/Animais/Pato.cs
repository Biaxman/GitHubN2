﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED.Animais
{
    public class Pato: Ave, IOviparo, IVoar, IAquatico
    {
        private int altMaxMetros;
        private double velocidadeVoo;

        private bool viveEmTerra;
        private bool mergulho;
        private bool aguaDoce;

        public Pato(string nome, DateTime data, char sexo)
        {
            Nome = nome;
            DatadeNascimento = data;
            Sexo = sexo;
            CorPena = "Branco";
            AltMaxMetros = 1200;
            VelocidadeVoo = 52;
            ViveEmTerra = true;
            Mergulho = true;
            AguaDoce = true;

        }
        public void Botar()
        {
            Console.WriteLine("bota");
        }
        public void Chocar()
        {
            Console.WriteLine("choca");
        }
        public void Voar()
        {
            Console.WriteLine("voa");
        }

        public int AltMaxMetros
        {
            get
            {
                return altMaxMetros;
            }
            set
            {
                altMaxMetros = value;
            }
        }

        public double VelocidadeVoo
        {
            get
            {
                return velocidadeVoo;
            }
            set
            {
                velocidadeVoo = value;
            }
        }

        public bool ViveEmTerra
        {
            get
            {
                return viveEmTerra;
            }

            set
            {
                viveEmTerra = false;
            }
        }
        public bool Mergulho
        {
            get
            {
                return mergulho;
            }
            set
            {
                mergulho = true;
            }
        }

        public bool AguaDoce
        {
            get
            {
                return aguaDoce;
            }
            set
            {
                aguaDoce = true;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "Espécie:" + this.GetType().Name;
        }
    }
}
