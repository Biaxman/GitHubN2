﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED.Animais
{
    public class Tartaruga : Reptil, IAquatico, IOviparo
    {
        private bool viveEmTerra;
        private bool mergulho;
        private bool aguaDoce;

        public Tartaruga(string nome, DateTime data, char sexo)
        {
            Nome = nome;
            DatadeNascimento = data;
            Sexo = sexo;
            TemCasco = true;
            ViveEmTerra = true;
            Mergulho = true;
            AguaDoce = false;
        }

        public bool ViveEmTerra
        {
            get
            {
                return viveEmTerra;
            }
            set
            {
                viveEmTerra = value;
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
                mergulho = value;
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
                aguaDoce = value;
            }
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

