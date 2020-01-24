using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastCare.Telas.Ranking
{
    public partial class frmAvaliacao : Form
    {
        public frmAvaliacao()
        {
            InitializeComponent();
        }


        private void imgStar1_Click(object sender, EventArgs e)
        {
            imgStar1.Image = Properties.Resources.StarFull1;
            imgStar2.Image = Properties.Resources.StarNull1;
            imgStar3.Image = Properties.Resources.StarNull1;
            imgStar4.Image = Properties.Resources.StarNull1;
            imgStar5.Image = Properties.Resources.StarNull1;
        }

        private void imgStar2_Click(object sender, EventArgs e)
        {
            imgStar1.Image = Properties.Resources.StarFull1;
            imgStar2.Image = Properties.Resources.StarFull1;
            imgStar3.Image = Properties.Resources.StarNull1;
            imgStar4.Image = Properties.Resources.StarNull1;
            imgStar5.Image = Properties.Resources.StarNull1;
        }

        private void imgStar3_Click(object sender, EventArgs e)
        {
            imgStar1.Image = Properties.Resources.StarFull1;
            imgStar2.Image = Properties.Resources.StarFull1;
            imgStar3.Image = Properties.Resources.StarFull1;
            imgStar4.Image = Properties.Resources.StarNull1;
            imgStar5.Image = Properties.Resources.StarNull1;
        }

        private void imgStar4_Click(object sender, EventArgs e)
        {
            imgStar1.Image = Properties.Resources.StarFull1;
            imgStar2.Image = Properties.Resources.StarFull1;
            imgStar3.Image = Properties.Resources.StarFull1;
            imgStar4.Image = Properties.Resources.StarFull1;
            imgStar5.Image = Properties.Resources.StarNull1;
        }

        private void imgStar5_Click(object sender, EventArgs e)
        {
            imgStar1.Image = Properties.Resources.StarFull1;
            imgStar2.Image = Properties.Resources.StarFull1;
            imgStar3.Image = Properties.Resources.StarFull1;
            imgStar4.Image = Properties.Resources.StarFull1;
            imgStar5.Image = Properties.Resources.StarFull1;
        }
    }
}
