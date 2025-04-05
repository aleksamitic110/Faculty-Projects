namespace MemoryGame
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.odustaniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openMeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.btnStartGame = new System.Windows.Forms.Button();
			this.btnClosePanel = new System.Windows.Forms.Button();
			this.btnGenerisiPolje = new System.Windows.Forms.Button();
			this.nudKolone = new System.Windows.Forms.NumericUpDown();
			this.nudRedovi = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panelSat = new System.Windows.Forms.Panel();
			this.labelaVreme = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.labelaSkor = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudKolone)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudRedovi)).BeginInit();
			this.panelSat.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Location = new System.Drawing.Point(0, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1261, 732);
			this.panel1.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1261, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadGameToolStripMenuItem,
            this.odustaniToolStripMenuItem,
            this.openMeniToolStripMenuItem});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.menuToolStripMenuItem.Text = "Menu";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeyDisplayString = "CTRL + S";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// loadGameToolStripMenuItem
			// 
			this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
			this.loadGameToolStripMenuItem.ShortcutKeyDisplayString = "CTRL + L";
			this.loadGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
			this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.loadGameToolStripMenuItem.Text = "Load Game";
			this.loadGameToolStripMenuItem.Click += new System.EventHandler(this.loadGameToolStripMenuItem_Click);
			// 
			// odustaniToolStripMenuItem
			// 
			this.odustaniToolStripMenuItem.Name = "odustaniToolStripMenuItem";
			this.odustaniToolStripMenuItem.ShortcutKeyDisplayString = "CTRL + O";
			this.odustaniToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.odustaniToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.odustaniToolStripMenuItem.Text = "Odustani";
			this.odustaniToolStripMenuItem.Click += new System.EventHandler(this.odustaniToolStripMenuItem_Click);
			// 
			// openMeniToolStripMenuItem
			// 
			this.openMeniToolStripMenuItem.Name = "openMeniToolStripMenuItem";
			this.openMeniToolStripMenuItem.ShortcutKeyDisplayString = "CTRL + M";
			this.openMeniToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
			this.openMeniToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.openMeniToolStripMenuItem.Text = "Open meni";
			this.openMeniToolStripMenuItem.Click += new System.EventHandler(this.openMeniToolStripMenuItem_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.SandyBrown;
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.btnStartGame);
			this.panel2.Controls.Add(this.btnClosePanel);
			this.panel2.Controls.Add(this.btnGenerisiPolje);
			this.panel2.Controls.Add(this.nudKolone);
			this.panel2.Controls.Add(this.nudRedovi);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(0, 27);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(314, 404);
			this.panel2.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(150, 319);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(161, 72);
			this.button1.TabIndex = 7;
			this.button1.Text = "Give up";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnStartGame
			// 
			this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStartGame.Location = new System.Drawing.Point(7, 142);
			this.btnStartGame.Name = "btnStartGame";
			this.btnStartGame.Size = new System.Drawing.Size(304, 71);
			this.btnStartGame.TabIndex = 6;
			this.btnStartGame.Text = "Start Game";
			this.btnStartGame.UseVisualStyleBackColor = true;
			this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
			// 
			// btnClosePanel
			// 
			this.btnClosePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClosePanel.Location = new System.Drawing.Point(12, 319);
			this.btnClosePanel.Name = "btnClosePanel";
			this.btnClosePanel.Size = new System.Drawing.Size(119, 72);
			this.btnClosePanel.TabIndex = 5;
			this.btnClosePanel.Text = "Close panel";
			this.btnClosePanel.UseVisualStyleBackColor = true;
			this.btnClosePanel.Click += new System.EventHandler(this.btnClosePanel_Click);
			// 
			// btnGenerisiPolje
			// 
			this.btnGenerisiPolje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGenerisiPolje.Location = new System.Drawing.Point(7, 77);
			this.btnGenerisiPolje.Name = "btnGenerisiPolje";
			this.btnGenerisiPolje.Size = new System.Drawing.Size(304, 59);
			this.btnGenerisiPolje.TabIndex = 4;
			this.btnGenerisiPolje.Text = "Generate new field";
			this.btnGenerisiPolje.UseVisualStyleBackColor = true;
			this.btnGenerisiPolje.Click += new System.EventHandler(this.btnGenerisiPolje_Click);
			// 
			// nudKolone
			// 
			this.nudKolone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudKolone.Location = new System.Drawing.Point(115, 45);
			this.nudKolone.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
			this.nudKolone.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nudKolone.Name = "nudKolone";
			this.nudKolone.Size = new System.Drawing.Size(53, 26);
			this.nudKolone.TabIndex = 3;
			this.nudKolone.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// nudRedovi
			// 
			this.nudRedovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudRedovi.Location = new System.Drawing.Point(115, 13);
			this.nudRedovi.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
			this.nudRedovi.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
			this.nudRedovi.Name = "nudRedovi";
			this.nudRedovi.Size = new System.Drawing.Size(53, 26);
			this.nudRedovi.TabIndex = 2;
			this.nudRedovi.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "KOLONE : ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(11, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "REDOVI : ";
			// 
			// panelSat
			// 
			this.panelSat.AllowDrop = true;
			this.panelSat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panelSat.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panelSat.Controls.Add(this.labelaVreme);
			this.panelSat.Location = new System.Drawing.Point(1129, 0);
			this.panelSat.Name = "panelSat";
			this.panelSat.Size = new System.Drawing.Size(132, 24);
			this.panelSat.TabIndex = 3;
			// 
			// labelaVreme
			// 
			this.labelaVreme.AutoSize = true;
			this.labelaVreme.Dock = System.Windows.Forms.DockStyle.Left;
			this.labelaVreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelaVreme.Location = new System.Drawing.Point(0, 0);
			this.labelaVreme.Name = "labelaVreme";
			this.labelaVreme.Size = new System.Drawing.Size(59, 24);
			this.labelaVreme.TabIndex = 0;
			this.labelaVreme.Text = "TIME";
			this.labelaVreme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.Color.YellowGreen;
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.labelaSkor);
			this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel3.Location = new System.Drawing.Point(51, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1078, 24);
			this.panel3.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(458, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 16);
			this.label3.TabIndex = 1;
			this.label3.Text = "SCORE";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelaSkor
			// 
			this.labelaSkor.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelaSkor.AutoSize = true;
			this.labelaSkor.Location = new System.Drawing.Point(514, 5);
			this.labelaSkor.Name = "labelaSkor";
			this.labelaSkor.Size = new System.Drawing.Size(50, 16);
			this.labelaSkor.TabIndex = 0;
			this.labelaSkor.Text = "label3";
			this.labelaSkor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(1261, 756);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panelSat);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Memory Game";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudKolone)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudRedovi)).EndInit();
			this.panelSat.ResumeLayout(false);
			this.panelSat.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem odustaniToolStripMenuItem;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.NumericUpDown nudRedovi;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown nudKolone;
		private System.Windows.Forms.Button btnGenerisiPolje;
		private System.Windows.Forms.ToolStripMenuItem openMeniToolStripMenuItem;
		private System.Windows.Forms.Button btnClosePanel;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Panel panelSat;
		private System.Windows.Forms.Label labelaVreme;
		private System.Windows.Forms.Button btnStartGame;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label labelaSkor;
		private System.Windows.Forms.Label label3;
	}
}

