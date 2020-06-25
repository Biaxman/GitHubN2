using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N2_POO_ED.Estrutura_de_Dados;

namespace N2_POO_ED.Estrutura_de_Dados
{
    class ListaAnimais
    {
        public NodoAnimal primeiro = null;
        public NodoAnimal ultimo = null;
        int qtde = 0;

        private void InserirNaPosicao(NodoAnimal anterior, Animal valor)
        {
            NodoAnimal novo = new NodoAnimal();
            novo.Dado = valor;
            if (anterior == null)
            {
                if (qtde == 0)
                {
                    primeiro = novo;
                    novo.Anterior = null;
                }
                else
                {
                    primeiro.Anterior = novo;
                    novo.Proximo = primeiro;
                    primeiro = novo;
                }
            }
            else
            {
                novo.Anterior = ultimo;
                novo.Proximo = anterior.Proximo;
                anterior.Proximo = novo;
            }
            if (novo.Proximo == null)
            {
                ultimo = novo;
            }
            qtde++;
        }

        public void InserirNoInicio(Animal valor)
        {
            InserirNaPosicao(null, valor);
        }

        public void InserirNoFim(Animal valor)
        {
            if (qtde == 0)
            {
                primeiro = null;
                InserirNoInicio(valor);
            }
            else
            {
                NodoAnimal aux = primeiro;
                while (aux.Proximo != null)
                    aux = aux.Proximo;

                InserirNaPosicao(aux, valor);
            }
        }

        public bool Pesquisar(string nome)
        {
            NodoAnimal aux = primeiro;
            while (aux.Proximo != null)
            {
                if (aux.Dado.Nome == nome)
                {
                    return true;
                }
                aux = aux.Proximo;
            }
            return false;
        }

        public int RetornarQuantidade()
        {
            return qtde;
        }
    }

}
