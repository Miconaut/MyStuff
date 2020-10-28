using LiveCharts.WinForms;
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

namespace Covid1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private const string COVID1_CSV_PATH = "Covid1.csv";
        private const string WORLD_XML_PATH = "World.xml";

        [Obsolete]
        private void Form1_Load(object sender, EventArgs e)
        {
            var r = new Random();
            LiveCharts.WinForms.GeoMap geoMap = new LiveCharts.WinForms.GeoMap();
            Dictionary<string, double> keyValues = new Dictionary<string, double>();

            CSV csv = new CSV(COVID1_CSV_PATH);

            List<string> Znacka = csv.GetListForName("Znacka").GetStrings();
            List<double> Corona = csv.GetListForName("Corona").GetDoubleFloats();

            for (int Index = 0; Index < Znacka.Count; Index++)
            {
                keyValues.Add(Znacka[Index], Corona[Index]);
            }

            geoMap.HeatMap = keyValues;

            geoMap.Source = WORLD_XML_PATH;
            this.Controls.Add(geoMap);
            geoMap.Dock = DockStyle.Fill;

            geoMap.LandClick += GeoMap_LandClick;
            geoMap.EnableZoomingAndPanning = true;
            geoMap.Hoverable = true;
        }
        private void GeoMap_LandClick(object arg1, LiveCharts.Maps.MapData arg2)
        {
            Console.WriteLine(arg2.Id);
        }
    }
}
