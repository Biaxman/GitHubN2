using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED.Animais
{
    public class Tucano: Ave, IVoar, IOviparo
    {
        private int altMaxMetros;
        private double velocidadeVoo;

        public Tucano(string nome, DateTime data, char sexo)
        {
            Nome = nome;
            DatadeNascimento = data;
            Sexo = sexo;
            Ciscar();
            CorPena = "Cinza";
            AltMaxMetros = 100;
            VelocidadeVoo = 60;
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

        public void Chocar()
        {
            Console.WriteLine("Chocou um ovo, é um milagre");
        }


    }
}
