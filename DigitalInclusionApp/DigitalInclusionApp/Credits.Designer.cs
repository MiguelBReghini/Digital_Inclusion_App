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
            textBox1 = new TextBox();
            socialProjectTxt = new TextBox();
            btnBack = new Button();
            lblTitulo = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 11, 174);
            panel1.BackgroundImage = Properties.Resources._1280;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
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
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(2, 36, 64);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ActiveCaption;
            textBox1.Location = new Point(38, 385);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(848, 88);
            textBox1.TabIndex = 6;
            textBox1.Text = "Desenvolvimento: Felipe Juliano dos Santos, Miguel Bricailo Reghini e Pedro Henrique Zanella";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // socialProjectTxt
            // 
            socialProjectTxt.BackColor = Color.FromArgb(2, 36, 64);
            socialProjectTxt.BorderStyle = BorderStyle.None;
            socialProjectTxt.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            socialProjectTxt.ForeColor = SystemColors.ActiveCaption;
            socialProjectTxt.Location = new Point(38, 188);
            socialProjectTxt.Multiline = true;
            socialProjectTxt.Name = "socialProjectTxt";
            socialProjectTxt.ReadOnly = true;
            socialProjectTxt.Size = new Size(848, 167);
            socialProjectTxt.TabIndex = 5;
            socialProjectTxt.Text = resources.GetString("socialProjectTxt.Text");
            socialProjectTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 50.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ImageAlign = ContentAlignment.TopCenter;
            btnBack.Location = new Point(214, 564);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(500, 97);
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
            lblTitulo.Font = new Font("Segoe UI", 80F, FontStyle.Bold);
            lblTitulo.ForeColor = SystemColors.GradientActiveCaption;
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
        private TextBox socialProjectTxt;
        private TextBox textBox1;
    }
}
