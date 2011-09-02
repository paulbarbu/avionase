namespace Avionase {
	partial class top {
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(top));
			this.topOK = new System.Windows.Forms.Button();
			this.topS = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.topS)).BeginInit();
			this.SuspendLayout();
			// 
			// topOK
			// 
			this.topOK.Location = new System.Drawing.Point(120, 221);
			this.topOK.Name = "topOK";
			this.topOK.Size = new System.Drawing.Size(75, 23);
			this.topOK.TabIndex = 0;
			this.topOK.Text = "OK";
			this.topOK.UseVisualStyleBackColor = true;
			this.topOK.Click += new System.EventHandler(this.topOK_Click);
			// 
			// topS
			// 
			this.topS.AllowUserToAddRows = false;
			this.topS.AllowUserToDeleteRows = false;
			this.topS.AllowUserToResizeRows = false;
			this.topS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.topS.Location = new System.Drawing.Point(17, 12);
			this.topS.MultiSelect = false;
			this.topS.Name = "topS";
			this.topS.ReadOnly = true;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.topS.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.topS.RowHeadersWidth = 50;
			this.topS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.topS.Size = new System.Drawing.Size(280, 203);
			this.topS.TabIndex = 1;
			this.topS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.topS_CellContentClick);
			this.topS.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.topS_Arrow);
			this.topS.Sorted += new System.EventHandler(this.topS_Sorted);
			// 
			// top
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(315, 256);
			this.Controls.Add(this.topS);
			this.Controls.Add(this.topOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "top";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Top Shooters";
			this.Load += new System.EventHandler(this.top_Load);
			((System.ComponentModel.ISupportInitialize)(this.topS)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button topOK;
		private System.Windows.Forms.DataGridView topS;

	}
}