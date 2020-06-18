using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED
{
    class Animal

    {
        public string Nome { get; set; }
        public DateTime DatadeNascimento { get; set; }
        public char Sexo { get; set; }

        public bool Carnivoro { get; set; } = false;
        public bool Peconhento { get; set; } = false;

        public virtual void Movimentar()
        { }

        public virtual void Comunicar()
        { }

        public virtual void Alimentar()
        { }

        public virtual int Idade (DateTime DatadeNascimento)
        {
            int idade = DateTime.Now.Year - DatadeNascimento.Year;
            if(DateTime.Now.DayOfYear < DatadeNascimento.DayOfYear)
            {
                idade = idade - 1;
            }
            return idade;
        }

        
    }

}
