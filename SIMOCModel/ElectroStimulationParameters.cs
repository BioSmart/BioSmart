using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMOCModel
{
    public class ElectroStimulationParameters
    {
        private Point desiredAngle;

        public Point DesiredAngle
        {
            get { return desiredAngle; }
            set
            {
                desiredAngle = value;
                OnCalibrationChange?.Invoke(this, null);
            }
        }

        #region Pulse Width

        private int pulseWidth;

        public int PulseWidth
        {
            get { return pulseWidth; }
            set
            {
                if (value < 50)
                    value = 50;
                else if (value > 600)
                    value = 600;
                else if (value % 50 != 0)
                    value = value - (value % 50);

                pulseWidth = value;
            }
        }

        #endregion

        #region Time Between Pulses

        private int timeBetweenPulses;

        public int TimeBetweenPulses
        {
            get { return timeBetweenPulses; }
            set
            {
                if (value < 50)
                    value = 50;
                else if (value > 10000)
                    value = 10000;
                else if (value % 50 != 0)
                    value = value - (value % 50);

                timeBetweenPulses = value;
            }
        }

        #endregion

        #region Amplitude

        private int amplitude;

        public int Amplitude
        {
            get { return amplitude; }
            set
            {
                if (value < 0)
                    value = 0;
                else if (value > 100)
                    value = 100;
                else if (value % 1 != 0)
                    value = value - (value % 1);

                amplitude = value;
                OnStimulationChange?.Invoke(this, null);
            }
        }

        #endregion

        #region Stimulation Frequency

        private int stimulationFrequency;

        public int StimulationFrequency
        {
            get { return stimulationFrequency; }
            set
            {
                if (value < 5)
                    value = 5;
                else if (value > 150)
                    value = 150;
                else if (value % 5 != 0)
                    value = value - (value % 5);

                stimulationFrequency = value;
            }
        }

        #endregion

        #region Events

        public event EventHandler OnStimulationChange;
        public event EventHandler OnCalibrationChange;

        #endregion

        public byte[] ToByteArray()
        {
            byte[] stimulationChannel1 = new byte[] { (byte)(this.PulseWidth / 50), (byte)(this.TimeBetweenPulses / 50), (byte)this.Amplitude, (byte)(this.StimulationFrequency / 5) };
            byte[] stimulationChannel2 = new byte[] { (byte)(this.PulseWidth / 50), (byte)(this.TimeBetweenPulses / 50), (byte)this.Amplitude, (byte)(this.StimulationFrequency / 5) };
            byte[] stimulationChannel3 = new byte[] { (byte)(this.PulseWidth / 50), (byte)(this.TimeBetweenPulses / 50), (byte)this.Amplitude, (byte)(this.StimulationFrequency / 5) };
            byte[] stimulationChannel4 = new byte[] { (byte)(this.PulseWidth / 50), (byte)(this.TimeBetweenPulses / 50), (byte)this.Amplitude, (byte)(this.StimulationFrequency / 5) };
            byte[] stimulationChannel5 = new byte[] { (byte)(this.PulseWidth / 50), (byte)(this.TimeBetweenPulses / 50), (byte)this.Amplitude, (byte)(this.StimulationFrequency / 5) };
            byte[] stimulationChannel6 = new byte[] { (byte)(this.PulseWidth / 50), (byte)(this.TimeBetweenPulses / 50), (byte)this.Amplitude, (byte)(this.StimulationFrequency / 5) };
            byte[] stimulationChannel7 = new byte[] { (byte)(this.PulseWidth / 50), (byte)(this.TimeBetweenPulses / 50), (byte)this.Amplitude, (byte)(this.StimulationFrequency / 5) };
            byte[] stimulationChannel8 = new byte[] { (byte)(this.PulseWidth / 50), (byte)(this.TimeBetweenPulses / 50), (byte)this.Amplitude, (byte)(this.StimulationFrequency / 5) };
            byte[] stimulationChannels =
                stimulationChannel1
                .Concat(stimulationChannel2)
                .Concat(stimulationChannel3)
                .Concat(stimulationChannel4)
                .Concat(stimulationChannel5)
                .Concat(stimulationChannel6)
                .Concat(stimulationChannel7)
                .Concat(stimulationChannel8)
                .ToArray();

            byte[] start = new byte[] { (byte)'$', (byte)'C' } ;

            byte[] result = start.Concat(stimulationChannels).ToArray();

            byte[] end = new byte[] { GetChecksum(result), (byte)';' };

            return result.Concat(end).ToArray();
        }

        private static byte GetChecksum(byte[] content)
        {
            byte sum = 0;

            for (int i = 0; i < content.Length; i++)
            {
                sum += content[i];
            }

            return sum;
        }

    }
}
