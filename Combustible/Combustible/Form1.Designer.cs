namespace Combustible
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Distancia = new TextBox();
            Rendimiento = new TextBox();
            Total = new TextBox();
            Calcular = new Button();
            SuspendLayout();
            // 
            // Distancia
            // 
            Distancia.Location = new Point(300, 83);
            Distancia.Name = "Distancia";
            Distancia.Size = new Size(160, 23);
            Distancia.TabIndex = 0;
            // 
            // Rendimiento
            // 
            Rendimiento.Location = new Point(300, 130);
            Rendimiento.Name = "Rendimiento";
            Rendimiento.Size = new Size(156, 23);
            Rendimiento.TabIndex = 1;
            // 
            // Total
            // 
            Total.Location = new Point(291, 284);
            Total.Name = "Total";
            Total.Size = new Size(178, 23);
            Total.TabIndex = 2;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(328, 203);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(118, 24);
            Calcular.TabIndex = 3;
            Calcular.Text = "Calcular ";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(800, 450);
            Controls.Add(Calcular);
            Controls.Add(Total);
            Controls.Add(Rendimiento);
            Controls.Add(Distancia);
            Name = "Form1";
            Text = "Combustible ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Distancia;
        private TextBox Rendimiento;
        private TextBox Total;
        private Button Calcular;
    }
}
