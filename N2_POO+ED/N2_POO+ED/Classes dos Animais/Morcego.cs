using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED.Classes_dos_Animais
{
    class Morcego : Mamifero, IVoar
    {
        public Morcego()
        {
            QtdeMamas = 2;
            TemPelos = true;
            CorPelo = "Preta";
        }

        public int AltMaxMetros
        {
            get
            {
                return AltMaxMetros;
            }
            set
            {
                AltMaxMetros = value;
            }
        }

        public double VelocidadeVoo
        {
            get
            {
                return VelocidadeVoo;
            }
            set
            {
                VelocidadeVoo = value;
            }
        }

        public void Voar()
        {
            Console.WriteLine("voar");
        }

    }
}
