using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class ClockForm : Form
    {
        private Timer Timer { get; set; }

        public ClockForm()
        {
            this.Timer = new Timer();
            this.Timer.Interval = 500;
            this.Timer.Tick += Timer_Tick;
            this.Timer.Start();
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            this.TimeLabel.Text = now.ToString("HH:mm");
            this.SecondsLabel.Text = now.ToString(":ss");
        }
    }
}
