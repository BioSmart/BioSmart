//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using SIMOCModel;
//using SimocNeo;

//namespace SIMOCComm
//{
//    public class SIMOCold
//    {
//        public const int PortaServidor = 5049;
//        public const int QuantidadeSensores = 5;

//        public SIMOCold()
//        {
//            XSIMOC = new XSIMOC();
//            Sensores = new Sensor[QuantidadeSensores];
//            Conectado = false;
//            LogErro = new List<Erro>();

//            XSIMOC.Port = PortaServidor;
//            XSIMOC.OnConect += XSIMOC_OnConect;
//            XSIMOC.OnDisconect += XSIMOC_OnDisconect;
//            XSIMOC.OnGetSensor += XSIMOC_OnGetSensor;
//            XSIMOC.OnError += XSIMOC_OnError;
//            XSIMOC.OnRead += XSIMOC_OnRead;
//        }

//        #region Propriedades

//        public XSIMOC XSIMOC { get; set; }

//        public Sensor[] Sensores { get; set; }

//        public bool Conectado { get; set; }

//        public List<Erro> LogErro { get; set; }

//        public long LeiturasRealizadas { get; set; }

//        #endregion

//        #region Eventos

//        public event EventHandler OnConnect;
//        public event EventHandler OnDisconnect;

//        #endregion

//        public void Conectar()
//        {
//            XSIMOC.Active = true;

//            LeiturasRealizadas = 0;

//            for (int i = 0; i < Sensores.Length; i++)
//            {
//                Sensores[i] = new Sensor();
//            }
//        }

//        public void Desconectar()
//        {
//            XSIMOC.Active = false;
//            Conectado = false;

//            OnDisconnect?.Invoke(this, null);
//        }

//        List<string> pacotes = new List<string>();
//        private void XSIMOC_OnRead(string Buffer)
//        {
//            pacotes.Add(Buffer);
//        }

//        private void XSIMOC_OnError(string Data, int ErrorCode)
//        {
//            LogErro.Add(new Erro(ErrorCode, Data, DateTime.Now));
//        }

//        private void XSIMOC_OnGetSensor()
//        {
//            LeiturasRealizadas++;

//            for (byte i = 1; i <= QuantidadeSensores; i++)
//            {
//                Sensores[i - 1].X = XSIMOC.GetSensorAnguloX(i);
//                Sensores[i - 1].Y = XSIMOC.GetSensorAnguloY(i);
//            }
//        }

//        private void XSIMOC_OnConect(string Data)
//        {
//            Conectado = true;

//            OnConnect?.Invoke(this, null);
//        }

//        private void XSIMOC_OnDisconect(string Data)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
