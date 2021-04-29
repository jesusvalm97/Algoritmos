namespace WindowsFormsAppImageWithText
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxText = new System.Windows.Forms.TextBox();
            this.cmdCreateImage = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdCreateImage);
            this.panel1.Controls.Add(this.txtBoxText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 199);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa un texto";
            // 
            // txtBoxText
            // 
            this.txtBoxText.Location = new System.Drawing.Point(0, 16);
            this.txtBoxText.Name = "txtBoxText";
            this.txtBoxText.Size = new System.Drawing.Size(100, 20);
            this.txtBoxText.TabIndex = 1;
            // 
            // cmdCreateImage
            // 
            this.cmdCreateImage.Location = new System.Drawing.Point(11, 42);
            this.cmdCreateImage.Name = "cmdCreateImage";
            this.cmdCreateImage.Size = new System.Drawing.Size(89, 23);
            this.cmdCreateImage.TabIndex = 2;
            this.cmdCreateImage.Text = "Crear Imagen";
            this.cmdCreateImage.UseVisualStyleBackColor = true;
            this.cmdCreateImage.Click += new System.EventHandler(this.cmdCreateImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdCreateImage;
        private System.Windows.Forms.TextBox txtBoxText;
        private System.Windows.Forms.Label label1;
    }
}

