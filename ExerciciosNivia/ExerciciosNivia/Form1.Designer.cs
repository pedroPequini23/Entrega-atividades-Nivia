namespace ExerciciosNivia
{
    partial class frmexercicios
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmexercicios));
            menuStrip1 = new MenuStrip();
            programsToolStripMenuItem = new ToolStripMenuItem();
            postoDeGasolinaToolStripMenuItem = new ToolStripMenuItem();
            tabuadaEnquantoToolStripMenuItem = new ToolStripMenuItem();
            tabuadaRepitaToolStripMenuItem = new ToolStripMenuItem();
            tabuadaParaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { programsToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // programsToolStripMenuItem
            // 
            programsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { postoDeGasolinaToolStripMenuItem, tabuadaEnquantoToolStripMenuItem, tabuadaRepitaToolStripMenuItem, tabuadaParaToolStripMenuItem });
            programsToolStripMenuItem.Name = "programsToolStripMenuItem";
            programsToolStripMenuItem.Size = new Size(70, 20);
            programsToolStripMenuItem.Text = "Programs";
            // 
            // postoDeGasolinaToolStripMenuItem
            // 
            postoDeGasolinaToolStripMenuItem.Name = "postoDeGasolinaToolStripMenuItem";
            postoDeGasolinaToolStripMenuItem.Size = new Size(172, 22);
            postoDeGasolinaToolStripMenuItem.Text = "Posto de Gasolina";
            postoDeGasolinaToolStripMenuItem.Click += postoDeGasolinaToolStripMenuItem_Click;
            // 
            // tabuadaEnquantoToolStripMenuItem
            // 
            tabuadaEnquantoToolStripMenuItem.Name = "tabuadaEnquantoToolStripMenuItem";
            tabuadaEnquantoToolStripMenuItem.Size = new Size(172, 22);
            tabuadaEnquantoToolStripMenuItem.Text = "Tabuada Enquanto";
            tabuadaEnquantoToolStripMenuItem.Click += tabuadaEnquantoToolStripMenuItem_Click;
            // 
            // tabuadaRepitaToolStripMenuItem
            // 
            tabuadaRepitaToolStripMenuItem.Name = "tabuadaRepitaToolStripMenuItem";
            tabuadaRepitaToolStripMenuItem.Size = new Size(172, 22);
            tabuadaRepitaToolStripMenuItem.Text = "Tabuada Repita";
            tabuadaRepitaToolStripMenuItem.Click += tabuadaRepitaToolStripMenuItem_Click;
            // 
            // tabuadaParaToolStripMenuItem
            // 
            tabuadaParaToolStripMenuItem.Name = "tabuadaParaToolStripMenuItem";
            tabuadaParaToolStripMenuItem.Size = new Size(172, 22);
            tabuadaParaToolStripMenuItem.Text = "Tabuada Para";
            tabuadaParaToolStripMenuItem.Click += tabuadaParaToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // frmexercicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImage = Properties.Resources.caveira;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "frmexercicios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exercícios";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem programsToolStripMenuItem;
        private ToolStripMenuItem postoDeGasolinaToolStripMenuItem;
        private ToolStripMenuItem tabuadaEnquantoToolStripMenuItem;
        private ToolStripMenuItem tabuadaRepitaToolStripMenuItem;
        private ToolStripMenuItem tabuadaParaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}