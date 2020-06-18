using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED
{
    class Ave : Animal
    {
        public bool Rapina { get; set; } = false;
        public virtual void Ciscar()
        { }
        public string CorPena { get; set; }
    }
}
