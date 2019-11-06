using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());

        }
    }
    static class TimeForm2
    {
        public static int TimeData = 5551200;
    }
   // public static void VizovFormi()
 //   {
  //      Form3 Sponsor = new Form3();
  //      Sponsor.Show();
  //  }
    public class FormWorker
    {
        public static Form3 Sponsor
        {
            get
            {
                if (_sponsor == null)
                { 
                    _sponsor = new Form3();
                }
                return _sponsor;
            }
        }
        private static Form3 _sponsor;
        public static Form4 InfoMerop
        {
            get
            {
                if (_infomerop == null)
                {
                    _infomerop = new Form4();
                }
                return _infomerop;
            }
        }
        private static Form4 _infomerop;
        public static Form5 SpisokBlago
        {
            get
            {
                if (_spisokblago == null)
                {
                    _spisokblago = new Form5();
                }
                return _spisokblago;
            }
        }
        private static Form5 _spisokblago;
    }
}
