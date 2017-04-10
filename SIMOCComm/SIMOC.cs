using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIMOCModel;
using SimocNeo;

namespace SIMOCComm
{
    public class SIMOC
    {
        public const int QuantidadeSensores = 5;

        public SIMOC()
        {
            Comm = new Communicator(QuantidadeSensores);
            Sensores = new Sensor[QuantidadeSensores];
            Conectado = false;

            Comm.OnConnect += Comm_OnConnect;
            Comm.OnDisconnect += Comm_OnDisconnect;
            Comm.OnSensorRead += Comm_OnSensorRead;
        }

        #region Propriedades

        public Communicator Comm { get; set; }

        public Sensor[] Sensores { get; set; }

        public bool Conectado { get; set; }

        #endregion

        #region Eventos

        public event EventHandler OnConnect;
        public event EventHandler OnDisconnect;
        public event EventHandler OnSensorRead;

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

        #endregion

        public void Conectar()
        {
            for (int i = 0; i < Sensores.Length; i++)
            {
                Sensores[i] = new Sensor();
            }

            Comm.Start();
        }

        public void Desconectar()
        {
            Comm.Stop();
        }
    }
}
