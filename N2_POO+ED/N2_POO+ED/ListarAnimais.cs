using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2_POO_ED
{
    public partial class ListarAnimais : Form
    {
        public delegate void AtualizarFormPrincipal(Animal a);

        public AtualizarFormPrincipal metodoDelegado;

        public ListarAnimais(AtualizarFormPrincipal metodoRecebido)
        {
            metodoDelegado = metodoRecebido;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            VariavelGlobal.ListarAberto = false;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        public string VerificarPesquisaInterface(out string FiltroPesquisa)
        {

            if (rdbOviparo.Checked)
                FiltroPesquisa = "IOviparo";
            else if (rdbAquatico.Checked)
                FiltroPesquisa = "IAquatico";
            else if (rdbVoador.Checked)
                FiltroPesquisa = "IVoar";
            else if (rdbPredador.Checked)
                FiltroPesquisa = "IPredador";
            else
                FiltroPesquisa = "";

            return FiltroPesquisa;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string FiltroPesquisa = "";
            cbxListagem.Items.Clear();
            string[] resposta = new string[0];

            if (rdbMamifero.Checked)
            {
                resposta = VariavelGlobal.arvore.ListarMamifero().Split('|');
                foreach (string x in resposta)
                {
                    cbxListagem.Items.Add(x);
                }
            }


            else if (VerificarPesquisaInterface(out FiltroPesquisa) != "")
            {
                resposta = VariavelGlobal.arvore.ListarInterface(FiltroPesquisa).Split('|');
                foreach (string x in resposta)
                {
                    cbxListagem.Items.Add(x);
                }

            }
            else if (rdbAlfabetico.Checked || rdbTodos.Checked)
            {
                resposta = VariavelGlobal.arvore.ListagemEmOrdem().Split('|');
                foreach (string x in resposta)
                {
                    cbxListagem.Items.Add(x);
                }
            }

            else if (rdbIdade.Checked)
            {
                Animal[] vetAnimal = VariavelGlobal.arvore.ListarPorIdade();
                for (int i = 0; i < vetAnimal.Length; i++)
                {
                    cbxListagem.Items.Add(vetAnimal[i].Nome + " - " + vetAnimal[i].Idade(vetAnimal[i].DatadeNascimento) + " Ano(S)");

                }
            }
        }

        private void cbxListagem_SelectedValueChanged(object sender, EventArgs e)
        {
            string animal = cbxListagem.SelectedItem.ToString().Substring(0, cbxListagem.SelectedItem.ToString().IndexOf(" "));
            Animal a = VariavelGlobal.arvore.PesquisarPorNome(animal);
            metodoDelegado(a);
        }

        private void cbxListagem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}