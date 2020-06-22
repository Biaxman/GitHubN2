using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED.Animais
{
    class Pinguim : Ave, IOviparo, IAquatico
    {
        public Pinguim(string nome, DateTime data, char sexo)
        {
            Nome = nome;
            DatadeNascimento = data;
            Sexo = sexo;
            Ciscar();
            CorPena = "Azul";
        }

        public bool ViveEmTerra
        {
            get
            {
                return ViveEmTerra;
            }

            set
            {
                ViveEmTerra = true;
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
                AguaDoce = false;
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
