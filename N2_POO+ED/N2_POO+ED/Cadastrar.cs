using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using N2_POO_ED.Animais;
using N2_POO_ED.Classes_dos_Animais;
using N2_POO_ED.Estrutura_de_Dados;

namespace N2_POO_ED
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }


        ArvoreBin arvore = new ArvoreBin();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            DateTime dataNascimento = DateTime.Now;
            try
            {
                dataNascimento = Convert.ToDateTime(txtDataNascimento.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Data Inválida!");
            }


            string nome = txtNome.Text;
            char sexo = 'F';
            if (rdbMacho.Checked)
                sexo = 'M';

            string animal = cbxEspecie.Text;

            try
            {
                switch (animal)
                {
                    case "Baleia":
                        Baleia baleia = new Baleia(nome, dataNascimento, sexo);
                        arvore.Insere(baleia);
                        break;

                    case "Beija-flor":
                        BeijaFlor beijaFlor = new BeijaFlor(nome, dataNascimento, sexo);
                        arvore.Insere(beijaFlor);
                        break;

                    case "Cachorro":
                        Cachorro cachorro = new Cachorro(nome, dataNascimento, sexo);
                        arvore.Insere(cachorro);
                        break;

                    case "Coala":
                        Coala coala = new Coala(nome, dataNascimento, sexo);
                        arvore.Insere(coala);
                        break;

                    case "Coruja":
                        Coruja coruja = new Coruja(nome, dataNascimento, sexo);
                        arvore.Insere(coruja);
                        break;

                    case "Gato":
                        Gato gato = new Gato(nome, dataNascimento, sexo);
                        arvore.Insere(gato);
                        break;

                    case "Gavião":
                        Gaviao gaviao = new Gaviao(nome, dataNascimento, sexo);
                        arvore.Insere(gaviao);
                        break;

                    case "Leão":
                        Leao Leao = new Leao(nome, dataNascimento, sexo);
                        arvore.Insere(Leao);
                        break;

                    case "Morcego":
                        Morcego morcego = new Morcego(nome, dataNascimento, sexo);
                        arvore.Insere(morcego);
                        break;

                    case "Ornitorrinco":
                        Ornitorrinco ornitorrinco = new Ornitorrinco(nome, dataNascimento, sexo);
                        arvore.Insere(ornitorrinco);
                        break;

                    case "Pato":
                        Pato pato = new Pato(nome, dataNascimento, sexo);
                        arvore.Insere(pato);
                        break;

                    case "Pinguim":
                        Pinguim pinguim = new Pinguim(nome, dataNascimento, sexo);
                        arvore.Insere(pinguim);
                        break;

                    case "Pombo":
                        Pombo pombo = new Pombo(nome, dataNascimento, sexo);
                        arvore.Insere(pombo);
                        break;

                    case "Tartaruga":
                        Tartaruga tartaruga = new Tartaruga(nome, dataNascimento, sexo);
                        arvore.Insere(tartaruga);
                        break;

                    default:
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Já existe um animal com esse nome!");
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTest.Text = arvore.ListarInterface("IOviparo");
            //if(rdbMamifero.Checked || rdbOviparo.Checked)
            //{
            //    string categoria = "IOviparo";
            //    if(rdbMamifero.Checked)
            //        categoria = "Mamifero";
            //    arvore.ListarCategoria(categoria);
            //}


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        public string VerificarPesquisaInterface(string FiltroPesquisa)
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
                resposta = arvore.ListarMamifero().Split('|');
                foreach (string x in resposta)
                {
                    cbxListagem.Items.Add(x);
                }
            }
           

            else if (VerificarPesquisaInterface(FiltroPesquisa) != "")
            {
                resposta = arvore.ListarInterface(FiltroPesquisa).Split('|');
                foreach (string x in resposta)
                {
                    cbxListagem.Items.Add(x);
                }

            }
            else if (rdbAlfabetico.Checked || rdbTodos.Checked)
            {
                resposta = arvore.ListagemEmOrdem().Split('|');
                foreach (string x in resposta)
                {
                    cbxListagem.Items.Add(x);
                }
            }

        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            Baleia baleia = new Baleia("baleia", DateTime.Now, 'F');
            arvore.Insere(baleia);

            Tartaruga tartaruga = new Tartaruga("tartaruga", DateTime.Now, 'F');
            arvore.Insere(tartaruga);

            Pombo pombo = new Pombo("pombo", DateTime.Now, 'F');
            arvore.Insere(pombo);

            Pinguim pinguim = new Pinguim("pinguim", DateTime.Now, 'F');
            arvore.Insere(pinguim);

            Pato pato = new Pato("pato", DateTime.Now, 'F');
            arvore.Insere(pato);

            Ornitorrinco ornitorrinco = new Ornitorrinco("ornitorrinco", DateTime.Now, 'F');
            arvore.Insere(ornitorrinco);

            Morcego morcego = new Morcego("morcego", DateTime.Now, 'F');
            arvore.Insere(morcego);

            Leao Leao = new Leao("Leao", DateTime.Now, 'F');
            arvore.Insere(Leao);

            Gaviao gaviao = new Gaviao("gaviao", DateTime.Now, 'F');
            arvore.Insere(gaviao);

            Gato gato = new Gato("gato", DateTime.Now, 'F');
            arvore.Insere(gato);

            Coruja coruja = new Coruja("coruja", DateTime.Now, 'F');
            arvore.Insere(coruja);

            Coala coala = new Coala("coala", DateTime.Now, 'F');
            arvore.Insere(coala);

            Cachorro cachorro = new Cachorro("cachorro", DateTime.Now, 'F');
            arvore.Insere(cachorro);

            BeijaFlor beijaFlor = new BeijaFlor("beijaFlor", DateTime.Now, 'F');
            arvore.Insere(beijaFlor);


            btnTodos.Enabled = false;
        }


        //public int PesquisaBinaria(string nome)
        //{
        //    int meio;
        //    int Min = 0;
        //    int Max = listaAnimais.RetornarQuantidade();

        //    do
        //    {
        //        meio = (Min + Max) / 2;
        //        if (listaAnimais.Pesquisar(nome))
        //        {
        //            return meio;
        //        }
        //        else if (chave > vetor[meio])
        //            Min = meio + 1;
        //        else
        //            Max = meio - 1;
        //    }
        //    while (Min <= Max);

        //    //Caso o retorno for -1, então o número não existe na seqüencia.
        //    return -1;
        //}
    }
}

