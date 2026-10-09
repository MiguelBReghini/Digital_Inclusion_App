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
            panel1 = new Panel();
            keyboardProgressBar = new ProgressBar();
            backBtnKeyboardPractice = new Button();
            Palavra = new Label();
            disclaimerKeyboardPractice = new Label();
            diclaimerKeyboardPractice2 = new Label();
            instructionsKeyboardPractice = new Label();
            inputWord = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(keyboardProgressBar);
            panel1.Controls.Add(backBtnKeyboardPractice);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 371);
            panel1.Name = "panel1";
            panel1.Size = new Size(1069, 100);
            panel1.TabIndex = 0;
            // 
            // keyboardProgressBar
            // 
            keyboardProgressBar.Anchor = AnchorStyles.Bottom;
            keyboardProgressBar.Location = new Point(386, 44);
            keyboardProgressBar.Name = "keyboardProgressBar";
            keyboardProgressBar.Size = new Size(330, 23);
            keyboardProgressBar.TabIndex = 1;
            // 
            // backBtnKeyboardPractice
            // 
            backBtnKeyboardPractice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            backBtnKeyboardPractice.Font = new Font("Segoe UI", 20F);
            backBtnKeyboardPractice.Location = new Point(932, 23);
            backBtnKeyboardPractice.Name = "backBtnKeyboardPractice";
            backBtnKeyboardPractice.Size = new Size(125, 49);
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
            Palavra.Location = new Point(473, 37);
            Palavra.Name = "Palavra";
            Palavra.Size = new Size(0, 72);
            Palavra.TabIndex = 2;
            Palavra.TextAlign = ContentAlignment.TopCenter;
            // 
            // disclaimerKeyboardPractice
            // 
            disclaimerKeyboardPractice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            disclaimerKeyboardPractice.AutoSize = true;
            disclaimerKeyboardPractice.Location = new Point(440, 337);
            disclaimerKeyboardPractice.Name = "disclaimerKeyboardPractice";
            disclaimerKeyboardPractice.Size = new Size(385, 15);
            disclaimerKeyboardPractice.TabIndex = 3;
            disclaimerKeyboardPractice.Text = "Dica: Segure shift e a tecla desejada para deixar a letra dela em maiscúlo";
            // 
            // diclaimerKeyboardPractice2
            // 
            diclaimerKeyboardPractice2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            diclaimerKeyboardPractice2.AutoSize = true;
            diclaimerKeyboardPractice2.Location = new Point(440, 322);
            diclaimerKeyboardPractice2.Name = "diclaimerKeyboardPractice2";
            diclaimerKeyboardPractice2.Size = new Size(457, 15);
            diclaimerKeyboardPractice2.TabIndex = 4;
            diclaimerKeyboardPractice2.Text = "Dica: Aperte a tecla do acento desejado e então na tecla que você deseja por o acento";
            // 
            // instructionsKeyboardPractice
            // 
            instructionsKeyboardPractice.AutoSize = true;
            instructionsKeyboardPractice.Font = new Font("Segoe UI", 20F);
            instructionsKeyboardPractice.Location = new Point(282, 197);
            instructionsKeyboardPractice.Name = "instructionsKeyboardPractice";
            instructionsKeyboardPractice.Size = new Size(556, 37);
            instructionsKeyboardPractice.TabIndex = 5;
            instructionsKeyboardPractice.Text = "Digite a palavra acima dentro da caixa abaixo";
            // 
            // inputWord
            // 
            inputWord.Anchor = AnchorStyles.Bottom;
            inputWord.Font = new Font("Segoe UI", 20F);
            inputWord.Location = new Point(386, 253);
            inputWord.MaximumSize = new Size(330, 48);
            inputWord.Name = "inputWord";
            inputWord.ReadOnly = true;
            inputWord.ScrollBars = RichTextBoxScrollBars.None;
            inputWord.Size = new Size(330, 48);
            inputWord.TabIndex = 6;
            inputWord.Text = "Aperte qualquer tecla";
            inputWord.WordWrap = false;
            // 
            // KeyboardPractice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 471);
            Controls.Add(inputWord);
            Controls.Add(instructionsKeyboardPractice);
            Controls.Add(diclaimerKeyboardPractice2);
            Controls.Add(disclaimerKeyboardPractice);
            Controls.Add(Palavra);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "KeyboardPractice";
            Text = "Praticar o Teclado";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button backBtnKeyboardPractice;
        private ProgressBar keyboardProgressBar;
        private Label Palavra;
        private Label disclaimerKeyboardPractice;
        private Label diclaimerKeyboardPractice2;
        private Label instructionsKeyboardPractice;
        private RichTextBox inputWord;
    }
}