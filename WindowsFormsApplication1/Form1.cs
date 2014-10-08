using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MapWinGIS.Shapefile sp = new MapWinGIS.Shapefile();
            sp.Open("./GISSampleData/base.shp", null);
           int layer1=  axMap1.AddLayer(sp, true);
            MapWinGIS.Shapefile sp1 = new MapWinGIS.Shapefile();
            sp1.Open("./GISSampleData/nile.shp", null);
            axMap1.set_ShapeLayerFillColor(layer1, (UInt32)(System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Azure)));

            
           int layer2=  axMap1.AddLayer(sp1, true);
           axMap1.set_ShapeLayerLineColor(layer2, (UInt32)(System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)));
           axMap1.set_ShapeLayerLineWidth(layer2, 5);


        }
    }
}
