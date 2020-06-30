using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED.Animais
{
    public class Gato : Mamifero, IPredador
    {
        public Gato(string nome, DateTime data, char sexo)
        {
            Nome = nome;
            DatadeNascimento = data;
            Sexo = sexo;
            Carnivoro = true;
            QtdeMamas = 8;
            TemPelos = true;
            CorPelo = "Marrom";
        }

        public void Ataque()
        {
            Console.WriteLine("Atacar");
        }

        public override string ToString()
        {
            return base.ToString() + "Espécie:" + this.GetType().Name;
        }
    }
}
