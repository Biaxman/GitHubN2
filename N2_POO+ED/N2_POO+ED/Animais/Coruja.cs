using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED.Animais
{
    public class Coruja : Ave, IVoar, IOviparo, IPredador
    {
        private int altMaxMetros;
        private double velocidadeVoo;

        public Coruja(string nome, DateTime data, char sexo)
        {
            Nome = nome;
            DatadeNascimento = data;
            Sexo = sexo;
            Carnivoro = true;
            Ciscar();
            Rapina = true;
            CorPena = "Cinza";
            AltMaxMetros = 15;
            VelocidadeVoo = 15;
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
