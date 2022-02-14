using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace ConverterTerritorioEmGeometriaMySql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Exemplo usando o site open street map
        // https://www.openstreetmap.org/relation/334547

        const string _apiReversoPoligonosTerritorio = "https://nominatim.openstreetmap.org/reverse?format=json&osm_id={0}&osm_type=R&polygon_geojson=1";
        const string _apiReversoNomeTerritorio = "https://nominatim.openstreetmap.org/reverse?format=json&lat={0}&lon={1}&osm_id={2}&accept-language=en";
        const string _apiReversoRelacaoTerritorio = "https://nominatim.openstreetmap.org/search.php?city={0}&format=json";
        // https://nominatim.openstreetmap.org/reverse?format=json&osm_id=334547&osm_type=R&polygon_geojson=1

        // Obter o nome da cidade
        // https://nominatim.openstreetmap.org/reverse?format=json&lat=51.7728321&lon=19.4528033&osm_id=246291409&accept-language=en

        // Obter a relação da cidade
        // https://nominatim.openstreetmap.org/search.php?city=%C5%81%C3%B3d%C5%BA&format=json

        // Obter o reverso em polígonos
        // https://nominatim.openstreetmap.org/reverse?format=json&osm_id=1582777&osm_type=R&polygon_geojson=1



        private async void btnObterTerritorio_Click(object sender, EventArgs e)
        {
            btnObterTerritorio.Enabled = false;

            using HttpClient client = new ();
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
            
            var stream = await client.GetStreamAsync(string.Format(_apiReversoPoligonosTerritorio, 334547));

            /*string text;
            using (StreamReader reader = new(stream, Encoding.UTF8))
            {
                text = reader.ReadToEnd();
            }*/

            StringBuilder sb = new();

            var lista = await JsonSerializer.DeserializeAsync<RelacaoReverso>(stream);

            sb.Append("Polygon((");
            List<double> first = new();
            var enUS = new CultureInfo("en-US");

            for (int i = 0; i < lista.geojson.coordinates[0].Count; i++)
            {
                var coord = lista.geojson.coordinates[0][i];
                var par = i % 2 == 0;

                if (i == 0) first = coord;
                
                sb.Append($"{coord[1].ToString(enUS)} {coord[0].ToString(enUS)},");
            }
            sb.Append($"{first[1].ToString(enUS)} {first[0].ToString(enUS)}))");

            string final = sb.ToString();

            btnObterTerritorio.Enabled = true;
        }
    }
}