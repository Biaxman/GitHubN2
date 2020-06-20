using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED.Animais
{
    class Leao: Mamifero, IPredador
    {
        public Leao()
        {
            QtdeMamas = 8;
            TemPelos = true;
            CorPelo = "Laranja";
        }

        public void Ataque()
        {
            Console.WriteLine("Atacar");
        }
    }
}