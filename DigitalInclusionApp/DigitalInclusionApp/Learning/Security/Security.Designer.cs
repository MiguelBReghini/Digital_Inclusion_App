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
            panel1.BackColor = Color.FromArgb(1, 34, 62);
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
            btnBack.Anchor = AnchorStyles.Bottom;
            btnBack.BackColor = Color.FromArgb(231, 237, 58);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            btnBack.ForeColor = Color.FromArgb(1, 34, 62);
            btnBack.Location = new Point(212, 571);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(500, 80);
            btnBack.TabIndex = 4;
            btnBack.Text = "⬅       Voltar";
            btnBack.TextAlign = ContentAlignment.MiddleLeft;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnScam
            // 
            btnScam.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            btnScam.Location = new Point(312, 248);
            btnScam.Name = "btnScam";
            btnScam.Size = new Size(300, 254);
            btnScam.TabIndex = 1;
            btnScam.Text = "Golpes";
            btnScam.TextAlign = ContentAlignment.BottomCenter;
            btnScam.UseVisualStyleBackColor = true;
            btnScam.Click += btnScam_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 80F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(128, 255, 255);
            lblTitulo.Location = new Point(170, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(584, 142);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "Security";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Segurança";
            WindowState = FormWindowState.Maximized;
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
