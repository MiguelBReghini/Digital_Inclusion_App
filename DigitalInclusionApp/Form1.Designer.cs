namespace DigitalInclusionApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1584, 861);
            panel2.TabIndex = 3;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 72F);
            button4.Location = new Point(85, 669);
            button4.Name = "button4";
            button4.Size = new Size(534, 135);
            button4.TabIndex = 6;
            button4.Text = "Créditos";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 60F);
            button3.Location = new Point(964, 669);
            button3.Name = "button3";
            button3.Size = new Size(534, 135);
            button3.TabIndex = 5;
            button3.Text = "Sair";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 72F);
            button2.Location = new Point(525, 432);
            button2.Name = "button2";
            button2.Size = new Size(534, 165);
            button2.TabIndex = 4;
            button2.Text = "Exercícios";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.Font = new Font("Segoe UI", 72F);
            button1.Location = new Point(525, 213);
            button1.Name = "button1";
            button1.Size = new Size(534, 165);
            button1.TabIndex = 3;
            button1.Text = "Aprender";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 72F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1584, 136);
            label1.TabIndex = 2;
            label1.Text = "ConectaIdade";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1584, 861);
            Controls.Add(panel2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bank App";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}
