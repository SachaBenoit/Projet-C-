namespace BatailleNavale
{
    partial class FormMenu
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
            this.cmdCloseApplication = new System.Windows.Forms.Button();
            this.cmdNewPart = new System.Windows.Forms.Button();
            this.cmdChargePart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdCloseApplication
            // 
            this.cmdCloseApplication.Location = new System.Drawing.Point(583, 150);
            this.cmdCloseApplication.Name = "cmdCloseApplication";
            this.cmdCloseApplication.Size = new System.Drawing.Size(127, 106);
            this.cmdCloseApplication.TabIndex = 0;
            this.cmdCloseApplication.Text = "Fermer Application";
            this.cmdCloseApplication.UseVisualStyleBackColor = true;
            this.cmdCloseApplication.Click += new System.EventHandler(this.cmdCloseApplication_Click);
            // 
            // cmdNewPart
            // 
            this.cmdNewPart.Location = new System.Drawing.Point(93, 150);
            this.cmdNewPart.Name = "cmdNewPart";
            this.cmdNewPart.Size = new System.Drawing.Size(127, 106);
            this.cmdNewPart.TabIndex = 1;
            this.cmdNewPart.Text = "Nouvelle Partie";
            this.cmdNewPart.UseVisualStyleBackColor = true;
            this.cmdNewPart.Click += new System.EventHandler(this.cmdNewPart_Click);
            // 
            // cmdChargePart
            // 
            this.cmdChargePart.Location = new System.Drawing.Point(337, 150);
            this.cmdChargePart.Name = "cmdChargePart";
            this.cmdChargePart.Size = new System.Drawing.Size(127, 106);
            this.cmdChargePart.TabIndex = 2;
            this.cmdChargePart.Text = "Charger Partie";
            this.cmdChargePart.UseVisualStyleBackColor = true;
            this.cmdChargePart.Click += new System.EventHandler(this.cmdChargePart_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdChargePart);
            this.Controls.Add(this.cmdNewPart);
            this.Controls.Add(this.cmdCloseApplication);
            this.Name = "FormMenu";
            this.Text = "FromMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdCloseApplication;
        private System.Windows.Forms.Button cmdNewPart;
        private System.Windows.Forms.Button cmdChargePart;
    }
}