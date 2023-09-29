namespace Escritorio.MenuAdminForm
{
    partial class MenuAdmin
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
            espBtn = new Button();
            planBtn = new Button();
            button3 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // espBtn
            // 
            espBtn.Location = new Point(21, 120);
            espBtn.Name = "espBtn";
            espBtn.Size = new Size(80, 23);
            espBtn.TabIndex = 0;
            espBtn.Text = "Especialidad";
            espBtn.UseVisualStyleBackColor = true;
            espBtn.Click += espBtn_Click;
            // 
            // planBtn
            // 
            planBtn.Location = new Point(107, 120);
            planBtn.Name = "planBtn";
            planBtn.Size = new Size(81, 23);
            planBtn.TabIndex = 1;
            planBtn.Text = "Plan";
            planBtn.UseVisualStyleBackColor = true;
            planBtn.Click += planBtn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(194, 120);
            button3.Name = "button3";
            button3.Size = new Size(80, 23);
            button3.TabIndex = 2;
            button3.Text = "Persona";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 53);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 3;
            label1.Text = "Menu de administración";
            // 
            // MenuAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 186);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(planBtn);
            Controls.Add(espBtn);
            Name = "MenuAdmin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button espBtn;
        private Button planBtn;
        private Button button3;
        private Label label1;
    }
}