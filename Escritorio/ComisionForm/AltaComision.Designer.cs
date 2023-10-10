namespace Escritorio.ComisionForm
{
    partial class AltaComision
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
            label2 = new Label();
            inputDesc = new TextBox();
            label1 = new Label();
            comboPlan = new ComboBox();
            label3 = new Label();
            inputAnio = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 35);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 7;
            label2.Text = "Descripción";
            // 
            // inputDesc
            // 
            inputDesc.Location = new Point(21, 53);
            inputDesc.Name = "inputDesc";
            inputDesc.Size = new Size(121, 23);
            inputDesc.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 92);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 5;
            label1.Text = "Plan";
            // 
            // comboPlan
            // 
            comboPlan.FormattingEnabled = true;
            comboPlan.Location = new Point(21, 110);
            comboPlan.Name = "comboPlan";
            comboPlan.Size = new Size(121, 23);
            comboPlan.TabIndex = 4;
           
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 137);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 9;
            label3.Text = "Año";
            // 
            // inputAnio
            // 
            inputAnio.Location = new Point(21, 155);
            inputAnio.Name = "inputAnio";
            inputAnio.Size = new Size(121, 23);
            inputAnio.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(22, 201);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 10;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AltaComision
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(165, 236);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(inputAnio);
            Controls.Add(label2);
            Controls.Add(inputDesc);
            Controls.Add(label1);
            Controls.Add(comboPlan);
            Name = "AltaComision";
            Text = "Academia";
            Load += AltaComision_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox inputDesc;
        private Label label1;
        private ComboBox comboPlan;
        private Label label3;
        private TextBox inputAnio;
        private Button button1;
    }
}