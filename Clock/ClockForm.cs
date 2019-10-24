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
            Activated += ClockForm_Activated;
        }

        private void ClockForm_Activated(object sender, EventArgs e)
        {
            var form = Form.ActiveForm;
            form.TopMost = true;

            // Define the border style of the form to a dialog box.
            form.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Set the MaximizeBox to false to remove the maximize box.
            form.MaximizeBox = false;

            // Set the MinimizeBox to false to remove the minimize box.
            form.MinimizeBox = false;

            // Set the start position of the form to the center of the screen.
            form.StartPosition = FormStartPosition.CenterScreen;

            // Display the form as a modal dialog box.
            form.ShowDialog();



        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            this.TimeLabel.Text = now.ToString("HH:mm");
            this.SecondsLabel.Text = now.ToString(":ss");
        }
    }
}
