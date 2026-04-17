using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Power
{
    public partial class frmTimer : Form
    {
        public frmTimer()
        {
            InitializeComponent();
        }

       public struct stTime
        {
            public int Hour;
            public int Min;
            public int Sec;
        }

        public stTime TheTimeOfTimer; // the time assigned by user 

        public void UpdateTimeLabel(Label NameOfLabel, int value)
        {
            NameOfLabel.Text = value.ToString();
            NameOfLabel.Tag = value; 
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (TheTimeOfTimer.Sec == 0 && TheTimeOfTimer.Min == 0 && TheTimeOfTimer.Hour == 0)
            //{
            //    timer1.Enabled = false;
             
            //    UpDownHour.Enabled = true;
            //    UpDownMin.Enabled = true;
            //    UpDownSec.Enabled = true;
            //    RestUpDown();
            //    labTSec.Text = "0";
            //    labTMin.Text = "0";
            //    labTHour.Text = "0";

            //    MessageBox.Show("Your Timer Has Finished ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            //    return;
            //}



            //if (TheTimeOfTimer.Min == 0 && TheTimeOfTimer.Hour != 0 && TheTimeOfTimer.Sec == 0)
            //{
            //    TheTimeOfTimer.Min = 59;
            //    TheTimeOfTimer.Sec = 59;
            //    TheTimeOfTimer.Hour--;

            //    UpdateTimeLabel(labTHour, TheTimeOfTimer.Hour);
            //    UpdateTimeLabel(labTMin, TheTimeOfTimer.Min);
            //    UpdateTimeLabel(labTSec, TheTimeOfTimer.Sec);

            //    return;
            //}


            //if (TheTimeOfTimer.Sec != 0)
            //{
            //    TheTimeOfTimer.Sec--; // decrement the seconds 
            //    UpdateTimeLabel(labTSec, TheTimeOfTimer.Sec); // update the label

            //}
            //else  // 60 Sec Has Passed 
            //{

            //    if (TheTimeOfTimer.Min != 0) TheTimeOfTimer.Min--;

            //    TheTimeOfTimer.Sec = 59;

            //    UpdateTimeLabel(labTSec, TheTimeOfTimer.Sec); // update the label --> 59 
            //    UpdateTimeLabel(labTMin, TheTimeOfTimer.Min); // update the label 
            //}

            //// 1 Min = 60000 Ms = 60 Sec



        }



        public void RestUpDown()
        {
            UpDownHour.Value = 0;
            UpDownMin.Value = 0;
            UpDownSec.Value = 0;
        }

        private void SetTimer(string UpDownCounter, int value)
        {
            switch (UpDownCounter)
            {
                case "Hour":
                    UpdateTimeLabel(labTHour, value); // update the label
                    TheTimeOfTimer.Hour = value;
                    break;


                case "Min":
                    UpdateTimeLabel(labTMin, value); // update the label
                    TheTimeOfTimer.Min = value;
                    break;

                case "Sec":
                    UpdateTimeLabel(labTSec, value); // update the label
                    TheTimeOfTimer.Sec = value;
                    break;


            }
        }

        private void UpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown ud = sender as NumericUpDown;
            SetTimer(ud.Tag.ToString(), Convert.ToInt32(ud.Value));
        }

        // the start of Timer 
        public void Start()
        {
            if (TheTimeOfTimer.Sec == 0 && TheTimeOfTimer.Min == 0 && TheTimeOfTimer.Hour == 0)
            {
                //MessageBox.Show("Timer Cannot Start", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpDownHour.Enabled = true;
                UpDownMin.Enabled = true;
                UpDownSec.Enabled = true;

            }
            else
            {
               // timer1.Enabled = true;
               // UpDownHour.Enabled = false;
                //UpDownMin.Enabled = false;
                //UpDownSec.Enabled = false;
          
                //btnStop.Enabled = true;

            }

        }
        public void TimerStop()
        {
            timer1.Enabled = false;

            
        }

        public void RestTimer()
        {
            
            RestUpDown();
            TheTimeOfTimer.Hour = 0;
            TheTimeOfTimer.Min = 0;
            TheTimeOfTimer.Sec = 0;
            //btnStop.Enabled = false;
         
            UpdateTimeLabel(labTHour, 0); // update the label
            UpdateTimeLabel(labTMin, 0); // update the label
            UpdateTimeLabel(labTSec, 0); // update the label

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Start(); // start the timer 
            this.Hide();
        }

        public bool ChangePowerState = true; // to avoid change power state when the user press rest button and the timer is running
        
        
        private void btnRest_Click(object sender, EventArgs e)
        {
            ChangePowerState = false; // if rest is clicked don't change power state 

            RestTimer();

        }


    }
}
