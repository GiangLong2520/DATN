using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoTroBenhNhanThan.GUI
{
    public partial class TurnWindow : Sample
    {
        public TurnWindow()
        {
            InitializeComponent();
        }

        int ticks = 0;
        private void TurnWindow_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            if(ticks == 60) {
                ticks= 0;
                lb_token.Text = HealthCheckWindow.turnNo.ToString() + " # CLINIC";
            }
        }

        private void lb_token_Click(object sender, EventArgs e)
        {

        }

        private void TurnWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }
    }
}
