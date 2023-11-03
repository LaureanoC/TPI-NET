namespace Escritorio.PersonaForm
{
    partial class AltaPersona
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            inputNombre = new TextBox();
            inputApellido = new TextBox();
            inputLegajo = new TextBox();
            inputDir = new TextBox();
            inputTelefono = new TextBox();
            label6 = new Label();
            aggBtn = new Button();
            inputFechaNac = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            inputComboPlan = new ComboBox();
            label9 = new Label();
            inputEmail = new TextBox();
            inputTipo = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 60);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 116);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 160);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Dirección";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(167, 60);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 3;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(167, 116);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 4;
            label5.Text = "Legajo";
            // 
            // inputNombre
            // 
            inputNombre.Location = new Point(36, 81);
            inputNombre.Name = "inputNombre";
            inputNombre.Size = new Size(100, 23);
            inputNombre.TabIndex = 5;
            // 
            // inputApellido
            // 
            inputApellido.Location = new Point(36, 134);
            inputApellido.Name = "inputApellido";
            inputApellido.Size = new Size(100, 23);
            inputApellido.TabIndex = 6;
            // 
            // inputLegajo
            // 
            inputLegajo.Location = new Point(167, 134);
            inputLegajo.Name = "inputLegajo";
            inputLegajo.Size = new Size(100, 23);
            inputLegajo.TabIndex = 7;
            // 
            // inputDir
            // 
            inputDir.Location = new Point(36, 178);
            inputDir.Name = "inputDir";
            inputDir.Size = new Size(100, 23);
            inputDir.TabIndex = 7;
            // 
            // inputTelefono
            // 
            inputTelefono.Location = new Point(167, 81);
            inputTelefono.Name = "inputTelefono";
            inputTelefono.Size = new Size(100, 23);
            inputTelefono.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(117, 23);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 9;
            label6.Text = "Nueva persona";
            // 
            // aggBtn
            // 
            aggBtn.Location = new Point(103, 327);
            aggBtn.Name = "aggBtn";
            aggBtn.Size = new Size(100, 23);
            aggBtn.TabIndex = 10;
            aggBtn.Text = "Agregar";
            aggBtn.UseVisualStyleBackColor = true;
            aggBtn.Click += aggBtn_Click;
            // 
            // inputFechaNac
            // 
            inputFechaNac.Location = new Point(167, 236);
            inputFechaNac.Name = "inputFechaNac";
            inputFechaNac.Size = new Size(100, 23);
            inputFechaNac.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(167, 216);
            label7.Name = "label7";
            label7.Size = new Size(119, 15);
            label7.TabIndex = 12;
            label7.Text = "Fecha de Nacimiento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 216);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 13;
            label8.Text = "Plan";
            // 
            // inputComboPlan
            // 
            inputComboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            inputComboPlan.FormattingEnabled = true;
            inputComboPlan.Location = new Point(36, 234);
            inputComboPlan.Name = "inputComboPlan";
            inputComboPlan.Size = new Size(100, 23);
            inputComboPlan.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(167, 160);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 15;
            label9.Text = "Email";
            // 
            // inputEmail
            // 
            inputEmail.Location = new Point(167, 178);
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(100, 23);
            inputEmail.TabIndex = 16;
            // 
            // inputTipo
            // 
            inputTipo.FormattingEnabled = true;
            inputTipo.Items.AddRange(new object[] { "Profesor", "Alumno" });
            inputTipo.Location = new Point(103, 280);
            inputTipo.Name = "inputTipo";
            inputTipo.Size = new Size(100, 23);
            inputTipo.TabIndex = 17;
            // 
            // AltaPersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 362);
            Controls.Add(inputTipo);
            Controls.Add(inputEmail);
            Controls.Add(label9);
            Controls.Add(inputComboPlan);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(inputFechaNac);
            Controls.Add(aggBtn);
            Controls.Add(label6);
            Controls.Add(inputTelefono);
            Controls.Add(inputDir);
            Controls.Add(inputLegajo);
            Controls.Add(inputApellido);
            Controls.Add(inputNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AltaPersona";
            Text = "Academia";
            Load += AltaPersona_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox inputNombre;
        private TextBox inputApellido;
        private TextBox inputLegajo;
        private TextBox inputDir;
        private TextBox inputTelefono;
        private Label label6;
        private Button aggBtn;
        private DateTimePicker inputFechaNac;
        private Label label7;
        private Label label8;
        private ComboBox inputComboPlan;
        private Label label9;
        private TextBox inputEmail;
        private ComboBox inputTipo;
    }
}