﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED
{
    public abstract class Animal
    {
        private bool carnivoro = false;
        private bool peconhento = false;
        public string Nome { get; set; }
        public DateTime DatadeNascimento { get; set; }
        public char Sexo { get; set; }

        public bool Carnivoro
        {
            get => carnivoro;
            set => carnivoro = value;
        }
        public bool Peconhento
        {
            get => peconhento;
            set => peconhento = value;
        }

        public virtual void Movimentar()
        { }

        public virtual void Comunicar()
        { }

        public virtual void Alimentar()
        { }

        public virtual int Idade (DateTime DatadeNascimento)
        {
            int idade = DateTime.Now.Year - DatadeNascimento.Year;
            if(DateTime.Now.DayOfYear < DatadeNascimento.DayOfYear)
            {
                idade = idade - 1;
            }
            return idade;
        }

        
    }

}
