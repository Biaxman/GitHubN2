using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED
{
    public class Ave : Animal
    {
        private bool rapina = false;
        public bool Rapina
        {
            get =>rapina;
            set => rapina = value;

        }
        public virtual void Ciscar()
        { }
        public string CorPena { get; set; }
    }
}
