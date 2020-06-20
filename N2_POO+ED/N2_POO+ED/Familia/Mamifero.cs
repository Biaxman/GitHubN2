using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED
{
    class Mamifero : Animal
    {
        private bool temPelos = false;
        public enum cor {  }
        public int QtdeMamas { get; set; }
        public bool TemPelos
        {
            get => temPelos;
            set => temPelos = value;
        }
        public string CorPelo { get; set; }

    }
}
