namespace Escritorio.MateriaForm
{
    partial class AltaMateria
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
            inputMateria = new TextBox();
            label1 = new Label();
            inputHorasSemanales = new TextBox();
            label3 = new Label();
            inputHorasTotales = new TextBox();
            label4 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // inputMateria
            // 
            inputMateria.Location = new Point(32, 62);
            inputMateria.Name = "inputMateria";
            inputMateria.Size = new Size(121, 23);
            inputMateria.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 44);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Materia";
            // 
            // inputHorasSemanales
            // 
            inputHorasSemanales.Location = new Point(181, 62);
            inputHorasSemanales.Name = "inputHorasSemanales";
            inputHorasSemanales.Size = new Size(116, 23);
            inputHorasSemanales.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(181, 44);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 6;
            label3.Text = "HorasSemanales";
            // 
            // inputHorasTotales
            // 
            inputHorasTotales.Location = new Point(181, 114);
            inputHorasTotales.Name = "inputHorasTotales";
            inputHorasTotales.Size = new Size(116, 23);
            inputHorasTotales.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(181, 96);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 8;
            label4.Text = "HorasTotales";
            // 
            // button1
            // 
            button1.Location = new Point(113, 169);
            button1.Name = "button1";
            button1.Size = new Size(109, 23);
            button1.TabIndex = 10;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(32, 114);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 96);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 12;
            label5.Text = "Plan";
            // 
            // AltaMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 213);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(inputHorasTotales);
            Controls.Add(label4);
            Controls.Add(inputHorasSemanales);
            Controls.Add(label3);
            Controls.Add(inputMateria);
            Controls.Add(label1);
            Name = "AltaMateria";
            Text = "Academia";
            Load += AltaMateria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputMateria;
        private Label label1;
        private TextBox inputHorasSemanales;
        private Label label3;
        private TextBox inputHorasTotales;
        private Label label4;
        private Button button1;
        private ComboBox comboBox1;
        private Label label5;
    }
}