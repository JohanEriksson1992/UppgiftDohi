using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UppgiftDohi.Models
{
    public class Polyline
    {
        private double lat;
        private double lng;

        public Polyline(double lat, double lng)
        {
            this.Lat = lat;
            this.Lng = lng;
        }

        public double Lat
        {
            get
            {
                return lat;
            }

            set
            {
                lat = value;
            }
        }

        public double Lng
        {
            get
            {
                return lng;
            }

            set
            {
                lng = value;
            }
        }
    }
}