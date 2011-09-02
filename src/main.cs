using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Avionase {
    static class Program {
        public static char[,] a = new char[9, 9];

        public static bool generat2 = false;
        public static bool generat3 = false;

        public static int a1;
        public static int a2;
        public static int a3;

        public static int a_ramase = 3;
		public static int ct = 0;

		public static string nume;
		public static bool numeOK = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NewGame());
        }
    }
}
