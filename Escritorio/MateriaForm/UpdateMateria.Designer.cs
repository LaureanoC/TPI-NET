namespace Escritorio.MateriaForm
{
    partial class UpdateMateria
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
            label5 = new Label();
            comboBox1 = new ComboBox();
            btnModificar = new Button();
            inputHorasTotales = new TextBox();
            label4 = new Label();
            inputHorasSemanales = new TextBox();
            label3 = new Label();
            inputMateria = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 102);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 23;
            label5.Text = "Plan";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(73, 120);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 22;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(140, 178);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(109, 23);
            btnModificar.TabIndex = 21;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // inputHorasTotales
            // 
            inputHorasTotales.Location = new Point(222, 120);
            inputHorasTotales.Name = "inputHorasTotales";
            inputHorasTotales.Size = new Size(116, 23);
            inputHorasTotales.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(222, 102);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 19;
            label4.Text = "HorasTotales";
            // 
            // inputHorasSemanales
            // 
            inputHorasSemanales.Location = new Point(222, 68);
            inputHorasSemanales.Name = "inputHorasSemanales";
            inputHorasSemanales.Size = new Size(116, 23);
            inputHorasSemanales.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(222, 50);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 17;
            label3.Text = "HorasSemanales";
            // 
            // inputMateria
            // 
            inputMateria.Location = new Point(73, 68);
            inputMateria.Name = "inputMateria";
            inputMateria.Size = new Size(121, 23);
            inputMateria.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 50);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 13;
            label1.Text = "Materia";
            // 
            // UpdateMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 254);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(btnModificar);
            Controls.Add(inputHorasTotales);
            Controls.Add(label4);
            Controls.Add(inputHorasSemanales);
            Controls.Add(label3);
            Controls.Add(inputMateria);
            Controls.Add(label1);
            Name = "UpdateMateria";
            Text = "Form1";
            Load += UpdateMateria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private ComboBox comboBox1;
        private Button btnModificar;
        private TextBox inputHorasTotales;
        private Label label4;
        private TextBox inputHorasSemanales;
        private Label label3;
        private TextBox inputMateria;
        private Label label1;
    }
}