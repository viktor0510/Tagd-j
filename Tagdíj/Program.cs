using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Common;
using MySql.Data.MySqlClient;

namespace Tagdíj
{
    static class Program
    {
        public static Tagokuj tagokuj = null;
        public static Tagokmodositas tagokmodositas = null;
        public static Befizetesekuj befizetesekuj = null;
        public static Befizeteslekerdezes befizeteslekerdezes = null;
        public static Form1 nyito = null;
        public static MySqlConnection conn = null;
        public static MySqlCommand sql = null;

        static void Main()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "tagdij";
            conn = new MySqlConnection(sb.ToString());
            try
            {
                conn.Open();
                sql = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            tagokuj = new Tagokuj();
            tagokmodositas = new Tagokmodositas();
            befizetesekuj = new Befizetesekuj();
            befizeteslekerdezes = new Befizeteslekerdezes();
            nyito = new Form1();
            Application.Run(nyito);
        }
    }
}
