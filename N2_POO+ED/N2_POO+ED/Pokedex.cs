using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using N2_POO_ED.Properties;
using System.Runtime.InteropServices;

namespace N2_POO_ED
{


    public partial class Pokedex : Form
    {
        CadastarAnimal cadastrar;
        ListarAnimais listar;
        public Pokedex()
        {
            InitializeComponent();
            pnlFundo.BackgroundImage = null;
            ptbAnimal.Image = null;
            ptbAtaque.Image = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            cadastrar = new CadastarAnimal();
            cadastrar.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            cadastrar.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (VariavelGlobal.ListarAberto == false)
            {
                VariavelGlobal.ListarAberto = true;
                listar = new ListarAnimais(new ListarAnimais.AtualizarFormPrincipal(AtualizarTela));
                listar.Location = new Point(this.Location.X + this.Width, this.Location.Y + 299);
                listar.Show();
            }

        }

        private void AtualizarTela(Animal a)
        {
            AtualizarImagem(a);
            AtualizarTxt(a);
        }

        private void AtualizarTxt(Animal a)
        {
            txtInfo.Text = a.ToString();
        }

        private void AtualizarImagem(Animal a)
        {
            if (a.GetType().GetInterfaces().Where(o => o.Name == "IAquatico").Count() > 0)
                pnlFundo.BackgroundImage = Resources.FundoAgua;
            else
                pnlFundo.BackgroundImage = Resources.FundoGrama;

            ptbAtaque.Image = null;

            if (a is Animais.Pato)
                ptbAnimal.Image = Resources.ducklett;
            else if (a is Animais.Baleia)
                ptbAnimal.Image = Resources.Wailord;
            else if (a is Animais.Cachorro)
                ptbAnimal.Image = Resources.herdier2;
            else if (a is Animais.Coala)
                ptbAnimal.Image = Resources.komala;
            else if (a is Animais.Coruja)
                ptbAnimal.Image = Resources.noctowl;
            else if (a is Animais.Gato)
                ptbAnimal.Image = Resources.glameow;
            else if (a is Animais.Gaviao)
                ptbAnimal.Image = Resources.bravary2;
            else if (a is Animais.Leao)
                ptbAnimal.Image = Resources.pyroar;
            else if (a is Animais.Morcego)
                ptbAnimal.Image = Resources.golbat;
            else if (a is Animais.Ornitorrinco)
                ptbAnimal.Image = Resources.Psyduck;
            else if (a is Animais.Pinguim)
                ptbAnimal.Image = Resources.Prinplup;
            else if (a is Animais.Pombo)
                ptbAnimal.Image = Resources.pedolv;
            else if (a is Animais.Tartaruga)
                ptbAnimal.Image = Resources.Tirtouga;
            else if (a is Animais.Tucano)
                ptbAnimal.Image = Resources.Toucannon;
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void pnlBorder_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Pokedex_Move(object sender, EventArgs e)
        {
            if (listar != null)
                listar.Location = new Point(this.Location.X + this.Width, this.Location.Y + 299);
        }

        private void pnlFundo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
