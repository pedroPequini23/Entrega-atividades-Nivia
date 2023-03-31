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
    public partial class frmpara : Form
    {
        public frmpara()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int i, num, result;

            num = Convert.ToInt32(txtnum.Text);

            for (i = 0; i <= 10; i++)
            {
                result = num * i;
                txtresult.Text = String.Concat(txtresult.Text, "\r\n", result.ToString());
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
