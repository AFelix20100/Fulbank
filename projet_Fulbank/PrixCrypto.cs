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
            Root PrixCrypto = AppelsAPI.RequeteAPI();
            prix0.Text = PrixCrypto.data[0].priceUsd.ToString();
            prix1.Text = PrixCrypto.data[1].priceUsd.ToString();
            prix2.Text = PrixCrypto.data[2].priceUsd.ToString();
            string[] names = new string[] { Name0.Text.ToString().ToLower(), Name1.Text.ToString().ToLower(), Name2.Text.ToString().ToLower()};
            Chart[] listCharts = new Chart[] { chrt1, chrt2, chrt3}; //Une liste avec 3 zones qui contiennent des graphiques
            Root CryptoHistory = new Root();
            chrt1.ChartAreas.Add("Price");
            chrt2.ChartAreas.Add("Price2"); //On ajoute un graphique à chaque zone
            chrt3.ChartAreas.Add("Price3");  
            Series bitcoin = new Series();
            Series ethereum = new Series(); //On instancie une serie d'informations vide
            Series tether = new Series(); 
            bitcoin.ChartType = SeriesChartType.Line;
            ethereum.ChartType = SeriesChartType.Line; //Par defaut le graphique est une diagramme alors on la change dans un graphique classique
            tether.ChartType = SeriesChartType.Line;
            bitcoin.Color = Color.Gold;
            ethereum.Color = Color.Blue; //On  change la valeur des lignes du graphique
            tether.Color = Color.Green;
            chrt1.Series.Add(bitcoin);
            chrt2.Series.Add(ethereum); //On ajoute les séries d'informations vides qux graphes  
            chrt3.Series.Add(tether);
            double value = 0;
           
            for (int indexChart = 0; indexChart < listCharts.Count(); indexChart++)
            {
                CryptoHistory = AppelsAPI.getCryptoHistory(names[indexChart]);
                listCharts[indexChart].ChartAreas[0].AxisY.Minimum = CryptoHistory.data[355].priceUsd*0.95;
                listCharts[indexChart].ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                listCharts[indexChart].ChartAreas[0].AxisX.LineWidth = 0;               //On rend invisibles quelques parties du graphique
                listCharts[indexChart].ChartAreas[0].AxisX.LabelStyle.Enabled = false;
                listCharts[indexChart].ChartAreas[0].AxisX.MajorTickMark.Enabled = false;
                listCharts[indexChart].ChartAreas[0].AxisX.MinorTickMark.Enabled = false;
                listCharts[indexChart].Legends.Clear();
                for (int indexDay = 355; indexDay < CryptoHistory.data.Count; indexDay++)
                {
                    value = Double.Parse(CryptoHistory.data[indexDay].priceUsd.ToString()); 
                    value = Math.Truncate(value); 
                    listCharts[indexChart].Series[0].Points.Add(value); //On remplie les séries d'informations
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
