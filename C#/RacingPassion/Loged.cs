using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace RacingPassion
{
    public partial class Loged : Form
    {
        
        public Loged(String text)
        {
            InitializeComponent();
            label1.Text = "Welcome to Racing Passion app for car diagnostic";
            username.Text = text;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("D:\\RacingPassionProject\\Python\\dist\\CarOutputs.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Car frm = new Car(username.Text);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Profile frm = new Profile(username.Text);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void Loged_Load(object sender, EventArgs e)
        {

        }
    }
}
