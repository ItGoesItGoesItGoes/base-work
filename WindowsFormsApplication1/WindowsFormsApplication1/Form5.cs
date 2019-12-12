using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        int timerOut = TimeForm2.TimeData;
        int days = 0, hours = 0, minutes = 0;
        string dataString = "";

        public Form5()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeForm2.TimeData = timerOut;
            this.Hide();
            FormWorker.InfoMerop.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerOut -= 1;
            days = (timerOut / 86400);
            hours = (timerOut - (days * 86400)) / 3600;
            minutes = (timerOut - (days * 86400) - (hours * 3600)) / 60;
            dataString = days + " дней " + hours + " часов и " + minutes + " минут до старта марафона";
            label1.Text = dataString;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            UserControl1 usercontrol11 = new UserControl1();
          
            this.Controls.Add(usercontrol11);
            UserControl1.picturebox1.Image = new Bitmap("C:/Users/user12/Desktop/464_Savos/WindowsFormsApplication1/Pics/arise-logo.png");
        }
    }
}
