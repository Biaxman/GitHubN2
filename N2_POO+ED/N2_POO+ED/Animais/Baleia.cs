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

            ViveEmTerra = false;
            Mergulho = true;
            Carnivoro = true;
            AguaDoce = false;
            QtdeMamas = 8;
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
    }
}
