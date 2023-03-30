namespace ExerciciosNivia
{
    partial class frmenquanto
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
            btncalcular = new Button();
            btnvoltar = new Button();
            btnlimpar = new Button();
            lblresult = new Label();
            lblnum = new Label();
            txtnum = new TextBox();
            txtresult = new TextBox();
            SuspendLayout();
            // 
            // btncalcular
            // 
            btncalcular.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btncalcular.Location = new Point(89, 326);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(131, 67);
            btncalcular.TabIndex = 0;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // btnvoltar
            // 
            btnvoltar.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnvoltar.Location = new Point(561, 326);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(131, 67);
            btnvoltar.TabIndex = 1;
            btnvoltar.Text = "Voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnlimpar.Location = new Point(336, 326);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(131, 67);
            btnlimpar.TabIndex = 2;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // lblresult
            // 
            lblresult.AutoSize = true;
            lblresult.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblresult.Location = new Point(89, 180);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(101, 22);
            lblresult.TabIndex = 4;
            lblresult.Text = "Resultado:";
            lblresult.Click += lblresult_Click;
            // 
            // lblnum
            // 
            lblnum.AutoSize = true;
            lblnum.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblnum.Location = new Point(89, 81);
            lblnum.Name = "lblnum";
            lblnum.Size = new Size(164, 22);
            lblnum.TabIndex = 5;
            lblnum.Text = "Digite um número:";
            // 
            // txtnum
            // 
            txtnum.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtnum.Location = new Point(456, 81);
            txtnum.Multiline = true;
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(205, 23);
            txtnum.TabIndex = 6;
            // 
            // txtresult
            // 
            txtresult.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtresult.Location = new Point(456, 180);
            txtresult.Multiline = true;
            txtresult.Name = "txtresult";
            txtresult.ReadOnly = true;
            txtresult.ScrollBars = ScrollBars.Vertical;
            txtresult.Size = new Size(205, 86);
            txtresult.TabIndex = 7;
            // 
            // frmenquanto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtresult);
            Controls.Add(txtnum);
            Controls.Add(lblnum);
            Controls.Add(lblresult);
            Controls.Add(btnlimpar);
            Controls.Add(btnvoltar);
            Controls.Add(btncalcular);
            Name = "frmenquanto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tabuada até 10 ENQUANTO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalcular;
        private Button btnvoltar;
        private Button btnlimpar;
        private Label lblresult;
        private Label lblnum;
        private TextBox txtnum;
        private TextBox txtresult;
    }
}