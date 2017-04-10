using System;

namespace SIMOCModel
{
    public class Sensor
    {
        public const int ValorMinimo = 200;
        public const int ValorMaximo = 1800;
        public const int Faixa = ValorMaximo - ValorMinimo;

        public double? XInicial { get; set; }

        public double? YInicial { get; set; }

        public double? AnguloXInicial
        {
            get
            {
                if (XInicial.HasValue)
                {
                    return 180 * ((XInicial.Value - ValorMinimo) / (Faixa));
                }

                return null;
            }
        }

        public double? AnguloYInicial
        {
            get
            {
                if (YInicial.HasValue)
                {
                    return 180 * ((YInicial.Value - ValorMinimo) / (Faixa));
                }

                return null;
            }
        }

        private double x;
        public double X
        {
            get { return x; }
            set
            {
                x = value;
                if (!XInicial.HasValue)
                {
                    XInicial = value;
                }
            }
        }

        private double y;
        public double Y
        {
            get { return y; }
            set
            {
                y = value;
                if (!YInicial.HasValue)
                {
                    YInicial = value;
                }
            }
        }

        public double AnguloX
        {
            get
            {
                var anguloX = 180 * ((X - ValorMinimo) / (Faixa));

                if (AnguloXInicial.HasValue)
                {
                    anguloX = anguloX - AnguloXInicial.Value;
                }

                anguloX = Math.Abs(anguloX);

                return anguloX;
            }
        }

        public double AnguloY
        {
            get
            {
                var anguloY = 180 * ((Y - ValorMinimo) / (Faixa));

                if (AnguloYInicial.HasValue)
                {
                    anguloY = anguloY - AnguloYInicial.Value;
                }

                anguloY = Math.Abs(anguloY);

                return anguloY;
            }
        }
    }
}