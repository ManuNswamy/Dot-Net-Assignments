using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MyPracticeService
{
    public partial class MyPracticeService : ServiceBase
    {
        public MyPracticeService()
        {
            InitializeComponent();
            if (System.Diagnostics.EventLog.SourceExists("MyPracticeSource"))
                System.Diagnostics.EventLog.CreateEventSource("MyPracticeSource", "MyPracticeServiceLog");

            eventLog1.Source = "MyPracticeSource";
            eventLog1.Log = "MyPracticeServiceLog";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("My Service Starts");

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 60000;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(this.OnTimer);
            timer.Start();
        }

        private void OnTimer(object sender, ElapsedEventArgs e)
        {
            eventLog1.WriteEntry("Timer Timer");
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("My Service Stops");
        }
    }
}
