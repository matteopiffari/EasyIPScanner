using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.IO;

namespace IPScanner
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Console.WriteLine("Start");
            Console.WriteLine("");

                string a = IP1.Text;
                string b = IP2.Text;
                string c = IP3.Text;
                int d = 0;


                while (d < 255)
                {

                    string CPing = a + "." + b + "." + c + "." + Convert.ToString(d);

                    Ping ping = new Ping();
                    PingReply replay = ping.Send(CPing, 250);
                    Console.WriteLine(CPing + " " + replay.Status.ToString());

                    d = d + 1;
                }

            Console.WriteLine("");
            Console.WriteLine("Finished");
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Project-Piffa/IPScanner");
        }
    }
}
