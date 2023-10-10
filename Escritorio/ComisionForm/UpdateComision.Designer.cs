namespace Escritorio.ComisionForm
{
    partial class UpdateComision
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
            label3 = new Label();
            inputAnio = new TextBox();
            label2 = new Label();
            inputDesc = new TextBox();
            label1 = new Label();
            comboPlan = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(67, 203);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 17;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 139);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 16;
            label3.Text = "Año";
            // 
            // inputAnio
            // 
            inputAnio.Location = new Point(66, 157);
            inputAnio.Name = "inputAnio";
            inputAnio.Size = new Size(121, 23);
            inputAnio.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 37);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 14;
            label2.Text = "Descripción";
            // 
            // inputDesc
            // 
            inputDesc.Location = new Point(66, 55);
            inputDesc.Name = "inputDesc";
            inputDesc.Size = new Size(121, 23);
            inputDesc.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 94);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 12;
            label1.Text = "Plan";
            // 
            // comboPlan
            // 
            comboPlan.FormattingEnabled = true;
            comboPlan.Location = new Point(66, 112);
            comboPlan.Name = "comboPlan";
            comboPlan.Size = new Size(121, 23);
            comboPlan.TabIndex = 11;
            // 
            // UpdateComision
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 262);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(inputAnio);
            Controls.Add(label2);
            Controls.Add(inputDesc);
            Controls.Add(label1);
            Controls.Add(comboPlan);
            Name = "UpdateComision";
            Text = "Academia";
            Load += UpdateComision_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label3;
        private TextBox inputAnio;
        private Label label2;
        private TextBox inputDesc;
        private Label label1;
        private ComboBox comboPlan;
    }
}