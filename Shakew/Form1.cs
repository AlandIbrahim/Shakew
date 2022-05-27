using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shakew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormyDww F2=new FormyDww();
            F2.Show();
            F2.Owner=this;
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            //Size = new Size(0, 0);
            unchecked
            {

                Random random = new Random();//create a Random object and call it random.

                //create integer called val, and assign a random value to it, between -21474838648(minimum integer) and 21474838647(maximum integer)
                int val = random.Next(int.MinValue, int.MaxValue);
                val |= (int)0xff000000;//this line is to keep ALPHA in ARGB* at full 255.
                BackColor = Color.FromArgb(val);
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
        }

        private void xwlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xwlaToolStripMenuItem.Checked = !xwlaToolStripMenuItem.Checked;
            TopMost = xwlaToolStripMenuItem.Checked;
        }

        private void button1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            HelpForm HF= new HelpForm();
            HF.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alwaysOnTopToolStripMenuItem.Checked = !alwaysOnTopToolStripMenuItem.Checked;
            TopMost= alwaysOnTopToolStripMenuItem.Checked;
        }

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
