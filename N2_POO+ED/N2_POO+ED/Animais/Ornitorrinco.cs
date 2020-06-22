using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED.Animais
{
    class Ornitorrinco : Mamifero, IAquatico, IOviparo
    {
        public Ornitorrinco(string nome, DateTime data, char sexo)
        {
            Nome = nome;
            DatadeNascimento = data;
            Sexo = sexo;
            Peconhento = true;
            QtdeMamas = 0;
            TemPelos = true;
            CorPelo = "Marrom";
        }
        public bool ViveEmTerra
        {
            get
            {
                return ViveEmTerra;
            }

            set
            {
                ViveEmTerra = false;
            }
        }
        public bool Mergulho
        {
            get
            {
                return Mergulho;
            }
            set
            {
                Mergulho = true;
            }
        }

        public bool AguaDoce
        {
            get
            {
                return AguaDoce;
            }
            set
            {
                AguaDoce = true;
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
    }
}

