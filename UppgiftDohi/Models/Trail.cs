using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UppgiftDohi.Models
{
    public class Trail
    {
        private int id;
        private string name;
        private string info;
        private double length;
        private double duration;
        private string image;

        private List<Polyline> polylines = new List<Polyline>();
        private List<Place> places = new List<Place>();

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Info
        {
            get
            {
                return info;
            }

            set
            {
                info = value;
            }
        }

        public double Length
        {
            get
            {
                return length;
            }

            set
            {
                length = value;
            }
        }

        public double Duration
        {
            get
            {
                return duration;
            }

            set
            {
                duration = value;
            }
        }

        public string Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
            }
        }

        public List<Polyline> Polylines
        {
            get
            {
                return polylines;
            }

            set
            {
                polylines = value;
            }
        }

        public List<Place> Places
        {
            get
            {
                return places;
            }

            set
            {
                places = value;
            }
        }

        public Trail(int id, string name, string info, double length, double duration, string image, List<Polyline> polylines, List<Place> places)
        {
            this.Id = id;
            this.Name = name;
            this.Info = info;
            this.Length = length;
            this.Duration = duration;
            this.Image = image;
            this.Polylines = polylines;
            this.Places = places;
        }

        public static List<Trail> GenerateList()
        {
            List<Trail> trails = new List<Trail>();
            List<Polyline> polylines = new List<Polyline>();
            List<Place> places = new List<Place>();

            Polyline polyline = new Polyline(59.334415, 18.110103);
            polylines.Add(polyline);
            polyline = new Polyline(59.35, 18.110103);
            polylines.Add(polyline);
            polyline = new Polyline(59.35, 18.05);
            polylines.Add(polyline);
            polyline = new Polyline(59.34, 18.09);
            polylines.Add(polyline);

            Place place = new Place("Fontän", "Sergelfontänen", "http://www.pixgallery.com/downloadPreview/WUTYV9", polylines[1]);
            places.Add(place);
            place = new Place("Staty", "Gustav 2 Adolf", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/10/Gustaf_II_Adolf.JPG/250px-Gustaf_II_Adolf.JPG", polylines[3]);
            places.Add(place);
            Trail trail = new Trail(1, "Stadsvandring", "Skön promenad", 4, 50, "bild", polylines, places);

            trails.Add(trail);

            polylines = new List<Polyline>();
            places = new List<Place>();

            polyline = new Polyline(59.334415, 18.0);
            polylines.Add(polyline);
            polyline = new Polyline(59.31, 17.9);
            polylines.Add(polyline);
            polyline = new Polyline(59.29, 18.03);
            polylines.Add(polyline);
            polyline = new Polyline(59.27, 18.00);
            polylines.Add(polyline);

            place = new Place("Båt", "Fin utsikt", "http://images.travelnow.com/hotels/11000000/10020000/10011200/10011115/10011115_2_y.jpg", polylines[1]);
            places.Add(place);
            place = new Place("Älvsjö pendeltågsstation", "", "http://www.pro.se/PageFiles/55174/DSC_0003-1.jpg?preset=ArticleMainImage", polylines[3]);
            places.Add(place);
            trail = new Trail(1, "Zick Zack", "Simkläder kan behövas", 7, 90, "bild", polylines, places);

            trails.Add(trail);

            return trails;
        }

    }
}