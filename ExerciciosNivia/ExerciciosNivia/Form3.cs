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
    public partial class frmrepita : Form
    {
        public frmrepita()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int num, result, i;

            num = Convert.ToInt32(txtnum.Text);
           

            i = 1;

            do
            {
                result = num * i;
               
                txtresult.Text = String.Concat(txtresult.Text, "\r\n", result.ToString());
                i++;
            } while (i < 11);
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmexercicios fm = new frmexercicios();
            fm.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtresult.Clear();
            txtnum.Focus();

        }
    }
}
