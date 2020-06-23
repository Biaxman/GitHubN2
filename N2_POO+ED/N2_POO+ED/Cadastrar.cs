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
            DateTime data = DateTime.Now;
            try
            {
                DateTime test = Convert.ToDateTime(txtDataNascimento.Text);

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



            switch (animal)
            {
                case "Baleia":
                    Baleia baleia = new Baleia(nome, data, sexo);
                    arvore.Insere(baleia);
                    break;

                case "BeijaFlor":
                    BeijaFlor beijaFlor = new BeijaFlor(nome, data, sexo);
                    arvore.Insere(beijaFlor);
                    break;

                case "Cachorro":
                    Cachorro cachorro = new Cachorro(nome, data, sexo);
                    arvore.Insere(cachorro);
                    break;

                case "Coala":
                    Coala coala = new Coala(nome, data, sexo);
                    arvore.Insere(coala);
                    break;

                case "Coruja":
                    Coruja coruja = new Coruja(nome, data, sexo);
                    arvore.Insere(coruja);
                    break;

                case "Gato":
                    Gato gato = new Gato(nome, data, sexo);
                    arvore.Insere(gato);
                    break;

                case "Gaviao":
                    Gaviao gaviao = new Gaviao(nome, data, sexo);
                    arvore.Insere(gaviao);
                    break;

                case "Leao":
                    Leao Leao = new Leao(nome, data, sexo);
                    arvore.Insere(Leao);
                    break;

                case "Morcego":
                    Morcego morcego = new Morcego(nome, data, sexo);
                    arvore.Insere(morcego);
                    break;

                case "Ornitorrinco":
                    Ornitorrinco ornitorrinco = new Ornitorrinco(nome, data, sexo);
                    arvore.Insere(ornitorrinco);
                    break;

                case "Pato":
                    Pato pato = new Pato(nome, data, sexo);
                    arvore.Insere(pato);
                    break;

                case "Pinguim":
                    Pinguim pinguim = new Pinguim(nome, data, sexo);
                    arvore.Insere(pinguim);
                    break;

                case "Pombo":
                    Pombo pombo = new Pombo(nome, data, sexo);
                    arvore.Insere(pombo);
                    break;

                case "Tartaruga":
                    Tartaruga tartaruga = new Tartaruga(nome, data, sexo);
                    arvore.Insere(tartaruga);
                    break;

                default:
                    break;
            }

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

