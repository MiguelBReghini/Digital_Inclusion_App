namespace DigitalInclusionApp
{
    partial class Learning
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
            panel1 = new Panel();
            btnBack = new Button();
            btnSecurity = new Button();
            btnInformatics = new Button();
            lblTitulo = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 34, 62);
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnSecurity);
            panel1.Controls.Add(btnInformatics);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(924, 700);
            panel1.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.BackColor = Color.FromArgb(231, 237, 58);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 39.75F, FontStyle.Bold);
            btnBack.ForeColor = Color.FromArgb(1, 34, 62);
            btnBack.Location = new Point(215, 569);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(500, 80);
            btnBack.TabIndex = 4;
            btnBack.Text = "⬅       Voltar";
            btnBack.TextAlign = ContentAlignment.MiddleLeft;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSecurity
            // 
            btnSecurity.Anchor = AnchorStyles.Left;
            btnSecurity.Font = new Font("Segoe UI", 39.75F, FontStyle.Bold);
            btnSecurity.Location = new Point(520, 246);
            btnSecurity.Name = "btnSecurity";
            btnSecurity.Size = new Size(300, 254);
            btnSecurity.TabIndex = 3;
            btnSecurity.Text = "Segurança";
            btnSecurity.TextAlign = ContentAlignment.BottomCenter;
            btnSecurity.UseVisualStyleBackColor = true;
            btnSecurity.Click += btnSecurity_Click;
            // 
            // btnInformatics
            // 
            btnInformatics.Anchor = AnchorStyles.Left;
            btnInformatics.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnInformatics.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            btnInformatics.Location = new Point(104, 246);
            btnInformatics.Name = "btnInformatics";
            btnInformatics.Size = new Size(300, 254);
            btnInformatics.TabIndex = 1;
            btnInformatics.Text = "Informática";
            btnInformatics.TextAlign = ContentAlignment.BottomCenter;
            btnInformatics.UseVisualStyleBackColor = true;
            btnInformatics.Click += btnInformatics_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 80F, FontStyle.Bold | FontStyle.Underline);
            lblTitulo.ForeColor = Color.FromArgb(58, 237, 213);
            lblTitulo.Location = new Point(199, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(526, 142);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Aprenda!";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // Learning
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(924, 700);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Learning";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aprender";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnBack;
        private Button btnSecurity;
        private Button btnInformatics;
        private Label lblTitulo;
    }
}
