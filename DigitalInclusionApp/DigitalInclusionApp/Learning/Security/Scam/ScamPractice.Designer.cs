namespace DigitalInclusionApp
{
    partial class ScamPractice
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
            btnNotScam = new Button();
            btnScam = new Button();
            btnNext = new Button();
            lblProgress = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.Font = new Font("Segoe UI", 14F);
            lblQuestion.Location = new Point(12, 70);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(776, 111);
            lblQuestion.TabIndex = 0;
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblExplanation
            // 
            lblExplanation.Anchor = AnchorStyles.None;
            lblExplanation.Font = new Font("Segoe UI", 14F);
            lblExplanation.Location = new Point(23, 219);
            lblExplanation.Name = "lblExplanation";
            lblExplanation.Size = new Size(754, 58);
            lblExplanation.TabIndex = 1;
            lblExplanation.TextAlign = ContentAlignment.BottomCenter;
            lblExplanation.Visible = false;
            // 
            // btnNotScam
            // 
            btnNotScam.Location = new Point(130, 284);
            btnNotScam.Name = "btnNotScam";
            btnNotScam.Size = new Size(135, 63);
            btnNotScam.TabIndex = 2;
            btnNotScam.Text = "Não é scan";
            btnNotScam.UseVisualStyleBackColor = true;
            btnNotScam.Click += btnNotScam_Click;
            // 
            // btnScam
            // 
            btnScam.Location = new Point(564, 284);
            btnScam.Name = "btnScam";
            btnScam.Size = new Size(139, 63);
            btnScam.TabIndex = 3;
            btnScam.Text = "É Golpe";
            btnScam.UseVisualStyleBackColor = true;
            btnScam.Click += btnScam_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(344, 368);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(114, 54);
            btnNext.TabIndex = 4;
            btnNext.Text = "Próximo";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Visible = false;
            btnNext.Click += btnNext_Click;
            // 
            // lblProgress
            // 
            lblProgress.Anchor = AnchorStyles.Top;
            lblProgress.Location = new Point(263, 9);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(244, 31);
            lblProgress.TabIndex = 5;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(667, 382);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(110, 40);
            btnBack.TabIndex = 6;
            btnBack.Text = "Voltar";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ScamPractice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(lblProgress);
            Controls.Add(btnNext);
            Controls.Add(btnScam);
            Controls.Add(btnNotScam);
            Controls.Add(lblExplanation);
            Controls.Add(lblQuestion);
            Name = "ScamPractice";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label lblQuestion;
        private Label lblExplanation;
        private Button btnNotScam;
        private Button btnScam;
        private Button btnNext;
        private Label lblProgress;
        private Button btnBack;
    }
}