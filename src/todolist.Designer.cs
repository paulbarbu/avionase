namespace Avionase {
    partial class todolist {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(todolist));
			this.list = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// list
			// 
			this.list.BackColor = System.Drawing.SystemColors.Control;
			this.list.Cursor = System.Windows.Forms.Cursors.Default;
			this.list.Enabled = false;
			this.list.Location = new System.Drawing.Point(12, 12);
			this.list.Multiline = true;
			this.list.Name = "list";
			this.list.Size = new System.Drawing.Size(179, 68);
			this.list.TabIndex = 0;
			this.list.Text = "To do List:\r\n\r\n* offline random\r\n* if user comes from file->new game or ctrl+N, s" +
				"ave his nick\r\n\r\n";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(66, 89);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(71, 27);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// todolist
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(203, 128);
			this.ControlBox = false;
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.list);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "todolist";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "To do list";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox list;
        private System.Windows.Forms.Button btnOK;
    }
}