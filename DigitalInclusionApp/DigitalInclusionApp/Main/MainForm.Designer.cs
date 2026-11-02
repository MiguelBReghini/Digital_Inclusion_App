namespace DigitalInclusionApp
{
    partial class MainForm
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
            panel1 = new Panel();
            btnSair = new Button();
            panel3 = new Panel();
            lblTitulo = new Label();
            btnCreditos = new Button();
            btnAprender = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 34, 62);
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnCreditos);
            panel1.Controls.Add(btnAprender);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1188, 700);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Bottom;
            btnSair.BackColor = Color.FromArgb(237, 58, 82);
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 60F, FontStyle.Bold);
            btnSair.ForeColor = Color.FromArgb(1, 34, 62);
            btnSair.Location = new Point(600, 390);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(470, 244);
            btnSair.TabIndex = 4;
            btnSair.Text = "❌       Sair";
            btnSair.TextAlign = ContentAlignment.MiddleLeft;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblTitulo);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1188, 162);
            panel3.TabIndex = 6;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 90F, FontStyle.Bold | FontStyle.Underline);
            lblTitulo.ForeColor = Color.PaleTurquoise;
            lblTitulo.Location = new Point(173, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(839, 159);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "ConectaIdade";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCreditos
            // 
            btnCreditos.BackColor = Color.FromArgb(171, 237, 58);
            btnCreditos.FlatStyle = FlatStyle.Flat;
            btnCreditos.Font = new Font("Segoe UI", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreditos.ForeColor = Color.FromArgb(1, 34, 62);
            btnCreditos.Location = new Point(118, 390);
            btnCreditos.Name = "btnCreditos";
            btnCreditos.Size = new Size(476, 244);
            btnCreditos.TabIndex = 3;
            btnCreditos.Text = "👤 Créditos";
            btnCreditos.UseVisualStyleBackColor = false;
            btnCreditos.Click += btnCreditos_Click;
            // 
            // btnAprender
            // 
            btnAprender.BackColor = Color.FromArgb(58, 237, 213);
            btnAprender.FlatStyle = FlatStyle.Flat;
            btnAprender.Font = new Font("Segoe UI", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAprender.ForeColor = Color.FromArgb(1, 34, 62);
            btnAprender.Location = new Point(118, 168);
            btnAprender.Name = "btnAprender";
            btnAprender.Size = new Size(952, 204);
            btnAprender.TabIndex = 1;
            btnAprender.Text = "📖 Aprender";
            btnAprender.UseVisualStyleBackColor = false;
            btnAprender.Click += btnAprender_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1188, 700);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAprender;
        private Label lblTitulo;
        private Button btnSair;
        private Button btnCreditos;
        private Panel panel3;
    }
}
