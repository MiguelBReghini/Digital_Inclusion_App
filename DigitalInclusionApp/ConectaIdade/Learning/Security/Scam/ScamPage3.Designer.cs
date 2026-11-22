namespace DigitalInclusionApp
{
    partial class ScamPage3
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
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            lblUrgencia = new Label();
            lblLink = new Label();
            lblCPF = new Label();
            lblPIX = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            voltarBtn = new Button();
            btnPraticaKeyboard = new Button();
            panel2 = new Panel();
            process1 = new System.Diagnostics.Process();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 70F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(128, 255, 255);
            label1.Location = new Point(455, 6);
            label1.Margin = new Padding(20);
            label1.Name = "label1";
            label1.Size = new Size(354, 125);
            label1.TabIndex = 0;
            label1.Text = "Golpes";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(1, 34, 62);
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(voltarBtn);
            panel1.Controls.Add(btnPraticaKeyboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 767);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblUrgencia);
            panel3.Controls.Add(lblLink);
            panel3.Controls.Add(lblCPF);
            panel3.Controls.Add(lblPIX);
            panel3.Location = new Point(499, 124);
            panel3.Name = "panel3";
            panel3.Size = new Size(753, 494);
            panel3.TabIndex = 1;
            // 
            // lblUrgencia
            // 
            lblUrgencia.AutoSize = true;
            lblUrgencia.Font = new Font("Segoe UI", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUrgencia.ForeColor = Color.Red;
            lblUrgencia.Location = new Point(45, 15);
            lblUrgencia.Name = "lblUrgencia";
            lblUrgencia.Size = new Size(380, 106);
            lblUrgencia.TabIndex = 9;
            lblUrgencia.Text = "Urgência";
            // 
            // lblLink
            // 
            lblLink.AutoSize = true;
            lblLink.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLink.ForeColor = Color.Red;
            lblLink.Location = new Point(45, 279);
            lblLink.Name = "lblLink";
            lblLink.Size = new Size(671, 65);
            lblLink.TabIndex = 12;
            lblLink.Text = "Links encurtados e suspeitos";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCPF.ForeColor = Color.Red;
            lblCPF.Location = new Point(45, 416);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(720, 47);
            lblCPF.TabIndex = 10;
            lblCPF.Text = "Pedir dados como Cartão de Crédito e CPF";
            // 
            // lblPIX
            // 
            lblPIX.AutoSize = true;
            lblPIX.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPIX.ForeColor = Color.Red;
            lblPIX.Location = new Point(45, 154);
            lblPIX.Name = "lblPIX";
            lblPIX.Size = new Size(673, 59);
            lblPIX.TabIndex = 11;
            lblPIX.Text = "Pedir Transferência Rápida (PIX)";
            lblPIX.Click += lblPIX_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.brave_zFomwUXpNu;
            pictureBox1.Location = new Point(187, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 298);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(1, 34, 62);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ActiveCaption;
            textBox1.Location = new Point(75, 455);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(416, 163);
            textBox1.TabIndex = 7;
            textBox1.Text = "Alguns padrões que servem para identificar um golpe é:\r\n\r\n";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // voltarBtn
            // 
            voltarBtn.Anchor = AnchorStyles.Bottom;
            voltarBtn.AutoSize = true;
            voltarBtn.BackColor = Color.FromArgb(231, 237, 58);
            voltarBtn.FlatStyle = FlatStyle.Flat;
            voltarBtn.Font = new Font("Segoe UI", 45F, FontStyle.Bold, GraphicsUnit.Point, 0);
            voltarBtn.ForeColor = Color.FromArgb(1, 34, 62);
            voltarBtn.Location = new Point(116, 642);
            voltarBtn.Name = "voltarBtn";
            voltarBtn.Size = new Size(500, 93);
            voltarBtn.TabIndex = 5;
            voltarBtn.Text = "⬅      Voltar";
            voltarBtn.TextAlign = ContentAlignment.MiddleLeft;
            voltarBtn.UseVisualStyleBackColor = false;
            voltarBtn.Click += voltarBtn_Click;
            // 
            // btnPraticaKeyboard
            // 
            btnPraticaKeyboard.Anchor = AnchorStyles.Bottom;
            btnPraticaKeyboard.AutoSize = true;
            btnPraticaKeyboard.BackColor = Color.FromArgb(128, 255, 255);
            btnPraticaKeyboard.FlatStyle = FlatStyle.Flat;
            btnPraticaKeyboard.Font = new Font("Segoe UI", 45F, FontStyle.Bold);
            btnPraticaKeyboard.ForeColor = Color.FromArgb(1, 34, 62);
            btnPraticaKeyboard.Location = new Point(654, 642);
            btnPraticaKeyboard.Name = "btnPraticaKeyboard";
            btnPraticaKeyboard.Size = new Size(500, 93);
            btnPraticaKeyboard.TabIndex = 4;
            btnPraticaKeyboard.Text = "Prática    ➞";
            btnPraticaKeyboard.TextAlign = ContentAlignment.MiddleRight;
            btnPraticaKeyboard.UseVisualStyleBackColor = false;
            btnPraticaKeyboard.Click += btnPraticaKeyboard_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1264, 127);
            panel2.TabIndex = 2;
            // 
            // process1
            // 
            process1.StartInfo.CreateNewProcessGroup = false;
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UseCredentialsForNetworkingOnly = false;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // ScamPage3
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            ClientSize = new Size(1264, 767);
            Controls.Add(panel1);
            Name = "ScamPage3";
            Text = "Teclado";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Button btnPraticaKeyboard;
        private Button voltarBtn;
        private System.Diagnostics.Process process1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private ImageList imageList1;
        private Label lblLink;
        private Label lblPIX;
        private Label lblCPF;
        private Label lblUrgencia;
        private Panel panel3;
    }
}
