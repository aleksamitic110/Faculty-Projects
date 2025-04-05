namespace _19252_C_
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
			this.fileText = new System.Windows.Forms.RichTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.loadFileBtn = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.downBtn = new System.Windows.Forms.Button();
			this.upBtn = new System.Windows.Forms.Button();
			this.findBtn = new System.Windows.Forms.Button();
			this.timeLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.patternTxtBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.fileNameLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.algorithmCombo = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.occurancesNumber = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// fileText
			// 
			this.fileText.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.fileText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fileText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fileText.Location = new System.Drawing.Point(0, 0);
			this.fileText.Name = "fileText";
			this.fileText.Size = new System.Drawing.Size(634, 614);
			this.fileText.TabIndex = 0;
			this.fileText.Text = "";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.fileText);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(634, 614);
			this.panel1.TabIndex = 1;
			// 
			// loadFileBtn
			// 
			this.loadFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loadFileBtn.Location = new System.Drawing.Point(75, 542);
			this.loadFileBtn.Name = "loadFileBtn";
			this.loadFileBtn.Size = new System.Drawing.Size(231, 66);
			this.loadFileBtn.TabIndex = 2;
			this.loadFileBtn.Text = "Load .txt";
			this.loadFileBtn.UseVisualStyleBackColor = true;
			this.loadFileBtn.Click += new System.EventHandler(this.loadFileBtn_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.panel2.Controls.Add(this.occurancesNumber);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.downBtn);
			this.panel2.Controls.Add(this.upBtn);
			this.panel2.Controls.Add(this.findBtn);
			this.panel2.Controls.Add(this.timeLabel);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.patternTxtBox);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.fileNameLabel);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.algorithmCombo);
			this.panel2.Controls.Add(this.loadFileBtn);
			this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel2.Location = new System.Drawing.Point(652, 15);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(373, 611);
			this.panel2.TabIndex = 3;
			// 
			// downBtn
			// 
			this.downBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.downBtn.Location = new System.Drawing.Point(106, 350);
			this.downBtn.Name = "downBtn";
			this.downBtn.Size = new System.Drawing.Size(173, 66);
			this.downBtn.TabIndex = 12;
			this.downBtn.Text = "↓";
			this.downBtn.UseVisualStyleBackColor = true;
			this.downBtn.Click += new System.EventHandler(this.downBtn_Click);
			// 
			// upBtn
			// 
			this.upBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.upBtn.Location = new System.Drawing.Point(106, 278);
			this.upBtn.Name = "upBtn";
			this.upBtn.Size = new System.Drawing.Size(173, 66);
			this.upBtn.TabIndex = 11;
			this.upBtn.Text = "↑";
			this.upBtn.UseVisualStyleBackColor = true;
			this.upBtn.Click += new System.EventHandler(this.upBtn_Click);
			// 
			// findBtn
			// 
			this.findBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.findBtn.Location = new System.Drawing.Point(75, 206);
			this.findBtn.Name = "findBtn";
			this.findBtn.Size = new System.Drawing.Size(231, 66);
			this.findBtn.TabIndex = 10;
			this.findBtn.Text = "Find";
			this.findBtn.UseVisualStyleBackColor = true;
			this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
			// 
			// timeLabel
			// 
			this.timeLabel.AutoSize = true;
			this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timeLabel.Location = new System.Drawing.Point(137, 456);
			this.timeLabel.Name = "timeLabel";
			this.timeLabel.Size = new System.Drawing.Size(0, 25);
			this.timeLabel.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 456);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 25);
			this.label3.TabIndex = 8;
			this.label3.Text = "Time: ";
			// 
			// patternTxtBox
			// 
			this.patternTxtBox.BackColor = System.Drawing.Color.MediumAquamarine;
			this.patternTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.patternTxtBox.ForeColor = System.Drawing.Color.Maroon;
			this.patternTxtBox.Location = new System.Drawing.Point(143, 145);
			this.patternTxtBox.Name = "patternTxtBox";
			this.patternTxtBox.Size = new System.Drawing.Size(200, 31);
			this.patternTxtBox.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(22, 148);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 25);
			this.label2.TabIndex = 6;
			this.label2.Text = "Pattern: ";
			// 
			// fileNameLabel
			// 
			this.fileNameLabel.AutoSize = true;
			this.fileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fileNameLabel.Location = new System.Drawing.Point(124, 13);
			this.fileNameLabel.Name = "fileNameLabel";
			this.fileNameLabel.Size = new System.Drawing.Size(0, 25);
			this.fileNameLabel.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 25);
			this.label1.TabIndex = 4;
			this.label1.Text = "Algorithm: ";
			// 
			// algorithmCombo
			// 
			this.algorithmCombo.BackColor = System.Drawing.Color.MediumAquamarine;
			this.algorithmCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.algorithmCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.algorithmCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.algorithmCombo.FormattingEnabled = true;
			this.algorithmCombo.Items.AddRange(new object[] {
            "Rabin–Karp ",
            "SoundEx"});
			this.algorithmCombo.Location = new System.Drawing.Point(143, 69);
			this.algorithmCombo.Name = "algorithmCombo";
			this.algorithmCombo.Size = new System.Drawing.Size(200, 33);
			this.algorithmCombo.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 431);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(144, 25);
			this.label4.TabIndex = 13;
			this.label4.Text = "Occurances:";
			// 
			// occurancesNumber
			// 
			this.occurancesNumber.AutoSize = true;
			this.occurancesNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.occurancesNumber.Location = new System.Drawing.Point(162, 431);
			this.occurancesNumber.Name = "occurancesNumber";
			this.occurancesNumber.Size = new System.Drawing.Size(0, 25);
			this.occurancesNumber.TabIndex = 14;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1030, 638);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "StringFindAlg";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox fileText;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button loadFileBtn;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ComboBox algorithmCombo;
		private System.Windows.Forms.Label fileNameLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox patternTxtBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label timeLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button downBtn;
		private System.Windows.Forms.Button upBtn;
		private System.Windows.Forms.Button findBtn;
		private System.Windows.Forms.Label occurancesNumber;
		private System.Windows.Forms.Label label4;
	}
}

