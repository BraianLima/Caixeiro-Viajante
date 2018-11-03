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

        public BoxTravelerController(string street, string city, WebBrowser map)
        {
            BoxTravelerModel Dados = new BoxTravelerModel(street, city);
            SearchLocal(Dados.Street, Dados.City, map);
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

        private void SearchLocal(string currentStreet, string currentCity, WebBrowser currentMap)
        {
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
    }
}
