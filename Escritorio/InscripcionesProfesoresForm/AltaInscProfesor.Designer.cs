namespace Escritorio.InscripcionesProfesoresForm
{
    partial class AltaInscProfesor
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
            inputCargo = new TextBox();
            inputLegajo = new ComboBox();
            inputCurso = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(151, 171);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // inputCargo
            // 
            inputCargo.Location = new Point(108, 126);
            inputCargo.Name = "inputCargo";
            inputCargo.PlaceholderText = "Cargo";
            inputCargo.Size = new Size(169, 23);
            inputCargo.TabIndex = 1;
            // 
            // inputLegajo
            // 
            inputLegajo.DropDownStyle = ComboBoxStyle.DropDownList;
            inputLegajo.FormattingEnabled = true;
            inputLegajo.Location = new Point(108, 68);
            inputLegajo.Name = "inputLegajo";
            inputLegajo.Size = new Size(169, 23);
            inputLegajo.TabIndex = 2;
            // 
            // inputCurso
            // 
            inputCurso.DropDownStyle = ComboBoxStyle.DropDownList;
            inputCurso.FormattingEnabled = true;
            inputCurso.Location = new Point(108, 97);
            inputCurso.Name = "inputCurso";
            inputCurso.Size = new Size(169, 23);
            inputCurso.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 21);
            label1.Name = "label1";
            label1.Size = new Size(169, 15);
            label1.TabIndex = 4;
            label1.Text = "Inscripción de profesor a curso";
            // 
            // AltaInscProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 225);
            Controls.Add(label1);
            Controls.Add(inputCurso);
            Controls.Add(inputLegajo);
            Controls.Add(inputCargo);
            Controls.Add(button1);
            Name = "AltaInscProfesor";
            Text = "AltaInscProfesor";
            Load += AltaInscProfesor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox inputCargo;
        private ComboBox inputLegajo;
        private ComboBox inputCurso;
        private Label label1;
    }
}