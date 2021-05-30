using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingPassion
{
    public partial class Profile : Form
    {
        public Profile(String text)
        {
            InitializeComponent();
            usern.Text = text;
            String users = text;

            try
            {
                SQLiteConnection conn = new SQLiteConnection("Data Source=RacinPassionDB.db;Version=3;");
                conn.Open();
                string query = "SELECT surname, name, email FROM user WHERE username = '"+users+"'";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    surname.Text = dr.GetValue(0).ToString();
                    name.Text = dr.GetValue(1).ToString();
                    email.Text = dr.GetValue(2).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }

            //UserFromDb();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            Loged frm = new Loged(usern.Text);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
        public void UserFromDb()
        {


             try
             {
                 SQLiteConnection conn = new SQLiteConnection("Data Source=RacinPassionDB.db;Version=3;");
                 conn.Open();
                 string query = "SELECT surname, name, email FROM user WHERE username = @usern";
                 SQLiteCommand cmd = new SQLiteCommand(query, conn);
                 SQLiteDataReader dr = cmd.ExecuteReader();
                 while (dr.Read())
                 {
                     surname.Text = dr.GetValue(0).ToString();
                     name.Text = dr.GetValue(1).ToString();
                     email.Text = dr.GetValue(2).ToString();
                 }
             }
             catch
             {
                 MessageBox.Show("Error");
             }



        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
