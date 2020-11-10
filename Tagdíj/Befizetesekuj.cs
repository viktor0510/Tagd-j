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
    public partial class Befizetesekuj : Form
    {
        public Befizetesekuj()
        {
            InitializeComponent();
        }

        private void Befizetesekuj_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Program.nyito.Show();
        }

        private void button1_Befizetes_Click(object sender, EventArgs e)
        {
            string beazonosito = (string)textBox1_ujAzon.Text.Trim();
            DateTime datum = dateTimePicker1_ujdatum.Value;
            string osszeg = (string)textBox1_ujosszeg.Text.Trim();
            Program.sql.CommandText= "INSERT INTO `befiz` (`azon`, `datum`, `osszeg`) VALUES('"+beazonosito+"', '"+datum+"', '"+osszeg+"')";
            Program.sql.ExecuteNonQuery();
        }
    }
}
