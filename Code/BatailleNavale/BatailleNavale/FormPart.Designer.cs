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
            this.cmdReady = new System.Windows.Forms.Button();
            this.cmdSetOrientation = new System.Windows.Forms.Button();
            this.lblOrientation = new System.Windows.Forms.Label();
            this.lstPlayerShip = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmdReady
            // 
            this.cmdReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReady.Location = new System.Drawing.Point(613, 415);
            this.cmdReady.Name = "cmdReady";
            this.cmdReady.Size = new System.Drawing.Size(91, 32);
            this.cmdReady.TabIndex = 7;
            this.cmdReady.Text = "Prêt";
            this.cmdReady.UseVisualStyleBackColor = true;
            this.cmdReady.Click += new System.EventHandler(this.cmdReady_Click);
            // 
            // cmdSetOrientation
            // 
            this.cmdSetOrientation.Location = new System.Drawing.Point(612, 321);
            this.cmdSetOrientation.Name = "cmdSetOrientation";
            this.cmdSetOrientation.Size = new System.Drawing.Size(115, 23);
            this.cmdSetOrientation.TabIndex = 6;
            this.cmdSetOrientation.Text = "Orientation";
            this.cmdSetOrientation.UseVisualStyleBackColor = true;
            this.cmdSetOrientation.Click += new System.EventHandler(this.cmdSetOrientation_Click);
            // 
            // lblOrientation
            // 
            this.lblOrientation.AutoSize = true;
            this.lblOrientation.Location = new System.Drawing.Point(610, 347);
            this.lblOrientation.Name = "lblOrientation";
            this.lblOrientation.Size = new System.Drawing.Size(118, 13);
            this.lblOrientation.TabIndex = 5;
            this.lblOrientation.Text = "Orientation du bateau : ";
            // 
            // lstPlayerShip
            // 
            this.lstPlayerShip.FormattingEnabled = true;
            this.lstPlayerShip.Location = new System.Drawing.Point(612, 90);
            this.lstPlayerShip.Name = "lstPlayerShip";
            this.lstPlayerShip.Size = new System.Drawing.Size(234, 225);
            this.lstPlayerShip.TabIndex = 4;
            this.lstPlayerShip.SelectedIndexChanged += new System.EventHandler(this.lstPlayerShip_SelectedIndexChanged);
            // 
            // FormPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 553);
            this.Controls.Add(this.cmdReady);
            this.Controls.Add(this.cmdSetOrientation);
            this.Controls.Add(this.lblOrientation);
            this.Controls.Add(this.lstPlayerShip);
            this.Name = "FormPart";
            this.Text = "FormPart";
            this.Load += new System.EventHandler(this.FormPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdReady;
        private System.Windows.Forms.Button cmdSetOrientation;
        private System.Windows.Forms.Label lblOrientation;
        private System.Windows.Forms.ListBox lstPlayerShip;
    }
}