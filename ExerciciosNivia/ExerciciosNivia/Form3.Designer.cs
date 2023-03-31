namespace ExerciciosNivia
{
    partial class frmrepita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrepita));
            lblresult = new Label();
            lblnum = new Label();
            txtnum = new TextBox();
            txtresult = new TextBox();
            btncalcular = new Button();
            btnvoltar = new Button();
            btnlimpar = new Button();
            SuspendLayout();
            // 
            // lblresult
            // 
            lblresult.AutoSize = true;
            lblresult.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblresult.Location = new Point(99, 168);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(101, 22);
            lblresult.TabIndex = 11;
            lblresult.Text = "Resultado:";
            // 
            // lblnum
            // 
            lblnum.AutoSize = true;
            lblnum.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblnum.Location = new Point(99, 69);
            lblnum.Name = "lblnum";
            lblnum.Size = new Size(164, 22);
            lblnum.TabIndex = 12;
            lblnum.Text = "Digite um número:";
            // 
            // txtnum
            // 
            txtnum.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtnum.Location = new Point(466, 69);
            txtnum.Multiline = true;
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(205, 23);
            txtnum.TabIndex = 1;
            // 
            // txtresult
            // 
            txtresult.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtresult.Location = new Point(466, 168);
            txtresult.Multiline = true;
            txtresult.Name = "txtresult";
            txtresult.ReadOnly = true;
            txtresult.ScrollBars = ScrollBars.Vertical;
            txtresult.Size = new Size(205, 86);
            txtresult.TabIndex = 14;
            // 
            // btncalcular
            // 
            btncalcular.BackColor = SystemColors.Window;
            btncalcular.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btncalcular.Location = new Point(100, 319);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(126, 63);
            btncalcular.TabIndex = 15;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = false;
            btncalcular.Click += btncalcular_Click;
            // 
            // btnvoltar
            // 
            btnvoltar.BackColor = SystemColors.Window;
            btnvoltar.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnvoltar.Location = new Point(582, 319);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(126, 63);
            btnvoltar.TabIndex = 16;
            btnvoltar.Text = "Voltar";
            btnvoltar.UseVisualStyleBackColor = false;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.BackColor = SystemColors.Window;
            btnlimpar.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnlimpar.Location = new Point(346, 319);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(126, 63);
            btnlimpar.TabIndex = 17;
            btnlimpar.Text = "oi";
            btnlimpar.UseVisualStyleBackColor = false;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // frmrepita
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
            Name = "frmrepita";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tabuada até 10 REPITA ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblresult;
        private Label lblnum;
        private TextBox txtnum;
        private TextBox txtresult;
        private Button btncalcular;
        private Button btnvoltar;
        private Button btnlimpar;
    }
}