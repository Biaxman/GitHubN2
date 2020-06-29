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

namespace N2_POO_ED
{
    public partial class CadastarAnimal : Form
    {
        public CadastarAnimal()
        {
            InitializeComponent();
        }

        private void rdbMacho_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            DateTime dataNascimento = DateTime.Now;
            try
            {
                dataNascimento = Convert.ToDateTime(txtDataNascimento.Text);

            }
            catch (Exception)
            {
                MessageBox msgErro = new MessageBox("Data Inválida!");
                msgErro.ShowDialog();
                return;
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
                        VariavelGlobal.arvore.Insere(baleia);
                        break;

                    case "Beija-flor":
                        Tucano beijaFlor = new Tucano(nome, dataNascimento, sexo);
                        VariavelGlobal.arvore.Insere(beijaFlor);
                        break;

                    case "Cachorro":
                        Cachorro cachorro = new Cachorro(nome, dataNascimento, sexo);
                        VariavelGlobal.arvore.Insere(cachorro);
                        break;

                    case "Coala":
                        Coala coala = new Coala(nome, dataNascimento, sexo);
                        VariavelGlobal.arvore.Insere(coala);
                        break;

                    case "Coruja":
                        Coruja coruja = new Coruja(nome, dataNascimento, sexo);
                        VariavelGlobal.arvore.Insere(coruja);
                        break;

                    case "Gato":
                        Gato gato = new Gato(nome, dataNascimento, sexo);
                        VariavelGlobal.arvore.Insere(gato);
                        break;

                    case "Gavião":
                        Gaviao gaviao = new Gaviao(nome, dataNascimento, sexo);
                        VariavelGlobal.arvore.Insere(gaviao);
                        break;

                    case "Leão":
                        Leao Leao = new Leao(nome, dataNascimento, sexo);
                        VariavelGlobal.arvore.Insere(Leao);
                        break;

                    case "Morcego":
                        Morcego morcego = new Morcego(nome, dataNascimento, sexo);
                        VariavelGlobal.arvore.Insere(morcego);
                        break;

                    case "Ornitorrinco":
                        Ornitorrinco ornitorrinco = new Ornitorrinco(nome, dataNascimento, sexo);
                        VariavelGlobal.arvore.Insere(ornitorrinco);
                        break;

                    case "Pato":
                        Pato pato = new Pato(nome, dataNascimento, sexo);
                        VariavelGlobal.arvore.Insere(pato);
                        break;

                    case "Pinguim":
                        Pinguim pinguim = new Pinguim(nome, dataNascimento, sexo);
                        VariavelGlobal.arvore.Insere(pinguim);
                        break;

                    case "Pombo":
                        Pombo pombo = new Pombo(nome, dataNascimento, sexo);
                        VariavelGlobal.arvore.Insere(pombo);
                        break;

                    case "Tartaruga":
                        Tartaruga tartaruga = new Tartaruga(nome, dataNascimento, sexo);
                        VariavelGlobal.arvore.Insere(tartaruga);
                        break;

                    default:
                        break;
                }
            }
            catch (Exception)
            {             
                MessageBox msgErro = new MessageBox("Já existe um animal com esse nome!");
                msgErro.ShowDialog();
                return;
            }
            MessageBox msg = new MessageBox("Cadastro Realizado Com Sucesso");
            TratamentoAudio.playQuemEsse();
            msg.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCadastrarTodos_Click(object sender, EventArgs e)
        {
            try
            {
            Baleia baleia = new Baleia("Wailord", Convert.ToDateTime("01/01/2020"), 'F');
            VariavelGlobal.arvore.Insere(baleia);

            Tartaruga tartaruga = new Tartaruga("Tirtouga", Convert.ToDateTime("01 / 01 / 2019"), 'F');
            VariavelGlobal.arvore.Insere(tartaruga);

            Pombo pombo = new Pombo("Pidove", Convert.ToDateTime("01 / 01 / 2018"), 'F');
            VariavelGlobal.arvore.Insere(pombo);

            Pinguim pinguim = new Pinguim("Prinplup", Convert.ToDateTime("01 / 01 / 2017"), 'F');
            VariavelGlobal.arvore.Insere(pinguim);

            Pato pato = new Pato("Ducklett", Convert.ToDateTime("01 / 01 / 2016"), 'F');
            VariavelGlobal.arvore.Insere(pato);

            Ornitorrinco ornitorrinco = new Ornitorrinco("Psyduck", Convert.ToDateTime("01 / 01 / 2015"), 'F');
            VariavelGlobal.arvore.Insere(ornitorrinco);

            Morcego morcego = new Morcego("Golbat", Convert.ToDateTime("01 / 01 / 2014"), 'F');
            VariavelGlobal.arvore.Insere(morcego);

            Leao Leao = new Leao("Pyroar", Convert.ToDateTime("01 / 01 / 2013"), 'F');
            VariavelGlobal.arvore.Insere(Leao);

            Gaviao gaviao = new Gaviao("Bravary", Convert.ToDateTime("01 / 01 / 2012"), 'F');
            VariavelGlobal.arvore.Insere(gaviao);

            Gato gato = new Gato("Glameow", Convert.ToDateTime("01 / 01 / 2011"), 'F');
            VariavelGlobal.arvore.Insere(gato);

            Coruja coruja = new Coruja("Noctowl", Convert.ToDateTime("01 / 01 / 2010"), 'F');
            VariavelGlobal.arvore.Insere(coruja);

            Coala coala = new Coala("Komala", Convert.ToDateTime("01 / 01 / 2009"), 'F');
            VariavelGlobal.arvore.Insere(coala);

            Cachorro cachorro = new Cachorro("Herdier", Convert.ToDateTime("01 / 01 / 2008"), 'F');
            VariavelGlobal.arvore.Insere(cachorro);

            Tucano tucano = new Tucano("Toucannon", Convert.ToDateTime("01 / 01 / 2007"), 'F');
            VariavelGlobal.arvore.Insere(tucano);

            }
            catch (Exception)
            {
                MessageBox msgErro = new MessageBox("Animais já cadastrados");
                msgErro.ShowDialog();
                return;
            }
            btnCadastrarTodos.Enabled = false;
            MessageBox msg = new MessageBox("Cadastro Realizado Com Sucesso");
            TratamentoAudio.playQuemEsse();
            msg.ShowDialog();
            
        }

        private void cbxEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
