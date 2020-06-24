namespace N2_POO_ED
{
    partial class Cadastrar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.cbxEspecie = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rdbMacho = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.rdbMamifero = new System.Windows.Forms.RadioButton();
            this.rdbOviparo = new System.Windows.Forms.RadioButton();
            this.rdbAquatico = new System.Windows.Forms.RadioButton();
            this.rdbVoador = new System.Windows.Forms.RadioButton();
            this.rdbIdade = new System.Windows.Forms.RadioButton();
            this.rdbAlfabetico = new System.Windows.Forms.RadioButton();
            this.rdbPredador = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.cbxListagem = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Nascimento";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sexo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.txtDataNascimento);
            this.groupBox1.Controls.Add(this.cbxEspecie);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.rdbMacho);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 200);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(131, 160);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(121, 23);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(131, 51);
            this.txtDataNascimento.Mask = "99/99/9999";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(79, 20);
            this.txtDataNascimento.TabIndex = 1;
            // 
            // cbxEspecie
            // 
            this.cbxEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEspecie.FormattingEnabled = true;
            this.cbxEspecie.Items.AddRange(new object[] {
            "Baleia",
            "Beija-flor",
            "Cachorro",
            "Coala",
            "Coruja",
            "Gato",
            "Gavião",
            "Leão",
            "Morcego",
            "Ornitorrinco",
            "Pato",
            "Pinguim",
            "Pombo",
            "Tartaruga"});
            this.cbxEspecie.Location = new System.Drawing.Point(131, 120);
            this.cbxEspecie.Name = "cbxEspecie";
            this.cbxEspecie.Size = new System.Drawing.Size(121, 21);
            this.cbxEspecie.TabIndex = 2;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(131, 88);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(57, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Fêmea";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rdbMacho
            // 
            this.rdbMacho.AutoSize = true;
            this.rdbMacho.Location = new System.Drawing.Point(194, 86);
            this.rdbMacho.Name = "rdbMacho";
            this.rdbMacho.Size = new System.Drawing.Size(58, 17);
            this.rdbMacho.TabIndex = 5;
            this.rdbMacho.Text = "Macho";
            this.rdbMacho.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(131, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(121, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Espécie";
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(343, 227);
            this.txtTest.Multiline = true;
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(326, 188);
            this.txtTest.TabIndex = 7;
            // 
            // rdbMamifero
            // 
            this.rdbMamifero.AutoSize = true;
            this.rdbMamifero.Location = new System.Drawing.Point(343, 32);
            this.rdbMamifero.Name = "rdbMamifero";
            this.rdbMamifero.Size = new System.Drawing.Size(68, 17);
            this.rdbMamifero.TabIndex = 10;
            this.rdbMamifero.TabStop = true;
            this.rdbMamifero.Text = "Mamifero";
            this.rdbMamifero.UseVisualStyleBackColor = true;
            // 
            // rdbOviparo
            // 
            this.rdbOviparo.AutoSize = true;
            this.rdbOviparo.Location = new System.Drawing.Point(343, 75);
            this.rdbOviparo.Name = "rdbOviparo";
            this.rdbOviparo.Size = new System.Drawing.Size(62, 17);
            this.rdbOviparo.TabIndex = 11;
            this.rdbOviparo.TabStop = true;
            this.rdbOviparo.Text = "Oviparo";
            this.rdbOviparo.UseVisualStyleBackColor = true;
            // 
            // rdbAquatico
            // 
            this.rdbAquatico.AutoSize = true;
            this.rdbAquatico.Location = new System.Drawing.Point(546, 34);
            this.rdbAquatico.Name = "rdbAquatico";
            this.rdbAquatico.Size = new System.Drawing.Size(67, 17);
            this.rdbAquatico.TabIndex = 12;
            this.rdbAquatico.TabStop = true;
            this.rdbAquatico.Text = "Aquatico";
            this.rdbAquatico.UseVisualStyleBackColor = true;
            // 
            // rdbVoador
            // 
            this.rdbVoador.AutoSize = true;
            this.rdbVoador.Location = new System.Drawing.Point(445, 34);
            this.rdbVoador.Name = "rdbVoador";
            this.rdbVoador.Size = new System.Drawing.Size(59, 17);
            this.rdbVoador.TabIndex = 13;
            this.rdbVoador.TabStop = true;
            this.rdbVoador.Text = "Voador";
            this.rdbVoador.UseVisualStyleBackColor = true;
            // 
            // rdbIdade
            // 
            this.rdbIdade.AutoSize = true;
            this.rdbIdade.Location = new System.Drawing.Point(343, 119);
            this.rdbIdade.Name = "rdbIdade";
            this.rdbIdade.Size = new System.Drawing.Size(52, 17);
            this.rdbIdade.TabIndex = 14;
            this.rdbIdade.TabStop = true;
            this.rdbIdade.Text = "Idade";
            this.rdbIdade.UseVisualStyleBackColor = true;
            // 
            // rdbAlfabetico
            // 
            this.rdbAlfabetico.AutoSize = true;
            this.rdbAlfabetico.Location = new System.Drawing.Point(541, 75);
            this.rdbAlfabetico.Name = "rdbAlfabetico";
            this.rdbAlfabetico.Size = new System.Drawing.Size(72, 17);
            this.rdbAlfabetico.TabIndex = 15;
            this.rdbAlfabetico.TabStop = true;
            this.rdbAlfabetico.Text = "Alfabética";
            this.rdbAlfabetico.UseVisualStyleBackColor = true;
            // 
            // rdbPredador
            // 
            this.rdbPredador.AutoSize = true;
            this.rdbPredador.Location = new System.Drawing.Point(445, 75);
            this.rdbPredador.Name = "rdbPredador";
            this.rdbPredador.Size = new System.Drawing.Size(68, 17);
            this.rdbPredador.TabIndex = 16;
            this.rdbPredador.TabStop = true;
            this.rdbPredador.Text = "Predador";
            this.rdbPredador.UseVisualStyleBackColor = true;
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Location = new System.Drawing.Point(445, 119);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(94, 17);
            this.rdbTodos.TabIndex = 17;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos Animais";
            this.rdbTodos.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(709, 27);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 18;
            this.btnListar.Text = "button1";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(12, 249);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(75, 23);
            this.btnTodos.TabIndex = 19;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // cbxListagem
            // 
            this.cbxListagem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxListagem.FormattingEnabled = true;
            this.cbxListagem.IntegralHeight = false;
            this.cbxListagem.Location = new System.Drawing.Point(343, 174);
            this.cbxListagem.Name = "cbxListagem";
            this.cbxListagem.Size = new System.Drawing.Size(196, 21);
            this.cbxListagem.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(364, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 69);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Imagem Animal";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(364, 324);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 79);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Informações Animal";
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbxListagem);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.rdbTodos);
            this.Controls.Add(this.rdbPredador);
            this.Controls.Add(this.rdbAlfabetico);
            this.Controls.Add(this.rdbIdade);
            this.Controls.Add(this.rdbVoador);
            this.Controls.Add(this.rdbAquatico);
            this.Controls.Add(this.rdbOviparo);
            this.Controls.Add(this.rdbMamifero);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtDataNascimento;
        private System.Windows.Forms.ComboBox cbxEspecie;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rdbMacho;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.RadioButton rdbMamifero;
        private System.Windows.Forms.RadioButton rdbOviparo;
        private System.Windows.Forms.RadioButton rdbAquatico;
        private System.Windows.Forms.RadioButton rdbVoador;
        private System.Windows.Forms.RadioButton rdbIdade;
        private System.Windows.Forms.RadioButton rdbAlfabetico;
        private System.Windows.Forms.RadioButton rdbPredador;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.ComboBox cbxListagem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
    }
}