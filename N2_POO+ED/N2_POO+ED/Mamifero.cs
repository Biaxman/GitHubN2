using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED
{
    class Mamifero : Animal
    {
        public int QtdeMamas { get; set; }
        public bool TemPelos { get; set; } = false;
        public string CorPelo { get; set; }

    }
}
