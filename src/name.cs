using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Avionase {
	public partial class name : Form {
		public name() {
			InitializeComponent();
		}

		private void name_Load(object sender, EventArgs e) {
			Program.numeOK = false;
		}

		private bool nameCheck(string name) {
			string chars = ",.<>!@#$%^&*()+=|{}[]';:?/~`\"";
			for (int i = 0; i < chars.Length; i++) {
				if (name.IndexOf(chars[i]) >= 0 ) {
					return false;
				}
			}

			return true;
		}

		private void submitName_Click(object sender, EventArgs e) {
			if (nickBox.Text.Length > 0 && nickBox.Text.Length <= 20 && nameCheck(nickBox.Text)){
				Program.nume = nickBox.Text;
				Program.numeOK = true;
				this.Close();
			}
			else {
				nickBox.Clear();
				MessageBox.Show("Please enter a nickname between 0 and 20 characters!\nOnly letters and numbers are allowed!", "Error, Invalid nickname!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void name_Enter(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				submitName_Click(sender, e);
			}
		}

		private void nickBox_TextChanged(object sender, EventArgs e) {

		}
	}
}
