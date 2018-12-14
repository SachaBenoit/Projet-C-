namespace BatailleNavale
{
    partial class FormPart
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
            this.cmdSavePart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdSavePart
            // 
            this.cmdSavePart.Location = new System.Drawing.Point(641, 263);
            this.cmdSavePart.Name = "cmdSavePart";
            this.cmdSavePart.Size = new System.Drawing.Size(80, 50);
            this.cmdSavePart.TabIndex = 0;
            this.cmdSavePart.Text = "Sauvegarder";
            this.cmdSavePart.UseVisualStyleBackColor = true;
            this.cmdSavePart.Click += new System.EventHandler(this.cmdSavePart_Click);
            // 
            // FormPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdSavePart);
            this.Name = "FormPart";
            this.Text = "FormPart";
            this.Load += new System.EventHandler(this.FormPart_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdSavePart;
    }
}