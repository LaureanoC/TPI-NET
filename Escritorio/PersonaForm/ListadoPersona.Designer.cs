namespace Escritorio.PersonaForm
{
    partial class ListadoPersona
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
            dataPersona = new DataGridView();
            agregarBtn = new Button();
            modBtn = new Button();
            elimBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataPersona).BeginInit();
            SuspendLayout();
            // 
            // dataPersona
            // 
            dataPersona.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataPersona.Location = new Point(12, 12);
            dataPersona.Name = "dataPersona";
            dataPersona.RowTemplate.Height = 25;
            dataPersona.Size = new Size(757, 358);
            dataPersona.TabIndex = 0;
            // 
            // agregarBtn
            // 
            agregarBtn.Location = new Point(694, 376);
            agregarBtn.Name = "agregarBtn";
            agregarBtn.Size = new Size(75, 23);
            agregarBtn.TabIndex = 1;
            agregarBtn.Text = "Agregar";
            agregarBtn.UseVisualStyleBackColor = true;
            agregarBtn.Click += agregarBtn_Click;
            // 
            // modBtn
            // 
            modBtn.Location = new Point(613, 376);
            modBtn.Name = "modBtn";
            modBtn.Size = new Size(75, 23);
            modBtn.TabIndex = 2;
            modBtn.Text = "Modificar";
            modBtn.UseVisualStyleBackColor = true;
            modBtn.Click += modBtn_Click;
            // 
            // elimBtn
            // 
            elimBtn.Location = new Point(532, 376);
            elimBtn.Name = "elimBtn";
            elimBtn.Size = new Size(75, 23);
            elimBtn.TabIndex = 3;
            elimBtn.Text = "Eliminar";
            elimBtn.UseVisualStyleBackColor = true;
            elimBtn.Click += elimBtn_Click;
            // 
            // ListadoPersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 404);
            Controls.Add(elimBtn);
            Controls.Add(modBtn);
            Controls.Add(agregarBtn);
            Controls.Add(dataPersona);
            Name = "ListadoPersona";
            Text = "Academia";
            Load += ListadoPersona_Load;
            ((System.ComponentModel.ISupportInitialize)dataPersona).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataPersona;
        private Button agregarBtn;
        private Button modBtn;
        private Button elimBtn;
    }
}