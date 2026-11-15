namespace DigitalInclusionApp
{
    partial class BasicPage2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasicPage2));
            label1 = new Label();
            panel1 = new Panel();
            textBox2 = new TextBox();
            imgCabos = new PictureBox();
            imgRoteador = new PictureBox();
            imgMoldem = new PictureBox();
            voltarBtn = new Button();
            btnProximo = new Button();
            panel2 = new Panel();
            process1 = new System.Diagnostics.Process();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgCabos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgRoteador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgMoldem).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 70F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(128, 255, 255);
            label1.Location = new Point(468, 2);
            label1.Margin = new Padding(20);
            label1.Name = "label1";
            label1.Size = new Size(334, 125);
            label1.TabIndex = 0;
            label1.Text = "Básico";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(1, 34, 62);
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(imgCabos);
            panel1.Controls.Add(imgRoteador);
            panel1.Controls.Add(imgMoldem);
            panel1.Controls.Add(voltarBtn);
            panel1.Controls.Add(btnProximo);
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
            textBox2.Location = new Point(85, 436);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(1096, 202);
            textBox2.TabIndex = 11;
            textBox2.Text = resources.GetString("textBox2.Text");
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // imgCabos
            // 
            imgCabos.BackgroundImage = Properties.Resources.CabosBasico;
            imgCabos.BackgroundImageLayout = ImageLayout.Stretch;
            imgCabos.Location = new Point(888, 124);
            imgCabos.Name = "imgCabos";
            imgCabos.Size = new Size(293, 298);
            imgCabos.SizeMode = PictureBoxSizeMode.Zoom;
            imgCabos.TabIndex = 10;
            imgCabos.TabStop = false;
            // 
            // imgRoteador
            // 
            imgRoteador.BackgroundImage = Properties.Resources.RoteadorBasico;
            imgRoteador.BackgroundImageLayout = ImageLayout.Stretch;
            imgRoteador.Location = new Point(487, 124);
            imgRoteador.Name = "imgRoteador";
            imgRoteador.Size = new Size(293, 298);
            imgRoteador.SizeMode = PictureBoxSizeMode.Zoom;
            imgRoteador.TabIndex = 9;
            imgRoteador.TabStop = false;
            // 
            // imgMoldem
            // 
            imgMoldem.BackgroundImage = Properties.Resources.MoldemBasico;
            imgMoldem.BackgroundImageLayout = ImageLayout.Stretch;
            imgMoldem.Location = new Point(85, 124);
            imgMoldem.Name = "imgMoldem";
            imgMoldem.Size = new Size(293, 298);
            imgMoldem.SizeMode = PictureBoxSizeMode.Zoom;
            imgMoldem.TabIndex = 8;
            imgMoldem.TabStop = false;
            // 
            // voltarBtn
            // 
            voltarBtn.Anchor = AnchorStyles.Bottom;
            voltarBtn.AutoSize = true;
            voltarBtn.BackColor = Color.FromArgb(231, 237, 58);
            voltarBtn.FlatStyle = FlatStyle.Flat;
            voltarBtn.Font = new Font("Segoe UI", 45F, FontStyle.Bold, GraphicsUnit.Point, 0);
            voltarBtn.ForeColor = Color.FromArgb(1, 34, 62);
            voltarBtn.Location = new Point(99, 644);
            voltarBtn.Name = "voltarBtn";
            voltarBtn.Size = new Size(500, 93);
            voltarBtn.TabIndex = 5;
            voltarBtn.Text = "⬅      Voltar";
            voltarBtn.TextAlign = ContentAlignment.MiddleLeft;
            voltarBtn.UseVisualStyleBackColor = false;
            voltarBtn.Click += voltarBtn_Click;
            // 
            // btnProximo
            // 
            btnProximo.Anchor = AnchorStyles.Bottom;
            btnProximo.AutoSize = true;
            btnProximo.BackColor = Color.FromArgb(128, 255, 255);
            btnProximo.FlatStyle = FlatStyle.Flat;
            btnProximo.Font = new Font("Segoe UI", 45F, FontStyle.Bold);
            btnProximo.ForeColor = Color.FromArgb(1, 34, 62);
            btnProximo.Location = new Point(659, 644);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(500, 93);
            btnProximo.TabIndex = 4;
            btnProximo.Text = "Próximo   ➞";
            btnProximo.TextAlign = ContentAlignment.MiddleRight;
            btnProximo.UseVisualStyleBackColor = false;
            btnProximo.Click += btnProximo_Click;
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
            // BasicPage2
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            ClientSize = new Size(1264, 767);
            Controls.Add(panel1);
            Name = "BasicPage2";
            Text = "Teclado";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgCabos).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgRoteador).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgMoldem).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Button btnProximo;
        private Button voltarBtn;
        private System.Diagnostics.Process process1;
        private PictureBox imgMoldem;
        private ImageList imageList1;
        private PictureBox imgCabos;
        private PictureBox imgRoteador;
        private TextBox textBox2;
    }
}
