using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixeiroViajante
{
    class BoxTravelerModel
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }

        public BoxTravelerModel()
        {
            Street = string.Empty;
            City = string.Empty;
            Lat = string.Empty;
            Lon = string.Empty;
        }
        
        public BoxTravelerModel(string SearchStreet, string SearchCity)
        {
            this.Street = SearchStreet;
            this.City = SearchCity;
        }

    }
}
