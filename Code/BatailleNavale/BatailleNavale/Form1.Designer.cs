namespace BatailleNavale
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstPlayerShip = new System.Windows.Forms.ListBox();
            this.lblOrientation = new System.Windows.Forms.Label();
            this.cmdSetOrientation = new System.Windows.Forms.Button();
            this.cmdReady = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPlayerShip
            // 
            this.lstPlayerShip.FormattingEnabled = true;
            this.lstPlayerShip.Location = new System.Drawing.Point(597, 117);
            this.lstPlayerShip.Name = "lstPlayerShip";
            this.lstPlayerShip.Size = new System.Drawing.Size(234, 225);
            this.lstPlayerShip.TabIndex = 0;
            this.lstPlayerShip.SelectedIndexChanged += new System.EventHandler(this.lstPlayerShip_SelectedIndexChanged);
            // 
            // lblOrientation
            // 
            this.lblOrientation.AutoSize = true;
            this.lblOrientation.Location = new System.Drawing.Point(595, 374);
            this.lblOrientation.Name = "lblOrientation";
            this.lblOrientation.Size = new System.Drawing.Size(118, 13);
            this.lblOrientation.TabIndex = 1;
            this.lblOrientation.Text = "Orientation du bateau : ";
            // 
            // cmdSetOrientation
            // 
            this.cmdSetOrientation.Location = new System.Drawing.Point(597, 348);
            this.cmdSetOrientation.Name = "cmdSetOrientation";
            this.cmdSetOrientation.Size = new System.Drawing.Size(115, 23);
            this.cmdSetOrientation.TabIndex = 2;
            this.cmdSetOrientation.Text = "Orientation";
            this.cmdSetOrientation.UseVisualStyleBackColor = true;
            this.cmdSetOrientation.Click += new System.EventHandler(this.cmdSetOrientation_Click);
            // 
            // cmdReady
            // 
            this.cmdReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReady.Location = new System.Drawing.Point(598, 439);
            this.cmdReady.Name = "cmdReady";
            this.cmdReady.Size = new System.Drawing.Size(91, 32);
            this.cmdReady.TabIndex = 3;
            this.cmdReady.Text = "Prêt";
            this.cmdReady.UseVisualStyleBackColor = true;
            this.cmdReady.Click += new System.EventHandler(this.cmdReady_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 553);
            this.Controls.Add(this.cmdReady);
            this.Controls.Add(this.cmdSetOrientation);
            this.Controls.Add(this.lblOrientation);
            this.Controls.Add(this.lstPlayerShip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPlayerShip;

        private System.Windows.Forms.Label lblOrientation;
        private System.Windows.Forms.Button cmdSetOrientation;
        private System.Windows.Forms.Button cmdReady;

    }
}

