namespace EjerciciosLibro.UI
{
    partial class Contactos
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
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumeroMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ContactosListBox = new System.Windows.Forms.ListBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(15, 59);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(121, 20);
            this.NombreTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero";
            // 
            // NumeroMaskedTextBox
            // 
            this.NumeroMaskedTextBox.Location = new System.Drawing.Point(15, 137);
            this.NumeroMaskedTextBox.Mask = "000-000-0000";
            this.NumeroMaskedTextBox.Name = "NumeroMaskedTextBox";
            this.NumeroMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.NumeroMaskedTextBox.TabIndex = 4;
            // 
            // ContactosListBox
            // 
            this.ContactosListBox.FormattingEnabled = true;
            this.ContactosListBox.Location = new System.Drawing.Point(250, 26);
            this.ContactosListBox.Name = "ContactosListBox";
            this.ContactosListBox.Size = new System.Drawing.Size(296, 251);
            this.ContactosListBox.TabIndex = 5;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(15, 212);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(121, 33);
            this.AgregarButton.TabIndex = 6;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // Contactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 290);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.ContactosListBox);
            this.Controls.Add(this.NumeroMaskedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombreTextBox);
            this.Name = "Contactos";
            this.Text = "Contactos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox NumeroMaskedTextBox;
        private System.Windows.Forms.ListBox ContactosListBox;
        private System.Windows.Forms.Button AgregarButton;
    }
}