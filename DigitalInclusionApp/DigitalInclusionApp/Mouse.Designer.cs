namespace DigitalInclusionApp
{
    partial class Mouse
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
            mouseLabel = new Label();
            voltarBtn = new Button();
            btnTarget = new Button();
            btnTargetDir = new Button();
            progressMouse = new ProgressBar();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(mouseLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1326, 100);
            panel1.TabIndex = 0;
            // 
            // mouseLabel
            // 
            mouseLabel.Anchor = AnchorStyles.Top;
            mouseLabel.AutoSize = true;
            mouseLabel.Font = new Font("Segoe UI", 70F, FontStyle.Bold);
            mouseLabel.ForeColor = SystemColors.GradientActiveCaption;
            mouseLabel.Location = new Point(498, -10);
            mouseLabel.Name = "mouseLabel";
            mouseLabel.Size = new Size(349, 125);
            mouseLabel.TabIndex = 0;
            mouseLabel.Text = "Mouse";
            mouseLabel.Click += mouseLabel_Click;
            // 
            // voltarBtn
            // 
            voltarBtn.Anchor = AnchorStyles.Bottom;
            voltarBtn.BackColor = Color.FromArgb(231, 237, 58);
            voltarBtn.FlatAppearance.BorderColor = Color.FromArgb(1, 34, 62);
            voltarBtn.FlatAppearance.BorderSize = 2;
            voltarBtn.FlatStyle = FlatStyle.Flat;
            voltarBtn.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            voltarBtn.ForeColor = Color.FromArgb(1, 34, 62);
            voltarBtn.Location = new Point(413, 726);
            voltarBtn.Name = "voltarBtn";
            voltarBtn.Size = new Size(500, 80);
            voltarBtn.TabIndex = 1;
            voltarBtn.Text = "⬅       Voltar";
            voltarBtn.TextAlign = ContentAlignment.MiddleLeft;
            voltarBtn.UseVisualStyleBackColor = false;
            voltarBtn.Click += voltarBtn_Click;
            // 
            // btnTarget
            // 
            btnTarget.BackColor = SystemColors.ActiveCaption;
            btnTarget.BackgroundImageLayout = ImageLayout.None;
            btnTarget.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btnTarget.FlatAppearance.MouseDownBackColor = Color.Green;
            btnTarget.FlatAppearance.MouseOverBackColor = Color.Green;
            btnTarget.FlatStyle = FlatStyle.Flat;
            btnTarget.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTarget.ForeColor = SystemColors.ActiveCaptionText;
            btnTarget.Location = new Point(308, 197);
            btnTarget.Name = "btnTarget";
            btnTarget.Size = new Size(212, 84);
            btnTarget.TabIndex = 2;
            btnTarget.Text = "Clique Aqui para começar!";
            btnTarget.UseVisualStyleBackColor = false;
            btnTarget.Click += btnTarget_Click;
            // 
            // btnTargetDir
            // 
            btnTargetDir.BackColor = SystemColors.ActiveCaption;
            btnTargetDir.BackgroundImageLayout = ImageLayout.None;
            btnTargetDir.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btnTargetDir.FlatAppearance.MouseDownBackColor = Color.Green;
            btnTargetDir.FlatAppearance.MouseOverBackColor = Color.Green;
            btnTargetDir.FlatStyle = FlatStyle.Flat;
            btnTargetDir.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnTargetDir.ForeColor = Color.Black;
            btnTargetDir.Location = new Point(59, 118);
            btnTargetDir.Name = "btnTargetDir";
            btnTargetDir.Size = new Size(212, 84);
            btnTargetDir.TabIndex = 3;
            btnTargetDir.Text = "Botão Direito";
            btnTargetDir.UseVisualStyleBackColor = false;
            btnTargetDir.Visible = false;
            btnTargetDir.Click += btnTargetDir_Click;
            btnTargetDir.MouseDown += btnTargetDir_Click_MouseDown;
            // 
            // progressMouse
            // 
            progressMouse.ForeColor = Color.Lime;
            progressMouse.Location = new Point(348, 648);
            progressMouse.Name = "progressMouse";
            progressMouse.Size = new Size(675, 48);
            progressMouse.TabIndex = 4;
            // 
            // Mouse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(1, 34, 62);
            ClientSize = new Size(1326, 833);
            Controls.Add(progressMouse);
            Controls.Add(btnTargetDir);
            Controls.Add(btnTarget);
            Controls.Add(voltarBtn);
            Controls.Add(panel1);
            Name = "Mouse";
            Text = "Form1";
            Load += Mouse_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label mouseLabel;
        private Button voltarBtn;
        private Button btnTarget;
        private Button btnTargetDir;
        private ProgressBar progressMouse;
    }
}