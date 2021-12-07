using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using CheckBoxesForm;

namespace CheckBoxes
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            int checkboxCount = 0;

            bool checkBox1 = false;

            if (checkBox1.checked)
            {
                checkboxCount++;
            }
                bool checkBox2 = false;

            if (checkBox2.checked)
            {
                checkboxCount++;
            }
                bool checkBox3 = false;

            if (checkBox3.checked)
            {
                checkboxCount++;
            }
                bool checkBox4 = false;

            if (checkBox4.checked)
            {
                checkboxCount++;
            }
                bool checkBox5 = false;

            if (checkBox5.checked)
            {
                checkboxCount++;
            }

            string label1 = "";

            public void button1_Click(object sender, EventArgs e)
            {
                label1 = Console.Write("Testing Function");

            }

            // label1.Text = Console.WriteLine("Testing to see if this function works");
        }
    }
}
}                        