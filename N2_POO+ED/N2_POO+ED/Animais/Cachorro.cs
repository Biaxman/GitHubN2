using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED.Classes_dos_Animais
{
    class Cachorro : Mamifero, IPredador
    {

        public Cachorro()
        {
            QtdeMamas = 10;
            TemPelos = true;
            CorPelo = "Marrom";
        }

        public void Ataque()
        {
            Console.WriteLine("Atacar");
        }
    }
}
