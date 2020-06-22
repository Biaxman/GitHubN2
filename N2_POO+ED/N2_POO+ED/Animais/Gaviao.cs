using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED.Animais
{
    class Gaviao : Ave, IVoar , IPredador
    {
        public Gaviao(string nome, DateTime data, char sexo)
        {
            Nome = nome;
            DatadeNascimento = data;
            Sexo = sexo;
            Carnivoro = true;
            Ciscar();
            Rapina = true;
            CorPena = "Cinza";
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

        public void Botar()
        {
            Console.WriteLine("Botou um ovo");
        }

        public void Ataque()
        {
            Console.WriteLine("Atacar");
        }

        public void Chocar()
        {
            Console.WriteLine("Chocou um ovo, é um milagre");
        }
    }
}
