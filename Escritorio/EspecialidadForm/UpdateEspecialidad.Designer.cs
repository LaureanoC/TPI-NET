namespace Escritorio.Especialidad
{
    partial class UpdateEspecialidad
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
            inputDesc = new TextBox();
            btnModificar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // inputDesc
            // 
            inputDesc.Location = new Point(107, 110);
            inputDesc.Name = "inputDesc";
            inputDesc.Size = new Size(136, 23);
            inputDesc.TabIndex = 0;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(107, 168);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 49);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 2;
            label1.Text = "Modificar Especialidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 113);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Descripción";
            // 
            // UpdateEspecialidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 249);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnModificar);
            Controls.Add(inputDesc);
            Name = "UpdateEspecialidad";
            Text = "Academia";
            Load += UpdateEspecialidad_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputDesc;
        private Button btnModificar;
        private Label label1;
        private Label label2;
    }
}