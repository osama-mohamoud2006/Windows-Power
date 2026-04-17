using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Windows_Power.frmTimer;

namespace Windows_Power
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

           
        }

        frmTimer Timer = new frmTimer(); // Timer Form 
         PowerCore core ; // Power Core Class To Handle Power State Change


        private void pbInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Program Is Made To Manage Your Computer Power State\n" +
                " By Set Timer With Specific Time To Change its State According To Your Choice!", "Info");
        }


        public enum enPowerState :byte{ ShutDown=1,Reboot=2 , Sleep=3 }

        enPowerState PowerState;
       
        private void SetPowerState(string SelectedOption)
        {
           
           switch(SelectedOption.ToLower())
            {
                case "shutdown":
                    PowerState = enPowerState.ShutDown;
                    break;

                case "reboot":
                    PowerState = enPowerState.Reboot;
                    break;

                case "sleep":
                    PowerState = enPowerState.Sleep;
                    break;
            }

        }

        private void EnableScreenComp()
        {
            labMin.Enabled = true;
            labSec.Enabled = true;
            labHour.Enabled = true;
            btnSetTimer.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;

            SetPowerState(cb.SelectedItem.ToString());

            EnableScreenComp(); // To Enable set timer Control 
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            comboBox1.BackColor = Color.Wheat;
        }

        private void CallTimerFormButton_Click(object sender, EventArgs e) // call set timer form to set the timer and start it
        {
            
            Timer.ShowDialog();

            //btnStop.Visible = true;
            btnStop.Visible=true; /// --->>>>>>>>>>
            btnSetTimer.Enabled = false;
            timer1.Enabled = true;

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Timer.TimerStop(); // disable the timer of timer form (useless as i have moved the logic of timer here)
            btnStop.Visible = false;
            btnSetTimer.Enabled = true;

            
        }

        // This Function To Show Notification Before 30 Sec Of Power State Change To Notify User And Give Him The Chance To Stop The Timer If He Wants To
        void NotifIcon()
        {
            notifyBeforeChange.Icon = SystemIcons.Warning;  
            notifyBeforeChange.BalloonTipTitle = $"Your Device Will {PowerState.ToString()} Soon !";
            notifyBeforeChange.BalloonTipText= $"Click On This Notification To Stop The Timer If You Want To !";
            notifyBeforeChange.BalloonTipIcon= ToolTipIcon.Warning;

            notifyBeforeChange.ShowBalloonTip (30000); // Show Notification Before 30 Sec Of Power State Change
        }


        // According to user selection in combo box this function will call the specific method in PowerCore Class To Do The Operation
        private void DoPowerChange()
        {
            switch (PowerState)
            {
                case enPowerState.ShutDown:
                    PowerCore.ShutDown();
                    break;
                case enPowerState.Reboot:
                    PowerCore.Reboot();
                    break;
                case enPowerState.Sleep:
                    PowerCore.Sleep();
                    break;
            }
        }


        // Sorry for dirty code but in my level this is the best I can do :D (this timer handles the timer in both 2 forms)
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Notify User Before 30 sec 
            if (Timer.TheTimeOfTimer.Sec == 30 && Timer.TheTimeOfTimer.Hour==0 && Timer.TheTimeOfTimer.Min==0)
            {
                NotifIcon();
            }

            // the timer has finished and we need to do the power change operation and reset the timer form and labels in main form
            if (Timer.TheTimeOfTimer.Sec == 0 &&  Timer.TheTimeOfTimer.Min == 0 && Timer.TheTimeOfTimer.Hour == 0)
            {
                timer1.Enabled = false;

                Timer.UpDownHour.Enabled = true;
                Timer.UpDownMin.Enabled = true;
                Timer.UpDownSec.Enabled = true;

                Timer.RestUpDown();

                Timer.labTSec.Text = "0";
                Timer.labTMin.Text = "0";
                Timer.labTHour.Text = "0";

                this.labHour.Text = "0";    
                this.labMin.Text = "0";
                this.labSec.Text = "0";

                btnStop.Visible = false; // --->>>>>>> 
                btnSetTimer.Enabled = true;

                // if the user press rest button and the timer is running we don't want to change the power state
                if (Timer.ChangePowerState) DoPowerChange(); // change the power state(false) doesn't change the power state because the user press rest button of timer 

                Timer.ChangePowerState=true; // reset the rest button click state for the next time
                return;
            }



            if (Timer.TheTimeOfTimer.Min == 0 && Timer.TheTimeOfTimer.Hour != 0 && Timer.TheTimeOfTimer.Sec == 0)
            {
                Timer.TheTimeOfTimer.Min = 59;
                Timer.TheTimeOfTimer.Sec = 59;

               

                Timer.TheTimeOfTimer.Hour--;

                Timer.UpdateTimeLabel(Timer.labTHour, Timer.TheTimeOfTimer.Hour);
                Timer.UpdateTimeLabel(Timer.labTMin, Timer.TheTimeOfTimer.Min);
                Timer.UpdateTimeLabel(Timer.labTSec, Timer.TheTimeOfTimer.Sec);

                this.labSec.Text = Timer.TheTimeOfTimer.Sec.ToString();
                this.labMin.Text = Timer.TheTimeOfTimer.Min.ToString();
                this.labHour.Text = Timer.TheTimeOfTimer.Hour.ToString();


                return;
            }


            if (Timer.TheTimeOfTimer.Sec != 0)
            {
                Timer.TheTimeOfTimer.Sec--; // decrement the seconds 
                this.labSec.Text = Timer.TheTimeOfTimer.Sec.ToString();
                Timer.UpdateTimeLabel(Timer.labTSec, Timer.TheTimeOfTimer.Sec); // update the label

            }
            else  // 60 Sec Has Passed 
            {

                if (Timer.TheTimeOfTimer.Min != 0) Timer.TheTimeOfTimer.Min--;

                Timer.TheTimeOfTimer.Sec = 59;
                this.labSec.Text = Timer.TheTimeOfTimer.Sec.ToString();
                this.labMin.Text = Timer.TheTimeOfTimer.Min.ToString();
                Timer.UpdateTimeLabel(Timer.labTSec, Timer.TheTimeOfTimer.Sec); // update the label --> 59 
                Timer.UpdateTimeLabel(Timer.labTMin, Timer.TheTimeOfTimer.Min); // update the label 
            }

            this.labHour.Text = Timer.TheTimeOfTimer.Hour.ToString();
            this.labMin.Text  = Timer.TheTimeOfTimer.Min.ToString();
            this.labSec.Text  = Timer.TheTimeOfTimer.Sec.ToString();
            // 1 Min = 60000 Ms = 60 Sec
        }

        private void notifyBeforeChange_BalloonTipClicked(object sender, EventArgs e)
        {
            btnStop_Click(sender, e); // call stop button click event to stop the timer and prevent power state change
        }

    }
}
