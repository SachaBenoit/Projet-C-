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
            this.cmdPartLocal = new System.Windows.Forms.Button();
            this.cmdPartOnline = new System.Windows.Forms.Button();
            this.txtNamePart = new System.Windows.Forms.TextBox();
            this.txtNamePlayer = new System.Windows.Forms.TextBox();
            this.txtNameSecondPlayer = new System.Windows.Forms.TextBox();
            this.txtIPv4SecondPlayer = new System.Windows.Forms.TextBox();
            this.cmdPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdPartLocal
            // 
            this.cmdPartLocal.Location = new System.Drawing.Point(106, 72);
            this.cmdPartLocal.Name = "cmdPartLocal";
            this.cmdPartLocal.Size = new System.Drawing.Size(131, 96);
            this.cmdPartLocal.TabIndex = 0;
            this.cmdPartLocal.Text = "Partie Local";
            this.cmdPartLocal.UseVisualStyleBackColor = true;
            this.cmdPartLocal.Click += new System.EventHandler(this.cmdPartLocal_Click);
            // 
            // cmdPartOnline
            // 
            this.cmdPartOnline.Location = new System.Drawing.Point(106, 270);
            this.cmdPartOnline.Name = "cmdPartOnline";
            this.cmdPartOnline.Size = new System.Drawing.Size(131, 96);
            this.cmdPartOnline.TabIndex = 1;
            this.cmdPartOnline.Text = "Partie Réseau";
            this.cmdPartOnline.UseVisualStyleBackColor = true;
            this.cmdPartOnline.Click += new System.EventHandler(this.cmdPartOnline_Click);
            // 
            // txtNamePart
            // 
            this.txtNamePart.Location = new System.Drawing.Point(580, 51);
            this.txtNamePart.Name = "txtNamePart";
            this.txtNamePart.Size = new System.Drawing.Size(176, 20);
            this.txtNamePart.TabIndex = 2;
            this.txtNamePart.Text = "Nom de la partie";
            // 
            // txtNamePlayer
            // 
            this.txtNamePlayer.Location = new System.Drawing.Point(580, 111);
            this.txtNamePlayer.Name = "txtNamePlayer";
            this.txtNamePlayer.Size = new System.Drawing.Size(176, 20);
            this.txtNamePlayer.TabIndex = 3;
            this.txtNamePlayer.Text = "Nom du joueur";
            // 
            // txtNameSecondPlayer
            // 
            this.txtNameSecondPlayer.Location = new System.Drawing.Point(580, 175);
            this.txtNameSecondPlayer.Name = "txtNameSecondPlayer";
            this.txtNameSecondPlayer.Size = new System.Drawing.Size(176, 20);
            this.txtNameSecondPlayer.TabIndex = 4;
            this.txtNameSecondPlayer.Text = "Nom du deuxième joueur";
            // 
            // txtIPv4SecondPlayer
            // 
            this.txtIPv4SecondPlayer.Location = new System.Drawing.Point(580, 235);
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
            // FormNewPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdPlay);
            this.Controls.Add(this.txtIPv4SecondPlayer);
            this.Controls.Add(this.txtNameSecondPlayer);
            this.Controls.Add(this.txtNamePlayer);
            this.Controls.Add(this.txtNamePart);
            this.Controls.Add(this.cmdPartOnline);
            this.Controls.Add(this.cmdPartLocal);
            this.Name = "FormNewPart";
            this.Text = "FormNewPart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdPartLocal;
        private System.Windows.Forms.Button cmdPartOnline;
        private System.Windows.Forms.TextBox txtNamePart;
        private System.Windows.Forms.TextBox txtNamePlayer;
        private System.Windows.Forms.TextBox txtNameSecondPlayer;
        private System.Windows.Forms.TextBox txtIPv4SecondPlayer;
        private System.Windows.Forms.Button cmdPlay;
    }
}