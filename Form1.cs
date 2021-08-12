using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Location = new Point(113, 129);
        }

        private void BotonSi_Click(object sender, EventArgs e)
        {
            BotonSi_Click(); 
        }

        private void BotonSi_Click()
        {
            //this.Opacity -= 0.30000;
            this.BackColor = Color.Black;

            panel1.Visible = false;
            label1.Visible = false;
            BotonSi.Visible = false;

            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();

            try
            {
                panel1.Location = new Point(random.Next(0, 500), random.Next(0, 200));
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BotonNo_MouseLeave(object sender, EventArgs e)
        {
            BotonNo.Text = "No";
            BotonSi.Text = "Si";
            //BotonNo.Enabled = true;
        }

        private void BotonNo_MouseEnter(object sender, EventArgs e)
        {
            BotonNo.Text = "Si";
            BotonSi.Text = "No";
            //BotonSi.Focus();
            //BotonNo.Enabled = false;
        }

        private void BotonNo_Click(object sender, EventArgs e)
        {
            if (BotonNo.Text == "Si")
            {
                BotonSi_Click();
            }
        }
    }
}
