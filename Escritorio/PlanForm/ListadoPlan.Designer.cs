namespace Escritorio.PlanForm
{
    partial class ListadoPlanForm
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
            dataPlan = new DataGridView();
            btnAgregar = new Button();
            modButton = new Button();
            elimButton = new Button();
            btnGet = new Button();
            ((System.ComponentModel.ISupportInitialize)dataPlan).BeginInit();
            SuspendLayout();
            // 
            // dataPlan
            // 
            dataPlan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataPlan.Location = new Point(12, 12);
            dataPlan.Name = "dataPlan";
            dataPlan.RowTemplate.Height = 25;
            dataPlan.Size = new Size(586, 243);
            dataPlan.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(523, 261);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // modButton
            // 
            modButton.Location = new Point(442, 261);
            modButton.Name = "modButton";
            modButton.Size = new Size(75, 23);
            modButton.TabIndex = 2;
            modButton.Text = "Modificar";
            modButton.UseVisualStyleBackColor = true;
            modButton.Click += modButton_Click;
            // 
            // elimButton
            // 
            elimButton.Location = new Point(361, 261);
            elimButton.Name = "elimButton";
            elimButton.Size = new Size(75, 23);
            elimButton.TabIndex = 3;
            elimButton.Text = "Eliminar";
            elimButton.UseVisualStyleBackColor = true;
            elimButton.Click += elimButton_Click;
            // 
            // btnGet
            // 
            btnGet.Location = new Point(280, 261);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(75, 23);
            btnGet.TabIndex = 4;
            btnGet.Text = "Get";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // ListadoPlanForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 293);
            Controls.Add(btnGet);
            Controls.Add(elimButton);
            Controls.Add(modButton);
            Controls.Add(btnAgregar);
            Controls.Add(dataPlan);
            Name = "ListadoPlanForm";
            Text = "Academia";
            Load += ListadoPlan_Load;
            ((System.ComponentModel.ISupportInitialize)dataPlan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataPlan;
        private Button btnAgregar;
        private Button modButton;
        private Button elimButton;
        private Button btnGet;
    }
}