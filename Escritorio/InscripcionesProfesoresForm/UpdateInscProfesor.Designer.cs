namespace Escritorio.InscripcionesProfesoresForm
{
    partial class UpdateInscProfesor
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
            inputCurso = new ComboBox();
            inputCargo = new TextBox();
            button1 = new Button();
            legajo = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 46);
            label1.Name = "label1";
            label1.Size = new Size(223, 15);
            label1.TabIndex = 9;
            label1.Text = "Modificar Inscripción de profesor a curso";
            // 
            // inputCurso
            // 
            inputCurso.DropDownStyle = ComboBoxStyle.DropDownList;
            inputCurso.FormattingEnabled = true;
            inputCurso.Location = new Point(105, 125);
            inputCurso.Name = "inputCurso";
            inputCurso.Size = new Size(169, 23);
            inputCurso.TabIndex = 8;
            // 
            // inputCargo
            // 
            inputCargo.Location = new Point(105, 154);
            inputCargo.Name = "inputCargo";
            inputCargo.PlaceholderText = "Cargo";
            inputCargo.Size = new Size(169, 23);
            inputCargo.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(148, 199);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // legajo
            // 
            legajo.AutoSize = true;
            legajo.Location = new Point(199, 89);
            legajo.Name = "legajo";
            legajo.Size = new Size(42, 15);
            legajo.TabIndex = 16;
            legajo.Text = "Legajo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 89);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 15;
            label2.Text = "Legajo Profesor:";
            // 
            // UpdateInscProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 270);
            Controls.Add(legajo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inputCurso);
            Controls.Add(inputCargo);
            Controls.Add(button1);
            Name = "UpdateInscProfesor";
            Text = "Academia";
            Load += UpdateInscProfesor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox inputCurso;
        private TextBox inputCargo;
        private Button button1;
        private Label legajo;
        private Label label2;
    }
}