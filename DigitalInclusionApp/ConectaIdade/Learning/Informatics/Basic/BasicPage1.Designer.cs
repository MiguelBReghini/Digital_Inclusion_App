namespace DigitalInclusionApp
{
    partial class BasicPage1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasicPage1));
            label1 = new Label();
            panel1 = new Panel();
            txtAparelhos = new TextBox();
            imgConjunto = new PictureBox();
            imgCelular = new PictureBox();
            voltarBtn = new Button();
            btnProximo = new Button();
            panel2 = new Panel();
            process1 = new System.Diagnostics.Process();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgConjunto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgCelular).BeginInit();
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
            panel1.Controls.Add(txtAparelhos);
            panel1.Controls.Add(imgConjunto);
            panel1.Controls.Add(imgCelular);
            panel1.Controls.Add(voltarBtn);
            panel1.Controls.Add(btnProximo);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 767);
            panel1.TabIndex = 1;
            // 
            // txtAparelhos
            // 
            txtAparelhos.BackColor = Color.FromArgb(1, 34, 62);
            txtAparelhos.BorderStyle = BorderStyle.None;
            txtAparelhos.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAparelhos.ForeColor = SystemColors.ActiveCaption;
            txtAparelhos.Location = new Point(85, 436);
            txtAparelhos.Multiline = true;
            txtAparelhos.Name = "txtAparelhos";
            txtAparelhos.ReadOnly = true;
            txtAparelhos.Size = new Size(1096, 202);
            txtAparelhos.TabIndex = 11;
            txtAparelhos.Text = resources.GetString("txtAparelhos.Text");
            txtAparelhos.TextAlign = HorizontalAlignment.Center;
            // 
            // imgConjunto
            // 
            imgConjunto.Image = Properties.Resources.ConjuntoBasico;
            imgConjunto.BackgroundImageLayout = ImageLayout.Stretch;
            imgConjunto.Location = new Point(888, 124);
            imgConjunto.Name = "imgConjunto";
            imgConjunto.Size = new Size(293, 298);
            imgConjunto.SizeMode = PictureBoxSizeMode.Zoom;
            imgConjunto.TabIndex = 10;
            imgConjunto.TabStop = false;
            // 
            // imgCelular
            // 
            imgCelular.BackgroundImage = Properties.Resources.brave_vSZOW1oQ9V;
            imgCelular.BackgroundImageLayout = ImageLayout.Stretch;
            imgCelular.Location = new Point(85, 124);
            imgCelular.Name = "imgCelular";
            imgCelular.Size = new Size(335, 298);
            imgCelular.SizeMode = PictureBoxSizeMode.Zoom;
            imgCelular.TabIndex = 8;
            imgCelular.TabStop = false;
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
            // BasicPage1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            ClientSize = new Size(1264, 767);
            Controls.Add(panel1);
            Name = "BasicPage1";
            Text = "Teclado";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgConjunto).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgCelular).EndInit();
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
        private PictureBox imgCelular;
        private PictureBox imgConjunto;
        private TextBox txtAparelhos;
    }
}
