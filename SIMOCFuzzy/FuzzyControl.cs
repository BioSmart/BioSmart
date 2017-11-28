using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SIMOCModel;

namespace SIMOCFuzzy
{
    public class FuzzyControl
    {
        const int ThreadSleepTime = 500;

        public FuzzyControl(Sensor sensor, ElectroStimulationParameters stimulation)
        {
            Sensor = sensor;
            Stimulation = stimulation;
            Stimulation.OnCalibrationChange += Stimulation_OnCalibrationChange;
        }

        private bool ThreadRunning { get; set; }

        public void Stop()
        {
            ThreadRunning = false;
        }

        private void Stimulation_OnCalibrationChange(object sender, EventArgs e)
        {
            if (StimulationThread != null)
            {
                ThreadRunning = false;
                Thread.Sleep(1000);
            }

            if (Stimulation.DesiredAngle != null
                && Stimulation.DesiredAngle.X > 0
                && Stimulation.DesiredAngle.Y > 0)
            {
                ThreadRunning = true;
                StimulationThread = new Thread(ControlStimulation);
                StimulationThread.Start();
            }
        }

        public ElectroStimulationParameters Stimulation { get; set; }
        public Sensor Sensor { get; set; }
        public Thread StimulationThread { get; set; }

        public void ControlStimulation()
        {
            while (ThreadRunning)
            {
                if (Sensor.AnguloY < Stimulation.DesiredAngle.Y)
                {
                    while (ThreadRunning
                        && Sensor.AnguloY < Stimulation.DesiredAngle.Y)
                    {
                        Stimulation.Amplitude++;
                        Thread.Sleep(ThreadSleepTime);
                    }
                }
                else if (Sensor.AnguloY > Stimulation.DesiredAngle.Y)
                {
                    while (ThreadRunning
                        && Sensor.AnguloY > Stimulation.DesiredAngle.Y)
                    {
                        Stimulation.Amplitude--;
                        Thread.Sleep(ThreadSleepTime);
                    }
                }
            }
        }
    }
}
