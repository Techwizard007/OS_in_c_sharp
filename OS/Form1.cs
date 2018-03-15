using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OS;
using System.Threading;
using System.Speech.Synthesis;

namespace OS

 {
   
    
    public partial class Form1 : Form
    {
        Thread th;
        Form boot = new boot();
        
        public Form1()
        {
            InitializeComponent();
            timer1.Start();

            
            
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Close();
                th = new Thread(openform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                
                
                         
                                              
            }
            
        }
        private void openform()
        {
            Application.Run(new boot());
            
        }

    }
}
