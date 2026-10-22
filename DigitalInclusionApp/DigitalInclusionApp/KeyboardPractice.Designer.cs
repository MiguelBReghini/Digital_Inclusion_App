namespace DigitalInclusionApp
{
    partial class KeyboardPractice
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
            keyboardProgressBar = new ProgressBar();
            backBtnKeyboardPractice = new Button();
            Palavra = new Label();
            disclaimerKeyboardPractice = new Label();
            diclaimerKeyboardPractice2 = new Label();
            instructionsKeyboardPractice = new Label();
            inputWord = new RichTextBox();
            panel2 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // keyboardProgressBar
            // 
            keyboardProgressBar.Anchor = AnchorStyles.Bottom;
            keyboardProgressBar.Location = new Point(297, 547);
            keyboardProgressBar.Name = "keyboardProgressBar";
            keyboardProgressBar.Size = new Size(330, 23);
            keyboardProgressBar.TabIndex = 1;
            // 
            // backBtnKeyboardPractice
            // 
            backBtnKeyboardPractice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            backBtnKeyboardPractice.Font = new Font("Segoe UI", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backBtnKeyboardPractice.Location = new Point(302, 586);
            backBtnKeyboardPractice.Name = "backBtnKeyboardPractice";
            backBtnKeyboardPractice.Size = new Size(320, 93);
            backBtnKeyboardPractice.TabIndex = 0;
            backBtnKeyboardPractice.Text = "Voltar";
            backBtnKeyboardPractice.UseVisualStyleBackColor = true;
            backBtnKeyboardPractice.Click += backBtnKeyboardPractice_Click;
            // 
            // Palavra
            // 
            Palavra.Anchor = AnchorStyles.Top;
            Palavra.AutoSize = true;
            Palavra.Font = new Font("Segoe UI", 40F);
            Palavra.ImageAlign = ContentAlignment.TopCenter;
            Palavra.Location = new Point(401, 37);
            Palavra.Name = "Palavra";
            Palavra.Size = new Size(0, 72);
            Palavra.TabIndex = 2;
            Palavra.TextAlign = ContentAlignment.TopCenter;
            // 
            // disclaimerKeyboardPractice
            // 
            disclaimerKeyboardPractice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            disclaimerKeyboardPractice.AutoSize = true;
            disclaimerKeyboardPractice.BackColor = Color.FromArgb(2, 36, 64);
            disclaimerKeyboardPractice.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            disclaimerKeyboardPractice.ForeColor = SystemColors.ActiveCaption;
            disclaimerKeyboardPractice.Location = new Point(80, 471);
            disclaimerKeyboardPractice.Name = "disclaimerKeyboardPractice";
            disclaimerKeyboardPractice.Size = new Size(765, 30);
            disclaimerKeyboardPractice.TabIndex = 3;
            disclaimerKeyboardPractice.Text = "Dica: Segure shift e a tecla desejada para deixar a letra dela em maiscúlo";
            disclaimerKeyboardPractice.Click += disclaimerKeyboardPractice_Click;
            // 
            // diclaimerKeyboardPractice2
            // 
            diclaimerKeyboardPractice2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            diclaimerKeyboardPractice2.AutoSize = true;
            diclaimerKeyboardPractice2.BackColor = Color.FromArgb(2, 36, 64);
            diclaimerKeyboardPractice2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            diclaimerKeyboardPractice2.ForeColor = SystemColors.ActiveCaption;
            diclaimerKeyboardPractice2.Location = new Point(10, 428);
            diclaimerKeyboardPractice2.Name = "diclaimerKeyboardPractice2";
            diclaimerKeyboardPractice2.Size = new Size(902, 30);
            diclaimerKeyboardPractice2.TabIndex = 4;
            diclaimerKeyboardPractice2.Text = "Dica: Aperte a tecla do acento desejado e então na tecla que você deseja por o acento";
            diclaimerKeyboardPractice2.Click += this.diclaimerKeyboardPractice2_Click;
            // 
            // instructionsKeyboardPractice
            // 
            instructionsKeyboardPractice.AutoSize = true;
            instructionsKeyboardPractice.Font = new Font("Segoe UI", 20F);
            instructionsKeyboardPractice.Location = new Point(184, 218);
            instructionsKeyboardPractice.Name = "instructionsKeyboardPractice";
            instructionsKeyboardPractice.Size = new Size(556, 37);
            instructionsKeyboardPractice.TabIndex = 5;
            instructionsKeyboardPractice.Text = "Digite a palavra acima dentro da caixa abaixo";
            instructionsKeyboardPractice.Click += instructionsKeyboardPractice_Click;
            // 
            // inputWord
            // 
            inputWord.Anchor = AnchorStyles.Bottom;
            inputWord.BackColor = Color.FromArgb(2, 36, 64);
            inputWord.BorderStyle = BorderStyle.FixedSingle;
            inputWord.Font = new Font("Segoe UI", 40F);
            inputWord.ForeColor = SystemColors.ActiveCaption;
            inputWord.Location = new Point(206, 309);
            inputWord.Multiline = false;
            inputWord.Name = "inputWord";
            inputWord.ReadOnly = true;
            inputWord.ScrollBars = RichTextBoxScrollBars.None;
            inputWord.Size = new Size(513, 77);
            inputWord.TabIndex = 6;
            inputWord.Text = "Aperte qualquer tecla";
            inputWord.WordWrap = false;
            inputWord.TextChanged += inputWord_TextChanged;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources._1280;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(backBtnKeyboardPractice);
            panel2.Controls.Add(keyboardProgressBar);
            panel2.Controls.Add(instructionsKeyboardPractice);
            panel2.Controls.Add(disclaimerKeyboardPractice);
            panel2.Controls.Add(diclaimerKeyboardPractice2);
            panel2.Controls.Add(inputWord);
            panel2.Location = new Point(0, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(924, 702);
            panel2.TabIndex = 7;
            // 
            // KeyboardPractice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 700);
            Controls.Add(panel2);
            Controls.Add(Palavra);
            KeyPreview = true;
            Name = "KeyboardPractice";
            Text = "Praticar o Teclado";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button backBtnKeyboardPractice;
        private ProgressBar keyboardProgressBar;
        private Label Palavra;
        private Label disclaimerKeyboardPractice;
        private Label diclaimerKeyboardPractice2;
        private Label instructionsKeyboardPractice;
        private RichTextBox inputWord;
        private Panel panel2;
    }
}