namespace Avionase {
    partial class NewGame {
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGame));
			this.btnSP = new System.Windows.Forms.Button();
			this.btnMP = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.loadingBox = new System.Windows.Forms.TextBox();
			this.FileHelpExit = new System.Windows.Forms.MenuStrip();
			this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyrightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toDoListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.FileHelpExit.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSP
			// 
			this.btnSP.Location = new System.Drawing.Point(12, 45);
			this.btnSP.Name = "btnSP";
			this.btnSP.Size = new System.Drawing.Size(121, 101);
			this.btnSP.TabIndex = 0;
			this.btnSP.Text = "Single Player Game";
			this.btnSP.UseVisualStyleBackColor = true;
			this.btnSP.Click += new System.EventHandler(this.btnSP_Click);
			// 
			// btnMP
			// 
			this.btnMP.Enabled = false;
			this.btnMP.Location = new System.Drawing.Point(162, 45);
			this.btnMP.Name = "btnMP";
			this.btnMP.Size = new System.Drawing.Size(121, 101);
			this.btnMP.TabIndex = 0;
			this.btnMP.Text = "Multi Player Game";
			this.btnMP.UseVisualStyleBackColor = true;
			this.btnMP.Click += new System.EventHandler(this.btnSP_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(90, 161);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(116, 33);
			this.btnExit.TabIndex = 1;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// loadingBox
			// 
			this.loadingBox.BackColor = System.Drawing.SystemColors.Control;
			this.loadingBox.Cursor = System.Windows.Forms.Cursors.Default;
			this.loadingBox.Enabled = false;
			this.loadingBox.Location = new System.Drawing.Point(13, 200);
			this.loadingBox.Name = "loadingBox";
			this.loadingBox.ReadOnly = true;
			this.loadingBox.Size = new System.Drawing.Size(271, 20);
			this.loadingBox.TabIndex = 2;
			this.loadingBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.loadingBox.TextChanged += new System.EventHandler(this.loadingBox_TextChanged);
			// 
			// FileHelpExit
			// 
			this.FileHelpExit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1});
			this.FileHelpExit.Location = new System.Drawing.Point(0, 0);
			this.FileHelpExit.Name = "FileHelpExit";
			this.FileHelpExit.Size = new System.Drawing.Size(296, 24);
			this.FileHelpExit.TabIndex = 3;
			this.FileHelpExit.Text = "menuStrip1";
			// 
			// helpToolStripMenuItem1
			// 
			this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.copyrightToolStripMenuItem,
            this.toDoListToolStripMenuItem});
			this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
			this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem1.Text = "Help";
			// 
			// instructionsToolStripMenuItem
			// 
			this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
			this.instructionsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.instructionsToolStripMenuItem.Text = "Info";
			this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
			// 
			// copyrightToolStripMenuItem
			// 
			this.copyrightToolStripMenuItem.Name = "copyrightToolStripMenuItem";
			this.copyrightToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.copyrightToolStripMenuItem.Text = "About";
			this.copyrightToolStripMenuItem.Click += new System.EventHandler(this.copyrightToolStripMenuItem_Click);
			// 
			// toDoListToolStripMenuItem
			// 
			this.toDoListToolStripMenuItem.Name = "toDoListToolStripMenuItem";
			this.toDoListToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.toDoListToolStripMenuItem.Text = "To do list";
			this.toDoListToolStripMenuItem.Click += new System.EventHandler(this.toDoListToolStripMenuItem_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// NewGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(296, 232);
			this.ControlBox = false;
			this.Controls.Add(this.FileHelpExit);
			this.Controls.Add(this.loadingBox);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnMP);
			this.Controls.Add(this.btnSP);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "NewGame";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New Game";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.FileHelpExit.ResumeLayout(false);
			this.FileHelpExit.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSP;
        private System.Windows.Forms.Button btnMP;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox loadingBox;
        private System.Windows.Forms.MenuStrip FileHelpExit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyrightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toDoListToolStripMenuItem;
		private System.Windows.Forms.Timer timer1;
    }
}