using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterTerritorioEmGeometriaMySql
{
    public class RelacaoReverso
    {
        public int place_id { get; set; }
        public string licence{ get; set; }
        public string osm_type { get; set; }
        public int osm_id { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
        public string display_name { get; set; }
        public EnderecoReverso address { get; set; }
        public List<string> boundingbox { get; set; }
        public GeoLocalizacaoReverso geojson { get; set; }
    }

    public class EnderecoReverso
    {
        public string city { get; set; }
        public string municipality { get; set; }
        public string state_district { get; set; }
        public string state { get; set; }
        public string region { get; set; }
        public string country { get; set; }
        public string country_code { get; set; }
    }

    public class GeoLocalizacaoReverso
    {
        public string type { get; set; }
        public object coordinates { get; set; }
        //public List<List<List<double>>> coordinates { get; set; }
    }
}
