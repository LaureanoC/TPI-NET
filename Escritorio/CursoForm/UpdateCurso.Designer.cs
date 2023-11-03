namespace Escritorio.CursoForm
{
    partial class UpdateCurso
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
            comboMateria = new ComboBox();
            comboComision = new ComboBox();
            label4 = new Label();
            inputCupo = new TextBox();
            inputAnio = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // comboMateria
            // 
            comboMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboMateria.FormattingEnabled = true;
            comboMateria.Location = new Point(161, 49);
            comboMateria.Name = "comboMateria";
            comboMateria.Size = new Size(121, 23);
            comboMateria.TabIndex = 27;
            // 
            // comboComision
            // 
            comboComision.DropDownStyle = ComboBoxStyle.DropDownList;
            comboComision.FormattingEnabled = true;
            comboComision.Location = new Point(161, 81);
            comboComision.Name = "comboComision";
            comboComision.Size = new Size(121, 23);
            comboComision.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 52);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 25;
            label4.Text = "Materia";
            // 
            // inputCupo
            // 
            inputCupo.Location = new Point(161, 124);
            inputCupo.Name = "inputCupo";
            inputCupo.Size = new Size(118, 23);
            inputCupo.TabIndex = 24;
            // 
            // inputAnio
            // 
            inputAnio.Location = new Point(161, 153);
            inputAnio.Name = "inputAnio";
            inputAnio.Size = new Size(118, 23);
            inputAnio.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 124);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 22;
            label3.Text = "Cupo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 84);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 21;
            label2.Text = "Comision";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 156);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 20;
            label1.Text = "Año";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(178, 193);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Modificar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // UpdateCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 267);
            Controls.Add(comboMateria);
            Controls.Add(comboComision);
            Controls.Add(label4);
            Controls.Add(inputCupo);
            Controls.Add(inputAnio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Name = "UpdateCurso";
            Text = "Academia";
            Load += UpdateCurso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboMateria;
        private ComboBox comboComision;
        private Label label4;
        private TextBox inputCupo;
        private TextBox inputAnio;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAdd;
    }
}