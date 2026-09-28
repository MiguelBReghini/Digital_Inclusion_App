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
            btnCreditos = new Button();
            btnAprender = new Button();
            lblTitulo = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnCreditos);
            panel1.Controls.Add(btnAprender);
            panel1.Controls.Add(lblTitulo);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1586, 864);
            panel1.TabIndex = 0;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI", 48F);
            btnSair.Location = new Point(543, 709);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(500, 98);
            btnSair.TabIndex = 4;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnCreditos
            // 
            btnCreditos.Font = new Font("Segoe UI", 72F);
            btnCreditos.Location = new Point(543, 444);
            btnCreditos.Name = "btnCreditos";
            btnCreditos.Size = new Size(500, 177);
            btnCreditos.TabIndex = 3;
            btnCreditos.Text = "Créditos";
            btnCreditos.UseVisualStyleBackColor = true;
            btnCreditos.Click += btnCreditos_Click;
            // 
            // btnAprender
            // 
            btnAprender.Font = new Font("Segoe UI", 72F);
            btnAprender.Location = new Point(543, 207);
            btnAprender.Name = "btnAprender";
            btnAprender.Size = new Size(500, 177);
            btnAprender.TabIndex = 1;
            btnAprender.Text = "Aprender";
            btnAprender.UseVisualStyleBackColor = true;
            btnAprender.Click += btnAprender_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 96F);
            lblTitulo.Location = new Point(361, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(848, 170);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "ConectaIdade";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 861);
            Controls.Add(panel1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAprender;
        private Label lblTitulo;
        private Button btnSair;
        private Button btnCreditos;
    }
}
