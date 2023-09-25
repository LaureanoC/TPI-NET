namespace Escritorio.PlanForm
{
    partial class AltaPlanForm
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
            btnAgregar = new Button();
            comboEspecialidad = new ComboBox();
            inputDesc = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(108, 200);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(121, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // comboEspecialidad
            // 
            comboEspecialidad.FormattingEnabled = true;
            comboEspecialidad.Location = new Point(108, 137);
            comboEspecialidad.Name = "comboEspecialidad";
            comboEspecialidad.Size = new Size(121, 23);
            comboEspecialidad.TabIndex = 1;
            // 
            // inputDesc
            // 
            inputDesc.Location = new Point(108, 96);
            inputDesc.Name = "inputDesc";
            inputDesc.Size = new Size(121, 23);
            inputDesc.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 48);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 3;
            label1.Text = "Agregar Plan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 99);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 4;
            label2.Text = "Descripción";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 140);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 5;
            label3.Text = "Especialidad";
            // 
            // AltaPlanForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 266);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inputDesc);
            Controls.Add(comboEspecialidad);
            Controls.Add(btnAgregar);
            Name = "AltaPlanForm";
            Text = "Academia";
            Load += AltaPlanForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private ComboBox comboEspecialidad;
        private TextBox inputDesc;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}