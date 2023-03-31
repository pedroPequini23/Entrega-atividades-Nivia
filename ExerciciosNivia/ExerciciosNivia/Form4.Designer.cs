namespace ExerciciosNivia
{
    partial class frmpara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpara));
            txtresult = new TextBox();
            txtnum = new TextBox();
            lblnum = new Label();
            lblresult = new Label();
            btncalcular = new Button();
            btnvoltar = new Button();
            btnlimpar = new Button();
            SuspendLayout();
            // 
            // txtresult
            // 
            txtresult.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtresult.Location = new Point(470, 185);
            txtresult.Multiline = true;
            txtresult.Name = "txtresult";
            txtresult.ReadOnly = true;
            txtresult.ScrollBars = ScrollBars.Vertical;
            txtresult.Size = new Size(205, 86);
            txtresult.TabIndex = 11;
            // 
            // txtnum
            // 
            txtnum.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtnum.Location = new Point(470, 86);
            txtnum.Multiline = true;
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(205, 23);
            txtnum.TabIndex = 8;
            // 
            // lblnum
            // 
            lblnum.AutoSize = true;
            lblnum.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblnum.Location = new Point(103, 86);
            lblnum.Name = "lblnum";
            lblnum.Size = new Size(164, 22);
            lblnum.TabIndex = 10;
            lblnum.Text = "Digite um número:";
            // 
            // lblresult
            // 
            lblresult.AutoSize = true;
            lblresult.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblresult.Location = new Point(103, 185);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(101, 22);
            lblresult.TabIndex = 9;
            lblresult.Text = "Resultado:";
            // 
            // btncalcular
            // 
            btncalcular.BackColor = SystemColors.Window;
            btncalcular.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btncalcular.Location = new Point(103, 339);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(121, 58);
            btncalcular.TabIndex = 12;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = false;
            btncalcular.Click += btncalcular_Click;
            // 
            // btnvoltar
            // 
            btnvoltar.BackColor = SystemColors.Window;
            btnvoltar.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnvoltar.Location = new Point(549, 339);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(121, 58);
            btnvoltar.TabIndex = 13;
            btnvoltar.Text = "Voltar";
            btnvoltar.UseVisualStyleBackColor = false;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.BackColor = SystemColors.Window;
            btnlimpar.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnlimpar.Location = new Point(331, 339);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(121, 58);
            btnlimpar.TabIndex = 14;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = false;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // frmpara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnlimpar);
            Controls.Add(btnvoltar);
            Controls.Add(btncalcular);
            Controls.Add(txtresult);
            Controls.Add(txtnum);
            Controls.Add(lblnum);
            Controls.Add(lblresult);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmpara";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Taubuaté até 10 PARA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtresult;
        private TextBox txtnum;
        private Label lblnum;
        private Label lblresult;
        private Button btncalcular;
        private Button btnvoltar;
        private Button btnlimpar;
    }
}