namespace DigitalInclusionApp
{
    partial class BasicPractice
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
            lblQuestion = new Label();
            lblExplanation = new Label();
            lblProgress = new Label();
            btnBack = new Button();
            btnFalse = new Button();
            btnTrue = new Button();
            btnNext = new Button();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.Anchor = AnchorStyles.Top;
            lblQuestion.Font = new Font("Segoe UI", 14F);
            lblQuestion.Location = new Point(2, 61);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(786, 101);
            lblQuestion.TabIndex = 0;
            // 
            // lblExplanation
            // 
            lblExplanation.Anchor = AnchorStyles.Bottom;
            lblExplanation.Font = new Font("Segoe UI", 14F);
            lblExplanation.Location = new Point(2, 290);
            lblExplanation.Name = "lblExplanation";
            lblExplanation.Size = new Size(796, 66);
            lblExplanation.TabIndex = 1;
            // 
            // lblProgress
            // 
            lblProgress.Location = new Point(246, 9);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(260, 23);
            lblProgress.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(669, 380);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(119, 57);
            btnBack.TabIndex = 3;
            btnBack.Text = "Voltar";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnFalse
            // 
            btnFalse.Location = new Point(172, 310);
            btnFalse.Name = "btnFalse";
            btnFalse.Size = new Size(148, 66);
            btnFalse.TabIndex = 4;
            btnFalse.Text = "Falso";
            btnFalse.UseVisualStyleBackColor = true;
            btnFalse.Click += btnFalse_Click;
            // 
            // btnTrue
            // 
            btnTrue.Location = new Point(489, 310);
            btnTrue.Name = "btnTrue";
            btnTrue.Size = new Size(148, 66);
            btnTrue.TabIndex = 5;
            btnTrue.Text = "Verdadeiro";
            btnTrue.UseVisualStyleBackColor = true;
            btnTrue.Click += btnTrue_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(344, 380);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(122, 54);
            btnNext.TabIndex = 6;
            btnNext.Text = "Próximo";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Visible = false;
            btnNext.Click += btnNext_Click;
            // 
            // BasicPractice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNext);
            Controls.Add(btnTrue);
            Controls.Add(btnFalse);
            Controls.Add(btnBack);
            Controls.Add(lblProgress);
            Controls.Add(lblExplanation);
            Controls.Add(lblQuestion);
            Name = "BasicPractice";
            Text = "BasicPractice";
            ResumeLayout(false);
        }

        #endregion

        private Label lblQuestion;
        private Label lblExplanation;
        private Label lblProgress;
        private Button btnBack;
        private Button btnFalse;
        private Button btnTrue;
        private Button btnNext;
    }
}