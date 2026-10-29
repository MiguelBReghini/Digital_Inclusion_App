namespace DigitalInclusionApp
{
    partial class MousePage1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MousePage1));
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            btnTarget = new Button();
            textBox3 = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            voltarBtn = new Button();
            btnPraticaKeyboard = new Button();
            panel2 = new Panel();
            process1 = new System.Diagnostics.Process();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            label1.Location = new Point(458, 6);
            label1.Margin = new Padding(20);
            label1.Name = "label1";
            label1.Size = new Size(349, 125);
            label1.TabIndex = 0;
            label1.Text = "Mouse";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(1, 34, 62);
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnTarget);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(pictureBox3);
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
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            button1.FlatAppearance.MouseDownBackColor = Color.LightGreen;
            button1.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(997, 224);
            button1.Name = "button1";
            button1.Size = new Size(212, 161);
            button1.TabIndex = 14;
            button1.Text = "Clique Duas Vezes com o Botão Esquerdo Aqui!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // btnTarget
            // 
            btnTarget.BackColor = SystemColors.ActiveCaption;
            btnTarget.BackgroundImageLayout = ImageLayout.None;
            btnTarget.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btnTarget.FlatAppearance.MouseDownBackColor = Color.LightGreen;
            btnTarget.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            btnTarget.FlatStyle = FlatStyle.Flat;
            btnTarget.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTarget.ForeColor = SystemColors.ActiveCaptionText;
            btnTarget.Location = new Point(384, 223);
            btnTarget.Name = "btnTarget";
            btnTarget.Size = new Size(212, 161);
            btnTarget.TabIndex = 13;
            btnTarget.Text = "Clique com o Botão Esquerdo do Mouse aqui!";
            btnTarget.UseVisualStyleBackColor = false;
            btnTarget.Click += btnTarget_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(1, 34, 62);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.ForeColor = SystemColors.ActiveCaption;
            textBox3.Location = new Point(753, 483);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(416, 121);
            textBox3.TabIndex = 12;
            textBox3.Text = "Este quadro terá informações sobre Duplo Clique";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(648, 142);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(293, 298);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 142);
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
            textBox1.Location = new Point(126, 483);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(416, 121);
            textBox1.TabIndex = 7;
            textBox1.Text = "Este quadro terá informações sobre Botão Esquerdo";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // voltarBtn
            // 
            voltarBtn.Anchor = AnchorStyles.Bottom;
            voltarBtn.AutoSize = true;
            voltarBtn.BackColor = Color.FromArgb(231, 237, 58);
            voltarBtn.Font = new Font("Segoe UI", 45F, FontStyle.Bold, GraphicsUnit.Point, 0);
            voltarBtn.ForeColor = Color.FromArgb(1, 34, 62);
            voltarBtn.Location = new Point(96, 646);
            voltarBtn.Name = "voltarBtn";
            voltarBtn.Size = new Size(500, 91);
            voltarBtn.TabIndex = 5;
            voltarBtn.Text = "⬅       Voltar";
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
            btnPraticaKeyboard.Location = new Point(669, 644);
            btnPraticaKeyboard.Name = "btnPraticaKeyboard";
            btnPraticaKeyboard.Size = new Size(500, 93);
            btnPraticaKeyboard.TabIndex = 4;
            btnPraticaKeyboard.Text = "Próximo   ➞";
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
            // timer1
            // 
            timer1.Interval = 300;
            // 
            // MousePage1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            ClientSize = new Size(1264, 767);
            Controls.Add(panel1);
            Name = "MousePage1";
            Text = "Teclado";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private PictureBox pictureBox3;
        private TextBox textBox3;
        private Button btnTarget;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}
