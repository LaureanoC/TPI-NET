namespace Escritorio.InscripcionesAlumnosForm
{
    partial class UpdateInscAlumno
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboCurso = new ComboBox();
            button1 = new Button();
            legajo = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 46);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 13;
            label3.Text = "Modificar Inscripción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 80);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 12;
            label2.Text = "Legajo Alumno:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 122);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 11;
            label1.Text = "Curso";
            // 
            // comboCurso
            // 
            comboCurso.FormattingEnabled = true;
            comboCurso.Location = new Point(111, 119);
            comboCurso.Name = "comboCurso";
            comboCurso.Size = new Size(225, 23);
            comboCurso.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(178, 166);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // legajo
            // 
            legajo.AutoSize = true;
            legajo.Location = new Point(161, 80);
            legajo.Name = "legajo";
            legajo.Size = new Size(42, 15);
            legajo.TabIndex = 14;
            legajo.Text = "Legajo";
            // 
            // UpdateInscAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 212);
            Controls.Add(legajo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboCurso);
            Controls.Add(button1);
            Name = "UpdateInscAlumno";
            Text = "Academia";
            Load += UpdateInscAlumno_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboCurso;
        private Button button1;
        private Label legajo;
    }
}