namespace EjerciciosLibro.UI
{
    partial class Hora
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
            this.HoraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HoraTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HoraButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HoraDateTimePicker
            // 
            this.HoraDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HoraDateTimePicker.Location = new System.Drawing.Point(12, 39);
            this.HoraDateTimePicker.Name = "HoraDateTimePicker";
            this.HoraDateTimePicker.Size = new System.Drawing.Size(105, 20);
            this.HoraDateTimePicker.TabIndex = 0;
            // 
            // HoraTextBox
            // 
            this.HoraTextBox.Location = new System.Drawing.Point(182, 39);
            this.HoraTextBox.Name = "HoraTextBox";
            this.HoraTextBox.Size = new System.Drawing.Size(204, 20);
            this.HoraTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hora Actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Texto";
            // 
            // HoraButton
            // 
            this.HoraButton.Location = new System.Drawing.Point(13, 95);
            this.HoraButton.Name = "HoraButton";
            this.HoraButton.Size = new System.Drawing.Size(75, 23);
            this.HoraButton.TabIndex = 4;
            this.HoraButton.Text = "Hora";
            this.HoraButton.UseVisualStyleBackColor = true;
            this.HoraButton.Click += new System.EventHandler(this.HoraButton_Click);
            // 
            // Hora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 192);
            this.Controls.Add(this.HoraButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HoraTextBox);
            this.Controls.Add(this.HoraDateTimePicker);
            this.Name = "Hora";
            this.Text = "Hora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker HoraDateTimePicker;
        private System.Windows.Forms.TextBox HoraTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button HoraButton;
    }
}