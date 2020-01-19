using System;
using System.Collections.Generic;

namespace CornhacksProject.Models
{
        public class Parameters
        {
            public string dataset { get; set; }
            public string timezone { get; set; }
            public string q { get; set; }
            public int rows { get; set; }
            public List<string> sort { get; set; }
            public string format { get; set; }
            public List<string> facet { get; set; }
        }

        public class Fields
        {
            public string city { get; set; }
            public string country { get; set; }
            public string region { get; set; }
            public List<double> geopoint { get; set; }
            public double longitude { get; set; }
            public double latitude { get; set; }
            public string accentcity { get; set; }
            public int population { get; set; }
        }

        public class Geometry
        {
            public string type { get; set; }
            public List<double> coordinates { get; set; }
        }

        public class Record
        {
            public string datasetid { get; set; }
            public string recordid { get; set; }
            public Fields fields { get; set; }
            public Geometry geometry { get; set; }
            public DateTime record_timestamp { get; set; }
        }

        public class Facet
        {
            public int count { get; set; }
            public string path { get; set; }
            public string state { get; set; }
            public string name { get; set; }
        }

        public class FacetGroup
        {
            public List<Facet> facets { get; set; }
            public string name { get; set; }
        }

        public class CityPopulation
        {
            public int nhits { get; set; }
            public Parameters parameters { get; set; }
            public List<Record> records { get; set; }
            public List<FacetGroup> facet_groups { get; set; }
        }
    
}
