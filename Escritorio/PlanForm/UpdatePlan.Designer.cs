namespace Escritorio.PlanForm
{
    partial class UpdatePlan
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboEspecialidad = new ComboBox();
            inputDesc = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(109, 188);
            button1.Name = "button1";
            button1.Size = new Size(132, 23);
            button1.TabIndex = 0;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 44);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 1;
            label1.Text = "Modificar Plan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 106);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 2;
            label2.Text = "Descripción";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 141);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 3;
            label3.Text = "Especialidad";
            // 
            // comboEspecialidad
            // 
            comboEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEspecialidad.FormattingEnabled = true;
            comboEspecialidad.Location = new Point(109, 138);
            comboEspecialidad.Name = "comboEspecialidad";
            comboEspecialidad.Size = new Size(132, 23);
            comboEspecialidad.TabIndex = 4;
            // 
            // inputDesc
            // 
            inputDesc.Location = new Point(109, 103);
            inputDesc.Name = "inputDesc";
            inputDesc.Size = new Size(132, 23);
            inputDesc.TabIndex = 5;
            // 
            // UpdatePlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 274);
            Controls.Add(inputDesc);
            Controls.Add(comboEspecialidad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "UpdatePlan";
            Text = "Form1";
            Load += UpdatePlan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboEspecialidad;
        private TextBox inputDesc;
    }
}