using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingPassion
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        int startpoint = 0;
        
        private void timer1_Tick(object sender, EventArgs e)
        {

            startpoint += 5;
            progressBar1.Value = startpoint;
            if(progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                Form1 log = new Form1();
                this.Hide();
                log.Show();

            }

        }

        private void Loading_Load(object sender, EventArgs e)
        {

            timer1.Start();

        }
    }
}
