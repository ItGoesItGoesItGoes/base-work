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
    public partial class Form3 : Form
    {

        int timerOut = TimeForm2.TimeData;
        int days = 0, hours = 0, minutes = 0;
        string dataString = "";
        int BoxSodej = 300;
        //Form2 ManeForm;
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeForm2.TimeData = timerOut;
            //this.Hide();
            //ManeForm.Show();
            this.Hide();
            Form2 ManeForm= new Form2();

            //ManeForm.ShowDialog();
            ManeForm.Show();
            //this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g464_Savosteenko_BaranovDataSet.View_2' table. You can move, or remove it, as needed.
            this.view_2TableAdapter.Fill(this.g464_Savosteenko_BaranovDataSet.View_2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BoxSodej -= 10;
            textBox1.Text = BoxSodej.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BoxSodej += 10;
            textBox1.Text = BoxSodej.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label9.Text = textBox1.Text + "$";
            BoxSodej = Convert.ToInt32(textBox1.Text);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
