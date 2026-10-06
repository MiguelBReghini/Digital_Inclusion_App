namespace DigitalInclusionApp
{
    partial class Security
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false;</param>
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
            panel1 = new Panel();
            btnBack = new Button();
            btnScam = new Button();
            lblTitulo = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 11, 174);
            panel1.BackgroundImage = Properties.Resources.Fundo_Abstrato_Azul_com_Ondas_Fluídas;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnScam);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(924, 700);
            panel1.TabIndex = 3;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 32F);
            btnBack.Location = new Point(212, 569);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(500, 80);
            btnBack.TabIndex = 4;
            btnBack.Text = "Voltar";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnScam
            // 
            btnScam.Font = new Font("Segoe UI", 28F);
            btnScam.Location = new Point(312, 300);
            btnScam.Name = "btnScam";
            btnScam.Size = new Size(300, 200);
            btnScam.TabIndex = 1;
            btnScam.Text = "Golpes";
            btnScam.TextAlign = ContentAlignment.BottomCenter;
            btnScam.UseVisualStyleBackColor = true;
            btnScam.Click += btnScam_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 60F, FontStyle.Bold);
            lblTitulo.ForeColor = SystemColors.GradientActiveCaption;
            lblTitulo.Location = new Point(200, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(524, 106);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Segurança";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Security
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(924, 700);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Security";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Segurança";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnBack;
        private Button btnScam;
        private Label lblTitulo;
    }
}
