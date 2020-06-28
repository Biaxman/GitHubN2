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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pokedex));
            this.label1 = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Label();
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.ptbAtaque = new System.Windows.Forms.PictureBox();
            this.ptbAnimal = new System.Windows.Forms.PictureBox();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.pnlFundo.SuspendLayout();
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
            this.pnlFundo.Controls.Add(this.ptbAtaque);
            this.pnlFundo.Controls.Add(this.ptbAnimal);
            this.pnlFundo.Location = new System.Drawing.Point(43, 170);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(292, 189);
            this.pnlFundo.TabIndex = 5;
            this.pnlFundo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFundo_Paint);
            // 
            // ptbAtaque
            // 
            this.ptbAtaque.BackColor = System.Drawing.Color.Transparent;
            this.ptbAtaque.Image = ((System.Drawing.Image)(resources.GetObject("ptbAtaque.Image")));
            this.ptbAtaque.Location = new System.Drawing.Point(96, 73);
            this.ptbAtaque.Name = "ptbAtaque";
            this.ptbAtaque.Size = new System.Drawing.Size(57, 66);
            this.ptbAtaque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbAtaque.TabIndex = 1;
            this.ptbAtaque.TabStop = false;
            // 
            // ptbAnimal
            // 
            this.ptbAnimal.BackColor = System.Drawing.Color.Transparent;
            this.ptbAnimal.Image = ((System.Drawing.Image)(resources.GetObject("ptbAnimal.Image")));
            this.ptbAnimal.Location = new System.Drawing.Point(3, 64);
            this.ptbAnimal.Name = "ptbAnimal";
            this.ptbAnimal.Size = new System.Drawing.Size(87, 85);
            this.ptbAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbAnimal.TabIndex = 0;
            this.ptbAnimal.TabStop = false;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(43, 400);
            this.txtInfo.Name = "txtInfo";
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
            // Pokedex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(399, 598);
            this.Controls.Add(this.pnlBorder);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.pnlFundo);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Pokedex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "tet";
            this.Move += new System.EventHandler(this.Pokedex_Move);
            this.pnlFundo.ResumeLayout(false);
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
    }
}