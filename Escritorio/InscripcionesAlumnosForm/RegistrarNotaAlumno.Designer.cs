namespace Escritorio.InscripcionesAlumnosForm
{
    partial class RegistrarNotaAlumno
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
            comboCurso = new ComboBox();
            comboAlumno = new ComboBox();
            inputNota = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(104, 182);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboCurso
            // 
            comboCurso.FormattingEnabled = true;
            comboCurso.Location = new Point(83, 92);
            comboCurso.Name = "comboCurso";
            comboCurso.Size = new Size(121, 23);
            comboCurso.TabIndex = 1;
            // 
            // comboAlumno
            // 
            comboAlumno.FormattingEnabled = true;
            comboAlumno.Location = new Point(83, 52);
            comboAlumno.Name = "comboAlumno";
            comboAlumno.Size = new Size(121, 23);
            comboAlumno.TabIndex = 2;
            comboAlumno.DropDownClosed += comboAlumno_DropDownClosed;
            // 
            // inputNota
            // 
            inputNota.Location = new Point(83, 135);
            inputNota.Name = "inputNota";
            inputNota.PlaceholderText = "Nota";
            inputNota.Size = new Size(121, 23);
            inputNota.TabIndex = 3;
            // 
            // RegistrarNotaAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 270);
            Controls.Add(inputNota);
            Controls.Add(comboAlumno);
            Controls.Add(comboCurso);
            Controls.Add(button1);
            Name = "RegistrarNotaAlumno";
            Text = "Academia";
            Load += RegistrarNotaAlumno_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboCurso;
        private ComboBox comboAlumno;
        private TextBox inputNota;
    }
}