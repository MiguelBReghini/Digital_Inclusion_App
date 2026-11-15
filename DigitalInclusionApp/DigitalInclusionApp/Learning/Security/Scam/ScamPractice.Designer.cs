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
            // btnNotScam
            // 
            btnNotScam.Anchor = AnchorStyles.None;
            btnNotScam.BackColor = Color.Lime;
            btnNotScam.FlatStyle = FlatStyle.Flat;
            btnNotScam.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNotScam.ForeColor = Color.FromArgb(1, 34, 62);
            btnNotScam.Location = new Point(40, 323);
            btnNotScam.Name = "btnNotScam";
            btnNotScam.Size = new Size(352, 127);
            btnNotScam.TabIndex = 2;
            btnNotScam.Text = "Não é Golpe";
            btnNotScam.UseVisualStyleBackColor = false;
            btnNotScam.Click += btnNotScam_Click;
            // 
            // btnScam
            // 
            btnScam.Anchor = AnchorStyles.None;
            btnScam.BackColor = Color.Red;
            btnScam.FlatStyle = FlatStyle.Flat;
            btnScam.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnScam.ForeColor = Color.FromArgb(1, 34, 62);
            btnScam.Location = new Point(532, 323);
            btnScam.Name = "btnScam";
            btnScam.Size = new Size(352, 127);
            btnScam.TabIndex = 3;
            btnScam.Text = "É um Golpe";
            btnScam.UseVisualStyleBackColor = false;
            btnScam.Click += btnScam_Click;
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
            btnNext.Text = "Próximo ➞";
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
            panel1.Controls.Add(btnNotScam);
            panel1.Controls.Add(btnScam);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(btnBack);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(924, 700);
            panel1.TabIndex = 0;
            // 
            // ScamPractice
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(924, 700);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ScamPractice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Praticar Golpes";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
    }
}