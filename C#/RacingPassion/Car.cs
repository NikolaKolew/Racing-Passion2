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
    public partial class Car : Form
    {
        public Car(String text)
        {
            InitializeComponent();
            username.Text = text;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Loged frm = new Loged(username.Text);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (brand.Text.Trim() == "" && model.Text.Trim() == "" && engine.Text.Trim() == "" && hp.Text.Trim() == "" && fuel.Text.Trim() == "")
            {
                MessageBox.Show("Empty Fields");
            }
            else
            {

               

                    string query = "INSERT INTO car_info(Brand,Model,Engine,HP,Fuel) VALUES(@brand,@model,@engine,@hp,@fuel)";
                    SQLiteConnection conn = new SQLiteConnection("Data Source=RacinPassionDB.db;Version=3;");
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@brand", brand.Text);
                    cmd.Parameters.AddWithValue("@model", model.Text);
                    cmd.Parameters.AddWithValue("@engine", engine.Text);
                    cmd.Parameters.AddWithValue("@hp", hp.Text);
                    cmd.Parameters.AddWithValue("@fuel", fuel.Text);
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    MessageBox.Show("Car added");



            }




        }

        private void Car_Load(object sender, EventArgs e)
        {

        }
    }
}
