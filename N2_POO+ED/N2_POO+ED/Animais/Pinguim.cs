using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED.Animais
{
    class Pinguim : Ave, IOviparo, IAquatico
    {
        private bool viveEmTerra;
        private bool mergulho;
        private bool aguaDoce;

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
    }
}
