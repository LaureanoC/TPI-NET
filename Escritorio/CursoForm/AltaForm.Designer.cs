﻿namespace Escritorio.CursoForm
{
    partial class AltaForm
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
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            inputAnio = new TextBox();
            inputCupo = new TextBox();
            label4 = new Label();
            comboComision = new ComboBox();
            comboMateria = new ComboBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(191, 205);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 168);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 1;
            label1.Text = "Año";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 96);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Comision";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 136);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 3;
            label3.Text = "Cupo";
            // 
            // inputAnio
            // 
            inputAnio.Location = new Point(174, 165);
            inputAnio.Name = "inputAnio";
            inputAnio.Size = new Size(118, 23);
            inputAnio.TabIndex = 5;
            // 
            // inputCupo
            // 
            inputCupo.Location = new Point(174, 136);
            inputCupo.Name = "inputCupo";
            inputCupo.Size = new Size(118, 23);
            inputCupo.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 64);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 7;
            label4.Text = "Materia";
            // 
            // comboComision
            // 
            comboComision.DropDownStyle = ComboBoxStyle.DropDownList;
            comboComision.FormattingEnabled = true;
            comboComision.Location = new Point(174, 93);
            comboComision.Name = "comboComision";
            comboComision.Size = new Size(121, 23);
            comboComision.TabIndex = 8;
            // 
            // comboMateria
            // 
            comboMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboMateria.FormattingEnabled = true;
            comboMateria.Location = new Point(174, 61);
            comboMateria.Name = "comboMateria";
            comboMateria.Size = new Size(121, 23);
            comboMateria.TabIndex = 9;
            // 
            // AltaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 275);
            Controls.Add(comboMateria);
            Controls.Add(comboComision);
            Controls.Add(label4);
            Controls.Add(inputCupo);
            Controls.Add(inputAnio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Name = "AltaForm";
            Text = "Academia";
            Load += AltaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox inputAnio;
        private TextBox inputCupo;
        private Label label4;
        private ComboBox comboComision;
        private ComboBox comboMateria;
    }
}