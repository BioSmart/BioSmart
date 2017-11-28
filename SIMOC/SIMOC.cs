using System;
using SIMOCComm;
using SIMOCFuzzy;
using SIMOCModel;

namespace SIMOCDevice
{
    public class SIMOC
    {
        public const int QuantidadeSensores = 5;

        public SIMOC()
        {
            Sensores = new Sensor[QuantidadeSensores];
            Conectado = false;

            Comm = new Communicator(QuantidadeSensores);
            Comm.OnConnect += Comm_OnConnect;
            Comm.OnDisconnect += Comm_OnDisconnect;
            Comm.OnSensorRead += Comm_OnSensorRead;

            Stimulation = new ElectroStimulationParameters();
            Stimulation.OnStimulationChange += Stimulation_OnAmplitudeChanged;
        }

        #region Propriedades

        public Communicator Comm { get; set; }

        public Sensor[] Sensores { get; set; }

        public bool Conectado { get; set; }

        public ElectroStimulationParameters Stimulation { get; set; }

        public FuzzyControl Fuzzy { get; set; }

        #endregion

        #region Eventos

        public event EventHandler OnConnect;
        public event EventHandler OnDisconnect;
        public event EventHandler OnSensorRead;
        public event EventHandler OnStimulationChange;

        private void Comm_OnDisconnect(object sender, EventArgs e)
        {
            Conectado = false;

            OnDisconnect?.Invoke(this, null);
        }

        private void Comm_OnConnect(object sender, EventArgs e)
        {
            Conectado = true;

            OnConnect?.Invoke(this, null);
        }

        private void Comm_OnSensorRead(object sender, EventArgs e)
        {
            for (byte i = 0; i < QuantidadeSensores; i++)
            {
                Sensores[i].X = Comm.Points[i].X;
                Sensores[i].Y = Comm.Points[i].Y;
            }

            OnSensorRead?.Invoke(this, null);
        }

        private void Stimulation_OnAmplitudeChanged(object sender, EventArgs e)
        {
            this.Comm.SendInfo(this.Stimulation.ToByteArray());
            
            OnStimulationChange?.Invoke(this, null);
        }

        #endregion

        public void Conectar()
        {
            for (int i = 0; i < Sensores.Length; i++)
            {
                Sensores[i] = new Sensor();
            }

            Fuzzy = new FuzzyControl(Sensores[0], Stimulation);

            Comm.Start();
        }

        public void Desconectar()
        {
            Comm.Stop();
            Fuzzy.Stop();
        }
    }
}
