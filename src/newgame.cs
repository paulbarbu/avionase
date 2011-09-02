using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Avionase {

    public partial class NewGame : Form {

		public static Thread gen, wait;
		public int punct = 1;

        public NewGame() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
			btnSP.Enabled = true;
			Program.ct = 0;
			Program.generat2 = false;
			Program.generat3 = false;
			Program.a_ramase = 3;
        }

		void Algoritm() {
            int i, j;

            int x1 = new int();
            int y1 = new int();
            int x2 = new int();
            int y2 = new int();
            int x3 = new int();
            int y3 = new int();

            int ct = new int();

            int brk = new int();

            int v = new int();
            int v2 = new int();
            int v3 = new int();

            v = 0;
            v2 = 0;
            v3 = 0;

            Program.generat2 = false;
            Program.generat3 = false;
            //umplere matrice cu 0
            for (i = 0; i < 9; i++)
                for (j = 0; j < 9; j++)
                    Program.a[i, j] = '0';

        //avionul 1
        //randomizare a1,x1, y1;
        rerand:

            if (brk > 1) {
                DialogResult dlgResult = MessageBox.Show("Application needs to be restarted!\nError while generating airplanes!\nPlease open the game again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dlgResult == DialogResult.OK) {
                    Application.Exit();
                }
            }
            else
                brk++;

            Program.a1 = RandomNumberGenerator.GetRandomInt(1, 4);

            if (Program.a1 == 1) {
                x1 = RandomNumberGenerator.GetRandomInt(2, 6);
                y1 = RandomNumberGenerator.GetRandomInt(0, 5);
            }
            else if (Program.a1 == 2) {
                x1 = RandomNumberGenerator.GetRandomInt(3, 8);
                y1 = RandomNumberGenerator.GetRandomInt(2, 6);
            }
            else if (Program.a1 == 3) {
                x1 = RandomNumberGenerator.GetRandomInt(2, 6);
                y1 = RandomNumberGenerator.GetRandomInt(3, 8);
            }
            else if (Program.a1 == 4) {
                x1 = RandomNumberGenerator.GetRandomInt(0, 5);
                y1 = RandomNumberGenerator.GetRandomInt(2, 6);
            }

            i = y1;
            j = x1;

            if (Program.a1 == 1) {  //varful in sus, este primul avion si nu are nevoie de verificari
                Program.a[i, j] = 'A';
                Program.a[i + 1, j - 2] = '1';
                Program.a[i + 1, j - 1] = '1';
                Program.a[i + 1, j] = '1';
                Program.a[i + 1, j + 1] = '1';
                Program.a[i + 1, j + 2] = '1';
                Program.a[i + 2, j] = '1';
                Program.a[i + 3, j - 1] = '1';
                Program.a[i + 3, j] = '1';
                Program.a[i + 3, j + 1] = '1';
            }
            else if (Program.a1 == 2) { //varful la dreapta
                Program.a[i, j] = 'A';
                Program.a[i - 2, j - 1] = '1';
                Program.a[i - 1, j - 1] = '1';
                Program.a[i, j - 1] = '1';
                Program.a[i + 1, j - 1] = '1';
                Program.a[i + 2, j - 1] = '1';
                Program.a[i, j - 2] = '1';
                Program.a[i - 1, j - 3] = '1';
                Program.a[i, j - 3] = '1';
                Program.a[i + 1, j - 3] = '1';
            }
            else if (Program.a1 == 3) {//varful in jos
                Program.a[i, j] = 'A';
                Program.a[i - 1, j - 2] = '1';
                Program.a[i - 1, j - 1] = '1';
                Program.a[i - 1, j] = '1';
                Program.a[i - 1, j + 1] = '1';
                Program.a[i - 1, j + 2] = '1';
                Program.a[i - 2, j] = '1';
                Program.a[i - 3, j - 1] = '1';
                Program.a[i - 3, j] = '1';
                Program.a[i - 3, j + 1] = '1';
            }
            else { //varful in stanga
                Program.a[i, j] = 'A';
                Program.a[i - 2, j + 1] = '1';
                Program.a[i - 1, j + 1] = '1';
                Program.a[i, j + 1] = '1';
                Program.a[i + 1, j + 1] = '1';
                Program.a[i + 2, j + 1] = '1';
                Program.a[i, j + 2] = '1';
                Program.a[i - 1, j + 3] = '1';
                Program.a[i, j + 3] = '1';
                Program.a[i + 1, j + 3] = '1';
            }

            //avionul 2
            ct = 0;
            while (Program.generat2 == false) {
                v2++;
                v++;
                //randomizare a2, x2, y2;
                Program.a2 = RandomNumberGenerator.GetRandomInt(1, 4);

                if (Program.a2 == 1) {
                    x2 = RandomNumberGenerator.GetRandomInt(2, 6);
                    y2 = RandomNumberGenerator.GetRandomInt(0, 5);
                }
                else if (Program.a2 == 2) {
                    x2 = RandomNumberGenerator.GetRandomInt(3, 8);
                    y2 = RandomNumberGenerator.GetRandomInt(2, 6);
                }
                else if (Program.a2 == 3) {
                    x2 = RandomNumberGenerator.GetRandomInt(2, 6);
                    y2 = RandomNumberGenerator.GetRandomInt(3, 8);
                }
                else if (Program.a2 == 4) {
                    x2 = RandomNumberGenerator.GetRandomInt(0, 5);
                    y2 = RandomNumberGenerator.GetRandomInt(2, 6);
                }

                i = y2;
                j = x2;

                if (Program.a2 == 1) {  //varful in sus
                    if (Program.a[i, j] == '0' && Program.a[i + 1, j - 2] == '0' && Program.a[i + 1, j - 1] == '0' && Program.a[i + 1, j] == '0' && Program.a[i + 1, j + 1] == '0' && Program.a[i + 1, j + 2] == '0' && Program.a[i + 2, j] == '0' && Program.a[i + 3, j - 1] == '0' && Program.a[i + 3, j] == '0' && Program.a[i + 3, j + 1] == '0') {
                        Program.a[i, j] = 'B';
                        //a[i + 1, j - 2] = a[i + 1, j - 1] = a[i + 1, j] = a[i + 1, j + 1] = a[i + 1, j + 2] = a[i + 2, j] = a[i + 3, j - 1] = a[i + 3, j] = a[i + 3, j + 1] = '2';
                        Program.a[i + 1, j - 2] = '2';
                        Program.a[i + 1, j - 1] = '2';
                        Program.a[i + 1, j] = '2';
                        Program.a[i + 1, j + 1] = '2';
                        Program.a[i + 1, j + 2] = '2';
                        Program.a[i + 2, j] = '2';
                        Program.a[i + 3, j - 1] = '2';
                        Program.a[i + 3, j] = '2';
                        Program.a[i + 3, j + 1] = '2';
                        Program.generat2 = true;
                    }
                }

                else if (Program.a2 == 2) { //varful la dreapta
                    if (Program.a[i, j] == '0' && Program.a[i - 2, j - 1] == '0' && Program.a[i - 1, j - 1] == '0' && Program.a[i, j - 1] == '0' && Program.a[i + 1, j - 1] == '0' && Program.a[i + 2, j - 1] == '0' && Program.a[i, j - 2] == '0' && Program.a[i - 1, j - 3] == '0' && Program.a[i, j - 3] == '0' && Program.a[i + 1, j - 3] == '0') {
                        Program.a[i, j] = 'B';
                        //a[i - 2, j - 1] = a[i - 1, j - 1] = a[i, j - 1] = a[i + 1, j - 1] = a[i + 2, j - 1] = a[i, j - 2] = a[i - 1, j - 3] = a[i, j - 3] = a[i + 1, j - 3] = '2';
                        Program.a[i - 2, j - 1] = '2';
                        Program.a[i - 1, j - 1] = '2';
                        Program.a[i, j - 1] = '2';
                        Program.a[i + 1, j - 1] = '2';
                        Program.a[i + 2, j - 1] = '2';
                        Program.a[i, j - 2] = '2';
                        Program.a[i - 1, j - 3] = '2';
                        Program.a[i, j - 3] = '2';
                        Program.a[i + 1, j - 3] = '2';
                        Program.generat2 = true;
                    }
                }

                else if (Program.a2 == 3) {//varful in jos
                    if (Program.a[i, j] == '0' && Program.a[i - 1, j - 2] == '0' && Program.a[i - 1, j - 1] == '0' && Program.a[i - 1, j] == '0' && Program.a[i - 1, j + 1] == '0' && Program.a[i - 1, j + 2] == '0' && Program.a[i - 2, j] == '0' && Program.a[i - 3, j - 1] == '0' && Program.a[i - 3, j] == '0' && Program.a[i - 3, j + 1] == '0') {
                        Program.a[i, j] = 'B';
                        //a[i - 1, j - 2] = a[i - 1, j - 1] = a[i - 1, j] = a[i - 1, j + 1] = a[i - 1, j + 2] = a[i - 2, j] = a[i - 3, j - 1] = a[i - 3, j] = a[i - 3, j + 1] = '2';
                        Program.a[i - 1, j - 2] = '2';
                        Program.a[i - 1, j - 1] = '2';
                        Program.a[i - 1, j] = '2';
                        Program.a[i - 1, j + 1] = '2';
                        Program.a[i - 1, j + 2] = '2';
                        Program.a[i - 2, j] = '2';
                        Program.a[i - 3, j - 1] = '2';
                        Program.a[i - 3, j] = '2';
                        Program.a[i - 3, j + 1] = '2';
                        Program.generat2 = true;
                    }
                }
                else if (Program.a2 == 4) {//varful la stanga
                    if (Program.a[i, j] == '0' && Program.a[i - 2, j + 1] == '0' && Program.a[i - 1, j + 1] == '0' && Program.a[i, j + 1] == '0' && Program.a[i + 1, j + 1] == '0' && Program.a[i + 2, j + 1] == '0' && Program.a[i, j + 2] == '0' && Program.a[i - 1, j + 3] == '0' && Program.a[i, j + 3] == '0' && Program.a[i + 1, j + 3] == '0') {
                        Program.a[i, j] = 'B';
                        //a[i - 2, j + 1] = a[i - 1, j + 1] = a[i, j + 1] = a[i + 1, j + 1] = a[i + 2, j + 1] = a[i, j + 2] = a[i - 1, j + 3] = a[i, j + 3] = a[i + 1, j + 3] = '2';
                        Program.a[i - 2, j + 1] = '2';
                        Program.a[i - 1, j + 1] = '2';
                        Program.a[i, j + 1] = '2';
                        Program.a[i + 1, j + 1] = '2';
                        Program.a[i + 2, j + 1] = '2';
                        Program.a[i, j + 2] = '2';
                        Program.a[i - 1, j + 3] = '2';
                        Program.a[i, j + 3] = '2';
                        Program.a[i + 1, j + 3] = '2';
                        Program.generat2 = true;
                    }
                }
                if (Program.generat2 == false) { //incearca alte randomizari
                    if (ct > 350) {
                        ct = 0;
                        goto rerand;
                    }
                    else
                        ct++;
                }
            }

            //avionul 3
            while (Program.generat3 == false) {
                v3++;
                v++;
                //randomizare a3, x3, y3;
                Program.a3 = RandomNumberGenerator.GetRandomInt(1, 4);

                if (Program.a3 == 1) {
                    x3 = RandomNumberGenerator.GetRandomInt(2, 6);
                    y3 = RandomNumberGenerator.GetRandomInt(0, 5);
                }
                else if (Program.a3 == 2) {
                    x3 = RandomNumberGenerator.GetRandomInt(3, 8);
                    y3 = RandomNumberGenerator.GetRandomInt(2, 6);
                }
                else if (Program.a3 == 3) {
                    x3 = RandomNumberGenerator.GetRandomInt(2, 6);
                    y3 = RandomNumberGenerator.GetRandomInt(3, 8);
                }
                else if (Program.a3 == 4) {
                    x3 = RandomNumberGenerator.GetRandomInt(0, 5);
                    y3 = RandomNumberGenerator.GetRandomInt(2, 6);
                }

                i = y3;
                j = x3;


                if (Program.a3 == 1) {  //varful in sus
                    if (Program.a[i, j] == '0' && Program.a[i + 1, j - 2] == '0' && Program.a[i + 1, j - 1] == '0' && Program.a[i + 1, j] == '0' && Program.a[i + 1, j + 1] == '0' && Program.a[i + 1, j + 2] == '0' && Program.a[i + 2, j] == '0' && Program.a[i + 3, j - 1] == '0' && Program.a[i + 3, j] == '0' && Program.a[i + 3, j + 1] == '0') {
                        Program.a[i, j] = 'C';
                        //a[i + 1, j - 2] = a[i + 1, j - 1] = a[i + 1, j] = a[i + 1, j + 1] = a[i + 1, j + 2] = a[i + 2, j] = a[i + 3, j - 1] = a[i + 3, j] = a[i + 3, j + 1] = '3';
                        Program.a[i + 1, j - 2] = '3';
                        Program.a[i + 1, j - 1] = '3';
                        Program.a[i + 1, j] = '3';
                        Program.a[i + 1, j + 1] = '3';
                        Program.a[i + 1, j + 2] = '3';
                        Program.a[i + 2, j] = '3';
                        Program.a[i + 3, j - 1] = '3';
                        Program.a[i + 3, j] = '3';
                        Program.a[i + 3, j + 1] = '3';
                        Program.generat3 = true;
                    }
                }

                else if (Program.a3 == 2) { //varful la dreapta
                    if (Program.a[i, j] == '0' && Program.a[i - 2, j - 1] == '0' && Program.a[i - 1, j - 1] == '0' && Program.a[i, j - 1] == '0' && Program.a[i + 1, j - 1] == '0' && Program.a[i + 2, j - 1] == '0' && Program.a[i, j - 2] == '0' && Program.a[i - 1, j - 3] == '0' && Program.a[i, j - 3] == '0' && Program.a[i + 1, j - 3] == '0') {
                        Program.a[i, j] = 'C';
                        //a[i - 2, j - 1] = a[i - 1, j - 1] = a[i, j - 1] = a[i + 1, j - 1] = a[i + 2, j - 1] = a[i, j - 2] = a[i - 1, j - 3] = a[i, j - 3] = a[i + 1, j - 3] = '3';
                        Program.a[i - 2, j - 1] = '3';
                        Program.a[i - 1, j - 1] = '3';
                        Program.a[i, j - 1] = '3';
                        Program.a[i + 1, j - 1] = '3';
                        Program.a[i + 2, j - 1] = '3';
                        Program.a[i, j - 2] = '3';
                        Program.a[i - 1, j - 3] = '3';
                        Program.a[i, j - 3] = '3';
                        Program.a[i + 1, j - 3] = '3';
                        Program.generat3 = true;
                    }
                }

                else if (Program.a3 == 3) {//varful in jos
                    if (Program.a[i, j] == '0' && Program.a[i - 1, j - 2] == '0' && Program.a[i - 1, j - 1] == '0' && Program.a[i - 1, j] == '0' && Program.a[i - 1, j + 1] == '0' && Program.a[i - 1, j + 2] == '0' && Program.a[i - 2, j] == '0' && Program.a[i - 3, j - 1] == '0' && Program.a[i - 3, j] == '0' && Program.a[i - 3, j + 1] == '0') {
                        Program.a[i, j] = 'C';
                        //a[i - 1, j - 2] = a[i - 1, j - 1] = a[i - 1, j] = a[i - 1, j + 1] = a[i - 1, j + 2] = a[i - 2, j] = a[i - 3, j - 1] = a[i - 3, j] = a[i - 3, j + 1] = '3';
                        Program.a[i - 1, j - 2] = '3';
                        Program.a[i - 1, j - 1] = '3';
                        Program.a[i - 1, j] = '3';
                        Program.a[i - 1, j + 1] = '3';
                        Program.a[i - 1, j + 2] = '3';
                        Program.a[i - 2, j] = '3';
                        Program.a[i - 3, j - 1] = '3';
                        Program.a[i - 3, j] = '3';
                        Program.a[i - 3, j + 1] = '3';
                        Program.generat3 = true;
                    }
                }
                else if (Program.a3 == 4) {//varful la stanga
                    if (Program.a[i, j] == '0' && Program.a[i - 2, j + 1] == '0' && Program.a[i - 1, j + 1] == '0' && Program.a[i, j + 1] == '0' && Program.a[i + 1, j + 1] == '0' && Program.a[i + 2, j + 1] == '0' && Program.a[i, j + 2] == '0' && Program.a[i - 1, j + 3] == '0' && Program.a[i, j + 3] == '0' && Program.a[i + 1, j + 3] == '0') {
                        Program.a[i, j] = 'C';
                        //a[i - 2, j + 1] = a[i - 1, j + 1] = a[i, j + 1] = a[i + 1, j + 1] = a[i + 2, j + 1] = a[i, j + 2] = a[i - 1, j + 3] = a[i, j + 3] = a[i + 1, j + 3] = '3';
                        Program.a[i - 2, j + 1] = '3';
                        Program.a[i - 1, j + 1] = '3';
                        Program.a[i, j + 1] = '3';
                        Program.a[i + 1, j + 1] = '3';
                        Program.a[i + 2, j + 1] = '3';
                        Program.a[i, j + 2] = '3';
                        Program.a[i - 1, j + 3] = '3';
                        Program.a[i, j + 3] = '3';
                        Program.a[i + 1, j + 3] = '3';
                        Program.generat3 = true;
                    }
                }
                if (Program.generat3 == false) { //incearca alte randomizari
                    if (ct > 350) {
                        ct = 0;
                        goto rerand;
                    }
                    else
                        ct++;
                }
            }

			MethodInvoker show = delegate {

				foreach (Form f in Application.OpenForms){
					//If you have a MainForm.cs and SecondForm.cs open,
					//This would have a&nbsp;messagebox with "MainForm" and then "SecondForm"
					//MessageBox.Show(f.GetType().Name);
					if (f.GetType().Name == "instructions" || f.GetType().Name == "about" || f.GetType().Name == "todolist") {
						//You could also do&nbsp;a compare using the .GetType()&nbsp;and typeof() functions
						f.Hide();
					}
				}

				Avionase interfata = new Avionase();
				this.Hide();
				interfata.ShowDialog();				
			};

			noName:
			if (Program.numeOK) {
				btnSP.BeginInvoke(show);
			}
			else {
				Thread.Sleep(900);
				goto noName;
			}

        }

		public void pctpct() {
			MethodInvoker changeDot = delegate {

				if (punct == 1) {
					loadingBox.Text = "Please wait, generating airplanes.";
				}
				else if (punct == 2) {
					loadingBox.Text = "Please wait, generating airplanes..";
				}
				else{
					loadingBox.Text = "Please wait, generating airplanes...";
					punct = 0;
				}

				punct++;
			};
			
			loadingBox.BeginInvoke(changeDot);
		}


		name nameForm = new name(); 
        private void btnSP_Click(object sender, EventArgs e) {
			if (Directory.Exists("graphix")) {
				btnSP.Enabled = false;
				punct = 1;
				wait = new Thread(new ThreadStart(pctpct));
				timer1.Enabled = true;
				wait.Start();

				gen = new Thread(new ThreadStart(Algoritm));
				gen.Start();

				//MessageBox.Show("Generating airplanes!\n Please wait!", "Loading, Please wait!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				nameForm.ShowDialog();

				Program.a_ramase = 3;
			}
			else {
				MessageBox.Show("Sorry you need to get the graphix folder, else the game won't start", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.Exit();
			}
			
        }

        private void btnExit_Click(object sender, EventArgs e) {
			if (gen != null && gen.IsAlive) {
				gen.Abort();
			}
            Application.Exit();
        }

        private void loadingBox_TextChanged(object sender, EventArgs e) {

        }

        instructions instructiuni = new instructions();
        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e) {
            instructiuni.ShowDialog();
        }
        
        about aboutForm = new about();
        private void copyrightToolStripMenuItem_Click(object sender, EventArgs e) {
            aboutForm.ShowDialog();
        }

        todolist todo = new todolist();
        private void toDoListToolStripMenuItem_Click(object sender, EventArgs e) {
            todo.ShowDialog();
        }

		private void timer1_Tick(object sender, EventArgs e) {
			pctpct();
		}
    }
}
