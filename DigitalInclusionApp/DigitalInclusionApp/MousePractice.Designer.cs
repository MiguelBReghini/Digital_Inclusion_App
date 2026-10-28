namespace DigitalInclusionApp
{
    partial class MousePractice
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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(mouseLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(810, 100);
            panel1.TabIndex = 0;
            // 
            // mouseLabel
            // 
            mouseLabel.Anchor = AnchorStyles.Top;
            mouseLabel.AutoSize = true;
            mouseLabel.Font = new Font("Segoe UI", 34F);
            mouseLabel.Location = new Point(334, 9);
            mouseLabel.Name = "mouseLabel";
            mouseLabel.Size = new Size(165, 62);
            mouseLabel.TabIndex = 0;
            mouseLabel.Text = "Mouse";
            // 
            // voltarBtn
            // 
            voltarBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            voltarBtn.Font = new Font("Segoe UI", 22F);
            voltarBtn.Location = new Point(685, 401);
            voltarBtn.Name = "voltarBtn";
            voltarBtn.Size = new Size(113, 46);
            voltarBtn.TabIndex = 1;
            voltarBtn.Text = "Voltar";
            voltarBtn.UseVisualStyleBackColor = true;
            voltarBtn.Click += voltarBtn_Click;
            // 
            // btnTarget
            // 
            btnTarget.Font = new Font("Segoe UI", 14F);
            btnTarget.Location = new Point(314, 230);
            btnTarget.Name = "btnTarget";
            btnTarget.Size = new Size(203, 70);
            btnTarget.TabIndex = 2;
            btnTarget.Text = "Clique Aqui para começar";
            btnTarget.UseVisualStyleBackColor = true;
            btnTarget.Click += btnTarget_Click;
            // 
            // btnTargetDir
            // 
            btnTargetDir.Font = new Font("Segoe UI", 14F);
            btnTargetDir.Location = new Point(35, 138);
            btnTargetDir.Name = "btnTargetDir";
            btnTargetDir.Size = new Size(203, 70);
            btnTargetDir.TabIndex = 3;
            btnTargetDir.Text = "Clique Aqui com o Botão Direito";
            btnTargetDir.UseVisualStyleBackColor = true;
            btnTargetDir.Visible = false;
            btnTargetDir.MouseDown += btnTargetDir_Click_MouseDown;
            // 
            // Mouse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 459);
            Controls.Add(btnTargetDir);
            Controls.Add(btnTarget);
            Controls.Add(voltarBtn);
            Controls.Add(panel1);
            Name = "Mouse";
            Text = "Form1";
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
    }
}