namespace Calculadora_de_Viajes
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
            PuntodeOrigen = new TextBox();
            PuntoDestino = new TextBox();
            VelocidadConstante = new TextBox();
            Calcular = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // PuntodeOrigen
            // 
            PuntodeOrigen.Location = new Point(290, 27);
            PuntodeOrigen.Name = "PuntodeOrigen";
            PuntodeOrigen.Size = new Size(132, 23);
            PuntodeOrigen.TabIndex = 0;
            PuntodeOrigen.TextChanged += textBox1_TextChanged;
            // 
            // PuntoDestino
            // 
            PuntoDestino.Location = new Point(290, 71);
            PuntoDestino.Name = "PuntoDestino";
            PuntoDestino.Size = new Size(132, 23);
            PuntoDestino.TabIndex = 1;
            // 
            // VelocidadConstante
            // 
            VelocidadConstante.Location = new Point(290, 118);
            VelocidadConstante.Name = "VelocidadConstante";
            VelocidadConstante.Size = new Size(139, 23);
            VelocidadConstante.TabIndex = 2;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(315, 173);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(95, 31);
            Calcular.TabIndex = 3;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(290, 257);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 23);
            textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(Calcular);
            Controls.Add(VelocidadConstante);
            Controls.Add(PuntoDestino);
            Controls.Add(PuntodeOrigen);
            Name = "Form1";
            Text = "Calculadora Lu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PuntodeOrigen;
        private TextBox PuntoDestino;
        private TextBox VelocidadConstante;
        private Button Calcular;
        private TextBox textBox1;
    }
}
