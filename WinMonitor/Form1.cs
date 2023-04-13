using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenHardwareMonitor.Hardware;

namespace WinMonitor
{
    public partial class WinMonitor : MetroFramework.Forms.MetroForm
    {
        private string tmpInfo = string.Empty;
        private void GetCPUTemperature()
        {
            tmpInfo = string.Empty;
            Visitor visitor = new Visitor();

            Computer computer = new Computer();
            computer.Open();
            computer.CPUEnabled = true;
            computer.Accept(visitor);
            for (int i = 0; i < computer.Hardware.Length; i++)
            {
                if (computer.Hardware[i].HardwareType == HardwareType.CPU)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                        {
                            /*tmpInfo += computer.Hardware[i].Sensors[j].Name + ": " +
                                computer.Hardware[i].Sensors[j].Value.ToString() + "\n";*/

                            tmpInfo = computer.Hardware[0].Sensors[3].Value.ToString();
                            

                        }
                    }
                }
            }
            chart1.Series["CPU Temperature"].Points.AddY(double.Parse(tmpInfo));
            metroProgressBarTMP.Value = int.Parse(tmpInfo);
            templbl.Text = tmpInfo+ "°C";
            if (int.Parse(tmpInfo) > 60 && int.Parse(tmpInfo) < 72)
            {
                templbl.ForeColor = Color.Orange;               
            }
            else
            {
                templbl.ForeColor = Color.Black;
            }

            if (int.Parse(tmpInfo) >= 72)
            {
                templbl.ForeColor = Color.Red;
            }
           
            //""

        }

        const byte TEMPERATURE_ATTRIBUTE = 194;
        public List<byte> GetDriveTemp()
        {
            var retval = new List<byte>();
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\WMI", "SELECT * FROM MSStorageDriver_ATAPISmartData");
                //loop through all the hard disks
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    byte[] arrVendorSpecific = (byte[])queryObj.GetPropertyValue("VendorSpecific");
                    //Find the temperature attribute
                    int tempIndex = Array.IndexOf(arrVendorSpecific, TEMPERATURE_ATTRIBUTE);
                    retval.Add(arrVendorSpecific[tempIndex + 5]);
                }
            }
            catch (ManagementException err)
            {
                Console.WriteLine("An error occurred while querying for WMI data: " + err.Message);
            }
            return retval;
        }
        public WinMonitor()
        {
            InitializeComponent();
            computerHardware.MainboardEnabled = true;
            computerHardware.FanControllerEnabled = true;
            computerHardware.CPUEnabled = true;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            chart1.ChartAreas[0].BackColor = Color.Black;
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

       static Computer computerHardware = new Computer();
       

        private void timer_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fram = pRam.NextValue();
            float fhdd = pHDD.NextValue();
            metroProgressBarCPU.Value = (int)fcpu;
            metroProgressBarRAM.Value = (int)fram;
            metroProgressBarHDD.Value = (int)fhdd;
            lblCPU.Text = string.Format("{0:.00}%", fcpu);
            lblRAM.Text = string.Format("{0:0.00}%", fram);
            hddlbl.Text = string.Format("{0:0.00}%", fhdd);
            chart1.Series["CPU"].Points.AddY(fcpu);
            chart1.Series["RAM"].Points.AddY(fram);
            GetCPUTemperature();
            chart1.Series["HDD Temperature"].Points.AddY(double.Parse(GetDriveTemp().ToArray().First().ToString()));
            metroProgressBarHDDTemp.Value = int.Parse(GetDriveTemp().ToArray().First().ToString());
            temphddlbl.Text = GetDriveTemp().ToArray().First() + "°C";

            if (fram > 50 && fram < 72)
            {
                lblRAM.ForeColor = Color.Orange;
            }
            else
            {
                lblRAM.ForeColor = Color.Black;
            }

            if (fcpu > 50 && fcpu < 72)
            {
                lblCPU.ForeColor = Color.Orange;
            }
            else
            {
                lblCPU.ForeColor = Color.Black;
            }

            if (fram >= 72)
            {
                lblRAM.ForeColor = Color.Red;
            }

           
            foreach (var hardware in computerHardware.Hardware)
            {
                // This will be in the mainboard
                foreach (var subhardware in hardware.SubHardware)
                {
                    // This will be in the SuperIO
                    subhardware.Update();
                    if (subhardware.Sensors.Length > 0) // Index out of bounds check
                    {
                        foreach (var sensor in subhardware.Sensors)
                        {
                            // Look for the main fan sensor
                            if (sensor.SensorType == SensorType.Fan && sensor.Name.Equals("Fan", StringComparison.OrdinalIgnoreCase))
                            {
                                fanspeed.Text = Convert.ToString((int)(float)sensor.Value) + "RPM";
                            }
                            

                        }
                    }
                }
            }



        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroProgressBar1_Click(object sender, EventArgs e)
        {

        }


    }
}
