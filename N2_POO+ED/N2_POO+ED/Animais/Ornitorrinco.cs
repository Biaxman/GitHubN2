﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED.Animais
{
    public class Ornitorrinco : Mamifero, IAquatico, IOviparo
    {
        private bool viveEmTerra;
        private bool mergulho;
        private bool aguaDoce;

        public Ornitorrinco(string nome, DateTime data, char sexo)
        {
            Nome = nome;
            DatadeNascimento = data;
            Sexo = sexo;
            Peconhento = true;
            QtdeMamas = 0;
            TemPelos = true;
            CorPelo = "Marrom";
            ViveEmTerra = true;
            Mergulho = true;
            AguaDoce = true;
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

