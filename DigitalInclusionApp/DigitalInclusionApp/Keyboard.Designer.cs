namespace DigitalInclusionApp
{
    partial class Keyboard
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
            btnPraticaKeyboard = new Button();
            keyboardContent = new Label();
            panel2 = new Panel();
            imgKeyboard = new PictureBox();
            process1 = new System.Diagnostics.Process();
            voltarBtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgKeyboard).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(474, 4);
            label1.Margin = new Padding(20);
            label1.Name = "label1";
            label1.Size = new Size(210, 72);
            label1.TabIndex = 0;
            label1.Text = "Teclado";
            // 
            // panel1
            // 
            panel1.Controls.Add(voltarBtn);
            panel1.Controls.Add(btnPraticaKeyboard);
            panel1.Controls.Add(keyboardContent);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(imgKeyboard);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1158, 532);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // btnPraticaKeyboard
            // 
            btnPraticaKeyboard.Anchor = AnchorStyles.Bottom;
            btnPraticaKeyboard.AutoSize = true;
            btnPraticaKeyboard.Font = new Font("Segoe UI", 40F);
            btnPraticaKeyboard.Location = new Point(718, 409);
            btnPraticaKeyboard.Name = "btnPraticaKeyboard";
            btnPraticaKeyboard.Size = new Size(219, 93);
            btnPraticaKeyboard.TabIndex = 4;
            btnPraticaKeyboard.Text = "Praticar";
            btnPraticaKeyboard.UseVisualStyleBackColor = true;
            btnPraticaKeyboard.Click += btnPraticaKeyboard_Click;
            // 
            // keyboardContent
            // 
            keyboardContent.AllowDrop = true;
            keyboardContent.Anchor = AnchorStyles.Right;
            keyboardContent.AutoEllipsis = true;
            keyboardContent.AutoSize = true;
            keyboardContent.Font = new Font("Segoe UI", 25F);
            keyboardContent.Location = new Point(512, 85);
            keyboardContent.MaximumSize = new Size(600, 0);
            keyboardContent.Name = "keyboardContent";
            keyboardContent.Size = new Size(599, 276);
            keyboardContent.TabIndex = 3;
            keyboardContent.Text = "A imagem mostra um guia visual da posição correta dos dedos em um teclado de computador, com cada cor correspondendo a um dedo e às teclas que ele deve acionar. Note que há um padrão para facilitar.";
            keyboardContent.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1158, 84);
            panel2.TabIndex = 2;
            // 
            // imgKeyboard
            // 
            imgKeyboard.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            imgKeyboard.BackgroundImageLayout = ImageLayout.None;
            imgKeyboard.Image = Properties.Resources.d609243a20117cb8132988815ded3c8b;
            imgKeyboard.Location = new Point(3, 70);
            imgKeyboard.Margin = new Padding(20);
            imgKeyboard.Name = "imgKeyboard";
            imgKeyboard.Size = new Size(502, 450);
            imgKeyboard.TabIndex = 1;
            imgKeyboard.TabStop = false;
            imgKeyboard.Click += pictureBox1_Click;
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
            // voltarBtn
            // 
            voltarBtn.Anchor = AnchorStyles.Bottom;
            voltarBtn.AutoSize = true;
            voltarBtn.Font = new Font("Segoe UI", 20F);
            voltarBtn.Location = new Point(1029, 439);
            voltarBtn.Name = "voltarBtn";
            voltarBtn.Size = new Size(97, 52);
            voltarBtn.TabIndex = 5;
            voltarBtn.Text = "Voltar";
            voltarBtn.UseVisualStyleBackColor = true;
            voltarBtn.Click += voltarBtn_Click;
            // 
            // Keyboard
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            ClientSize = new Size(1158, 532);
            Controls.Add(panel1);
            Name = "Keyboard";
            Text = "Teclado";
            Load += Keyboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgKeyboard).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private PictureBox imgKeyboard;
        private Panel panel2;
        private Label keyboardContent;
        private Button btnPraticaKeyboard;
        private Button voltarBtn;
        private System.Diagnostics.Process process1;
    }
}