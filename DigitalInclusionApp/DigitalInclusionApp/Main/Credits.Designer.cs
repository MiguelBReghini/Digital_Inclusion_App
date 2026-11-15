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
            lblApoio = new Label();
            lblDev = new Label();
            imgCoordEx = new PictureBox();
            imgCienciaComp = new PictureBox();
            textBox1 = new TextBox();
            socialProjectTxt = new TextBox();
            btnBack = new Button();
            lblTitulo = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgCoordEx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgCienciaComp).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 34, 62);
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lblApoio);
            panel1.Controls.Add(lblDev);
            panel1.Controls.Add(imgCoordEx);
            panel1.Controls.Add(imgCienciaComp);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(socialProjectTxt);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(924, 700);
            panel1.TabIndex = 3;
            // 
            // lblApoio
            // 
            lblApoio.AutoSize = true;
            lblApoio.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApoio.ForeColor = Color.FromArgb(171, 237, 58);
            lblApoio.Location = new Point(635, 376);
            lblApoio.Name = "lblApoio";
            lblApoio.Size = new Size(79, 30);
            lblApoio.TabIndex = 10;
            lblApoio.Text = "Apoio:";
            lblApoio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDev
            // 
            lblDev.AutoSize = true;
            lblDev.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDev.ForeColor = Color.FromArgb(171, 237, 58);
            lblDev.Location = new Point(154, 376);
            lblDev.Name = "lblDev";
            lblDev.Size = new Size(189, 30);
            lblDev.TabIndex = 9;
            lblDev.Text = "Desenvolvimento:";
            lblDev.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imgCoordEx
            // 
            imgCoordEx.Anchor = AnchorStyles.Right;
            imgCoordEx.BackgroundImage = Properties.Resources.i_view32_zfbgVGLN9W;
            imgCoordEx.BackgroundImageLayout = ImageLayout.Stretch;
            imgCoordEx.Location = new Point(474, 409);
            imgCoordEx.Name = "imgCoordEx";
            imgCoordEx.Size = new Size(402, 118);
            imgCoordEx.TabIndex = 8;
            imgCoordEx.TabStop = false;
            // 
            // imgCienciaComp
            // 
            imgCienciaComp.Anchor = AnchorStyles.Left;
            imgCienciaComp.BackgroundImage = Properties.Resources.Ciencia_da_Computacao;
            imgCienciaComp.BackgroundImageLayout = ImageLayout.Stretch;
            imgCienciaComp.Location = new Point(42, 409);
            imgCienciaComp.Name = "imgCienciaComp";
            imgCienciaComp.Size = new Size(402, 118);
            imgCienciaComp.TabIndex = 7;
            imgCienciaComp.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.BackColor = Color.FromArgb(1, 34, 62);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ActiveCaption;
            textBox1.Location = new Point(349, 188);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(555, 248);
            textBox1.TabIndex = 6;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // socialProjectTxt
            // 
            socialProjectTxt.Anchor = AnchorStyles.Top;
            socialProjectTxt.BackColor = Color.FromArgb(1, 34, 62);
            socialProjectTxt.BorderStyle = BorderStyle.None;
            socialProjectTxt.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            socialProjectTxt.ForeColor = SystemColors.ActiveCaption;
            socialProjectTxt.Location = new Point(0, 188);
            socialProjectTxt.Multiline = true;
            socialProjectTxt.Name = "socialProjectTxt";
            socialProjectTxt.ReadOnly = true;
            socialProjectTxt.Size = new Size(343, 248);
            socialProjectTxt.TabIndex = 5;
            socialProjectTxt.Text = "Disciplina:\r\nProfessor Responsável:\r\nProfessor Colaborador:\r\nDesenvolvedores:\r\nCurso:\r\nInstituição:\r\nPeríodo:\r\nVersão:\r\nTecnologias:";
            socialProjectTxt.TextAlign = HorizontalAlignment.Right;
            socialProjectTxt.TextChanged += socialProjectTxt_TextChanged;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom;
            btnBack.BackColor = Color.FromArgb(231, 237, 58);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            btnBack.ForeColor = Color.FromArgb(1, 34, 62);
            btnBack.ImageAlign = ContentAlignment.TopCenter;
            btnBack.Location = new Point(214, 564);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(500, 80);
            btnBack.TabIndex = 4;
            btnBack.Text = "⬅       Voltar";
            btnBack.TextAlign = ContentAlignment.MiddleLeft;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 80F, FontStyle.Bold | FontStyle.Underline);
            lblTitulo.ForeColor = Color.FromArgb(171, 237, 58);
            lblTitulo.Location = new Point(227, 43);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(478, 142);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Créditos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Credits
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(924, 700);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Credits";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Credits";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgCoordEx).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgCienciaComp).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnBack;
        private Label lblTitulo;
        private TextBox socialProjectTxt;
        private TextBox textBox1;
        private PictureBox imgCienciaComp;
        private PictureBox imgCoordEx;
        private Label lblDev;
        private Label lblApoio;
    }
}
