using System.Windows.Forms;

namespace Vrijeme
{
    public partial class Form1 : Form
    {
        DateTime pocetno = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusTrenutnoVrijeme.Text = "Trenutno: " + DateTime.Now.ToLongTimeString();
            TimeSpan proteklo = new TimeSpan();
            proteklo = DateTime.Now - pocetno;
            toolStripStatusProtekloVrijeme.Text = "Proteklo: " +
            proteklo.Hours.ToString() + ":" + proteklo.Minutes.ToString() + ":" + proteklo.Seconds.ToString();
        }
    }
}