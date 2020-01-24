using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastCare.Telas.Outros
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (timer1.Enabled == true)
            {
                frmLogar tela = new frmLogar();
                tela.Show();
                Hide();
            }
               timer1.Enabled = false;
             
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

    }
}
