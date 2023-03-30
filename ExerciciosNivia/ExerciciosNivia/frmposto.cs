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
    public partial class frmposto : Form
    {
        public frmposto()
        {
            InitializeComponent();
        }

        private void lbltipo_Click(object sender, EventArgs e)
        {

        }

        private void txttipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double litro, total;
            string tipo;

            litro = Convert.ToDouble(txtlitros.Text);
            tipo = Convert.ToString(txttipo.Text);

            if (tipo.Equals("A"))
            {
                if (litro > 20)
                {
                    total = litro * (4.30 - (4.30 * 5 / 100));
                    txttotal.Text = total.ToString();
                }
                else
                {
                    total = litro * (4.30 - (4.30 * 3 / 100)); ;
                    txttotal.Text = total.ToString();
                }
            }
            else if (tipo.Equals("G"))
            {
                if (litro > 20)
                {
                    total = litro * (5.30 - (5.30 * 6 / 100));
                    txttotal.Text = total.ToString();
                }
                else
                {
                    total = litro * (5.30 - (5.30 * 4 / 100));
                    txttotal.Text = total.ToString();
                }

            }

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txttotal.Clear();
            txttipo.Clear();
            txtlitros.Clear();
            txtlitros.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmexercicios fm = new frmexercicios();
            fm.Show();
        }
    }
}
