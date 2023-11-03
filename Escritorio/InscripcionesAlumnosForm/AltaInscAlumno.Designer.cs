namespace Escritorio.InscripcionesAlumnosForm
{
    partial class AltaInscAlumno
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
            comboAlumno = new ComboBox();
            comboCurso = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(133, 194);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Inscribir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboAlumno
            // 
            comboAlumno.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAlumno.FormattingEnabled = true;
            comboAlumno.Location = new Point(111, 125);
            comboAlumno.Name = "comboAlumno";
            comboAlumno.Size = new Size(97, 23);
            comboAlumno.TabIndex = 3;
            // 
            // comboCurso
            // 
            comboCurso.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCurso.FormattingEnabled = true;
            comboCurso.Location = new Point(111, 83);
            comboCurso.Name = "comboCurso";
            comboCurso.Size = new Size(208, 23);
            comboCurso.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 83);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "Curso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 128);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 6;
            label2.Text = "Legajo Alumno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 35);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 7;
            label3.Text = "Inscripción";
            // 
            // AltaInscAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 254);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboCurso);
            Controls.Add(comboAlumno);
            Controls.Add(button1);
            Name = "AltaInscAlumno";
            Text = "Academia";
            Load += AltaInscAlumno_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboAlumno;
        private ComboBox comboCurso;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}