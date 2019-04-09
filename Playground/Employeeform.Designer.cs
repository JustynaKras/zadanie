namespace Playground
{
    partial class Employeeform
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.header = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imie i nazwisko";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(148, 96);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(179, 20);
            this.nameInput.TabIndex = 1;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.header.Location = new System.Drawing.Point(34, 13);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(75, 42);
            this.header.TabIndex = 2;
            this.header.Text = "xxx";
            this.header.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.header.Click += new System.EventHandler(this.header_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(372, 92);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 3;
            this.Save.Text = "OK";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Employeeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.header);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label1);
            this.Name = "Employeeform";
            this.Text = "Employform";
            this.Load += new System.EventHandler(this.Employeeform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button Save;
    }
}