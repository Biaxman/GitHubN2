using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED
{
    public interface IVoar
    {
        void Voar();
        int AltMaxMetros { get; set; }
        double VelocidadeVoo { get; set; }
    }
}
