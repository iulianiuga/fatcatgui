using System;
using System.Diagnostics;
//using System.Timers;
using System.Windows.Forms;

namespace fatcatgui.controls.status
{
    public partial class StatusUc : UserControl
    {

      //  private int _theRefreshRate = 500;
      //  private System.Timers.Timer aTimer;

        public StatusUc()
        {
            InitializeComponent();
            // SetTimer();
            timer20000.Interval = 100;


            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            progressUcAppInfo.Valuemax = 100;
            progressUcAppInfo.Valuecur = -1;
            progressUcAppInfo.Prefixtext = "Fatcat v: " + version;


            //// os


            var outputo = "";

            var infoo = new ProcessStartInfo("os");
            infoo.FileName = "/bin/bash";
            infoo.Arguments = "-c \"hostnamectl\"";
            infoo.RedirectStandardOutput = true;
            infoo.UseShellExecute = false;

            using (var processo = Process.Start(infoo))
            {
                outputo = processo.StandardOutput.ReadToEnd();
            }

            var lineso = outputo.Split(new[] { "\n" }, StringSplitOptions.None);
            var os = lineso[4].Split(new[] { ":" }, StringSplitOptions.RemoveEmptyEntries)[1] + " " + lineso[5].Split(new[] { ":" }, StringSplitOptions.RemoveEmptyEntries)[1] + " " + lineso[6].Split(new[] { ":" }, StringSplitOptions.RemoveEmptyEntries)[1];


            progressUcOSinfo.Valuemax = 100; //double.Parse(memory[1]);
            progressUcOSinfo.Valuecur = -1;
            progressUcOSinfo.Prefixtext = os;


            imageUCLogo.bitmap = new System.Drawing.Bitmap(Application.StartupPath + "/logo.png");

            

        }

        //private void SetTimer()
        //{
        //    // Create a timer with a two second interval.
        //    aTimer = new System.Timers.Timer(_theRefreshRate);
        //    // Hook up the Elapsed event for the timer. 
        //    aTimer.Elapsed += OnTimedEvent;
        //    aTimer.AutoReset = true;
        //    aTimer.Enabled = true;
        //}
        //private void OnTimedEvent(Object source, ElapsedEventArgs e)

        //{


















        //}

        private void timer100_Tick(object sender, EventArgs e)
        {

            //uptime

            progressUcUptime.Valuemax = 1;
            progressUcUptime.Valuecur = -1;


            TimeSpan TimeDiff = DateTime.Now.Subtract(basestyles.datestart);
            progressUcUptime.Prefixtext = string.Format("Uptime {0}d:{1}h:{2}m:{3}s",
              TimeDiff.Days,
              TimeDiff.Hours,
              TimeDiff.Minutes,
              TimeDiff.Seconds);

        }

        private void timer20000_Tick(object sender, EventArgs e)
        {


            timer20000.Interval = 20000;
            //memory
            var output = "";

            var info = new ProcessStartInfo("free -m");
            info.FileName = "/bin/bash";
            info.Arguments = "-c \"free -m\"";
            info.RedirectStandardOutput = true;
            info.UseShellExecute = false;

            using (var process = Process.Start(info))
            {
                output = process.StandardOutput.ReadToEnd();
            }

            var lines = output.Split(new[] { "\n" }, StringSplitOptions.None);
            var memory = lines[1].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);



            progressUcMem.Valuemax = double.Parse(memory[1]);
            progressUcMem.Valuecur = double.Parse(memory[2]);
            progressUcMem.Prefixtext = "System memory used: ";


            //load

            var outputl = "";

            var infol = new ProcessStartInfo("mpstat");
            infol.FileName = "/bin/bash";
            // infol.Arguments = "-c \"mpstat 1 1\"";
            infol.Arguments = "-c \"uptime\"";
            infol.RedirectStandardOutput = true;
            infol.UseShellExecute = false;

            using (var processl = Process.Start(infol))
            {
                outputl = processl.StandardOutput.ReadToEnd();
                //    Console.WriteLine(outputl);
            }

            var linesl = outputl.Split(new[] { "\n" }, StringSplitOptions.None);
            var load = linesl[0].Split(new[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);

            //  Console.WriteLine("ss" + linesl[0]);
            // Console.WriteLine(load[8]);
            progressUcLoad.Valuemax = 4.0; //double.Parse(memory[1]);
            progressUcLoad.Valuecur = double.Parse(load[8]);
            progressUcLoad.Prefixtext = "System load: ";


            //drive

            var outputd = "";

            var infod = new ProcessStartInfo("dribe");
            infod.FileName = "/bin/bash";
            infod.Arguments = "-c \"df /dev/sda1\"";
            infod.RedirectStandardOutput = true;
            infod.UseShellExecute = false;

            using (var processd = Process.Start(infod))
            {
                outputd = processd.StandardOutput.ReadToEnd();
            }

            var linesd = outputd.Split(new[] { "\n" }, StringSplitOptions.None);
            var drive = linesd[1].Split(new[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);


            progressUcDrive.Valuemax = double.Parse(drive[1]); //double.Parse(memory[1]);
            progressUcDrive.Valuecur = double.Parse(drive[2]);
            progressUcDrive.Prefixtext = "System space used: ";

            //own mem

            var outputom = "";

            var infoom = new ProcessStartInfo("ownmem");
            infoom.FileName = "/bin/bash";
            infoom.Arguments = "-c \"pmap $(pgrep -f fatcatgui.exe) | tail -n 1\"";
            infoom.RedirectStandardOutput = true;
            infoom.UseShellExecute = false;

            using (var processom = Process.Start(infoom))
            {
                outputom = processom.StandardOutput.ReadToEnd();
                // Console.WriteLine(outputom);
            }

            var linesom = outputom.Split(new[] { "\n" }, StringSplitOptions.None);
            var ownmem = linesom[0].Split(new[] { " ", "K" }, StringSplitOptions.RemoveEmptyEntries);

            // Console.WriteLine(ownmem[1]);
            progressUcOwnMem.Valuemax = 1024 * 8; //double.Parse(drive[1]); //double.Parse(memory[1]);
            progressUcOwnMem.Valuecur = double.Parse(ownmem[1]) / 1024;
            progressUcOwnMem.Prefixtext = "Fatcat mem use: [" + ownmem[1].ToString() + "K]: ";
            //  Console.WriteLine(progressUcOwnMem.Valuemax + "/" +  progressUcOwnMem.Valuecur);

        }
    }
}
