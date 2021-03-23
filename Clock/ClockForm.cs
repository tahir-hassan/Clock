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
        public int OffsetInSeconds { get; set; } = 0;

        public ClockForm()
        {
            this.Timer = new Timer();
            this.Timer.Interval = 100;
            this.Timer.Tick += Timer_Tick;
            this.Timer.Start();
            InitializeComponent();
            Activated += ClockForm_Activated;
        }

        private void ClockForm_Activated(object sender, EventArgs e)
        {
            var form = Form.ActiveForm;
            form.TopMost = true;

            // Set the MaximizeBox to false to remove the maximize box.
            form.MaximizeBox = false;

            // Set the MinimizeBox to false to remove the minimize box.
            form.MinimizeBox = false;

            form.KeyUp += Form_KeyUp;

            // Set the start position of the form to the center of the screen.
            form.StartPosition = FormStartPosition.CenterScreen;

            Activated -= ClockForm_Activated;
        }

        private void Form_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Shift | Keys.OemMinus))
            {
                this.OffsetInSeconds -= 1;
            }
            else if (e.KeyData == (Keys.Shift | Keys.Oemplus))
            {
                this.OffsetInSeconds += 1;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var now = DateTime.Now.AddSeconds(this.OffsetInSeconds);
            this.TimeLabel.Text = now.ToString("HH:mm");
            this.SecondsLabel.Text = now.ToString(":ss");
            this.Text = this.TimeLabel.Text + " " + this.SecondsLabel.Text;
        }
    }
}
