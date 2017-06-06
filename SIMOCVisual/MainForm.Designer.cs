namespace SIMOCVisual
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Sensor0Y = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Sensor0X = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_Conectar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_Sensor1Y = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Sensor1X = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_Sensor2Y = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_Sensor2X = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label_Sensor3Y = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_Sensor3X = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label_Sensor4Y = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label_Sensor4X = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.progressBarAmplitude = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button_Calibrate = new System.Windows.Forms.Button();
            this.textBox_DesiredY = new System.Windows.Forms.TextBox();
            this.textBox_DesiredX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Sensor0Y);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label_Sensor0X);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sensor 1";
            // 
            // label_Sensor0Y
            // 
            this.label_Sensor0Y.AutoSize = true;
            this.label_Sensor0Y.Location = new System.Drawing.Point(82, 103);
            this.label_Sensor0Y.Name = "label_Sensor0Y";
            this.label_Sensor0Y.Size = new System.Drawing.Size(0, 25);
            this.label_Sensor0Y.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y:";
            // 
            // label_Sensor0X
            // 
            this.label_Sensor0X.AutoSize = true;
            this.label_Sensor0X.Location = new System.Drawing.Point(82, 48);
            this.label_Sensor0X.Name = "label_Sensor0X";
            this.label_Sensor0X.Size = new System.Drawing.Size(0, 25);
            this.label_Sensor0X.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label_Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 940);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(2168, 37);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label_Status
            // 
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(166, 32);
            this.label_Status.Text = "Desconectado";
            // 
            // button_Conectar
            // 
            this.button_Conectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Conectar.Location = new System.Drawing.Point(12, 192);
            this.button_Conectar.Name = "button_Conectar";
            this.button_Conectar.Size = new System.Drawing.Size(538, 93);
            this.button_Conectar.TabIndex = 2;
            this.button_Conectar.Text = "Conectar";
            this.button_Conectar.UseVisualStyleBackColor = true;
            this.button_Conectar.Click += new System.EventHandler(this.button_Conectar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_Sensor1Y);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label_Sensor1X);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(306, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 138);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sensor 2";
            this.groupBox2.Visible = false;
            // 
            // label_Sensor1Y
            // 
            this.label_Sensor1Y.AutoSize = true;
            this.label_Sensor1Y.Location = new System.Drawing.Point(82, 102);
            this.label_Sensor1Y.Name = "label_Sensor1Y";
            this.label_Sensor1Y.Size = new System.Drawing.Size(0, 25);
            this.label_Sensor1Y.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Y:";
            // 
            // label_Sensor1X
            // 
            this.label_Sensor1X.AutoSize = true;
            this.label_Sensor1X.Location = new System.Drawing.Point(82, 47);
            this.label_Sensor1X.Name = "label_Sensor1X";
            this.label_Sensor1X.Size = new System.Drawing.Size(0, 25);
            this.label_Sensor1X.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "X:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_Sensor2Y);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label_Sensor2X);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(306, 466);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 146);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sensor 3";
            this.groupBox3.Visible = false;
            // 
            // label_Sensor2Y
            // 
            this.label_Sensor2Y.AutoSize = true;
            this.label_Sensor2Y.Location = new System.Drawing.Point(82, 107);
            this.label_Sensor2Y.Name = "label_Sensor2Y";
            this.label_Sensor2Y.Size = new System.Drawing.Size(0, 25);
            this.label_Sensor2Y.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Y:";
            // 
            // label_Sensor2X
            // 
            this.label_Sensor2X.AutoSize = true;
            this.label_Sensor2X.Location = new System.Drawing.Point(82, 49);
            this.label_Sensor2X.Name = "label_Sensor2X";
            this.label_Sensor2X.Size = new System.Drawing.Size(0, 25);
            this.label_Sensor2X.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "X:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label_Sensor3Y);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label_Sensor3X);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(306, 618);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(244, 150);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sensor 4";
            this.groupBox4.Visible = false;
            // 
            // label_Sensor3Y
            // 
            this.label_Sensor3Y.AutoSize = true;
            this.label_Sensor3Y.Location = new System.Drawing.Point(82, 107);
            this.label_Sensor3Y.Name = "label_Sensor3Y";
            this.label_Sensor3Y.Size = new System.Drawing.Size(0, 25);
            this.label_Sensor3Y.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "Y:";
            // 
            // label_Sensor3X
            // 
            this.label_Sensor3X.AutoSize = true;
            this.label_Sensor3X.Location = new System.Drawing.Point(82, 49);
            this.label_Sensor3X.Name = "label_Sensor3X";
            this.label_Sensor3X.Size = new System.Drawing.Size(0, 25);
            this.label_Sensor3X.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "X:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label_Sensor4Y);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label_Sensor4X);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Location = new System.Drawing.Point(306, 774);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(244, 144);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sensor 5";
            this.groupBox5.Visible = false;
            // 
            // label_Sensor4Y
            // 
            this.label_Sensor4Y.AutoSize = true;
            this.label_Sensor4Y.Location = new System.Drawing.Point(82, 107);
            this.label_Sensor4Y.Name = "label_Sensor4Y";
            this.label_Sensor4Y.Size = new System.Drawing.Size(0, 25);
            this.label_Sensor4Y.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 25);
            this.label16.TabIndex = 2;
            this.label16.Text = "Y:";
            // 
            // label_Sensor4X
            // 
            this.label_Sensor4X.AutoSize = true;
            this.label_Sensor4X.Location = new System.Drawing.Point(82, 49);
            this.label_Sensor4X.Name = "label_Sensor4X";
            this.label_Sensor4X.Size = new System.Drawing.Size(0, 25);
            this.label_Sensor4X.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 25);
            this.label18.TabIndex = 0;
            this.label18.Text = "X:";
            // 
            // progressBarAmplitude
            // 
            this.progressBarAmplitude.Location = new System.Drawing.Point(1496, 51);
            this.progressBarAmplitude.Name = "progressBarAmplitude";
            this.progressBarAmplitude.Size = new System.Drawing.Size(654, 879);
            this.progressBarAmplitude.Step = 1;
            this.progressBarAmplitude.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1502, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2104, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "100";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button_Calibrate);
            this.groupBox7.Controls.Add(this.textBox_DesiredY);
            this.groupBox7.Controls.Add(this.textBox_DesiredX);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Location = new System.Drawing.Point(262, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(288, 174);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Ângulo desejado";
            // 
            // button_Calibrate
            // 
            this.button_Calibrate.Enabled = false;
            this.button_Calibrate.Location = new System.Drawing.Point(150, 69);
            this.button_Calibrate.Name = "button_Calibrate";
            this.button_Calibrate.Size = new System.Drawing.Size(132, 93);
            this.button_Calibrate.TabIndex = 5;
            this.button_Calibrate.Text = "Calibrar";
            this.button_Calibrate.UseVisualStyleBackColor = true;
            this.button_Calibrate.Click += new System.EventHandler(this.button_Calibrate_Click);
            // 
            // textBox_DesiredY
            // 
            this.textBox_DesiredY.Location = new System.Drawing.Point(45, 131);
            this.textBox_DesiredY.Name = "textBox_DesiredY";
            this.textBox_DesiredY.ReadOnly = true;
            this.textBox_DesiredY.Size = new System.Drawing.Size(100, 31);
            this.textBox_DesiredY.TabIndex = 4;
            // 
            // textBox_DesiredX
            // 
            this.textBox_DesiredX.Location = new System.Drawing.Point(44, 69);
            this.textBox_DesiredX.Name = "textBox_DesiredX";
            this.textBox_DesiredX.ReadOnly = true;
            this.textBox_DesiredX.Size = new System.Drawing.Size(100, 31);
            this.textBox_DesiredX.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Y:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "X:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(556, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series_MinAngle";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Series_MaxAngle";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Name = "Series_CurrentAngle";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(934, 918);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1704, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Amplitude do pulso elétrico";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2168, 977);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.progressBarAmplitude);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_Conectar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Projeto Capernaum - Teste de lógica difusa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Sensor0Y;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Sensor0X;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel label_Status;
        private System.Windows.Forms.Button button_Conectar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_Sensor1Y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Sensor1X;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_Sensor2Y;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_Sensor2X;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label_Sensor3Y;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_Sensor3X;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label_Sensor4Y;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label_Sensor4X;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ProgressBar progressBarAmplitude;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button_Calibrate;
        private System.Windows.Forms.TextBox textBox_DesiredY;
        private System.Windows.Forms.TextBox textBox_DesiredX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
    }
}

