namespace Escritorio.PersonaForm
{
    partial class UpdatePersona
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
            inputEmail = new TextBox();
            label9 = new Label();
            inputComboPlan = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            inputFechaNac = new DateTimePicker();
            modBtn = new Button();
            label6 = new Label();
            inputTelefono = new TextBox();
            inputDir = new TextBox();
            inputLegajo = new TextBox();
            inputApellido = new TextBox();
            inputNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // inputEmail
            // 
            inputEmail.Location = new Point(178, 198);
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(100, 23);
            inputEmail.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(178, 180);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 33;
            label9.Text = "Email";
            // 
            // inputComboPlan
            // 
            inputComboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            inputComboPlan.FormattingEnabled = true;
            inputComboPlan.Location = new Point(47, 254);
            inputComboPlan.Name = "inputComboPlan";
            inputComboPlan.Size = new Size(100, 23);
            inputComboPlan.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 236);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 31;
            label8.Text = "Plan";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(178, 236);
            label7.Name = "label7";
            label7.Size = new Size(119, 15);
            label7.TabIndex = 30;
            label7.Text = "Fecha de Nacimiento";
            // 
            // inputFechaNac
            // 
            inputFechaNac.Location = new Point(178, 256);
            inputFechaNac.Name = "inputFechaNac";
            inputFechaNac.Size = new Size(100, 23);
            inputFechaNac.TabIndex = 29;
            // 
            // modBtn
            // 
            modBtn.Location = new Point(114, 308);
            modBtn.Name = "modBtn";
            modBtn.Size = new Size(100, 23);
            modBtn.TabIndex = 28;
            modBtn.Text = "Modificar";
            modBtn.UseVisualStyleBackColor = true;
            modBtn.Click += modBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(114, 41);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 27;
            label6.Text = "Modificar persona";
            // 
            // inputTelefono
            // 
            inputTelefono.Location = new Point(178, 101);
            inputTelefono.Name = "inputTelefono";
            inputTelefono.Size = new Size(100, 23);
            inputTelefono.TabIndex = 26;
            // 
            // inputDir
            // 
            inputDir.Location = new Point(47, 198);
            inputDir.Name = "inputDir";
            inputDir.Size = new Size(100, 23);
            inputDir.TabIndex = 25;
            // 
            // inputLegajo
            // 
            inputLegajo.Location = new Point(178, 154);
            inputLegajo.Name = "inputLegajo";
            inputLegajo.Size = new Size(100, 23);
            inputLegajo.TabIndex = 24;
            // 
            // inputApellido
            // 
            inputApellido.Location = new Point(47, 154);
            inputApellido.Name = "inputApellido";
            inputApellido.Size = new Size(100, 23);
            inputApellido.TabIndex = 23;
            // 
            // inputNombre
            // 
            inputNombre.Location = new Point(47, 101);
            inputNombre.Name = "inputNombre";
            inputNombre.Size = new Size(100, 23);
            inputNombre.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(178, 136);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 21;
            label5.Text = "Legajo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(178, 80);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 20;
            label4.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 180);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 19;
            label3.Text = "Dirección";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 136);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 18;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 80);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 17;
            label1.Text = "Nombre";
            // 
            // UpdatePersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 361);
            Controls.Add(inputEmail);
            Controls.Add(label9);
            Controls.Add(inputComboPlan);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(inputFechaNac);
            Controls.Add(modBtn);
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
            Name = "UpdatePersona";
            Text = "Academia";
            Load += UpdatePersona_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputEmail;
        private Label label9;
        private ComboBox inputComboPlan;
        private Label label8;
        private Label label7;
        private DateTimePicker inputFechaNac;
        private Button modBtn;
        private Label label6;
        private TextBox inputTelefono;
        private TextBox inputDir;
        private TextBox inputLegajo;
        private TextBox inputApellido;
        private TextBox inputNombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}