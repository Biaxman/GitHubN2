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
        public int QtdeNodosInternos() 
        {
            return qtdeNodosInternos;
        }

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
                no_aux = PesquisaValor(valor, raiz);
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
            resultado = resultado + " - " + no.GetValor().Nome;
            PercursoInterfixado(no.GetNoDireita());
        }

        private void PesquisarMamifero(Nodo no)
        {

            if (no.EhExterno())
                return;
            PesquisarMamifero(no.GetNoEsquerda());
            object x = no.GetValor().GetType();
            if (no.GetValor().GetType().BaseType.Name == "Mamifero")
            {
                resultado = resultado + " - " + no.GetValor().Nome;
                
            }
            PesquisarMamifero(no.GetNoDireita());
        }

        private void PesquisarPorInterface(Nodo no, string tipo)
        {
            if (no.EhExterno())
                return;
            PesquisarPorInterface(no.GetNoEsquerda(), tipo);
            object[] test = no.GetValor().GetType().GetInterfaces();
            for (int i = 0; i < test.Length; i++)
            {
                string a = test[i].ToString();
                string b = a.Substring(a.IndexOf('.') + 1);
                if(b == tipo)
                    resultado = resultado + " - " + no.GetValor().Nome;
            }
            PesquisarPorInterface(no.GetNoDireita(),tipo);
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

        private Nodo PesquisaValor(Animal valor, Nodo no)
        {

            if (no.EhExterno())
                return no; // não achou!
            else if (valor.Nome.CompareTo(no.GetValor().Nome) == 0)
                return no;
            else if (valor.Nome.CompareTo(no.GetValor().Nome) == 1)
                return PesquisaValor(valor, no.GetNoDireita());
            else
                return PesquisaValor(valor, no.GetNoEsquerda());
        }

        //public void Remove(int valor)
        //{
        //    //primeiro, procuramos o nodo que tem o valor:
        //    Nodo noQueSeraApagado = PesquisaValor(valor, raiz);
        //    if (noQueSeraApagado == null || noQueSeraApagado.EhExterno())
        //        throw new Exception("Valor não existe na árvore");
        //    else
        //    {
        //        // um dos filhos é um nó externo
        //        if (noQueSeraApagado.GetNoEsquerda().EhExterno() ||
        //         noQueSeraApagado.GetNoDireita().EhExterno())
        //        {
        //            ExcluiComNodoExterno(noQueSeraApagado);
        //        }
        //        else
        //        {
        //            ExcluiSemNodoExterno(noQueSeraApagado);
        //        }
        //    }
        //}

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
