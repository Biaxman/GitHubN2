using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED.Animais
{
    class Gaviao : Ave, IVoar , IPredador, IOviparo
    {
        private int altMaxMetros;
        private double velocidadeVoo;

        public Gaviao(string nome, DateTime data, char sexo)
        {
            Nome = nome;
            DatadeNascimento = data;
            Sexo = sexo;
            Carnivoro = true;
            Ciscar();
            Rapina = true;
            CorPena = "Cinza";
            AltMaxMetros = 2400;
            VelocidadeVoo = 320;
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
