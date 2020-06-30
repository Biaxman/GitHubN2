using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED.Animais
{
    public class Baleia: Mamifero, IAquatico, IPredador
    {
        private bool viveEmTerra;
        private bool mergulho;
        private bool aguaDoce;


        public Baleia(string nome, DateTime data, char sexo)
        {
            Nome = nome;
            DatadeNascimento = data;
            Sexo = sexo;
            ViveEmTerra = false;
            Mergulho = true;
            AguaDoce = false;
            Carnivoro = true;
            QtdeMamas = 8;
        }

        public bool ViveEmTerra
        {
            get
            {
                return viveEmTerra;
            }
            set
            {
                viveEmTerra = value;
            }
        }

        public bool Mergulho
        {
            get
            {
                return mergulho;
            }
            set
            {
                mergulho = value;
            }
        }

        public bool AguaDoce
        {
            get
            {
                return aguaDoce;
            }
            set
            {
                aguaDoce = value;
            }
        }

        public void Ataque()
        {
            Console.WriteLine("Atacar");
        }

        public override string ToString()
        {
            return base.ToString() + "Espécie:" + this.GetType().Name;
        }
    }
}