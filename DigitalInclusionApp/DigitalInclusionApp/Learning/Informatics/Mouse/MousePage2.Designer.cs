namespace DigitalInclusionApp
{
    partial class MousePage2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MousePage2));
            label1 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            vScrollBar1 = new VScrollBar();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            hScrollBar1 = new HScrollBar();
            trackBar1 = new TrackBar();
            textBox2 = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            voltarBtn = new Button();
            btnPraticaKeyboard = new Button();
            panel2 = new Panel();
            process1 = new System.Diagnostics.Process();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
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
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(vScrollBar1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(hScrollBar1);
            panel1.Controls.Add(trackBar1);
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
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(1, 34, 62);
            label6.Enabled = false;
            label6.Font = new Font("Segoe UI", 50.25F, FontStyle.Bold);
            label6.ForeColor = Color.Green;
            label6.Location = new Point(1099, 130);
            label6.Name = "label6";
            label6.Size = new Size(130, 89);
            label6.TabIndex = 19;
            label6.Text = "✔";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(1, 34, 62);
            label5.Enabled = false;
            label5.Font = new Font("Segoe UI", 50.25F, FontStyle.Bold);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(1099, 329);
            label5.Name = "label5";
            label5.Size = new Size(130, 89);
            label5.TabIndex = 18;
            label5.Text = "✔";
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(985, 130);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(111, 384);
            vScrollBar1.SmallChange = 5;
            vScrollBar1.TabIndex = 17;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.GradientActiveCaption;
            label4.Location = new Point(529, 120);
            label4.Name = "label4";
            label4.Size = new Size(117, 21);
            label4.TabIndex = 16;
            label4.Text = "Solte no final!";
            label4.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Font = new Font("Segoe UI", 50.25F, FontStyle.Bold);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(489, 225);
            label3.Name = "label3";
            label3.Size = new Size(130, 89);
            label3.TabIndex = 15;
            label3.Text = "✔";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("Segoe UI", 50.25F, FontStyle.Bold);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(359, 225);
            label2.Name = "label2";
            label2.Size = new Size(130, 89);
            label2.TabIndex = 14;
            label2.Text = "✔";
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(359, 141);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(260, 84);
            hScrollBar1.TabIndex = 13;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(359, 348);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(260, 45);
            trackBar1.TabIndex = 12;
            trackBar1.TickStyle = TickStyle.Both;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(1, 34, 62);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.ActiveCaption;
            textBox2.Location = new Point(706, 517);
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
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(652, 120);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(293, 298);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 298);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(1, 34, 62);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ActiveCaption;
            textBox1.Location = new Point(34, 466);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(585, 121);
            textBox1.TabIndex = 7;
            textBox1.Text = "Ainda com o Botão Esquerdo, podemos arrastar objetos com o ponteiro. \r\nTente arrastar as barras acima até o final!";
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
            voltarBtn.Location = new Point(102, 644);
            voltarBtn.Name = "voltarBtn";
            voltarBtn.Size = new Size(500, 93);
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
            btnPraticaKeyboard.Location = new Point(661, 644);
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
            // MousePage2
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            ClientSize = new Size(1264, 767);
            Controls.Add(panel1);
            Name = "MousePage2";
            Text = "Teclado";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
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
        private TrackBar trackBar1;
        private Label label2;
        private HScrollBar hScrollBar1;
        private Label label3;
        private Label label4;
        private VScrollBar vScrollBar1;
        private Label label6;
        private Label label5;
    }
}
