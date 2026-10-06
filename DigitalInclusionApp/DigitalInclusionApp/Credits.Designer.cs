namespace DigitalInclusionApp
{
    partial class Credits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credits));
            panel1 = new Panel();
            btnBack = new Button();
            lblTitulo = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 11, 174);
            panel1.BackgroundImage = Properties.Resources.Fundo_Abstrato_Azul_com_Ondas_Fluídas;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btnBack);
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
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            lblTitulo.ForeColor = SystemColors.GradientActiveCaption;
            lblTitulo.Location = new Point(300, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(324, 80);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Créditos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.AllowDrop = true;
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.FromArgb(240, 240, 240);
            textBox1.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(50, 130);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ShortcutsEnabled = false;
            textBox1.Size = new Size(824, 80);
            textBox1.TabIndex = 5;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // textBox2
            // 
            textBox2.AllowDrop = true;
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = Color.FromArgb(240, 240, 240);
            textBox2.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(50, 230);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.ShortcutsEnabled = false;
            textBox2.Size = new Size(824, 80);
            textBox2.TabIndex = 6;
            textBox2.Text = "Desenvolvimento: Felipe Juliano dos Santos, Miguel Bricailo Reghini e Pedro Henrique Zanella";
            // 
            // Credits
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(924, 700);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Credits";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Credits";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnBack;
        private Label lblTitulo;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
