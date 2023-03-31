namespace ExerciciosNivia
{
    public partial class frmexercicios : Form
    {
        public frmexercicios()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void postoDeGasolinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmposto fm = new frmposto();
            fm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabuadaEnquantoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmenquanto fm = new frmenquanto();
            fm.Show();
        }

        private void tabuadaRepitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmrepita fm = new frmrepita();
            fm.Show();
        }

        private void tabuadaParaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmpara fm = new frmpara();
            fm.Show();
        }
    }
}