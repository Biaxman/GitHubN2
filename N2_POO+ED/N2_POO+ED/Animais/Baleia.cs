using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED.Animais
{
    class Baleia: Mamifero, IAquatico
    {
        private bool viveEmTerra;
        private bool mergulho;
        private bool aguaDoce;


        public Baleia(string nome, DateTime data, char sexo)
        {
            Nome = nome;
            DatadeNascimento = data;
            Sexo = sexo;
            ViveEmTerra = false;
            Mergulho = false;
            AguaDoce = false;
            QtdeMamas = 8;
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
                AguaDoce = false;
            }
        }
    }
}
