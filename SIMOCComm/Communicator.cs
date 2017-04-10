using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using SIMOCModel;

namespace SIMOCComm
{
    public class Communicator
    {
        public const int ServerPort = 5049;
        public const int MessageSize = 24;
        public const char MessageStart = '$';
        public const char MessageEnd = ';';

        public Communicator(int numberOfSensors)
        {
            NumberOfSensors = numberOfSensors;
            Points = new Point[NumberOfSensors];
            for (int i = 0; i < Points.Length; i++)
            {
                Points[i] = new Point();
            }

            Connected = false;
            NumberOfReads = 0;
            Errors = new List<Error>();

            Listener = new AsynchronousSocketListener(ServerPort, MessageSize, MessageStart, MessageEnd);

            Listener.OnConnect += Listener_OnConnect;
            Listener.OnDisconnect += Listener_OnDisconnect;
            Listener.OnRead += Listener_OnRead;
            Listener.OnError += Listener_OnError;
        }

        private void Listener_OnError(object sender, SIMOCModel.Events.ErrorEventArgs e)
        {
            Errors.Add(new Error(e.ErrorType, e.Exception.Message, DateTime.Now));
        }

        #region Properties

        public int NumberOfSensors { get; set; }

        public Point[] Points { get; private set; }

        public AsynchronousSocketListener Listener { get; private set; }

        public bool Connected { get; set; }

        public long NumberOfReads { get; set; }

        public List<Error> Errors { get; set; }

        #endregion

        #region Events

        public event EventHandler OnSensorRead;
        public event EventHandler OnConnect;
        public event EventHandler OnDisconnect;

        private void Listener_OnRead(object sender, SIMOCModel.Events.ReadEventArgs e)
        {
            NumberOfReads++;

            switch ((char)e.Content[1])
            {
                case 'A':
                    // Bateria
                    break;
                case 'B':
                    // Sensors
                    ReadSensors(e.Content);
                    OnSensorRead?.Invoke(this, null);
                    break;
                case 'C':
                    // Estimulação
                    break;
                case 'Z':
                    // Zera canais
                    break;
                default:
                    // Ocorreu um problema
                    break;
            }
        }

        private void ReadSensors(byte[] content)
        {
            int pointPosition = 0;
            for (int i = 2; i < content.Length - 2; i += 4)
            {
                Points[pointPosition].X = (content[i] << 8) + content[i + 1];
                Points[pointPosition].Y = (content[i + 2] << 8) + content[i + 3];
                pointPosition++;
            }
        }

        private void Listener_OnDisconnect(object sender, EventArgs e)
        {
            Connected = false;
            OnDisconnect?.Invoke(this, null);
        }

        private void Listener_OnConnect(object sender, EventArgs e)
        {
            Connected = true;
            OnConnect?.Invoke(this, null);
        }

        #endregion

        #region Operations

        public void Start()
        {
            Listener.StartListening();
        }

        public void Stop()
        {
            Listener.StopListening();
        }

        #endregion
    }
}
