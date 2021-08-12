using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            timer1.Start();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(2);
            //while (this.Opacity > 0)
            //{
            //    this.Opacity -= 0.00002;
            //}

            if (progressBar1.Value == 100)
            {
                this.Close();
                Application.Exit();
            }           
        }
    }
}
