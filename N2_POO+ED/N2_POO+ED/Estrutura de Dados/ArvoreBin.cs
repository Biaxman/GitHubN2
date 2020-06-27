using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED.Estrutura_de_Dados
{
    class ArvoreBin
    {
        private Nodo raiz = null; // raiz da árvore
        private int qtdeNodosInternos = 0; // qtde de nos internos
        private string resultado = ""; // utilizada na listagem dos nodos
        private int contadorVetAnimal = 0;
        public int QtdeNodosInternos() 
        {
            return qtdeNodosInternos;
        }

        ListaAnimais lista = new ListaAnimais();

        public void Insere(Animal valor) // insere um valor int
        {
            Nodo no_aux;
            if (qtdeNodosInternos == 0) // árvore vazia!
            {
                // árvore vazia, devemos criar o primeiro Nodo, que será a raiz
                no_aux = new Nodo();
                raiz = no_aux;
            }
            else
            {
                // localiza onde deve ser inserido o novo nó.
                no_aux = PesquisaValor(valor.Nome, raiz);
                if (no_aux.EhInterno())
                {
                    throw new Exception("Este valor já existe na árvore!!!!");
                }
            }
            // este era um Nodo externo e portanto não tinha filhos.
            // Agora ele passará a ser interno, portanto devemos criar outros 2
            // nodos externos (filhos) para ele.
            no_aux.SetValor(valor);
            no_aux.SetNoEsquerda(Nodo.CriaNoExterno(no_aux));
            no_aux.SetNoDireita(Nodo.CriaNoExterno(no_aux));
            qtdeNodosInternos++;
        }
        private void PercursoInterfixado(Nodo no)
        {
            if (no.EhExterno())
                return;
            PercursoInterfixado(no.GetNoEsquerda());
            if (resultado == "")
                resultado = no.GetValor().Nome;
            else
                resultado = resultado + "|" + no.GetValor().Nome;
            PercursoInterfixado(no.GetNoDireita());
        }

        private void PesquisarMamifero(Nodo no)
        {

            if (no.EhExterno())
                return;
            PesquisarMamifero(no.GetNoEsquerda());
            
            if(no.GetValor() is Mamifero)
            {
                if (resultado == "")
                    resultado = no.GetValor().Nome;
                else
                    resultado = resultado + "|" + no.GetValor().Nome;
            }
            PesquisarMamifero(no.GetNoDireita());
        }

        private void PesquisarPorInterface(Nodo no, string tipo)
        {
            if (no.EhExterno())
                return;
            PesquisarPorInterface(no.GetNoEsquerda(), tipo);
            object[] InterfacesVet = no.GetValor().GetType().GetInterfaces();

            if(no.GetValor().GetType().GetInterfaces().Where(o => o.Name == tipo).Count() > 0)
            {
                if (resultado == "")
                    resultado = no.GetValor().Nome;
                else
                    resultado = resultado + "|" + no.GetValor().Nome;
            }

            PesquisarPorInterface(no.GetNoDireita(), tipo);
        }

        private void PesquisarPorIdade(Nodo no, Animal[]vet)
        {
            if (no.EhExterno())
                return;
            PesquisarPorIdade(no.GetNoEsquerda(),vet);
            vet[contadorVetAnimal++] = no.GetValor();
            PesquisarPorIdade(no.GetNoDireita(),vet);
        }

        public Animal[] ListarPorIdade()
        {
            Animal[] vetAnimais = new Animal[qtdeNodosInternos];
            contadorVetAnimal = 0;
            PesquisarPorIdade(raiz,vetAnimais);

            for (int i = 0; i <= vetAnimais.Length -1; i++)
            {
                for (int j = 0; j <= vetAnimais.Length - 1 - 1; j++)
                {
                    if (vetAnimais[j].Idade(vetAnimais[j].DatadeNascimento) > vetAnimais[j + 1].Idade(vetAnimais[j+1].DatadeNascimento))
                    {
                        Animal temp = vetAnimais[j];
                        vetAnimais[j] = vetAnimais[j + 1];
                        vetAnimais[j + 1] = temp;
                    }
                }
            }

            return vetAnimais;
        }

        public string ListagemEmOrdem()
        {
            resultado = "";
            if (qtdeNodosInternos != 0)
                PercursoInterfixado(raiz);
            return resultado;
        }

        public string ListarMamifero()
        {
            resultado = "";
            if (qtdeNodosInternos != 0)
                PesquisarMamifero(raiz);
            return resultado;
        }

        public string ListarInterface(string tipo)
        {
            resultado = "";
            if (qtdeNodosInternos != 0)
                PesquisarPorInterface(raiz, tipo);
            return resultado;
        }

        private Nodo PesquisaValor(string nome, Nodo no)
        {

            if (no.EhExterno())
                return no; // não achou!
            else if (nome.CompareTo(no.GetValor().Nome) == 0)
                return no;
            else if (nome.CompareTo(no.GetValor().Nome) == 1)
                return PesquisaValor(nome, no.GetNoDireita());
            else
                return PesquisaValor(nome, no.GetNoEsquerda());
        }

        public Animal PesquisarPorNome(string nome)
        {
            Nodo n = PesquisaValor(nome, raiz);

            return n.GetValor();
        }

        private void ExcluiComNodoExterno(Nodo noQueSeraApagado)
        {
            qtdeNodosInternos--;
            //descobre quem será o nodo que irá ficar no lugar do que foi apagado
            Nodo nodo_substituto;
            if (noQueSeraApagado.GetNoEsquerda().EhInterno())
                nodo_substituto = noQueSeraApagado.GetNoEsquerda();
            else
                nodo_substituto = noQueSeraApagado.GetNoDireita();
            // substitui o apagado pelo novo nodo
            Nodo PaiNodoApagado = noQueSeraApagado.GetNoPai();
            //altera o pai do novo substituto
            nodo_substituto.SetNoPai(PaiNodoApagado);
            //o pai do nodo substituto também deve ter sua referência de filho corrigida.
            //mas primeiro precisamos saber o no apagado er a raiz, que neste caso não tem pai.
            if (PaiNodoApagado != null)
            {
                if (PaiNodoApagado.GetNoDireita() == noQueSeraApagado)
                    PaiNodoApagado.SetNoDireita(nodo_substituto);
                else
                    PaiNodoApagado.SetNoEsquerda(nodo_substituto);
            }
            else
                raiz = nodo_substituto;
        }

        private Nodo PesquisaNodoInternoInterfixado(Nodo no)
        {
            if (no.EhExterno())
                return null;
            Nodo retorno = PesquisaNodoInternoInterfixado(no.GetNoEsquerda());
            if (retorno == null)
                return no;
            else
                return retorno;
        }
        private void ExcluiSemNodoExterno(Nodo noQueSeraApagado)
        {
            //encontra o nodo substituto
            Nodo NodoSubstituto = PesquisaNodoInternoInterfixado(noQueSeraApagado.GetNoDireita());
            Console.Write("Nodo substituto: " + NodoSubstituto.GetValor());
            //Altera o valor do nodo que será removido pelo valor do nodo substituto
            noQueSeraApagado.SetValor(NodoSubstituto.GetValor());
            //Remove o nodo substituto
            ExcluiComNodoExterno(NodoSubstituto);
        }

    }
}
