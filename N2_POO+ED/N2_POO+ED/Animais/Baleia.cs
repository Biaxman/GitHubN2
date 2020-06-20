using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED.Animais
{
    class Baleia: Mamifero, IAquatico
    {
        public Baleia()
        {
            QtdeMamas = 8;
            TemPelos = true;
            CorPelo = "Laranja";
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
