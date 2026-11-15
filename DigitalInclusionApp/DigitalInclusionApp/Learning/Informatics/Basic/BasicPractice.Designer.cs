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
            btnFalse = new Button();
            btnTrue = new Button();
            btnNext = new Button();
            lblProgress = new Label();
            btnBack = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblQuestion.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestion.ForeColor = SystemColors.ButtonHighlight;
            lblQuestion.Location = new Point(40, 60);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(844, 150);
            lblQuestion.TabIndex = 0;
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblExplanation
            // 
            lblExplanation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblExplanation.BackColor = Color.FromArgb(2, 36, 64);
            lblExplanation.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExplanation.ForeColor = SystemColors.ButtonHighlight;
            lblExplanation.Location = new Point(40, 220);
            lblExplanation.Name = "lblExplanation";
            lblExplanation.Size = new Size(844, 100);
            lblExplanation.TabIndex = 1;
            lblExplanation.TextAlign = ContentAlignment.MiddleCenter;
            lblExplanation.Visible = false;
            // 
            // btnFalse
            // 
            btnFalse.Anchor = AnchorStyles.None;
            btnFalse.BackColor = Color.Red;
            btnFalse.FlatStyle = FlatStyle.Flat;
            btnFalse.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFalse.ForeColor = Color.FromArgb(1, 34, 62);
            btnFalse.Location = new Point(40, 323);
            btnFalse.Name = "btnFalse";
            btnFalse.Size = new Size(352, 127);
            btnFalse.TabIndex = 2;
            btnFalse.Text = "Falso";
            btnFalse.UseVisualStyleBackColor = false;
            btnFalse.Click += btnFalse_Click;
            // 
            // btnTrue
            // 
            btnTrue.Anchor = AnchorStyles.None;
            btnTrue.BackColor = Color.Lime;
            btnTrue.FlatStyle = FlatStyle.Flat;
            btnTrue.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTrue.ForeColor = Color.FromArgb(1, 34, 62);
            btnTrue.Location = new Point(532, 323);
            btnTrue.Name = "btnTrue";
            btnTrue.Size = new Size(352, 127);
            btnTrue.TabIndex = 3;
            btnTrue.Text = "Verdadeiro";
            btnTrue.UseVisualStyleBackColor = false;
            btnTrue.Click += btnTrue_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.BackColor = Color.FromArgb(231, 237, 58);
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.FromArgb(1, 34, 62);
            btnNext.Location = new Point(290, 508);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(542, 140);
            btnNext.TabIndex = 4;
            btnNext.Text = "Próximo →";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Visible = false;
            btnNext.Click += btnNext_Click;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.BackColor = Color.FromArgb(2, 36, 64);
            lblProgress.Dock = DockStyle.Top;
            lblProgress.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProgress.ForeColor = SystemColors.ActiveCaption;
            lblProgress.Location = new Point(0, 0);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(0, 50);
            lblProgress.TabIndex = 5;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.BackColor = Color.FromArgb(231, 237, 58);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.FromArgb(1, 34, 62);
            btnBack.Location = new Point(105, 508);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(542, 140);
            btnBack.TabIndex = 6;
            btnBack.Text = "⬅   Voltar";
            btnBack.TextAlign = ContentAlignment.MiddleLeft;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(2, 36, 64);
            panel1.Controls.Add(lblProgress);
            panel1.Controls.Add(lblQuestion);
            panel1.Controls.Add(lblExplanation);
            panel1.Controls.Add(btnFalse);
            panel1.Controls.Add(btnTrue);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(btnBack);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(924, 700);
            panel1.TabIndex = 0;
            // 
            // BasicPractice
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(924, 700);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BasicPractice";
            Text = "BasicPractice";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
    }
}