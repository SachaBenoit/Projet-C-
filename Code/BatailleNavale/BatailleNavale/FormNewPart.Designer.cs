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
            this.txtPlayerOne = new System.Windows.Forms.TextBox();
            this.txtPlayerTwo = new System.Windows.Forms.TextBox();
            this.cmdPlay = new System.Windows.Forms.Button();
            this.rdbPartLocal = new System.Windows.Forms.RadioButton();
            this.rdbPartOnline = new System.Windows.Forms.RadioButton();
            this.nudNbCells = new System.Windows.Forms.NumericUpDown();
            this.lstShip = new System.Windows.Forms.ListBox();
            this.cmdAddShip = new System.Windows.Forms.Button();
            this.cmdRemoveShip = new System.Windows.Forms.Button();
            this.txtShip = new System.Windows.Forms.TextBox();
            this.nudSizeShip = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComputerName = new System.Windows.Forms.TextBox();
            this.rdbHost = new System.Windows.Forms.RadioButton();
            this.rdbClient = new System.Windows.Forms.RadioButton();
            this.gboxGameMode = new System.Windows.Forms.GroupBox();
            this.gboxPlayerMode = new System.Windows.Forms.GroupBox();
            this.lblPlayerTwo = new System.Windows.Forms.Label();
            this.lblPlayerOne = new System.Windows.Forms.Label();
            this.lblPartyName = new System.Windows.Forms.Label();
            this.lblComputerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNbCells)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeShip)).BeginInit();
            this.gboxGameMode.SuspendLayout();
            this.gboxPlayerMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNamePart
            // 
            this.txtNamePart.Location = new System.Drawing.Point(24, 29);
            this.txtNamePart.Name = "txtNamePart";
            this.txtNamePart.Size = new System.Drawing.Size(176, 20);
            this.txtNamePart.TabIndex = 2;
            this.txtNamePart.Text = "partie 1 ";
            // 
            // txtPlayerOne
            // 
            this.txtPlayerOne.Location = new System.Drawing.Point(24, 89);
            this.txtPlayerOne.Name = "txtPlayerOne";
            this.txtPlayerOne.Size = new System.Drawing.Size(176, 20);
            this.txtPlayerOne.TabIndex = 3;
            // 
            // txtPlayerTwo
            // 
            this.txtPlayerTwo.Location = new System.Drawing.Point(24, 153);
            this.txtPlayerTwo.Name = "txtPlayerTwo";
            this.txtPlayerTwo.Size = new System.Drawing.Size(176, 20);
            this.txtPlayerTwo.TabIndex = 4;
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
            this.rdbPartLocal.Location = new System.Drawing.Point(9, 19);
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
            this.rdbPartOnline.Location = new System.Drawing.Point(9, 42);
            this.rdbPartOnline.Name = "rdbPartOnline";
            this.rdbPartOnline.Size = new System.Drawing.Size(92, 17);
            this.rdbPartOnline.TabIndex = 8;
            this.rdbPartOnline.Text = "Partie Réseau";
            this.rdbPartOnline.UseVisualStyleBackColor = true;
            this.rdbPartOnline.CheckedChanged += new System.EventHandler(this.rdbPartOnline_CheckedChanged);
            // 
            // nudNbCells
            // 
            this.nudNbCells.Location = new System.Drawing.Point(24, 221);
            this.nudNbCells.Maximum = new decimal(new int[] {
            10,
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
            this.nudNbCells.TabIndex = 10;
            this.nudNbCells.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lstShip
            // 
            this.lstShip.FormattingEnabled = true;
            this.lstShip.Location = new System.Drawing.Point(578, 40);
            this.lstShip.Name = "lstShip";
            this.lstShip.Size = new System.Drawing.Size(178, 160);
            this.lstShip.TabIndex = 11;
            // 
            // cmdAddShip
            // 
            this.cmdAddShip.Location = new System.Drawing.Point(578, 206);
            this.cmdAddShip.Name = "cmdAddShip";
            this.cmdAddShip.Size = new System.Drawing.Size(86, 23);
            this.cmdAddShip.TabIndex = 12;
            this.cmdAddShip.Text = "Ajouter";
            this.cmdAddShip.UseVisualStyleBackColor = true;
            this.cmdAddShip.Click += new System.EventHandler(this.cmdAddShip_Click);
            // 
            // cmdRemoveShip
            // 
            this.cmdRemoveShip.Location = new System.Drawing.Point(670, 206);
            this.cmdRemoveShip.Name = "cmdRemoveShip";
            this.cmdRemoveShip.Size = new System.Drawing.Size(86, 23);
            this.cmdRemoveShip.TabIndex = 13;
            this.cmdRemoveShip.Text = "Supprimer";
            this.cmdRemoveShip.UseVisualStyleBackColor = true;
            this.cmdRemoveShip.Click += new System.EventHandler(this.cmdRemoveShip_Click);
            // 
            // txtShip
            // 
            this.txtShip.Location = new System.Drawing.Point(578, 235);
            this.txtShip.Name = "txtShip";
            this.txtShip.Size = new System.Drawing.Size(132, 20);
            this.txtShip.TabIndex = 14;
            this.txtShip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShip_KeyDown);
            // 
            // nudSizeShip
            // 
            this.nudSizeShip.Location = new System.Drawing.Point(716, 235);
            this.nudSizeShip.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudSizeShip.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSizeShip.Name = "nudSizeShip";
            this.nudSizeShip.Size = new System.Drawing.Size(40, 20);
            this.nudSizeShip.TabIndex = 15;
            this.nudSizeShip.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Taille de la grille : ";
            // 
            // txtComputerName
            // 
            this.txtComputerName.Location = new System.Drawing.Point(379, 399);
            this.txtComputerName.Name = "txtComputerName";
            this.txtComputerName.Size = new System.Drawing.Size(153, 20);
            this.txtComputerName.TabIndex = 17;
            // 
            // rdbHost
            // 
            this.rdbHost.AutoSize = true;
            this.rdbHost.Location = new System.Drawing.Point(11, 26);
            this.rdbHost.Name = "rdbHost";
            this.rdbHost.Size = new System.Drawing.Size(48, 17);
            this.rdbHost.TabIndex = 18;
            this.rdbHost.TabStop = true;
            this.rdbHost.Text = "Hôte";
            this.rdbHost.UseVisualStyleBackColor = true;
            // 
            // rdbClient
            // 
            this.rdbClient.AutoSize = true;
            this.rdbClient.Location = new System.Drawing.Point(11, 49);
            this.rdbClient.Name = "rdbClient";
            this.rdbClient.Size = new System.Drawing.Size(51, 17);
            this.rdbClient.TabIndex = 19;
            this.rdbClient.TabStop = true;
            this.rdbClient.Text = "Client";
            this.rdbClient.UseVisualStyleBackColor = true;
            this.rdbClient.CheckedChanged += new System.EventHandler(this.rdbClient_CheckedChanged);
            // 
            // gboxGameMode
            // 
            this.gboxGameMode.Controls.Add(this.rdbPartOnline);
            this.gboxGameMode.Controls.Add(this.rdbPartLocal);
            this.gboxGameMode.Location = new System.Drawing.Point(24, 341);
            this.gboxGameMode.Name = "gboxGameMode";
            this.gboxGameMode.Size = new System.Drawing.Size(145, 80);
            this.gboxGameMode.TabIndex = 20;
            this.gboxGameMode.TabStop = false;
            this.gboxGameMode.Text = "Mode de jeu";
            // 
            // gboxPlayerMode
            // 
            this.gboxPlayerMode.Controls.Add(this.rdbClient);
            this.gboxPlayerMode.Controls.Add(this.rdbHost);
            this.gboxPlayerMode.Location = new System.Drawing.Point(198, 341);
            this.gboxPlayerMode.Name = "gboxPlayerMode";
            this.gboxPlayerMode.Size = new System.Drawing.Size(145, 80);
            this.gboxPlayerMode.TabIndex = 21;
            this.gboxPlayerMode.TabStop = false;
            this.gboxPlayerMode.Text = "Jouer en tant que ";
            // 
            // lblPlayerTwo
            // 
            this.lblPlayerTwo.AutoSize = true;
            this.lblPlayerTwo.Location = new System.Drawing.Point(26, 137);
            this.lblPlayerTwo.Name = "lblPlayerTwo";
            this.lblPlayerTwo.Size = new System.Drawing.Size(83, 13);
            this.lblPlayerTwo.TabIndex = 22;
            this.lblPlayerTwo.Text = "nom du joueur 2";
            // 
            // lblPlayerOne
            // 
            this.lblPlayerOne.AutoSize = true;
            this.lblPlayerOne.Location = new System.Drawing.Point(26, 73);
            this.lblPlayerOne.Name = "lblPlayerOne";
            this.lblPlayerOne.Size = new System.Drawing.Size(80, 13);
            this.lblPlayerOne.TabIndex = 23;
            this.lblPlayerOne.Text = "nom du joueur1";
            // 
            // lblPartyName
            // 
            this.lblPartyName.AutoSize = true;
            this.lblPartyName.Location = new System.Drawing.Point(24, 13);
            this.lblPartyName.Name = "lblPartyName";
            this.lblPartyName.Size = new System.Drawing.Size(82, 13);
            this.lblPartyName.TabIndex = 24;
            this.lblPartyName.Text = "nom de la partie";
            // 
            // lblComputerName
            // 
            this.lblComputerName.AutoSize = true;
            this.lblComputerName.Location = new System.Drawing.Point(379, 383);
            this.lblComputerName.Name = "lblComputerName";
            this.lblComputerName.Size = new System.Drawing.Size(122, 13);
            this.lblComputerName.TabIndex = 25;
            this.lblComputerName.Text = "Nom de la machine hôte";
            // 
            // FormNewPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblComputerName);
            this.Controls.Add(this.lblPartyName);
            this.Controls.Add(this.lblPlayerOne);
            this.Controls.Add(this.lblPlayerTwo);
            this.Controls.Add(this.txtComputerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudSizeShip);
            this.Controls.Add(this.txtShip);
            this.Controls.Add(this.cmdRemoveShip);
            this.Controls.Add(this.cmdAddShip);
            this.Controls.Add(this.lstShip);
            this.Controls.Add(this.nudNbCells);
            this.Controls.Add(this.cmdPlay);
            this.Controls.Add(this.txtPlayerTwo);
            this.Controls.Add(this.txtPlayerOne);
            this.Controls.Add(this.txtNamePart);
            this.Controls.Add(this.gboxGameMode);
            this.Controls.Add(this.gboxPlayerMode);
            this.Name = "FormNewPart";
            this.Text = "FormNewPart";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNewPart_FormClosed);
            this.Load += new System.EventHandler(this.FormNewPart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNbCells)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeShip)).EndInit();
            this.gboxGameMode.ResumeLayout(false);
            this.gboxGameMode.PerformLayout();
            this.gboxPlayerMode.ResumeLayout(false);
            this.gboxPlayerMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNamePart;
        private System.Windows.Forms.TextBox txtPlayerOne;
        private System.Windows.Forms.TextBox txtPlayerTwo;
        private System.Windows.Forms.Button cmdPlay;
        private System.Windows.Forms.RadioButton rdbPartLocal;
        private System.Windows.Forms.RadioButton rdbPartOnline;
        private System.Windows.Forms.NumericUpDown nudNbCells;
        private System.Windows.Forms.ListBox lstShip;
        private System.Windows.Forms.Button cmdAddShip;
        private System.Windows.Forms.Button cmdRemoveShip;
        private System.Windows.Forms.TextBox txtShip;
        private System.Windows.Forms.NumericUpDown nudSizeShip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComputerName;
        private System.Windows.Forms.RadioButton rdbHost;
        private System.Windows.Forms.RadioButton rdbClient;
        private System.Windows.Forms.GroupBox gboxGameMode;
        private System.Windows.Forms.GroupBox gboxPlayerMode;
        private System.Windows.Forms.Label lblPlayerTwo;
        private System.Windows.Forms.Label lblPlayerOne;
        private System.Windows.Forms.Label lblPartyName;
        private System.Windows.Forms.Label lblComputerName;
    }
}