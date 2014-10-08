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
            axMap1.AddLayer(sp, true);
            MapWinGIS.Shapefile sp1 = new MapWinGIS.Shapefile();
            sp1.Open("./GISSampleData/nile.shp", null);
            
            axMap1.AddLayer(sp1, true);

        }
    }
}
