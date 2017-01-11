using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UppgiftDohi.Models
{
    public class Place
    {
        private string name;
        private string info;
        private string image;
        private Polyline position;

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

        public Polyline Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
            }
        }

        public Place(string name, string info, string image, Polyline position)
        {
            this.Name = name;
            this.Info = info;
            this.Image = image;
            this.Position = position;
        }

    }
}