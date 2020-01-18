using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace CornhacksProject.Models
{
    public class Location
    {
        public string type { get; set; }
        public List<double> coordinates { get; set; }

        public Location(string type, List<double> coordinates)
        {
            this.type = type;
            this.coordinates = coordinates;
        }
    }

    public class P1
    {
        public int conc { get; set; }
        public int aqius { get; set; }
        public int aqicn { get; set; }

        public P1(int conc, int aqius, int aqicn)
        {
            this.conc = conc;
            this.aqius = aqius;
            this.aqicn = aqicn;
        }
    }

    public class Pollution
    {
        public DateTime ts { get; set; }
        public int aqius { get; set; }
        public string mainus { get; set; }
        public int aqicn { get; set; }
        public string maincn { get; set; }
        public P1 p1 { get; set; }

        public Pollution(DateTime ts, int aqius, string mainus, int aqicn, string maincn, P1 p1)
        {
            this.ts = ts;
            this.aqius = aqius;
            this.aqicn = aqicn;
            this.mainus = mainus;
            this.maincn = maincn;
            this.p1 = p1;
        }
    }

    public class Units
    {
        public string p2 { get; set; }
        public string p1 { get; set; }
        public string o3 { get; set; }
        public string n2 { get; set; }
        public string s2 { get; set; }
        public string co { get; set; }

        public Units(string p2, string p1, string o3, string n2, string s2, string co)
        {
            this.p2 = p2;
            this.p1 = p1;
            this.o3 = o3;
            this.n2 = n2;
            this.s2 = s2;
            this.co = co;
        }
    }

    public class Current
    {
        public Pollution pollution { get; set; }
        public Units units { get; set; }

        public Current(Pollution pollution, Units units)
        {
            this.pollution = pollution;
            this.units = units;
        }
    }

    public class Data
    {
        public string name { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public Location location { get; set; }
        public Current current { get; set; }

        public Data(string name, string city, string state, string country, Location location, Current current)
        {
            this.name = name;
            this.city = city;
            this.state = state;
            this.country = country;
            this.location = location;
            this.current = current;
        }
    }

    public class AirVisualResult
    {
        public string status { get; set; }
        public Data data { get; set; }

        public AirVisualResult(string status, Data data)
        {
            this.status = status;
            if (status != "success")
                throw new Exception("AirVisualResult status exception: " + status);
            this.data = data;
        }
    }
}