namespace Escritorio.Especialidad
{
    partial class ListadoEspecialidadForm
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
            dataEspecialidad = new DataGridView();
            btnAgregar = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataEspecialidad).BeginInit();
            SuspendLayout();
            // 
            // dataEspecialidad
            // 
            dataEspecialidad.AllowUserToAddRows = false;
            dataEspecialidad.AllowUserToDeleteRows = false;
            dataEspecialidad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataEspecialidad.Location = new Point(12, 12);
            dataEspecialidad.Name = "dataEspecialidad";
            dataEspecialidad.ReadOnly = true;
            dataEspecialidad.RowTemplate.Height = 25;
            dataEspecialidad.Size = new Size(420, 230);
            dataEspecialidad.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(357, 248);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(276, 248);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(195, 247);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ListadoEspecialidadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 282);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnAgregar);
            Controls.Add(dataEspecialidad);
            Name = "ListadoEspecialidadForm";
            Text = "Academia";
            Load += ListadoEspecialidadForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataEspecialidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataEspecialidad;
        private Button btnAgregar;
        private Button button2;
        private Button button3;
    }
}