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
    public partial class Pokedex : Form
    {
        public Pokedex()
        {
            InitializeComponent();
        }

        private void tet_Load(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            CadastarAnimal cadastrar = new CadastarAnimal();
            cadastrar.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if(VariavelGlobal.ListarAberto == false)
            {
                VariavelGlobal.ListarAberto = true;
                ListarAnimais listar = new ListarAnimais();
                listar.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
