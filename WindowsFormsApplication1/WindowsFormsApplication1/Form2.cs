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
    public partial class Form2 : Form
    {

        int timerOut = TimeForm2.TimeData;
        int days = 0,hours = 0, minutes = 0;
        string dataString = "";
        public Form2()
        {
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerOut -= 1;
            days = (timerOut/86400);
            hours = (timerOut - (days*86400))/3600;
            minutes = (timerOut - (days * 86400) - (hours * 3600))/60;
            dataString = days + " дней " + hours + " часов и " + minutes + " минут до старта марафона";
            label3.Text = dataString;
            //label3.Text = timerOut.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TimeForm2.TimeData = timerOut;
            this.Hide();
            //TimeForm2.TimeData = timerOut;
            //Form3 Sponsor = new Form3();
            //Sponsor.Show();
            FormWorker.Sponsor.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TimeForm2.TimeData = timerOut;
            this.Hide();
            FormWorker.InfoMerop.Show();
        }
    }
}
