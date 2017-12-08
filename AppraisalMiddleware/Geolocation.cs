using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppraisalMiddleware
{
    using Amazon.Lambda.Core;

    public class GeoLocationRepository
    {
        private static GeoLocation _current;
        public GeoLocationRepository()
        {
            if (_current != null) return;
            _current = new GeoLocation
                       {
                          Latitude = "42.331394",
                          Longitude = "-83.047245"
                       };
        }

        public GeoLocation GetGeoLocation()
        {
            return _current;
        }

        public bool SaveGeoLocation(GeoLocation position)
        {
            _current = position;
            return true;
        }


    }

    public class GeoLocation
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }

}