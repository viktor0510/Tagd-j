using MySql.Data.MySqlClient;
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
    public partial class Befizeteslekerdezes : Form
    {
        public Befizeteslekerdezes()
        {
            InitializeComponent();
        }

        private void Befizeteslekerdezes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Program.nyito.Show();
        }

        private void button1_lekerdezes_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.befizeteslekerdezes.Show();
        }

        private void Befizeteslekerdezes_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "azonosito";
            dataGridView1.Columns[0].HeaderText = "Azonosító";
            dataGridView1.Columns[1].Name = "datum";
            dataGridView1.Columns[1].HeaderText = "Dátum";
            dataGridView1.Columns[2].Name = "osszeg";
            dataGridView1.Columns[2].HeaderText = "Összeg";
            try
            {
                Program.sql.CommandText = "SELECT `azon`, `datum`, `osszeg` FROM `befiz` WHERE 1";
                using (MySqlDataReader dr=Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int ujIndex = dataGridView1.Rows.Add();
                        dataGridView1.Rows[ujIndex].Cells[0].Value = dr.GetInt32("azonosito");
                        dataGridView1.Rows[ujIndex].Cells[1].Value = dr.GetDateTime("datum");
                        dataGridView1.Rows[ujIndex].Cells[2].Value = dr.GetString("osszeg");
                    }
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Adatbázis elérési hiba!");
            }
        }
    }
}
