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
            Chart[] listCharts = new Chart[] { chrt1, chrt2};
            Root CryptoHistory = new Root();
            chrt1.ChartAreas.Add("Price");
            chrt2.ChartAreas.Add("Price2");
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
            chrt1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chrt1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            for (int indexChart = 0; indexChart < listCharts.Count(); indexChart++)
            {
                CryptoHistory = AppelHTTPS.getCryptoHistory(names[indexChart]);
                listCharts[indexChart].ChartAreas[0].AxisY.Minimum = Double.Parse(Math.Floor(Decimal.Truncate(Decimal.Parse(CryptoHistory.data[355].priceUsd.ToString()))).ToString());

                for (int indexDay = 357; indexDay < CryptoHistory.data.Count; indexDay++)
                {
                    listCharts[indexChart].Series[0].Points.Add(double.Parse(CryptoHistory.data[indexDay].priceUsd.ToString()));
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
