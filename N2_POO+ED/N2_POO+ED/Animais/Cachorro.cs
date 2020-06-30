using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED.Animais
{
    public class Cachorro : Mamifero, IPredador
    {
        public Cachorro(string nome, DateTime data, char sexo)
        {
            Nome = nome;
            DatadeNascimento = data;
            Sexo = sexo;
            Carnivoro = true;
            QtdeMamas = 10;
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
