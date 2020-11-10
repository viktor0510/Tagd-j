using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tagdíj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.tagokuj.Show();
        }

        private void módosításToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.tagokmodositas.Show();
        }

        private void újToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.befizetesekuj.Show();
        }

        private void lekérdezésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.befizeteslekerdezes.Show();
        }
    }
}
