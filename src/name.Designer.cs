namespace Avionase {
	partial class name {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(name));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.nickBox = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.submitName = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.Control;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Enabled = false;
			this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.textBox1.Location = new System.Drawing.Point(12, 9);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(260, 35);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Please enter your nickname while the airplanes are being generated...";
			// 
			// nickBox
			// 
			this.nickBox.Location = new System.Drawing.Point(75, 50);
			this.nickBox.Name = "nickBox";
			this.nickBox.Size = new System.Drawing.Size(197, 20);
			this.nickBox.TabIndex = 1;
			this.nickBox.TextChanged += new System.EventHandler(this.nickBox_TextChanged);
			this.nickBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.name_Enter);
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.SystemColors.Control;
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox3.ForeColor = System.Drawing.SystemColors.WindowText;
			this.textBox3.Location = new System.Drawing.Point(12, 53);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(57, 17);
			this.textBox3.TabIndex = 2;
			this.textBox3.Text = "Nickname:";
			// 
			// submitName
			// 
			this.submitName.Location = new System.Drawing.Point(88, 76);
			this.submitName.Name = "submitName";
			this.submitName.Size = new System.Drawing.Size(106, 34);
			this.submitName.TabIndex = 3;
			this.submitName.Text = "Submit";
			this.submitName.UseVisualStyleBackColor = true;
			this.submitName.Click += new System.EventHandler(this.submitName_Click);
			// 
			// name
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 119);
			this.ControlBox = false;
			this.Controls.Add(this.submitName);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.nickBox);
			this.Controls.Add(this.textBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "name";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Please wait...";
			this.Load += new System.EventHandler(this.name_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox nickBox;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button submitName;
	}
}