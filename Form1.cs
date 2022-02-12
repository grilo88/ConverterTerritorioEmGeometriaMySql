using System.Net;
using System.Net.Http;

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
            using HttpClient client = new ();
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
            
            var json = await client.GetStringAsync(string.Format(_apiReversoPoligonosTerritorio, 334547));
        }
    }
}