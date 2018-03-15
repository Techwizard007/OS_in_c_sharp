using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using OS;


namespace OS
{
    public partial class boot : Form
    {
        
        public boot()
        {
            
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
            timer1.Start();
            label2.Hide();
            label3.Hide();
            textuser.Hide();
            textpass.Hide();
            button1.Hide();

                
                       
        }
      
           
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void boot_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(2);
           
            if (progressBar1.Value==100)
            {
                //this.Hide();
                
                timer1.Stop();
                label1.Hide();
                progressBar1.Hide();
                label2.Show();
                label3.Show();
                textuser.Show();
                textpass.Show();
                button1.Show();
               


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textuser.Text=="root" && textpass.Text=="12345")
            {
                this.Hide();
                desktop d = new desktop();
                
                d.Show();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
