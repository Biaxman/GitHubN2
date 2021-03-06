﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED.Animais
{
    public class Pombo: Ave, IOviparo, IVoar 
    {
        private int altMaxMetros;
        private double velocidadeVoo;
        public Pombo(string nome, DateTime data, char sexo)
        {
            Nome = nome;
            DatadeNascimento = data;
            Sexo = sexo;
            Carnivoro = true;
            Ciscar();
            CorPena = "Cinza";
            AltMaxMetros = 2400;
            VelocidadeVoo = 102;
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

        public void Voar()
        {
            Console.WriteLine("voar");
        }

        public void Botar()
        {
            Console.WriteLine("Botou um ovo");
        }

        public void Chocar()
        {
            Console.WriteLine("Chocou um ovo, é um milagre");
        }

        public override string ToString()
        {
            return base.ToString() + "Espécie:" + this.GetType().Name;
        }
    }
}
