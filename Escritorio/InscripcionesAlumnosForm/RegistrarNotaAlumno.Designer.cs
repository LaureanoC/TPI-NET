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
            label1 = new Label();
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
            comboCurso.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCurso.FormattingEnabled = true;
            comboCurso.Location = new Point(23, 96);
            comboCurso.Name = "comboCurso";
            comboCurso.Size = new Size(239, 23);
            comboCurso.TabIndex = 1;
            // 
            // comboAlumno
            // 
            comboAlumno.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAlumno.FormattingEnabled = true;
            comboAlumno.Location = new Point(23, 52);
            comboAlumno.Name = "comboAlumno";
            comboAlumno.Size = new Size(239, 23);
            comboAlumno.TabIndex = 2;
            comboAlumno.DropDownClosed += comboAlumno_DropDownClosed;
            // 
            // inputNota
            // 
            inputNota.Location = new Point(23, 135);
            inputNota.Name = "inputNota";
            inputNota.PlaceholderText = "Nota";
            inputNota.Size = new Size(239, 23);
            inputNota.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 19);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 4;
            label1.Text = "Registrar nota";
            // 
            // RegistrarNotaAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 270);
            Controls.Add(label1);
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
        private Label label1;
    }
}