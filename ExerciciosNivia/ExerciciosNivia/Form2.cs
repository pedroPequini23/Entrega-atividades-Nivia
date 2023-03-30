using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosNivia
{
    public partial class frmenquanto : Form
    {
        public frmenquanto()
        {
            InitializeComponent();
        }

        private void lblresult_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int i, num, result;

            num = Convert.ToInt32(txtnum.Text);
            i = Convert.ToInt32(txtnum.Text);

            i = 1;

            while (i < 11)
            {
                result = num * i;
                txtresult.Text = String.Concat(txtresult.Text, "\r\n", result.ToString());
                i++;
            }


        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtresult.Clear();
            txtnum.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmexercicios fm = new frmexercicios();
            fm.Show();
        }
    }
}
