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
        public BoxTravelerView()
        {
            InitializeComponent();
            new BoxTravelerController(webBrowserMaps);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            new BoxTravelerController(richtxtboxStreet.Text, richtxtboxCity.Text, webBrowserMaps);
        }

        private void btnLatLong_Click(object sender, EventArgs e)
        {
            if (richtxtboxLat.Text == string.Empty || richtxtboxLong.Text == string.Empty)
            {
                MessageBox.Show("Forneça um valor de latitude e longitude válido", 
                    "Inconsistência nos dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                string lat = string.Empty;
                string lon = string.Empty;
                StringBuilder queryAddress = new StringBuilder();
                queryAddress.Append("http://maps.google.com/maps?q=");

                if (richtxtboxLat.Text != string.Empty)
                {
                    lat = richtxtboxLat.Text;
                    queryAddress.Append(lat + "%2C");
                }
                if (richtxtboxLong.Text != string.Empty)
                {
                    lon = richtxtboxLong.Text;
                    queryAddress.Append(lon);
                }
                webBrowserMaps.Navigate(queryAddress.ToString());
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
    }
}
