
namespace WinMonitor
{
    partial class WinMonitor
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinMonitor));
            this.pRam = new System.Diagnostics.PerformanceCounter();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarCPU = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarRAM = new MetroFramework.Controls.MetroProgressBar();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarTMP = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.pHDD = new System.Diagnostics.PerformanceCounter();
            this.hddlbl = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarHDD = new MetroFramework.Controls.MetroProgressBar();
            this.metroProgressBarHDDTemp = new MetroFramework.Controls.MetroProgressBar();
            this.temphddlbl = new MetroFramework.Controls.MetroLabel();
            this.hddname = new MetroFramework.Controls.MetroLabel();
            this.templbl = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fanspeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pRam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHDD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pRam
            // 
            this.pRam.CategoryName = "Memory";
            this.pRam.CounterName = "% Committed bytes In Use";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(35, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "CPU";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroProgressBarCPU
            // 
            this.metroProgressBarCPU.Location = new System.Drawing.Point(57, 78);
            this.metroProgressBarCPU.Name = "metroProgressBarCPU";
            this.metroProgressBarCPU.Size = new System.Drawing.Size(219, 23);
            this.metroProgressBarCPU.TabIndex = 1;
            this.metroProgressBarCPU.Click += new System.EventHandler(this.metroProgressBar1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(16, 111);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "RAM";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroProgressBarRAM
            // 
            this.metroProgressBarRAM.Location = new System.Drawing.Point(57, 109);
            this.metroProgressBarRAM.Name = "metroProgressBarRAM";
            this.metroProgressBarRAM.Size = new System.Drawing.Size(219, 23);
            this.metroProgressBarRAM.TabIndex = 1;
            this.metroProgressBarRAM.Click += new System.EventHandler(this.metroProgressBar1_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.InfoText;
            this.chart1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            this.chart1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Lime;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Lime;
            chartArea1.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.Lime;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Lime;
            chartArea1.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.Lime;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.Lime;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.BackColor = System.Drawing.Color.Black;
            legend1.ForeColor = System.Drawing.Color.Lime;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-18, 231);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "CPU Temperature";
            series3.YValuesPerPoint = 4;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "HDD";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "HDD Temperature";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(397, 162);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(15, 140);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(115, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "CPU Temperature";
            // 
            // metroProgressBarTMP
            // 
            this.metroProgressBarTMP.Location = new System.Drawing.Point(131, 140);
            this.metroProgressBarTMP.Name = "metroProgressBarTMP";
            this.metroProgressBarTMP.Size = new System.Drawing.Size(145, 23);
            this.metroProgressBarTMP.TabIndex = 1;
            this.metroProgressBarTMP.Click += new System.EventHandler(this.metroProgressBar1_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(118, 396);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(117, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Made by VMOON";
            // 
            // pHDD
            // 
            this.pHDD.CategoryName = "PhysicalDisk";
            this.pHDD.CounterName = "% Disk Time";
            this.pHDD.InstanceName = "_Total";
            // 
            // hddlbl
            // 
            this.hddlbl.AutoSize = true;
            this.hddlbl.Location = new System.Drawing.Point(282, 171);
            this.hddlbl.Name = "hddlbl";
            this.hddlbl.Size = new System.Drawing.Size(27, 19);
            this.hddlbl.TabIndex = 0;
            this.hddlbl.Text = "0%";
            this.hddlbl.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(16, 171);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(36, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "HDD";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroProgressBarHDD
            // 
            this.metroProgressBarHDD.Location = new System.Drawing.Point(57, 169);
            this.metroProgressBarHDD.Name = "metroProgressBarHDD";
            this.metroProgressBarHDD.Size = new System.Drawing.Size(219, 23);
            this.metroProgressBarHDD.TabIndex = 1;
            this.metroProgressBarHDD.Click += new System.EventHandler(this.metroProgressBar1_Click);
            // 
            // metroProgressBarHDDTemp
            // 
            this.metroProgressBarHDDTemp.Location = new System.Drawing.Point(131, 198);
            this.metroProgressBarHDDTemp.Name = "metroProgressBarHDDTemp";
            this.metroProgressBarHDDTemp.Size = new System.Drawing.Size(145, 23);
            this.metroProgressBarHDDTemp.TabIndex = 1;
            this.metroProgressBarHDDTemp.Click += new System.EventHandler(this.metroProgressBar1_Click);
            // 
            // temphddlbl
            // 
            this.temphddlbl.AutoSize = true;
            this.temphddlbl.Location = new System.Drawing.Point(282, 198);
            this.temphddlbl.Name = "temphddlbl";
            this.temphddlbl.Size = new System.Drawing.Size(34, 19);
            this.temphddlbl.TabIndex = 4;
            this.temphddlbl.Text = "0 °C";
            // 
            // hddname
            // 
            this.hddname.AutoSize = true;
            this.hddname.Location = new System.Drawing.Point(15, 198);
            this.hddname.Name = "hddname";
            this.hddname.Size = new System.Drawing.Size(116, 19);
            this.hddname.TabIndex = 3;
            this.hddname.Text = "HDD Temperature";
            // 
            // templbl
            // 
            this.templbl.AutoSize = true;
            this.templbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.templbl.Location = new System.Drawing.Point(282, 143);
            this.templbl.Name = "templbl";
            this.templbl.Size = new System.Drawing.Size(30, 15);
            this.templbl.TabIndex = 6;
            this.templbl.Text = "0 °C";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRAM.Location = new System.Drawing.Point(282, 114);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(25, 15);
            this.lblRAM.TabIndex = 6;
            this.lblRAM.Text = "0%";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCPU.Location = new System.Drawing.Point(283, 81);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(25, 15);
            this.lblCPU.TabIndex = 6;
            this.lblCPU.Text = "0%";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinMonitor.Properties.Resources.fan_16886;
            this.pictureBox1.Location = new System.Drawing.Point(250, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // fanspeed
            // 
            this.fanspeed.AutoSize = true;
            this.fanspeed.Location = new System.Drawing.Point(283, 36);
            this.fanspeed.Name = "fanspeed";
            this.fanspeed.Size = new System.Drawing.Size(40, 13);
            this.fanspeed.TabIndex = 8;
            this.fanspeed.Text = "0 RPM";
            // 
            // WinMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 415);
            this.Controls.Add(this.fanspeed);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.templbl);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.hddname);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.temphddlbl);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.metroProgressBarHDDTemp);
            this.Controls.Add(this.metroProgressBarTMP);
            this.Controls.Add(this.metroProgressBarHDD);
            this.Controls.Add(this.metroProgressBarRAM);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroProgressBarCPU);
            this.Controls.Add(this.hddlbl);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WinMonitor";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "WinMonitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHDD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter pRam;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarCPU;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarRAM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarTMP;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Diagnostics.PerformanceCounter pHDD;
        private MetroFramework.Controls.MetroLabel hddlbl;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarHDD;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarHDDTemp;
        private MetroFramework.Controls.MetroLabel temphddlbl;
        private MetroFramework.Controls.MetroLabel hddname;
        private System.Windows.Forms.Label templbl;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label fanspeed;
    }
}

