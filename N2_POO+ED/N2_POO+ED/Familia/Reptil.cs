using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED
{
    public class Reptil : Animal
    {
        private bool temEscamas = false;
        private bool temCasco = false;
        public bool TemEscamas
        {
            get => temEscamas;
            set => temEscamas = value;
        }
        public bool TemCasco
        {
            get => temCasco;
            set => temCasco = value;
        }

    }
}
