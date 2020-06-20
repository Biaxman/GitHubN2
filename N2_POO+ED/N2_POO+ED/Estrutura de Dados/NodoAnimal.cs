using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED.Estrutura_de_Dados
{
    public class NodoAnimal
    {
        public Animal Dado { get; set; }
        public NodoAnimal Proximo { get; set; }
        public NodoAnimal Anterior { get; set; }

        public NodoAnimal()
        {
            Proximo = null;
        }
    }
}
