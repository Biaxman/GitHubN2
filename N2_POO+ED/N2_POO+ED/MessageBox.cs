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
    public partial class MessageBox : Form
    {
        public MessageBox(string message)
        {
            InitializeComponent();
            lblMensagem.Text = message;
        }

        private void pcbVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
