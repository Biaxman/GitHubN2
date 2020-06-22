using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED.Animais
{
    class Pombo: Ave, IOviparo, IVoar 
    {
        public Pombo(string nome, DateTime data, char sexo)
        {
            Nome = nome;
            DatadeNascimento = data;
            Sexo = sexo;
            Carnivoro = true;
            Ciscar();
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

        public void Chocar()
        {
            Console.WriteLine("Chocou um ovo, é um milagre");
        }
    }
}
