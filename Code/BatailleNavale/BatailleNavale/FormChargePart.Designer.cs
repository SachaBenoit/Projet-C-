namespace BatailleNavale
{
    partial class FormChargePart
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
            this.lstPart = new System.Windows.Forms.ListBox();
            this.cmdPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPart
            // 
            this.lstPart.FormattingEnabled = true;
            this.lstPart.Location = new System.Drawing.Point(48, 26);
            this.lstPart.Name = "lstPart";
            this.lstPart.Size = new System.Drawing.Size(248, 212);
            this.lstPart.TabIndex = 0;
            // 
            // cmdPlay
            // 
            this.cmdPlay.Location = new System.Drawing.Point(240, 379);
            this.cmdPlay.Name = "cmdPlay";
            this.cmdPlay.Size = new System.Drawing.Size(92, 50);
            this.cmdPlay.TabIndex = 1;
            this.cmdPlay.Text = "Jouer";
            this.cmdPlay.UseVisualStyleBackColor = true;
            this.cmdPlay.Click += new System.EventHandler(this.cmdPlay_Click);
            // 
            // FormChargePart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 450);
            this.Controls.Add(this.cmdPlay);
            this.Controls.Add(this.lstPart);
            this.Name = "FormChargePart";
            this.Text = "FormChargePart";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormChargePart_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPart;
        private System.Windows.Forms.Button cmdPlay;
    }
}