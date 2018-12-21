namespace BatailleNavale
{
    partial class FormNewPart
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
            this.txtNamePart = new System.Windows.Forms.TextBox();
            this.txtNamePlayer = new System.Windows.Forms.TextBox();
            this.txtNameSecondPlayer = new System.Windows.Forms.TextBox();
            this.txtIPv4SecondPlayer = new System.Windows.Forms.TextBox();
            this.cmdPlay = new System.Windows.Forms.Button();
            this.rdbPartLocal = new System.Windows.Forms.RadioButton();
            this.rdbPartOnline = new System.Windows.Forms.RadioButton();
            this.nudNbCells = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNbCells)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNamePart
            // 
            this.txtNamePart.Location = new System.Drawing.Point(198, 40);
            this.txtNamePart.Name = "txtNamePart";
            this.txtNamePart.Size = new System.Drawing.Size(176, 20);
            this.txtNamePart.TabIndex = 2;
            this.txtNamePart.Text = "Nom de la partie";
            // 
            // txtNamePlayer
            // 
            this.txtNamePlayer.Location = new System.Drawing.Point(198, 100);
            this.txtNamePlayer.Name = "txtNamePlayer";
            this.txtNamePlayer.Size = new System.Drawing.Size(176, 20);
            this.txtNamePlayer.TabIndex = 3;
            this.txtNamePlayer.Text = "Nom du joueur";
            // 
            // txtNameSecondPlayer
            // 
            this.txtNameSecondPlayer.Location = new System.Drawing.Point(198, 164);
            this.txtNameSecondPlayer.Name = "txtNameSecondPlayer";
            this.txtNameSecondPlayer.Size = new System.Drawing.Size(176, 20);
            this.txtNameSecondPlayer.TabIndex = 4;
            this.txtNameSecondPlayer.Text = "Nom du deuxième joueur";
            // 
            // txtIPv4SecondPlayer
            // 
            this.txtIPv4SecondPlayer.Location = new System.Drawing.Point(198, 224);
            this.txtIPv4SecondPlayer.Name = "txtIPv4SecondPlayer";
            this.txtIPv4SecondPlayer.Size = new System.Drawing.Size(176, 20);
            this.txtIPv4SecondPlayer.TabIndex = 5;
            // 
            // cmdPlay
            // 
            this.cmdPlay.Location = new System.Drawing.Point(681, 371);
            this.cmdPlay.Name = "cmdPlay";
            this.cmdPlay.Size = new System.Drawing.Size(75, 48);
            this.cmdPlay.TabIndex = 6;
            this.cmdPlay.Text = "Jouer";
            this.cmdPlay.UseVisualStyleBackColor = true;
            this.cmdPlay.Click += new System.EventHandler(this.cmdPlay_Click);
            // 
            // rdbPartLocal
            // 
            this.rdbPartLocal.AutoSize = true;
            this.rdbPartLocal.Checked = true;
            this.rdbPartLocal.Location = new System.Drawing.Point(33, 40);
            this.rdbPartLocal.Name = "rdbPartLocal";
            this.rdbPartLocal.Size = new System.Drawing.Size(81, 17);
            this.rdbPartLocal.TabIndex = 7;
            this.rdbPartLocal.TabStop = true;
            this.rdbPartLocal.Text = "Partie Local";
            this.rdbPartLocal.UseVisualStyleBackColor = true;
            // 
            // rdbPartOnline
            // 
            this.rdbPartOnline.AutoSize = true;
            this.rdbPartOnline.Location = new System.Drawing.Point(33, 90);
            this.rdbPartOnline.Name = "rdbPartOnline";
            this.rdbPartOnline.Size = new System.Drawing.Size(92, 17);
            this.rdbPartOnline.TabIndex = 8;
            this.rdbPartOnline.Text = "Partie Réseau";
            this.rdbPartOnline.UseVisualStyleBackColor = true;
            // 
            // nudNbCells
            // 
            this.nudNbCells.Location = new System.Drawing.Point(379, 305);
            this.nudNbCells.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudNbCells.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudNbCells.Name = "nudNbCells";
            this.nudNbCells.Size = new System.Drawing.Size(120, 20);
            this.nudNbCells.TabIndex = 9;
            this.nudNbCells.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // FormNewPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudNbCells);
            this.Controls.Add(this.rdbPartOnline);
            this.Controls.Add(this.rdbPartLocal);
            this.Controls.Add(this.cmdPlay);
            this.Controls.Add(this.txtIPv4SecondPlayer);
            this.Controls.Add(this.txtNameSecondPlayer);
            this.Controls.Add(this.txtNamePlayer);
            this.Controls.Add(this.txtNamePart);
            this.Name = "FormNewPart";
            this.Text = "FormNewPart";
            this.Load += new System.EventHandler(this.FormNewPart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNbCells)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNamePart;
        private System.Windows.Forms.TextBox txtNamePlayer;
        private System.Windows.Forms.TextBox txtNameSecondPlayer;
        private System.Windows.Forms.TextBox txtIPv4SecondPlayer;
        private System.Windows.Forms.Button cmdPlay;
        private System.Windows.Forms.RadioButton rdbPartLocal;
        private System.Windows.Forms.RadioButton rdbPartOnline;
        private System.Windows.Forms.NumericUpDown nudNbCells;
    }
}