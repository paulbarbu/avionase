using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Avionase {
	public partial class top : Form {
		public top() {
			InitializeComponent();
		}

		private void topOK_Click(object sender, EventArgs e) {
			this.DialogResult = DialogResult.OK;
		}

		public void AutoNumberRowsForGridView(DataGridView dataGridView) {

			if (dataGridView != null) {

				for (int count = 0; (count <= (dataGridView.Rows.Count - 1)); count++) {

					dataGridView.Rows[count].HeaderCell.Value = string.Format((count + 1).ToString(), "0");

				}

			}

		}

		private void top_Load(object sender, EventArgs e) {
			List<string[]> topShooters = parseCSV("files\\top");

			DataTable top = new DataTable();

			//top.Columns.Add("Pos", typeof(int));
			top.Columns.Add("Name", typeof(string));
			top.Columns.Add("Time", typeof(int));
			top.Columns.Add("Hits", typeof(int));

			for (int i = 0; i < topShooters.Count; i++) {
				top.Rows.Add();
				//top.Rows[i][0] = i;
				top.Rows[i][0] = topShooters[i][0];
				top.Rows[i][1] = Int32.Parse(topShooters[i][1]);
				top.Rows[i][2] = Int32.Parse(topShooters[i][2]);
			}

			topS.DataSource = top;
			topS.Sort(topS.Columns[1], ListSortDirection.Ascending);

			//topS.Columns["Pos"].Width = 50;
			topS.Columns["Time"].Width = 60;
			topS.Columns["Hits"].Width = 50;
			topS.Columns["Name"].Width = 100;

			//topS.Columns["Pos"].Resizable = DataGridViewTriState.False;
			topS.Columns["Time"].Resizable = DataGridViewTriState.False;
			topS.Columns["Hits"].Resizable = DataGridViewTriState.False;

			//topS.Columns["Pos"].SortMode = DataGridViewColumnSortMode.NotSortable;

			//topS.Rows[0].HeaderCell.Size.Width = 20; ;

			AutoNumberRowsForGridView(topS);
		}

		public List<string[]> parseCSV(string path) {
			List<string[]> parsedData = new List<string[]>();

			try {
				using (StreamReader readFile = new StreamReader(path)) {
					string line;
					string[] row;

					while ((line = readFile.ReadLine()) != null) {
						row = line.Split(',');
						parsedData.Add(row);
					}
				}
			}
			catch (Exception e) {
				MessageBox.Show(e.Message, "Error");
			}

			return parsedData;
		}

		private void topS_CellContentClick(object sender, DataGridViewCellEventArgs e) {

		}

		private void topS_Sorted(object sender, EventArgs e) {
			AutoNumberRowsForGridView(topS);
		}

		private void topS_Arrow(object sender, DataGridViewRowPostPaintEventArgs e) {
			e.PaintHeader(DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentBackground);
		}
	}
}
