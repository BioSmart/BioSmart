using System;
using System.Threading;
using System.Windows.Forms;
using SIMOCDevice;

namespace SIMOCVisual
{
    public partial class MainForm : Form
    {
        public SIMOC SIMOC { get; set; }
        public Thread ThreadSensores { get; set; }

        public MainForm()
        {
            InitializeComponent();

            SIMOC = new SIMOC();
            SIMOC.OnConnect += SIMOC_OnConnect;
            SIMOC.OnDisconnect += SIMOC_OnDisconnect;
            SIMOC.OnSensorRead += SIMOC_OnSensorRead;
            SIMOC.OnStimulationChange += SIMOC_OnStimulationChange;
        }

        private void SIMOC_OnStimulationChange(object sender, EventArgs e)
        {
            AlterarProgressBarAmplitude(SIMOC.Stimulation.Amplitude);
        }

        private void SIMOC_OnSensorRead(object sender, EventArgs e)
        {
            AdicionarPontosGraficoAngulo(SIMOC.Stimulation, SIMOC.Sensores[0]);

            for (int i = 0; i < SIMOC.Sensores.Length; i++)
            {
                AlterarAnguloSensor(i,
                    SIMOC.Sensores[i].AnguloX.ToString(),
                    SIMOC.Sensores[i].AnguloY.ToString());
            }
        }

        private void SIMOC_OnDisconnect(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
            AlterarButtonCalibrar(false);
            AlterarButtonConectar(true, "Conectar");
            AlterarLabelStatus("Desconectado");
        }

        private void SIMOC_OnConnect(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
            AlterarButtonCalibrar(true);
            AlterarButtonConectar(true, "Desconectar");
            AlterarLabelStatus("Conectado");
        }

        private void button_Conectar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            button_Conectar.Enabled = false;
            button_Conectar.Text = "Aguarde...";

            if (SIMOC.Conectado)
            {
                label_Status.Text = "Desconectando...";
                SIMOC.Desconectar();
            }
            else
            {
                label_Status.Text = "Conectando...";
                SIMOC.Conectar();
            }
        }

        delegate void AlterarAnguloSensorDelegate(int sensor, string X, string Y);
        public void AlterarAnguloSensor(int sensor, string X, string Y)
        {
            if (InvokeRequired)
            {
                Invoke(new AlterarAnguloSensorDelegate(AlterarAnguloSensor), sensor, X, Y);
            }
            else
            {
                switch (sensor)
                {
                    case 0:
                        label_Sensor0X.Text = X;
                        label_Sensor0Y.Text = Y;
                        break;

                    case 1:
                        label_Sensor1X.Text = X;
                        label_Sensor1Y.Text = Y;
                        break;

                    case 2:
                        label_Sensor2X.Text = X;
                        label_Sensor2Y.Text = Y;
                        break;

                    case 3:
                        label_Sensor3X.Text = X;
                        label_Sensor3Y.Text = Y;
                        break;

                    case 4:
                        label_Sensor4X.Text = X;
                        label_Sensor4Y.Text = Y;
                        break;

                    default:
                        // Ignore
                        break;
                }
            }
        }

        delegate void AlterarButtonConectarDelegate(bool enabled, string text);
        public void AlterarButtonConectar(bool enabled, string text)
        {
            if (InvokeRequired)
            {
                Invoke(new AlterarButtonConectarDelegate(AlterarButtonConectar), enabled, text);
            }
            else
            {
                button_Conectar.Text = text;
                button_Conectar.Enabled = enabled;
            }
        }


        delegate void AlterarButtonCalibrarDelegate(bool enabled);
        public void AlterarButtonCalibrar(bool enabled)
        {
            if (InvokeRequired)
            {
                Invoke(new AlterarButtonCalibrarDelegate(AlterarButtonCalibrar), enabled);
            }
            else
            {
                button_Calibrate.Enabled = enabled;
            }
        }

        delegate void AlterarLabelStatusDelegate(string text);
        public void AlterarLabelStatus(string text)
        {
            if (InvokeRequired)
            {
                Invoke(new AlterarLabelStatusDelegate(AlterarLabelStatus), text);
            }
            else
            {
                label_Status.Text = text;
            }
        }

        delegate void AlterarProgressBarAmplitudeDelegate(int value);
        public void AlterarProgressBarAmplitude(int value)
        {
            if (InvokeRequired)
            {
                Invoke(new AlterarProgressBarAmplitudeDelegate(AlterarProgressBarAmplitude), value);
            }
            else
            {
                progressBarAmplitude.Value = value;
            }
        }

        delegate void AdicionarPontosGraficoAnguloDelegate(SIMOCModel.ElectroStimulationParameters stimulation, SIMOCModel.Sensor sensor);
        public void AdicionarPontosGraficoAngulo(SIMOCModel.ElectroStimulationParameters stimulation, SIMOCModel.Sensor sensor)
        {
            if (InvokeRequired)
            {
                Invoke(new AdicionarPontosGraficoAnguloDelegate(AdicionarPontosGraficoAngulo), stimulation, sensor);
            }
            else
            {
                if (stimulation.DesiredAngle != null)
                {
                    chart1.Series["Series_MaxAngle"].Points.AddY(stimulation.DesiredAngle.Y);
                }
                else
                {
                    chart1.Series["Series_MaxAngle"].Points.AddY(0);
                }

                chart1.Series["Series_CurrentAngle"].Points.AddY(sensor.AnguloY);
                chart1.Series["Series_MinAngle"].Points.AddY(0.1);
            }
        }

        private void button_Calibrate_Click(object sender, EventArgs e)
        {
            double x = SIMOC.Sensores[0].AnguloX;
            double y = SIMOC.Sensores[0].AnguloY;

            textBox_DesiredX.Text = x.ToString();
            textBox_DesiredY.Text = y.ToString();

            SIMOC.Stimulation.DesiredAngle = new SIMOCModel.Point(x, y);
        }
    }
}
