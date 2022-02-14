using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Xml;
using static System.Windows.Forms.ListViewItem;

namespace ConverterTerritorioEmGeometriaMySql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const string datasintese = "https://api.datasintese.com/";
        readonly Dictionary<string, string> Estado = new()
        {
            { "AC", "ACRE" },
            { "AL", "ALAGOAS" },
            { "AP", "AMAPA" },
            { "AM", "AMAZONAS" },
            { "BA", "BAHIA" },
            { "CE", "CEARÁ" },
            { "ES", "ESPÍRITO SANTO" },
            { "GO", "GOIÁS" },
            { "MA", "MARANHÃO" },
            { "MT", "MATO GROSSO" },
            { "MS", "MATO GROSSO DO SUL" },
            { "MG", "MINAS GERAIS" },
            { "PA", "PARÁ" },
            { "PB", "PARAÍBA" },
            { "PR", "PARANÁ" },
            { "PE", "PERNAMBUCO" },
            { "PI", "PIAUÍ" },
            { "RJ", "RIO DE JANEIRO" },
            { "RN", "RIO GRANDE DO NORTE" },
            { "RS", "RIO GRANDE DO SUL" },
            { "RO", "RONDÔNIA" },
            { "RR", "RORAIMA" },
            { "SC", "SANTA CATARINA" },
            { "SP", "SÃO PAULO" },
            { "SE", "SERGIPE" },
            { "TO", "TOCANTINS" },
            { "DF", "DISTRITO FEDERAL" },
        };


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
            btnObterGeometria.Enabled = false;

            using HttpClient client = new();
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");

            var stream = await client.GetStreamAsync(string.Format(_apiReversoPoligonosTerritorio, txtOsmId.Text));

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

            textBox2.Text = final;

            btnObterGeometria.Enabled = true;
        }

        private async void btnCarregarMunicipios_Click(object sender, EventArgs e)
        {
            btnCarregarMunicipios.Enabled = false;

            string endpoint = $"{datasintese}/v2/datatarget/parametros?tipo=pessoasjuridicas&descricao=municipio";

            using HttpClient client = new();
            client.DefaultRequestHeaders.Add("X_Auth_Cpf", "02857455143");
            client.DefaultRequestHeaders.Add("X_Auth_Token", "e7237b1941c2dc2d2fa1366ef35f10fa");

            var stream = await client.GetStreamAsync(endpoint);
            var lista = await JsonSerializer.DeserializeAsync<List<Parametro>>(stream);


            listBox1.BeginUpdate();
            listBox1.DataSource = lista[0].valores;
            listBox1.EndUpdate();

            //for (int i = 0; i < lista[0].valores.Count; i++)
            //{
            //    var valor = lista[0].valores[i];

            //    var uf = valor[..2];
            //    var municipio = valor[3..];


            //}
            btnCarregarMunicipios.Enabled = true;
        }

        private async void btnObterRelacoes_Click(object sender, EventArgs e)
        {
            btnObterRelacoes.Enabled = false;

            using HttpClient client = new();
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");

            var stream = await client.GetStreamAsync(string.Format(_apiReversoRelacaoTerritorio, listBox1.Text[3..]));
            var lista = await JsonSerializer.DeserializeAsync<List<RelacaoTerritorio>>(stream);

            listView1.BeginUpdate();
            listView1.Items.Clear();

            for (int i = 0; i < lista.Count; i++)
            {
                var item = new ListViewItem();
                item.Text = $"{lista[i].place_id}";

                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, $"{lista[i].osm_id}"));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, $"{lista[i].osm_type}"));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, $"{lista[i].lat}"));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, $"{lista[i].lon}"));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, $"{lista[i].display_name}"));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, $"{lista[i].@class}"));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, $"{lista[i].type}"));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, $"{lista[i].importance}"));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, $"{lista[i].icon}"));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, $"{lista[i].licence}"));

                listView1.Items.Add(item);
            }
            listView1.EndUpdate();

            string osm_id = "0";
            if (listView1.SelectedItems.Count == 0)
            {
                listView1.Items[0].Selected = true;

                var relation = listView1.Items.Cast<ListViewItem>().Where(x => 
                    x.SubItems.Cast<ListViewSubItem>().Where(y => y.Text == "relation").Any() &&                    // Tipo Relação
                    x.SubItems.Cast<ListViewSubItem>().Where(y => y.Text.ToUpper().Contains(txtEstado.Text + ",")   // Aumenta precisão usando o nome do Estado
                    ).Any()
                    ).Select(x => x.SubItems.Cast<ListViewSubItem>()).ToList();

                osm_id = relation.First().Skip(1).First().Text;
            }
            else
            {
                osm_id = listView1.SelectedItems[0].SubItems[1].Text;
            }

            txtOsmId.Text = osm_id;

            btnObterRelacoes.Enabled = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUF.Text = listBox1.Text[..2];
            txtEstado.Text = Estado[txtUF.Text];

            if (chkAutoCarregarRelacoes.Checked)
            {
                btnObterRelacoes_Click(sender, e);
            }
        }

        private void btnAbrirMapa_Click(object sender, EventArgs e)
        {
            string url = "https://www.openstreetmap.org/relation/{0}";

            if (listView1.Items.Count == 0)
            {
                return;
            }

            var proc = new Process();
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.FileName = string.Format(url, txtOsmId.Text);
            proc.Start();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string osm_id = listView1.SelectedItems[0].SubItems[1].Text;
                txtOsmId.Text = osm_id;
            }
        }
    }
}