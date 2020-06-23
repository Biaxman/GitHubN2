using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED.Estrutura_de_Dados
{
    class Nodo
    {
        private Nodo no_pai = null;
        private Nodo no_direita = null;
        private Nodo no_esquerda = null;
        private Animal valor;
        public Animal GetValor() { return valor; }
        public void SetValor(Animal v) { valor = v; }
        public void SetNoPai(Nodo no) { no_pai = no; }
        public void SetNoDireita(Nodo no) { no_direita = no; }
        public void SetNoEsquerda(Nodo no) { no_esquerda = no; }
        public Nodo GetNoPai() { return no_pai; }
        public Nodo GetNoDireita() { return no_direita; }
        public Nodo GetNoEsquerda() { return no_esquerda; }
        public Boolean NoEhRaiz(Nodo no) { return no.GetNoPai() == null; }
        /// <summary>
        /// Verifica se o nodo é externo
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        public bool EhExterno()
        {
            return (no_direita == null) && (no_esquerda == null);
        }
        /// <summary>
        /// Verifica se o nodo é interno
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        public bool EhInterno()
        {
            return (no_direita != null) || (no_esquerda != null);
        }
        /// <summary>
        /// Cria um nodo externo.
        /// </summary>
        /// <param name="Nopai"></param>
        /// <returns></returns>
        public static Nodo CriaNoExterno(Nodo Nopai)
        {
            Nodo no = new Nodo();
            no.SetNoPai(Nopai);
            return no;
        }
    }
}
