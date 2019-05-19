namespace EjerciciosLibro.UI
{
    partial class Diccionario
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
            this.PalabraTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.DiccionariolistBox = new System.Windows.Forms.ListBox();
            this.SignificadoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // PalabraTextBox
            // 
            this.PalabraTextBox.Location = new System.Drawing.Point(12, 52);
            this.PalabraTextBox.Name = "PalabraTextBox";
            this.PalabraTextBox.Size = new System.Drawing.Size(141, 20);
            this.PalabraTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Palabra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Significado";
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(413, 48);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 4;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // DiccionariolistBox
            // 
            this.DiccionariolistBox.FormattingEnabled = true;
            this.DiccionariolistBox.Location = new System.Drawing.Point(12, 161);
            this.DiccionariolistBox.Name = "DiccionariolistBox";
            this.DiccionariolistBox.Size = new System.Drawing.Size(361, 186);
            this.DiccionariolistBox.TabIndex = 5;
            // 
            // SignificadoRichTextBox
            // 
            this.SignificadoRichTextBox.Location = new System.Drawing.Point(179, 59);
            this.SignificadoRichTextBox.Name = "SignificadoRichTextBox";
            this.SignificadoRichTextBox.Size = new System.Drawing.Size(194, 79);
            this.SignificadoRichTextBox.TabIndex = 6;
            this.SignificadoRichTextBox.Text = "";
            // 
            // Diccionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 359);
            this.Controls.Add(this.SignificadoRichTextBox);
            this.Controls.Add(this.DiccionariolistBox);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PalabraTextBox);
            this.Name = "Diccionario";
            this.Text = "Diccionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PalabraTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.ListBox DiccionariolistBox;
        private System.Windows.Forms.RichTextBox SignificadoRichTextBox;
    }
}