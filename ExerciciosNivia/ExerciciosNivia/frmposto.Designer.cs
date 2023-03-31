namespace ExerciciosNivia
{
    partial class frmposto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmposto));
            lbllitros = new Label();
            lbltipo = new Label();
            btncalcular = new Button();
            btnvoltar = new Button();
            btnlimpar = new Button();
            lbltipoblz = new Label();
            txttotal = new TextBox();
            lbltotal = new Label();
            txtlitros = new TextBox();
            txttipo = new TextBox();
            SuspendLayout();
            // 
            // lbllitros
            // 
            lbllitros.AutoSize = true;
            lbllitros.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbllitros.ForeColor = Color.Black;
            lbllitros.Location = new Point(91, 73);
            lbllitros.Name = "lbllitros";
            lbllitros.Size = new Size(328, 18);
            lbllitros.TabIndex = 0;
            lbllitros.Text = "Digite a quantidade de litros obtidos:";
            // 
            // lbltipo
            // 
            lbltipo.AutoSize = true;
            lbltipo.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbltipo.ForeColor = Color.Black;
            lbltipo.Location = new Point(91, 119);
            lbltipo.Name = "lbltipo";
            lbltipo.Size = new Size(253, 18);
            lbltipo.TabIndex = 1;
            lbltipo.Text = "Digite o tipo de combustível:";
            lbltipo.Click += lbltipo_Click;
            // 
            // btncalcular
            // 
            btncalcular.BackColor = Color.WhiteSmoke;
            btncalcular.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btncalcular.Location = new Point(91, 332);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(122, 66);
            btncalcular.TabIndex = 2;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = false;
            btncalcular.Click += btncalcular_Click;
            // 
            // btnvoltar
            // 
            btnvoltar.BackColor = Color.WhiteSmoke;
            btnvoltar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnvoltar.Location = new Point(554, 332);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(122, 66);
            btnvoltar.TabIndex = 3;
            btnvoltar.Text = "Voltar";
            btnvoltar.UseVisualStyleBackColor = false;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.BackColor = Color.WhiteSmoke;
            btnlimpar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnlimpar.Location = new Point(320, 332);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(122, 66);
            btnlimpar.TabIndex = 4;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = false;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // lbltipoblz
            // 
            lbltipoblz.AutoSize = true;
            lbltipoblz.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbltipoblz.ForeColor = Color.Black;
            lbltipoblz.Location = new Point(91, 147);
            lbltipoblz.Name = "lbltipoblz";
            lbltipoblz.Size = new Size(220, 18);
            lbltipoblz.TabIndex = 5;
            lbltipoblz.Text = " A= Álcool e G= Gasolina";
            // 
            // txttotal
            // 
            txttotal.Enabled = false;
            txttotal.Location = new Point(474, 232);
            txttotal.Name = "txttotal";
            txttotal.ReadOnly = true;
            txttotal.Size = new Size(202, 23);
            txttotal.TabIndex = 7;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbltotal.ForeColor = Color.Black;
            lbltotal.Location = new Point(91, 232);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(59, 18);
            lbltotal.TabIndex = 9;
            lbltotal.Text = "Total:";
            // 
            // txtlitros
            // 
            txtlitros.Location = new Point(474, 68);
            txtlitros.Name = "txtlitros";
            txtlitros.Size = new Size(202, 23);
            txtlitros.TabIndex = 1;
            // 
            // txttipo
            // 
            txttipo.Location = new Point(474, 130);
            txttipo.Name = "txttipo";
            txttipo.Size = new Size(202, 23);
            txttipo.TabIndex = 11;
            // 
            // frmposto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txttipo);
            Controls.Add(txtlitros);
            Controls.Add(lbltotal);
            Controls.Add(txttotal);
            Controls.Add(lbltipoblz);
            Controls.Add(btnlimpar);
            Controls.Add(btnvoltar);
            Controls.Add(btncalcular);
            Controls.Add(lbltipo);
            Controls.Add(lbllitros);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmposto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Posto de Gasolina";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbllitros;
        private Label lbltipo;
        private Button btncalcular;
        private Button btnvoltar;
        private Button btnlimpar;
        private Label lbltipoblz;
        private TextBox txttotal;
        private Label lbltotal;
        private TextBox txtlitros;
        private TextBox txttipo;
    }
}