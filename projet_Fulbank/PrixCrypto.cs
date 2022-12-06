using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using projet_Fulbank.Class;

namespace projet_Fulbank
{
    public partial class PrixCrypto : Form
    {
        public PrixCrypto()
        {
            InitializeComponent();
        }

        private void PrixCrypto_Load(object sender, EventArgs e)
        {
            label13.Text = Connexion.lastName;
            label14.Text = Connexion.accountNumber.ToString();
            logo0.SizeMode = PictureBoxSizeMode.StretchImage;
            logo1.SizeMode = PictureBoxSizeMode.StretchImage;
            logo2.SizeMode = PictureBoxSizeMode.StretchImage;
            Root PrixCrypto = AppelHTTPS.RequeteHTTPS();
            prix0.Text = PrixCrypto.data[0].priceUsd.ToString();
            prix1.Text = PrixCrypto.data[1].priceUsd.ToString();
            prix2.Text = PrixCrypto.data[2].priceUsd.ToString();
            string[] names = new string[] { Name0.Text.ToString().ToLower(), Name1.Text.ToString().ToLower(), Name2.Text.ToString().ToLower()};
            Chart[] listCharts = new Chart[] { chrt1, chrt2, chrt3};
            Root CryptoHistory = new Root();
            chrt1.ChartAreas.Add("Price");
            chrt2.ChartAreas.Add("Price2");
            chrt3.ChartAreas.Add("Price3");
            Series bitcoin = new Series();
            Series ethereum = new Series();
            Series tether = new Series();
            bitcoin.ChartType = SeriesChartType.Line;
            ethereum.ChartType = SeriesChartType.Line;
            tether.ChartType = SeriesChartType.Line;
            bitcoin.Color = Color.Gold;
            ethereum.Color = Color.Blue;
            tether.Color = Color.Green;
            chrt1.Series.Add(bitcoin);
            chrt2.Series.Add(ethereum);
            chrt3.Series.Add(tether);
            double value = 0;
           
            for (int indexChart = 0; indexChart < listCharts.Count(); indexChart++)
            {
                CryptoHistory = AppelHTTPS.getCryptoHistory(names[indexChart]);
                listCharts[indexChart].ChartAreas[0].AxisY.Minimum = CryptoHistory.data[355].priceUsd*0.95;
                listCharts[indexChart].ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                listCharts[indexChart].ChartAreas[0].AxisX.LineWidth = 0;
                listCharts[indexChart].ChartAreas[0].AxisX.LabelStyle.Enabled = false;
                listCharts[indexChart].ChartAreas[0].AxisX.MajorTickMark.Enabled = false;
                listCharts[indexChart].ChartAreas[0].AxisX.MinorTickMark.Enabled = false;
              
                listCharts[indexChart].Legends.Clear();
                for (int indexDay = 355; indexDay < CryptoHistory.data.Count; indexDay++)
                {
                    value = Double.Parse(CryptoHistory.data[indexDay].priceUsd.ToString());
                    value = Math.Truncate(value);
                    listCharts[indexChart].Series[0].Points.Add(value);
                }
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void retour_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new Menu();
            menu.Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
