using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED.Classes_dos_Animais
{
    class Pato: Ave, IOviparo, IVoar
    {
        public Pato()
        {
            CorPena = "Branco";
        }
        public void Botar()
        {
            Console.WriteLine("bota");
        }
        public void Chocar()
        {
            Console.WriteLine("choca");
        }
        public void Voar()
        {
            Console.WriteLine("voa");
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
    }
}
