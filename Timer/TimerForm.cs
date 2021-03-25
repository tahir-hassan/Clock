using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class TimerForm : Form
    {
        private bool AlarmStarted = false;
        private SoundPlayer AlarmPlayer = new SoundPlayer();

        private TimeSpan TimerInitialValue { get; set; }
        private DateTime TimerStartDate { get; set; }
        private bool IsPaused { get; set; }

        private System.Windows.Forms.Timer Timer { get; set; }

        private static string MechanicalBellSoundLocation()
        {
            var loc = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var dir = System.IO.Path.GetDirectoryName(loc);
            return System.IO.Path.Combine(dir, "MechanicalBell.wav");
        }
        
        public TimerForm()
        {
            this.Timer = new System.Windows.Forms.Timer();
            this.Timer.Interval = 100;
            this.Timer.Tick += Timer_Tick;
            this.Timer.Start();
            InitializeComponent();
            this.AlarmPlayer.SoundLocation = MechanicalBellSoundLocation(); // find out the location of the .exe to get the file path.
            Activated += TimerForm_Activated;

            this.LogTextBox.KeyDown += TextBox_KeyDown_CommonKeyCommands;

            this.IsPaused = true;
            this.TimerInitialValue = new TimeSpan();
            DisplayTime(new TimeSpan());

            this.PausePlayButton.Click += Pause_Play_Click;
            this.ClearButton.Click += ClearButton_Click;
            this.AddOneButton.Click += AddOneButton_Click;
            this.AddFiveButton.Click += AddFiveButton_Click;
            this.AddFifteenButton.Click += AddFifteenButton_Click;
            this.AddThirtyButton.Click += AddThirtyButton_Click;
        }

        private static DateTime Now() => DateTime.UtcNow;

        private void AddTime(int minutes)
        {
            this.StopAlarm();

            if (minutes == 1 && Debugger.IsAttached)
            {
                this.TimerInitialValue += new TimeSpan(0, 0, 0, 5, 0);
            }
            else
            {
                this.TimerInitialValue += new TimeSpan(0, 0, minutes, 0, 0);
            }
        }

        public static void TextBox_KeyDown_CommonKeyCommands(object sender, KeyEventArgs e)
        {
            var textbox = (sender as TextBox);
            if (textbox == null)
            {
                return;
            }
            // Add support for CTRL+A  
            if (e.Control && e.KeyCode == Keys.A)
            {
                textbox.SelectAll();
            }
            // Add support for CTRL+Backspace  
            if (e.Control && e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = true;
                if (textbox.SelectionStart > 0)
                {
                    /*  
                     * Piggyback off of the supported "CTRL + Left Cursor" feature.  
                     * Does not need to send {CTRL}, because the user is currently holding {CTRL}.  
                     * Uses {DEL} rather than {BKSP} in order to avoid creating an infinite loop.  
                     * NOTE: {DEL} has the side effect of deleting text to the right if the cursor is  
                     *       already as far left as it can go, since no text will be selected by {LEFT}.  
                     *       The .SelectionStart > 0 condition prevents this side effect.  
                     */
                    SendKeys.Send("+{LEFT}{DEL}");
                }
            }
        }

        private void LogMessage(string message)
        {
            var logLine = $"{DateTime.Now.ToString("HH:mm ss")}|{message}";
            
            if (this.LogTextBox.Text == "")
            {
                this.LogTextBox.Text = logLine;
            }
            else
            {
                var existingLines = this.LogTextBox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                if (existingLines.Last() == string.Empty)
                {
                    var newValue = string.Join(Environment.NewLine, existingLines.Take(existingLines.Length - 1).Concat(new[] { logLine }));
                    this.LogTextBox.Text = newValue;
                }
                else
                {
                    var newValue = string.Join(Environment.NewLine, existingLines.Concat(new[] { logLine }));
                    this.LogTextBox.Text = newValue;
                }
            }
        }

        private void Pause(bool logMessage = true)
        {
            this.StopAlarm();
            if (!this.IsPaused)
            {
                this.IsPaused = true;
                var elapsed = Now() - TimerStartDate;

                // this should be in a method?
                this.TimerInitialValue -= elapsed;
                if (this.TimerInitialValue < new TimeSpan())
                {
                    this.TimerInitialValue = new TimeSpan();
                }

                if (logMessage)
                {
                    LogMessage($"Paused with time left {GetTimeString(this.TimerInitialValue)}");
                }
            }
        }

        

        private void Play()
        {
            this.StopAlarm();
            if (this.IsPaused && this.TimerInitialValue > new TimeSpan())
            {
                LogMessage($"Play with time left {GetTimeString(this.TimerInitialValue)}");
                this.IsPaused = false;
                this.TimerStartDate = Now();
            }            
        }

        private void Clear()
        {
            this.StopAlarm();
            Pause(logMessage: false);
            LogMessage($"Cleared with time left {GetTimeString(this.TimerInitialValue)}");
            this.TimerInitialValue = new TimeSpan();
        }

        private void PausePlay()
        {
            if (IsPaused)
            {
                Play();
            }
            else
            {
                Pause();
            }
        }


        private void AddThirtyButton_Click(object sender, EventArgs e)
        {
            AddTime(30);
        }

        private void AddFifteenButton_Click(object sender, EventArgs e)
        {
            AddTime(15);
        }

        private void AddFiveButton_Click(object sender, EventArgs e)
        {
            AddTime(5);
        }

        private void AddOneButton_Click(object sender, EventArgs e)
        {
            AddTime(1);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //if (this.IsPaused && this.TimerInitialValue == new TimeSpan())
            //{
            //    PlaySound();
            //}
            Clear();
        }

        private void Pause_Play_Click(object sender, EventArgs e)
        {
            PausePlay();
        }

        private void TimerForm_Activated(object sender, EventArgs e)
        {
            var form = Form.ActiveForm;
            form.TopMost = false;

            // Set the MaximizeBox to false to remove the maximize box.
            form.MaximizeBox = false;

            // Set the MinimizeBox to false to remove the minimize box.
            form.MinimizeBox = true;

            form.KeyUp += Form_KeyUp;

            // Set the start position of the form to the center of the screen.
            form.StartPosition = FormStartPosition.CenterScreen;

            Activated -= TimerForm_Activated;
        }

        private void Form_KeyUp(object sender, KeyEventArgs e)
        {
            // this technique can be used to handle keypresses
            if (e.KeyData == (Keys.Shift | Keys.OemMinus))
            {
            }
            else if (e.KeyData == (Keys.Shift | Keys.Oemplus))
            {
            }
        }

        private string GetTimeString(TimeSpan time)
        {
            var hoursMinutes = time.ToString(@"hh\:mm");
            var seconds = time.ToString(@"\:ss");
            return hoursMinutes + " " + seconds;
        }

        private void DisplayTime(TimeSpan time)
        {
            this.TimeLabel.Text = time.ToString(@"hh\:mm");
            this.SecondsLabel.Text = time.ToString(@"\:ss");
            this.Text = this.TimeLabel.Text + " " + this.SecondsLabel.Text;
        }

        private void StopAlarm()
        {
            if (AlarmStarted)
            {
                this.AlarmPlayer.Stop();
                LogMessage("Alarm stopped");
                AlarmStarted = false;
            }           
        }

        private void StartAlarm()
        {
            if (!AlarmStarted)
            {
                this.AlarmPlayer.PlayLooping();
                LogMessage("Alarm started");
                AlarmStarted = true;
            }            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!this.IsPaused)
            {
                var elapsed = Now() - TimerStartDate;
                var remainingTime = TimerInitialValue - elapsed;
                if (remainingTime < new TimeSpan())
                {
                    Clear();
                    StartAlarm();
                    DisplayTime(new TimeSpan());
                }
                else
                {
                    DisplayTime(remainingTime);
                }
            }

            if (this.IsPaused)
            {
                DisplayTime(this.TimerInitialValue);
            }
        }
    }
}
