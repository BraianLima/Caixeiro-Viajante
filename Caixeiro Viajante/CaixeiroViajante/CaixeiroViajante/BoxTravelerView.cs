using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixeiroViajante
{
    public partial class BoxTravelerView : Form
    {
        BoxTravelerController Controller = new BoxTravelerController();
        public BoxTravelerView()
        {
            InitializeComponent();
            new BoxTravelerController(webBrowserMaps);
        }
        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Controller.SearchLocal(richtxtboxStreet.Text, richtxtboxCity.Text, webBrowserMaps);
        }

        private void btnLatLong_Click(object sender, EventArgs e)
        {
            if (richtxtboxLat.Text == string.Empty || richtxtboxLong.Text == string.Empty)
            {
                MessageBox.Show("Forneça um valor de latitude e longitude válido", 
                    "Inconsistência nos dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else
            {
                Controller.SearchLatLon(richtxtboxLat.Text, richtxtboxLong.Text, webBrowserMaps);
            }
        }
    }
}
