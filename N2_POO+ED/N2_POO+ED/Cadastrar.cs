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


        ListaAnimais listaAnimais = new ListaAnimais();

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

            for

            string nome = txtNome.Text;
            char sexo = 'F';
            if(rdbMacho.Checked)
                sexo = 'M';

            string animal = cbxEspecie.Text;
  


            switch (animal)
            {
                case "Baleia":
                    Baleia baleia = new Baleia(nome, data, sexo);
                    listaAnimais.InserirNoFim(baleia);
                    break;

                case "BeijaFlor":
                    BeijaFlor beijaFlor = new BeijaFlor(nome, data, sexo);
                    listaAnimais.InserirNoFim(beijaFlor);
                    break;

                case "Cachorro":
                    Cachorro cachorro = new Cachorro(nome, data, sexo);
                    listaAnimais.InserirNoFim(cachorro);
                    break;

                case "Coala":
                    Coala coala = new Coala(nome, data, sexo);
                    listaAnimais.InserirNoFim(coala);
                    break;

                case "Coruja":
                    Coruja coruja = new Coruja(nome, data, sexo);
                    listaAnimais.InserirNoFim(coruja);
                    break;

                case "Gato":
                    Gato gato = new Gato(nome, data, sexo);
                    listaAnimais.InserirNoFim(gato);
                    break;

                case "Gaviao":
                    Gaviao gaviao = new Gaviao(nome, data, sexo);
                    listaAnimais.InserirNoFim(gaviao);
                    break;

                case "Leao":
                    Leao Leao = new Leao(nome, data, sexo);
                    listaAnimais.InserirNoFim(Leao);
                    break;

                case "Morcego":
                    Morcego morcego = new Morcego(nome, data, sexo);
                    listaAnimais.InserirNoFim(morcego);
                    break;

                case "Ornitorrinco":
                    Ornitorrinco ornitorrinco = new Ornitorrinco(nome, data, sexo);
                    listaAnimais.InserirNoFim(ornitorrinco);
                    break;

                case "Pato":
                    Pato pato = new Pato(nome, data, sexo);
                    listaAnimais.InserirNoFim(pato);
                    break;

                case "Pinguim":
                    Pinguim pinguim = new Pinguim(nome, data, sexo);
                    listaAnimais.InserirNoFim(pinguim);
                    break;

                case "Pombo":
                    Pombo pombo = new Pombo(nome, data, sexo);
                    listaAnimais.InserirNoFim(pombo);
                    break;

                case "Tartaruga":
                    Tartaruga tartaruga = new Tartaruga(nome, data, sexo);
                    listaAnimais.InserirNoFim(tartaruga);
                    break;

                default:
                    break;
            }

        }
    }
}
