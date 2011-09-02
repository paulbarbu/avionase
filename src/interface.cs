using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading;

namespace Avionase {
    public partial class Avionase : Form {

        public static int i, j;
		public static double showTime, intermediaryTime;
		public static DateTime startTime, iTime;
		public static TimeSpan duration;
		public static Thread thTimp;
		public static char[,] t = new char[9, 9];
		public static bool open = true;
		public static bool paused = false;
    
        public Avionase() {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        instructions instructiuni = new instructions();
        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e) {
            instructiuni.ShowDialog();
        }

        about aboutForm = new about();
        private void copyrightToolStripMenuItem_Click(object sender, EventArgs e) {
            aboutForm.ShowDialog();
        }
        
        NewGame newgame = new NewGame();
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Hide();
            newgame.ShowDialog();
        }

        private void Avionase_Load(object sender, EventArgs e) {
			pause.Enabled = false;
        }

        public static void lovire(int vertical, int orizontal, Button nume, TextBox hit, ProgressBar crash, System.Windows.Forms.Timer timp) {
			try {
				switch (Program.a[vertical, orizontal]) {
					case '4': hit.Clear();
						hit.Text = "You already have hit here!";
						break;

					case '1': nume.Image = new Bitmap("graphix\\a1.png");
						nume.Text = " ";
						Program.a[vertical, orizontal] = '4';

						hit.Clear();
						hit.Text = "Airplane no. 1 was hit!";
						break;

					case '2': nume.Image = new Bitmap("graphix\\a2.png");
						nume.Text = " ";
						Program.a[vertical, orizontal] = '4';

						hit.Clear();
						hit.Text = "Airplane no. 2 was hit!";
						break;

					case '3': nume.Image = new Bitmap("graphix\\a3.png");
						nume.Text = " ";
						Program.a[vertical, orizontal] = '4';

						hit.Clear();
						hit.Text = "Airplane no. 3 was hit!";
						break;

					case 'A':
						switch (Program.a1) {
							case 1: nume.Image = new Bitmap("graphix\\D1.png");
								nume.Text = " ";
								break;

							case 2: nume.Image = new Bitmap("graphix\\D2.png");
								nume.Text = " ";
								break;

							case 3: nume.Image = new Bitmap("graphix\\D3.png");
								nume.Text = " ";
								break;

							case 4: nume.Image = new Bitmap("graphix\\D4.png");
								nume.Text = " ";
								break;
						}
						hit.Clear();
						hit.Text = "Airplane no. 1 was crashed!";
						crash.PerformStep();

						Program.a_ramase--;
						Program.a[vertical, orizontal] = '4';
						break;

					case 'B':
						switch (Program.a2) {
							case 1: nume.Image = new Bitmap("graphix\\B1.png");
								nume.Text = " ";
								break;

							case 2: nume.Image = new Bitmap("graphix\\B2.png");
								nume.Text = " ";
								break;

							case 3: nume.Image = new Bitmap("graphix\\B3.png");
								nume.Text = " ";
								break;

							case 4: nume.Image = new Bitmap("graphix\\B4.png");
								nume.Text = " ";
								break;
						}
						hit.Clear();
						hit.Text = "Airplane no. 2 was crashed!";
						crash.PerformStep();

						Program.a_ramase--;
						Program.a[vertical, orizontal] = '4';
						break;

					case 'C':
						switch (Program.a3) {
							case 1: nume.Image = new Bitmap("graphix\\C1.png");
								nume.Text = " ";
								break;

							case 2: nume.Image = new Bitmap("graphix\\C2.png");
								nume.Text = " ";
								break;

							case 3: nume.Image = new Bitmap("graphix\\C3.png");
								nume.Text = " ";
								break;

							case 4: nume.Image = new Bitmap("graphix\\C4.png");
								nume.Text = " ";
								break;
						}
						hit.Clear();
						hit.Text = "Airplane no. 3 was crashed!";
						crash.PerformStep();

						Program.a_ramase--;
						Program.a[vertical, orizontal] = '4';
						break;

					default:
						if (Program.a[vertical, orizontal] == '0') nume.Text = " ";
						Program.a[vertical, orizontal] = '4';

						hit.Clear();
						hit.Text = "No airplane in the area!";
						break;

				}
			}
			catch (Exception img) {
				MessageBox.Show(img.Message);
			}
            if (Program.a_ramase == 0) {
				timp.Enabled = false;

                DialogResult dlgResult = MessageBox.Show("Congratulations, "+ Program.nume +", you won!\nYou can start a new game using: File menu -> New Game\nOr by pressing Ctrl+N", "Congratulations", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
				
				if (dlgResult == DialogResult.Cancel) {
					open = false;
					Application.Exit();
				}
            }
        }

        todolist todo = new todolist();
        private void toDoListToolStripMenuItem_Click(object sender, EventArgs e) {
            todo.ShowDialog();
        }

		void contor() {
			MethodInvoker action = delegate {
				iTime = DateTime.Now;
				duration = iTime - startTime;
				showTime = duration.TotalSeconds + intermediaryTime;
				timeElapsed.Clear();
				timeElapsed.Text = System.Convert.ToInt32(showTime) + "";
			};

			timeElapsed.BeginInvoke(action);			
		}

        private void buttons_Click(object sender, EventArgs e) {
			int iint, jint;
			if (sender is Button) {
				Button btn = (System.Windows.Forms.Button)sender;
				string btn_nume = btn.Name;
				string i = btn_nume.Substring(3, 1);
				string j = btn_nume.Substring(4, 1);
				iint = System.Convert.ToInt32(i, 10);
				jint = System.Convert.ToInt32(j, 10);

				if (Program.a[iint, jint] != '4' && Program.a[iint, jint] != 'F') {
					Program.ct++;
				}

				if (Program.ct == 1) {
					pause.Enabled = true;
					thTimp = new Thread(new ThreadStart(contor));
					thTimp.Start();
					startTime = DateTime.Now;
					timp.Enabled = true;
				}

				nrHits.Clear();
				nrHits.Text = Convert.ToString(Program.ct);

				if (Program.a[iint, jint] != 'F') {
					lovire(iint, jint, btn, hitBox, crashedBar, timp);
				}

				if (Program.a_ramase == 0) {
					timp.Enabled = false;
					thTimp.Abort();

					pause.Enabled = false;
					battleground.Enabled = false;

					if (Directory.Exists("files")) {
						if (File.Exists("files\\top")) {
							try {
								using (StreamWriter writeTop = new StreamWriter("files\\top", true)) {
									writeTop.WriteLine(Program.nume + "," + timeElapsed.Text + "," + Program.ct);
								}
							}
							catch (Exception append) {
								MessageBox.Show(append.Message, "Error");
							}
						}
						else {
							try {
								FileInfo fi = new FileInfo(@"files\\top");
								FileStream fstr = fi.Create();
								fstr.Close();

								using (StreamWriter writeTop = new StreamWriter("files\\top", true)) {
									writeTop.WriteLine(Program.nume + "," + timeElapsed.Text + "," + Program.ct);
								}
							}
							catch (Exception createAppend) {
								MessageBox.Show(createAppend.Message, "Error");
							}
						}
					}
					else {
						try {
							Directory.CreateDirectory("files");
							FileInfo fi = new FileInfo(@"files\\top");
							FileStream fstr = fi.Create();
							fstr.Close();

							using (StreamWriter writeTop = new StreamWriter("files\\top", true)) {
								writeTop.WriteLine(Program.nume + "," + timeElapsed.Text + "," + Program.ct);
							}
						}
						catch (Exception createAppend) {
							MessageBox.Show(createAppend.Message, "Error");
						}
					}

					if (open) {
						top topShooters = new top();
						topShooters.ShowDialog();
					}
				}
			}
        }

		private void timp_Tick(object sender, EventArgs e) {
			contor();
		}

		private void btn_MouseUP(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Right) {
				int iint, jint;
				Button btn = (System.Windows.Forms.Button)sender;
				string btn_nume = btn.Name;
				string i = btn_nume.Substring(3, 1);
				string j = btn_nume.Substring(4, 1);
				iint = System.Convert.ToInt32(i, 10);
				jint = System.Convert.ToInt32(j, 10);

				if(Program.a[iint, jint] != '4'){
					if (Program.a[iint, jint] != 'F') {
						t[iint, jint] = Program.a[iint, jint];
						Program.a[iint, jint] = 'F';

						btn.Image = new Bitmap("graphix\\flag.png");
						btn.Text = " ";
					}
					else if (Program.a[iint, jint] == 'F') {
						btn.Image = null;
						btn.Text = iint + "" + jint;

						Program.a[iint, jint] = t[iint, jint];
					}
				}
			}
		}

		top topShooters = new top();
		private void topShootersToolStripMenuItem_Click(object sender, EventArgs e) {
			topShooters.ShowDialog();
		}

		private void close(object sender, FormClosingEventArgs e) {
			if (e.CloseReason != CloseReason.ApplicationExitCall) {
				Application.Exit();
			}

		}

		private void pause_f() {
			paused = !paused;

			if (paused) {
				intermediaryTime += duration.TotalSeconds;
			}
			else {
				showTime = 0;
				startTime = DateTime.Now;
			}

			timp.Enabled = !paused;
			battleground.Enabled = !paused;
			pause.Text = paused ? "Unpause" : "Pause";
		}

		private void pause_Click(object sender, EventArgs e) {
			pause_f();
		}

		private void pause_down(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Pause || e.KeyCode == Keys.P) {
				pause_f();
			}
		}
	}

    public class RandomNumberGenerator {
        //Returns a single random integer between two numbers, both inclusive        
        public static int GetRandomInt(int min, int max) {
            return GetRandomInts(min, max, 1)[0];
        }

        //Returns an array of random integers between two numbers, both inclusive        
        public static int[] GetRandomInts(int min, int max, int trials) {
            //Build the url string to www.random.org
            string url = "http://www.random.org/integers/?num=" + trials.ToString(); ;

            url += "&min=" + min.ToString();
            url += "&max=" + max.ToString();
            url += "&col=1&base=10&format=html&rnd=new";

            string data = DownloadData(url);

            if (data != string.Empty) {
                //Parse the data
                string startMarker = "<pre class=" + '"' + "data" + '"' + ">"; //<pre class="data">
                int j = data.IndexOf(startMarker);
                if (j != -1) {
                    int k = data.IndexOf("</pre>", j);
                    if (k != -1) {
                        string intString = data.Substring(j + startMarker.Length, k - j - startMarker.Length);
                        intString = intString.Trim();

                        //Read each line
                        List<int> integers = new List<int>();
                        StringReader readLines = new StringReader(intString);

                        while (readLines.Peek() != -1) {
                            integers.Add(int.Parse(readLines.ReadLine()));
                        }

                        return integers.ToArray();
                    }
                }
            }

            return new int[] { -1 };
        }

        public static bool HasQuota() {
            string url = "http://www.random.org/quota/?format=plain";

            int ret = Convert.ToInt32(DownloadData(url));

            return (ret > 0);
        }

        //Connects to URL to download data
        private static string DownloadData(string url) {
            try {
                //Get a data stream from the url
                WebRequest req = WebRequest.Create(url);
                WebResponse response = req.GetResponse();
                Stream stream = response.GetResponseStream();

                //Download in chuncks
                byte[] buffer = new byte[1024];

                //Get Total Size
                int dataLength = (int)response.ContentLength;

                //Download to memory
                //Note: adjust the streams here to download directly to the hard drive
                MemoryStream memStream = new MemoryStream();
                while (true) {
                    //Try to read the data
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);

                    if (bytesRead == 0)
                        break;
                    else
                        memStream.Write(buffer, 0, bytesRead);
                }

                //Convert the downloaded stream to a byte array
                string downloadedData = System.Text.ASCIIEncoding.ASCII.GetString(memStream.ToArray());

                //Clean up
                stream.Close();
                memStream.Close();

                return downloadedData;
            }
            catch (Exception) {
                return string.Empty;
            }
        }

    }
}