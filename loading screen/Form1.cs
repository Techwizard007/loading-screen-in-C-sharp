using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loading_screen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            progressBar1.Value = progressBar1.Value + 1;


            if(progressBar1.Value == 100)
            {
                timer1.Stop();
                MessageBox.Show("loading compeleted","MEssage", MessageBoxButtons.OK,MessageBoxIcon.Information );
                this.Close(); 
            }
        }
    }
}
