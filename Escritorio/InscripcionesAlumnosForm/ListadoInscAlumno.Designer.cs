namespace Escritorio.InscripcionesAlumnosForm
{
    partial class ListadoInscAlumno
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
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnMod = new Button();
            btnDelete = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 272);
            dataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(713, 301);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Añadir";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnMod
            // 
            btnMod.Location = new Point(632, 301);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(75, 23);
            btnMod.TabIndex = 2;
            btnMod.Text = "Modificar";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(551, 301);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(457, 301);
            button1.Name = "button1";
            button1.Size = new Size(88, 23);
            button1.TabIndex = 4;
            button1.Text = "Registrar nota";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ListadoInscAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 336);
            Controls.Add(button1);
            Controls.Add(btnDelete);
            Controls.Add(btnMod);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Name = "ListadoInscAlumno";
            Text = "Academia";
            Load += ListadoInscAlumno_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnMod;
        private Button btnDelete;
        private Button button1;
    }
}