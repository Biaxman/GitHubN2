using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED.Classes_dos_Animais
{
    class Morcego : Mamifero, IVoar
    {
        private int altMaxMetros;
        private double velocidadeVoo;
        public Morcego(string nome, DateTime data, char sexo)
        {
            Nome = nome;
            DatadeNascimento = data;
            Sexo = sexo;
            QtdeMamas = 2;
            TemPelos = true;
            CorPelo = "Preta";
            AltMaxMetros = 15;
            VelocidadeVoo = 150;
        }

        public int AltMaxMetros
        {
            get
            {
                return altMaxMetros;
            }
            set
            {
                altMaxMetros = value;
            }
        }

        public double VelocidadeVoo
        {
            get
            {
                return velocidadeVoo;
            }
            set
            {
                velocidadeVoo = value;
            }
        }

        public void Voar()
        {
            Console.WriteLine("voar");
        }

    }
}
