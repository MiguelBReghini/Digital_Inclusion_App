namespace DigitalInclusionApp
{
    partial class MousePage3
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
            textBox1 = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            pictureBox2 = new PictureBox();
            voltarBtn = new Button();
            btnPraticaKeyboard = new Button();
            panel2 = new Panel();
            process1 = new System.Diagnostics.Process();
            btnTarget = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 70F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(128, 255, 255);
            label1.Location = new Point(438, 6);
            label1.Margin = new Padding(20);
            label1.Name = "label1";
            label1.Size = new Size(389, 125);
            label1.TabIndex = 0;
            label1.Text = "Teclado";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(1, 34, 62);
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnTarget);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(voltarBtn);
            panel1.Controls.Add(btnPraticaKeyboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 767);
            panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(1, 34, 62);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ActiveCaption;
            textBox1.Location = new Point(708, 450);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(416, 121);
            textBox1.TabIndex = 14;
            textBox1.Text = "Este quadro terá informações sobre Abrir pastas e Arquivos";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.KeyboardImage;
            pictureBox3.Location = new Point(922, 133);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(293, 298);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.KeyboardImage;
            pictureBox1.Location = new Point(623, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 298);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(1, 34, 62);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.ActiveCaption;
            textBox2.Location = new Point(82, 450);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(416, 121);
            textBox2.TabIndex = 11;
            textBox2.Text = "Este quadro terá informações sobre Botão Direito";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.KeyboardImage;
            pictureBox2.Location = new Point(46, 122);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(293, 298);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // voltarBtn
            // 
            voltarBtn.Anchor = AnchorStyles.Bottom;
            voltarBtn.AutoSize = true;
            voltarBtn.BackColor = Color.White;
            voltarBtn.Font = new Font("Segoe UI", 45F, FontStyle.Bold, GraphicsUnit.Point, 0);
            voltarBtn.Location = new Point(276, 644);
            voltarBtn.Name = "voltarBtn";
            voltarBtn.Size = new Size(320, 93);
            voltarBtn.TabIndex = 5;
            voltarBtn.Text = "Voltar";
            voltarBtn.UseVisualStyleBackColor = false;
            voltarBtn.Click += voltarBtn_Click;
            // 
            // btnPraticaKeyboard
            // 
            btnPraticaKeyboard.Anchor = AnchorStyles.Bottom;
            btnPraticaKeyboard.AutoSize = true;
            btnPraticaKeyboard.Font = new Font("Segoe UI", 45F, FontStyle.Bold);
            btnPraticaKeyboard.Location = new Point(675, 644);
            btnPraticaKeyboard.Name = "btnPraticaKeyboard";
            btnPraticaKeyboard.Size = new Size(320, 93);
            btnPraticaKeyboard.TabIndex = 4;
            btnPraticaKeyboard.Text = "Próximo";
            btnPraticaKeyboard.UseVisualStyleBackColor = true;
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
            btnTarget.Location = new Point(374, 196);
            btnTarget.Name = "btnTarget";
            btnTarget.Size = new Size(212, 161);
            btnTarget.TabIndex = 15;
            btnTarget.Text = "Clique com o Botão Direito do Mouse aqui!";
            btnTarget.UseVisualStyleBackColor = false;
            btnTarget.Click += btnTarget_Click;
            // 
            // MousePage3
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            ClientSize = new Size(1264, 767);
            Controls.Add(panel1);
            Name = "MousePage3";
            Text = "Teclado";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private ImageList imageList1;
        private PictureBox pictureBox2;
        private TextBox textBox2;
        private TextBox textBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Button btnTarget;
    }
}
