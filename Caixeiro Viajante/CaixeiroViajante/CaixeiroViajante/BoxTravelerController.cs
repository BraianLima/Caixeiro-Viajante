using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixeiroViajante
{
    class BoxTravelerController
    {
        BoxTravelerModel Dados = new BoxTravelerModel();

        public BoxTravelerController()
        {

        }

        public BoxTravelerController(WebBrowser GoogleMaps)
        {
            StartLocal(GoogleMaps);
        }


        private void StartLocal(WebBrowser webBrowserMaps)
        {

            string standardCity = "Curitiba";
            string standardStreet = "Praça Rui Barbosa";

            try
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("http://maps.google.com/maps?q=");

                if (standardStreet != string.Empty)
                {
                    queryaddress.Append(standardStreet + "," + "+");
                }

                if (standardCity != string.Empty)
                {
                    queryaddress.Append(standardCity + "," + "+");
                }

                webBrowserMaps.Navigate(queryaddress.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        public void SearchLocal(string currentStreet, string currentCity, WebBrowser currentMap)
        {
            Dados.StreetCity(currentStreet, currentCity);
            currentStreet = Dados.Street;
            currentCity = Dados.City;

            try
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("http://maps.google.com/maps?q=");

                if (currentStreet != string.Empty)
                {
                    queryaddress.Append(currentStreet + "," + "+");
                }

                if (currentCity != string.Empty)
                {
                    queryaddress.Append(currentCity + "," + "+");
                }

                currentMap.Navigate(queryaddress.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        public void SearchLatLon(string currentLat, string currentLon, WebBrowser currentMap)
        {
            Dados.LatLong(currentLat, currentLon);
            
            try
            {
                string lat = string.Empty;
                string lon = string.Empty;
                StringBuilder queryAddress = new StringBuilder();
                queryAddress.Append("http://maps.google.com/maps?q=");

                if (Dados.Lat != string.Empty)
                {
                    lat = Dados.Lat;
                    queryAddress.Append(lat + "%2C");
                }
                if (Dados.Lon != string.Empty)
                {
                    lon = Dados.Lon;
                    queryAddress.Append(lon);
                }
                currentMap.Navigate(queryAddress.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
    }
}
