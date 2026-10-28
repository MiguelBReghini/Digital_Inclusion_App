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
            textBox2 = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            voltarBtn = new Button();
            btnPraticaKeyboard = new Button();
            panel2 = new Panel();
            process1 = new System.Diagnostics.Process();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(pictureBox2);
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
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(1, 34, 62);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.ActiveCaption;
            textBox2.Location = new Point(701, 451);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(416, 121);
            textBox2.TabIndex = 11;
            textBox2.Text = "Este quadro terá informações sobre Scroll";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.KeyboardImage;
            pictureBox2.Location = new Point(764, 120);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(293, 298);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.KeyboardImage;
            pictureBox1.Location = new Point(216, 120);
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
            textBox1.Location = new Point(144, 451);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(416, 121);
            textBox1.TabIndex = 7;
            textBox1.Text = "Este quadro terá informações sobre Botão Direito";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox2;
        private TextBox textBox2;
    }
}
