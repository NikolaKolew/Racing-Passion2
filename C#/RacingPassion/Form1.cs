using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace RacingPassion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(user.Text.Trim() == "" && pass.Text.Trim() == "")
            {
                MessageBox.Show("Empty Fields");
            }
            else
            {
                string query = "SELECT * FROM user WHERE username= @user AND password= @pass";
                SQLiteConnection conn = new SQLiteConnection("Data Source=RacinPassionDB.db;Version=3;");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", user.Text);
                cmd.Parameters.AddWithValue("@pass", pass.Text);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    Loged frm = new Loged(user.Text);
                    
                    frm.Location = this.Location;
                    frm.StartPosition = FormStartPosition.Manual;
                    frm.FormClosing += delegate { this.Show(); };
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }


            }



        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {

            if (enteruser.Text.Trim() == "" && enterpass.Text.Trim() == "")
            {
                MessageBox.Show("Empty Fields");
            }
            else
            {
                try
                {

                    string query = "INSERT INTO user(username, password,name,surname,email) VALUES(@enteruser,@enterpass,@Name,@Surname,@email)";
                    
                    SQLiteConnection conn = new SQLiteConnection("Data Source=RacinPassionDB.db;Version=3;");
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@enteruser", enteruser.Text);
                    cmd.Parameters.AddWithValue("@enterpass", enterpass.Text);
                    cmd.Parameters.AddWithValue("@Name", Name.Text);
                    cmd.Parameters.AddWithValue("@Surname", Surname.Text);
                    cmd.Parameters.AddWithValue("@email", email.Text);
                    
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    MessageBox.Show("Registered");



                }
                catch
                {
                    MessageBox.Show("User already exist");
                }




            }



        }
    }
}
