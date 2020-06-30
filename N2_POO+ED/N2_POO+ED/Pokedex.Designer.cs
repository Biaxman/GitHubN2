namespace N2_POO_ED
{
    partial class Pokedex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pokedex));
            this.label1 = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Label();
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.ptbBalao = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.ptbAtaque = new System.Windows.Forms.PictureBox();
            this.ptbAnimal = new System.Windows.Forms.PictureBox();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.lblFechar = new System.Windows.Forms.Label();
            this.btnComer = new System.Windows.Forms.Button();
            this.btnAndar = new System.Windows.Forms.Button();
            this.btnFalar = new System.Windows.Forms.Button();
            this.btnNinho = new System.Windows.Forms.Button();
            this.btnCiscar = new System.Windows.Forms.Button();
            this.btnMamar = new System.Windows.Forms.Button();
            this.btnBotar = new System.Windows.Forms.Button();
            this.btnVoar = new System.Windows.Forms.Button();
            this.btnAtacar = new System.Windows.Forms.Button();
            this.tmrAlimento = new System.Windows.Forms.Timer(this.components);
            this.tmrMovimentar = new System.Windows.Forms.Timer(this.components);
            this.tmrOvo = new System.Windows.Forms.Timer(this.components);
            this.tmrCiscar = new System.Windows.Forms.Timer(this.components);
            this.tmrAmamentar = new System.Windows.Forms.Timer(this.components);
            this.tmrNinho = new System.Windows.Forms.Timer(this.components);
            this.tmrAtaque = new System.Windows.Forms.Timer(this.components);
            this.tmrNome = new System.Windows.Forms.Timer(this.components);
            this.tmrVoar = new System.Windows.Forms.Timer(this.components);
            this.pnlFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBalao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAtaque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "\r\nCadastrar\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnListar
            // 
            this.btnListar.AutoSize = true;
            this.btnListar.BackColor = System.Drawing.Color.Transparent;
            this.btnListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(102, 59);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(46, 45);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "\r\n   Listar\r\n\r\n";
            this.btnListar.Click += new System.EventHandler(this.label2_Click);
            // 
            // pnlFundo
            // 
            this.pnlFundo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFundo.BackgroundImage")));
            this.pnlFundo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFundo.Controls.Add(this.lblNome);
            this.pnlFundo.Controls.Add(this.ptbBalao);
            this.pnlFundo.Controls.Add(this.ptbAtaque);
            this.pnlFundo.Controls.Add(this.ptbAnimal);
            this.pnlFundo.Location = new System.Drawing.Point(43, 170);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(292, 189);
            this.pnlFundo.TabIndex = 5;
            this.pnlFundo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFundo_Paint);
            // 
            // ptbBalao
            // 
            this.ptbBalao.BackColor = System.Drawing.Color.Transparent;
            this.ptbBalao.BackgroundImage = global::N2_POO_ED.Properties.Resources.balaoFala;
            this.ptbBalao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbBalao.Location = new System.Drawing.Point(34, 3);
            this.ptbBalao.Name = "ptbBalao";
            this.ptbBalao.Size = new System.Drawing.Size(141, 79);
            this.ptbBalao.TabIndex = 2;
            this.ptbBalao.TabStop = false;
            this.ptbBalao.Visible = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(49, 26);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(13, 20);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = ".";
            // 
            // ptbAtaque
            // 
            this.ptbAtaque.BackColor = System.Drawing.Color.Transparent;
            this.ptbAtaque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbAtaque.Image = ((System.Drawing.Image)(resources.GetObject("ptbAtaque.Image")));
            this.ptbAtaque.Location = new System.Drawing.Point(153, 113);
            this.ptbAtaque.Name = "ptbAtaque";
            this.ptbAtaque.Size = new System.Drawing.Size(78, 73);
            this.ptbAtaque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbAtaque.TabIndex = 1;
            this.ptbAtaque.TabStop = false;
            // 
            // ptbAnimal
            // 
            this.ptbAnimal.BackColor = System.Drawing.Color.Transparent;
            this.ptbAnimal.Image = ((System.Drawing.Image)(resources.GetObject("ptbAnimal.Image")));
            this.ptbAnimal.Location = new System.Drawing.Point(3, 79);
            this.ptbAnimal.Name = "ptbAnimal";
            this.ptbAnimal.Size = new System.Drawing.Size(124, 109);
            this.ptbAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbAnimal.TabIndex = 0;
            this.ptbAnimal.TabStop = false;
            // 
            // txtInfo
            // 
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.Location = new System.Drawing.Point(43, 400);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(153, 134);
            this.txtInfo.TabIndex = 6;
            this.txtInfo.Text = "";
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.Color.Transparent;
            this.pnlBorder.Location = new System.Drawing.Point(-1, 0);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(401, 14);
            this.pnlBorder.TabIndex = 7;
            this.pnlBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBorder_MouseDown);
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.BackColor = System.Drawing.Color.Transparent;
            this.lblFechar.Location = new System.Drawing.Point(291, 32);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(14, 13);
            this.lblFechar.TabIndex = 8;
            this.lblFechar.Text = "X";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            // 
            // btnComer
            // 
            this.btnComer.BackgroundImage = global::N2_POO_ED.Properties.Resources.Berry;
            this.btnComer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnComer.Enabled = false;
            this.btnComer.Location = new System.Drawing.Point(207, 409);
            this.btnComer.Name = "btnComer";
            this.btnComer.Size = new System.Drawing.Size(35, 35);
            this.btnComer.TabIndex = 9;
            this.btnComer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAndar
            // 
            this.btnAndar.BackgroundImage = global::N2_POO_ED.Properties.Resources.Andar;
            this.btnAndar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAndar.Enabled = false;
            this.btnAndar.Location = new System.Drawing.Point(248, 409);
            this.btnAndar.Name = "btnAndar";
            this.btnAndar.Size = new System.Drawing.Size(35, 35);
            this.btnAndar.TabIndex = 10;
            this.btnAndar.Click += new System.EventHandler(this.btnAndar_Click);
            // 
            // btnFalar
            // 
            this.btnFalar.BackgroundImage = global::N2_POO_ED.Properties.Resources.Autofalante;
            this.btnFalar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFalar.Enabled = false;
            this.btnFalar.Location = new System.Drawing.Point(289, 409);
            this.btnFalar.Name = "btnFalar";
            this.btnFalar.Size = new System.Drawing.Size(35, 35);
            this.btnFalar.TabIndex = 11;
            this.btnFalar.Click += new System.EventHandler(this.btnFalar_Click);
            // 
            // btnNinho
            // 
            this.btnNinho.BackgroundImage = global::N2_POO_ED.Properties.Resources.Ninho;
            this.btnNinho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNinho.Enabled = false;
            this.btnNinho.Location = new System.Drawing.Point(289, 450);
            this.btnNinho.Name = "btnNinho";
            this.btnNinho.Size = new System.Drawing.Size(35, 35);
            this.btnNinho.TabIndex = 14;
            this.btnNinho.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCiscar
            // 
            this.btnCiscar.BackgroundImage = global::N2_POO_ED.Properties.Resources.iconfinder_03_twitter_104501;
            this.btnCiscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCiscar.Enabled = false;
            this.btnCiscar.Location = new System.Drawing.Point(248, 450);
            this.btnCiscar.Name = "btnCiscar";
            this.btnCiscar.Size = new System.Drawing.Size(35, 35);
            this.btnCiscar.TabIndex = 13;
            this.btnCiscar.Click += new System.EventHandler(this.btnCiscar_Click);
            // 
            // btnMamar
            // 
            this.btnMamar.BackgroundImage = global::N2_POO_ED.Properties.Resources.mamadeira;
            this.btnMamar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMamar.Enabled = false;
            this.btnMamar.Location = new System.Drawing.Point(207, 450);
            this.btnMamar.Name = "btnMamar";
            this.btnMamar.Size = new System.Drawing.Size(35, 35);
            this.btnMamar.TabIndex = 12;
            this.btnMamar.Click += new System.EventHandler(this.btnMamar_Click);
            // 
            // btnBotar
            // 
            this.btnBotar.BackgroundImage = global::N2_POO_ED.Properties.Resources.ovo;
            this.btnBotar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBotar.Enabled = false;
            this.btnBotar.Location = new System.Drawing.Point(289, 491);
            this.btnBotar.Name = "btnBotar";
            this.btnBotar.Size = new System.Drawing.Size(35, 35);
            this.btnBotar.TabIndex = 17;
            this.btnBotar.Click += new System.EventHandler(this.btnBotar_Click);
            // 
            // btnVoar
            // 
            this.btnVoar.BackgroundImage = global::N2_POO_ED.Properties.Resources.Iconeasa;
            this.btnVoar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoar.Enabled = false;
            this.btnVoar.Location = new System.Drawing.Point(248, 491);
            this.btnVoar.Name = "btnVoar";
            this.btnVoar.Size = new System.Drawing.Size(35, 35);
            this.btnVoar.TabIndex = 16;
            this.btnVoar.Click += new System.EventHandler(this.btnVoar_Click);
            // 
            // btnAtacar
            // 
            this.btnAtacar.BackgroundImage = global::N2_POO_ED.Properties.Resources.espada;
            this.btnAtacar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtacar.Enabled = false;
            this.btnAtacar.Location = new System.Drawing.Point(207, 491);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(35, 35);
            this.btnAtacar.TabIndex = 15;
            this.btnAtacar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAtacar.Click += new System.EventHandler(this.btnAtacar_Click);
            // 
            // tmrAlimento
            // 
            this.tmrAlimento.Interval = 50;
            this.tmrAlimento.Tick += new System.EventHandler(this.tmrAlimento_Tick);
            // 
            // tmrMovimentar
            // 
            this.tmrMovimentar.Tick += new System.EventHandler(this.tmrMovimentar_Tick);
            // 
            // tmrOvo
            // 
            this.tmrOvo.Interval = 500;
            this.tmrOvo.Tick += new System.EventHandler(this.tmrOvo_Tick);
            // 
            // tmrCiscar
            // 
            this.tmrCiscar.Interval = 500;
            this.tmrCiscar.Tick += new System.EventHandler(this.tmrCiscar_Tick);
            // 
            // tmrAmamentar
            // 
            this.tmrAmamentar.Interval = 2000;
            this.tmrAmamentar.Tick += new System.EventHandler(this.tmrAmamentar_Tick);
            // 
            // tmrNinho
            // 
            this.tmrNinho.Interval = 2000;
            this.tmrNinho.Tick += new System.EventHandler(this.tmrNinho_Tick);
            // 
            // tmrAtaque
            // 
            this.tmrAtaque.Tick += new System.EventHandler(this.tmrAtaque_Tick);
            // 
            // tmrNome
            // 
            this.tmrNome.Interval = 1500;
            this.tmrNome.Tick += new System.EventHandler(this.tmrNome_Tick);
            // 
            // tmrVoar
            // 
            this.tmrVoar.Tick += new System.EventHandler(this.tmrVoar_Tick);
            // 
            // Pokedex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(399, 598);
            this.Controls.Add(this.btnBotar);
            this.Controls.Add(this.btnVoar);
            this.Controls.Add(this.btnAtacar);
            this.Controls.Add(this.btnNinho);
            this.Controls.Add(this.btnCiscar);
            this.Controls.Add(this.btnMamar);
            this.Controls.Add(this.btnFalar);
            this.Controls.Add(this.btnAndar);
            this.Controls.Add(this.btnComer);
            this.Controls.Add(this.lblFechar);
            this.Controls.Add(this.pnlBorder);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.pnlFundo);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Pokedex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Pokedex";
            this.Move += new System.EventHandler(this.Pokedex_Move);
            this.pnlFundo.ResumeLayout(false);
            this.pnlFundo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBalao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAtaque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnListar;
        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.PictureBox ptbAnimal;
        private System.Windows.Forms.PictureBox ptbAtaque;
        private System.Windows.Forms.RichTextBox txtInfo;
        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.Button btnComer;
        private System.Windows.Forms.Button btnAndar;
        private System.Windows.Forms.Button btnFalar;
        private System.Windows.Forms.Button btnNinho;
        private System.Windows.Forms.Button btnCiscar;
        private System.Windows.Forms.Button btnMamar;
        private System.Windows.Forms.Button btnBotar;
        private System.Windows.Forms.Button btnVoar;
        private System.Windows.Forms.Button btnAtacar;
        private System.Windows.Forms.Timer tmrAlimento;
        private System.Windows.Forms.Timer tmrMovimentar;
        private System.Windows.Forms.Timer tmrOvo;
        private System.Windows.Forms.Timer tmrCiscar;
        private System.Windows.Forms.Timer tmrAmamentar;
        private System.Windows.Forms.Timer tmrNinho;
        private System.Windows.Forms.Timer tmrAtaque;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox ptbBalao;
        private System.Windows.Forms.Timer tmrNome;
        private System.Windows.Forms.Timer tmrVoar;
    }
}