namespace EjerciciosLibro.UI
{
    partial class Cadenas
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
            this.Cad1RichTextBox = new System.Windows.Forms.RichTextBox();
            this.Cad2RichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OrdenButton = new System.Windows.Forms.Button();
            this.OrdenListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Cad1RichTextBox
            // 
            this.Cad1RichTextBox.Location = new System.Drawing.Point(13, 37);
            this.Cad1RichTextBox.Name = "Cad1RichTextBox";
            this.Cad1RichTextBox.Size = new System.Drawing.Size(179, 96);
            this.Cad1RichTextBox.TabIndex = 0;
            this.Cad1RichTextBox.Text = "";
            // 
            // Cad2RichTextBox
            // 
            this.Cad2RichTextBox.Location = new System.Drawing.Point(286, 37);
            this.Cad2RichTextBox.Name = "Cad2RichTextBox";
            this.Cad2RichTextBox.Size = new System.Drawing.Size(199, 96);
            this.Cad2RichTextBox.TabIndex = 1;
            this.Cad2RichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadena 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cadena 2";
            // 
            // OrdenButton
            // 
            this.OrdenButton.Location = new System.Drawing.Point(468, 339);
            this.OrdenButton.Name = "OrdenButton";
            this.OrdenButton.Size = new System.Drawing.Size(125, 36);
            this.OrdenButton.TabIndex = 4;
            this.OrdenButton.Text = "Ordenar";
            this.OrdenButton.UseVisualStyleBackColor = true;
            this.OrdenButton.Click += new System.EventHandler(this.OrdenButton_Click);
            // 
            // OrdenListBox
            // 
            this.OrdenListBox.FormattingEnabled = true;
            this.OrdenListBox.Location = new System.Drawing.Point(13, 190);
            this.OrdenListBox.Name = "OrdenListBox";
            this.OrdenListBox.Size = new System.Drawing.Size(368, 225);
            this.OrdenListBox.TabIndex = 5;
            // 
            // Cadenas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.OrdenListBox);
            this.Controls.Add(this.OrdenButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cad2RichTextBox);
            this.Controls.Add(this.Cad1RichTextBox);
            this.Name = "Cadenas";
            this.Text = "Cadenas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Cad1RichTextBox;
        private System.Windows.Forms.RichTextBox Cad2RichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OrdenButton;
        private System.Windows.Forms.ListBox OrdenListBox;
    }
}