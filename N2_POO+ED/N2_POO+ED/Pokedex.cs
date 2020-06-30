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
        Point posicaoInicial;
        Animal animalAtual;
        bool voltar;
        bool descer;
        bool lado;
        int contadorMovimento;
        Image imagemAtaque;

        public Pokedex()
        {
            InitializeComponent();
            lblNome.Text = "";
            contadorMovimento = 0;
            voltar = false;
            descer = false;
            lado = false;
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
            AtualizarBotoes(a);
            imagemAtaque = AtualizarAtaque(a);
            animalAtual = a;
        }

        private Image AtualizarAtaque(Animal a)
        {
            if (a.GetType().GetInterfaces().Where(o => o.Name == "IAquatico").Count() > 0)
                return Resources.AtaqueOnda;
            else if (a.GetType().GetInterfaces().Where(o => o.Name == "IVoar").Count() > 0)
                return Resources.Tornado;
            else
                return Resources.lancaChamas__2_;
        }

        private void AtualizarBotoes(Animal a)
        {
            BloquearBotoes();

            if(a.GetType().GetInterfaces().Where(o => o.Name == "IOviparo").Count() > 0)
            {
                btnBotar.Enabled = true;
                btnNinho.Enabled = true;
            }

            if (a.GetType().GetInterfaces().Where(o => o.Name == "IVoar").Count() > 0)
                btnVoar.Enabled = true;

            if (a.GetType().GetInterfaces().Where(o => o.Name == "IPredador").Count() > 0)
                btnAtacar.Enabled = true;
            if (a is Mamifero)
                btnMamar.Enabled = true;

            if (a is Ave)
                btnCiscar.Enabled = true;

            if(a is Animal)
            {
                btnAndar.Enabled = true;
                btnComer.Enabled = true;
                btnFalar.Enabled = true;
            }
        }

        private void AtualizarTxt(Animal a)
        {
            txtInfo.Text = a.ToString();
        }

        private void AtualizarImagem(Animal a)
        {
            if (a.GetType().GetInterfaces().Where(o => o.Name == "IAquatico").Count() > 0 && a.GetType().Name != "Pato")
                pnlFundo.BackgroundImage = Resources.FundoAgua;
            else
                pnlFundo.BackgroundImage = Resources.FundoGrama;

            ptbAnimal.Image = GetImagePorAnimal(a);
        }

        private Image GetImagePorAnimal(Animal a)
        {

            if (a is Animais.Pato)
                return Resources.ducklett;
            else if (a is Animais.Baleia)
                return Resources.Wailord;
            else if (a is Animais.Cachorro)
                return Resources.herdier2;
            else if (a is Animais.Coala)
                return Resources.komala;
            else if (a is Animais.Coruja)
                return Resources.noctowl;
            else if (a is Animais.Gato)
                return Resources.glameow;
            else if (a is Animais.Gaviao)
                return Resources.bravary2;
            else if (a is Animais.Leao)
                return Resources.pyroar;
            else if (a is Animais.Morcego)
                return Resources.golbat;
            else if (a is Animais.Ornitorrinco)
                return Resources.Psyduck;
            else if (a is Animais.Pinguim)
                return Resources.Prinplup;
            else if (a is Animais.Pombo)
                return Resources.pedolv;
            else if (a is Animais.Tartaruga)
                return Resources.Tirtouga;
            else if (a is Animais.Tucano)
                return Resources.Toucannon;

            return null;
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

        private void button4_Click(object sender, EventArgs e)
        {
            BloquearBotoes();
            posicaoInicial = ptbAtaque.Location;
            ptbAtaque.Image = Resources.Ninho;
            tmrNinho.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ptbAtaque.BringToFront();
            BloquearBotoes();
            posicaoInicial = ptbAtaque.Location;
            ptbAtaque.Image = Resources.Berry2;
            tmrAlimento.Enabled = true;
        }

        private void BloquearBotoes()
        {
            btnAndar.Enabled = false;
            btnAtacar.Enabled = false;
            btnBotar.Enabled = false;
            btnCiscar.Enabled = false;
            btnComer.Enabled = false;
            btnFalar.Enabled = false;
            btnMamar.Enabled = false;
            btnNinho.Enabled = false;
            btnVoar.Enabled = false;
        }

        private void tmrAlimento_Tick(object sender, EventArgs e)
        {
            ptbAtaque.Location = new Point(ptbAtaque.Location.X - 3, ptbAtaque.Location.Y);

            if(ptbAtaque.Location.X < ptbAnimal.Location.X + ptbAnimal.Width - 15)
            {
                tmrAlimento.Enabled = false;
                ptbAtaque.Image = null;
                ptbAtaque.Location = posicaoInicial;
                AtualizarBotoes(animalAtual);
            }
        }

        private void btnAndar_Click(object sender, EventArgs e)
        {
            ptbAnimal.BringToFront();
            BloquearBotoes();
            posicaoInicial = ptbAnimal.Location;
            tmrMovimentar.Enabled = true;
        }

        private void tmrMovimentar_Tick(object sender, EventArgs e)
        {

            if(!voltar)
                ptbAnimal.Location = new Point(ptbAnimal.Location.X + 6, ptbAnimal.Location.Y);
            else
                ptbAnimal.Location = new Point(ptbAnimal.Location.X - 6, ptbAnimal.Location.Y);

            if (ptbAnimal.Location.X <= posicaoInicial.X)
            {
                ptbAnimal.Location = posicaoInicial;
                tmrMovimentar.Enabled = false;
                voltar = false;
                AtualizarBotoes(animalAtual);
            }
            if (ptbAnimal.Location.X > posicaoInicial.X + 50)
                voltar = true;
        }

        private void btnBotar_Click(object sender, EventArgs e)
        {
            ptbAtaque.Image = Resources.ovo;
            BloquearBotoes();
            posicaoInicial = ptbAtaque.Location;
            tmrOvo.Enabled = true;
        }

        private void tmrOvo_Tick(object sender, EventArgs e)
        {
            if (!voltar)
                ptbAtaque.Location = new Point(ptbAtaque.Location.X + 3, ptbAtaque.Location.Y);
            else
                ptbAtaque.Location = new Point(ptbAtaque.Location.X - 3, ptbAtaque.Location.Y);

            if (ptbAtaque.Location.X < posicaoInicial.X - 3)
            {
                contadorMovimento++;
                voltar = false;
            }
            if (ptbAtaque.Location.X >= posicaoInicial.X + 3)
                voltar = true;

            if(contadorMovimento == 2)
            {
                tmrOvo.Enabled = false;
                voltar = false;
                contadorMovimento = 0;
                ptbAtaque.Image = null;
                ptbAtaque.Location = posicaoInicial;
                posicaoInicial = new Point();
                AtualizarBotoes(animalAtual);
            }

        }

        private void btnCiscar_Click(object sender, EventArgs e)
        {
            BloquearBotoes();
            posicaoInicial = ptbAnimal.Location;
            tmrCiscar.Enabled = true;
        }

        private void tmrCiscar_Tick(object sender, EventArgs e)
        {
            if (!voltar)
            {
                Image img = ptbAnimal.Image;
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                ptbAnimal.Image = img;
                voltar = true;
                
            }
            else
            {
                Image img = ptbAnimal.Image;
                img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                ptbAnimal.Image = img;
                voltar = false;
                contadorMovimento++;
            }

            if(contadorMovimento == 3)
            {
                tmrCiscar.Enabled = false;
                ptbAnimal.Location = posicaoInicial;
                posicaoInicial = new Point();
                voltar = false;
                contadorMovimento = 0;
                AtualizarBotoes(animalAtual);
            }
        }

        private void btnMamar_Click(object sender, EventArgs e)
        {
            BloquearBotoes();
            ptbAtaque.Image = GetImagePorAnimal(animalAtual);
            tmrAmamentar.Enabled = true;
        }

        private void tmrAmamentar_Tick(object sender, EventArgs e)
        {
            ptbAtaque.Image = null;
            AtualizarBotoes(animalAtual);
        }

        private void tmrNinho_Tick(object sender, EventArgs e)
        {
            ptbAtaque.Image = null;
            ptbAtaque.Location = posicaoInicial;
            posicaoInicial = new Point();
            AtualizarBotoes(animalAtual);
            tmrNinho.Enabled = false;
        }

        private void btnAtacar_Click(object sender, EventArgs e)
        {
            BloquearBotoes();
            posicaoInicial = ptbAtaque.Location;
            ptbAtaque.Location = new Point(ptbAtaque.Location.X - 30, ptbAtaque.Location.Y);
            ptbAtaque.Image = imagemAtaque;
            tmrAtaque.Enabled = true;
        }

        private void tmrAtaque_Tick(object sender, EventArgs e)
        {
            ptbAtaque.Location = new Point(ptbAtaque.Location.X + 4, ptbAtaque.Location.Y);
            contadorMovimento++;

            if(contadorMovimento >10)
            {
                ptbAtaque.Image = null;
                ptbAtaque.Location = posicaoInicial;
                posicaoInicial = new Point();
                tmrAtaque.Enabled = false;
                AtualizarBotoes(animalAtual);
                contadorMovimento = 0;
            }
        }

        private void btnFalar_Click(object sender, EventArgs e)
        {
            ptbBalao.Controls.Add(lblNome);
            ptbBalao.Visible = true;
            lblNome.Location = new Point(ptbBalao.Location.X - 10, ptbBalao.Location.Y + 15);
            lblNome.Text = animalAtual.Nome;
            tmrNome.Enabled = true;
        }

        private void tmrNome_Tick(object sender, EventArgs e)
        {
            ptbBalao.Visible = false;
            lblNome.Text = "";
            AtualizarBotoes(animalAtual);
            tmrNome.Enabled = false;
        }

        private void btnVoar_Click(object sender, EventArgs e)
        {
            ptbAnimal.BringToFront();
            BloquearBotoes();
            posicaoInicial = ptbAnimal.Location;
            tmrVoar.Enabled = true;
        }

        private void tmrVoar_Tick(object sender, EventArgs e)
        {
            if(!descer && !lado && !voltar)
                ptbAnimal.Location = new Point(ptbAnimal.Location.X, ptbAnimal.Location.Y - 6);
            else if (!voltar && lado && !descer)
                ptbAnimal.Location = new Point(ptbAnimal.Location.X + 6, ptbAnimal.Location.Y);
            else if(!voltar && !lado && descer)
                ptbAnimal.Location = new Point(ptbAnimal.Location.X , ptbAnimal.Location.Y + 6);
            else if (voltar && lado && descer)
                ptbAnimal.Location = new Point(ptbAnimal.Location.X - 6, ptbAnimal.Location.Y);

            contadorMovimento++;

            if(contadorMovimento == 10)
            {
                if (!descer && !lado && !voltar)
                {
                    lado = true;
                    contadorMovimento = 0;
                }
                else if (!voltar && lado && !descer)
                {
                    lado = false;
                    voltar = false;
                    descer = true;
                    contadorMovimento = 0;
                }
                else if (!voltar && !lado && descer)
                {
                    voltar = true;
                    lado = true;
                    descer = true;
                    contadorMovimento = 0;
                }
                else
                {
                    ptbAnimal.Location = posicaoInicial;
                    lado = false;
                    descer = false;
                    voltar = false;
                    contadorMovimento = 0;
                    tmrVoar.Enabled = false;
                    AtualizarBotoes(animalAtual);
                }
            }
        }
    }
}
