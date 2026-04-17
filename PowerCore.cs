using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Power
{
    internal class PowerCore
    {
        // Shutdown
        public static void ShutDown()
        {
            Process.Start("shutdown", "/s /t 0");
        }

        // Reboot
        public static void Reboot()
        {
            Process.Start("shutdown", "/r /t 0");
        }

        // Sleep
        public static void Sleep()
        {
            Application.SetSuspendState(PowerState.Suspend, force: true, disableWakeEvent: true);
        }

     
    }
}
