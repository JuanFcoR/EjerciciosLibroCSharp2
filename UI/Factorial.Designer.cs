namespace EjerciciosLibro.UI
{
    partial class Factorial
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
            this.NumerotextBox1 = new System.Windows.Forms.TextBox();
            this.Titulolabel1 = new System.Windows.Forms.Label();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.Resultadolabel1 = new System.Windows.Forms.Label();
            this.ResultadotextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NumerotextBox1
            // 
            this.NumerotextBox1.Location = new System.Drawing.Point(85, 10);
            this.NumerotextBox1.Name = "NumerotextBox1";
            this.NumerotextBox1.Size = new System.Drawing.Size(100, 20);
            this.NumerotextBox1.TabIndex = 0;
            // 
            // Titulolabel1
            // 
            this.Titulolabel1.AutoSize = true;
            this.Titulolabel1.Location = new System.Drawing.Point(13, 13);
            this.Titulolabel1.Name = "Titulolabel1";
            this.Titulolabel1.Size = new System.Drawing.Size(47, 13);
            this.Titulolabel1.TabIndex = 1;
            this.Titulolabel1.Text = "Factorial";
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Location = new System.Drawing.Point(240, 30);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(75, 23);
            this.Calcularbutton.TabIndex = 2;
            this.Calcularbutton.Text = "Calcular";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // Resultadolabel1
            // 
            this.Resultadolabel1.AutoSize = true;
            this.Resultadolabel1.Location = new System.Drawing.Point(12, 56);
            this.Resultadolabel1.Name = "Resultadolabel1";
            this.Resultadolabel1.Size = new System.Drawing.Size(55, 13);
            this.Resultadolabel1.TabIndex = 3;
            this.Resultadolabel1.Text = "Resultado";
            // 
            // ResultadotextBox
            // 
            this.ResultadotextBox.Location = new System.Drawing.Point(85, 53);
            this.ResultadotextBox.Name = "ResultadotextBox";
            this.ResultadotextBox.Size = new System.Drawing.Size(100, 20);
            this.ResultadotextBox.TabIndex = 4;
            // 
            // Factorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 97);
            this.Controls.Add(this.ResultadotextBox);
            this.Controls.Add(this.Resultadolabel1);
            this.Controls.Add(this.Calcularbutton);
            this.Controls.Add(this.Titulolabel1);
            this.Controls.Add(this.NumerotextBox1);
            this.Name = "Factorial";
            this.Text = "Factorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumerotextBox1;
        private System.Windows.Forms.Label Titulolabel1;
        private System.Windows.Forms.Button Calcularbutton;
        private System.Windows.Forms.Label Resultadolabel1;
        private System.Windows.Forms.TextBox ResultadotextBox;
    }
}