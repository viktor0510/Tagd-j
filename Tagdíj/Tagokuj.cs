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
    public partial class Tagokuj : Form
    {
        public Tagokuj()
        {
            InitializeComponent();
        }

        private void Tagokuj_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Program.nyito.Show();
        }

        private void button1_ujRogzites_Click(object sender, EventArgs e)
        {
            string azonosito = (string)textBox1_ujazonosito.Text.Trim();
            string nev = (string)textBox2_ujnev.Text.Trim();
            int szulev = (int)numericUpDown1_ujszulev.Value;
            string irszam = (string)textBox3_ujiranyitoszam.Text.Trim();
            string orszag = (string)textBox4_ujorszag.Text.Trim();
            Program.sql.CommandText= "INSERT INTO `ugyfel` (`azon`, `nev`, `szulev`, `irszam`, `orsz`) VALUES('"+azonosito+"', '"+nev+"', '"+szulev+"', '"+irszam+"', '"+orszag+"')";
            Program.sql.ExecuteNonQuery();
        }
    }
}
