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
            panel1.BackColor = Color.Navy;
            panel1.BackgroundImage = Properties.Resources._1280;
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
            btnBack.Font = new Font("Segoe UI", 39.75F, FontStyle.Bold);
            btnBack.Location = new Point(215, 569);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(500, 80);
            btnBack.TabIndex = 4;
            btnBack.Text = "Voltar";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSecurity
            // 
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
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 80F, FontStyle.Bold);
            lblTitulo.ForeColor = SystemColors.GradientActiveCaption;
            lblTitulo.Location = new Point(199, 46);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(526, 142);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Aprenda!";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Learning
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(924, 700);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Learning";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aprender";
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
