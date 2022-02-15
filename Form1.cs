using MySqlConnector;
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
            { "AP", "AMAPÁ" },
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

        string lat = "";
        string lon = "";
        string geometria_robo = "";

        // Exemplo usando o site open street map
        // https://www.openstreetmap.org/relation/334547

        const string _apiReversoPoligonosTerritorio = "https://nominatim.openstreetmap.org/reverse?format=json&osm_id={0}&osm_type=R&polygon_geojson=1";
        const string _apiReversoNomeTerritorio = "https://nominatim.openstreetmap.org/reverse?format=json&lat={0}&lon={1}&osm_id={2}&accept-language=en";
        const string _apiReversoRelacaoTerritorio = "https://nominatim.openstreetmap.org/search.php?city={0}&format=json";
        const string _apiReversoRelacaoTerritorio2 = "https://nominatim.openstreetmap.org/search.php?q={0}&format=json";
        // https://nominatim.openstreetmap.org/reverse?format=json&osm_id=334547&osm_type=R&polygon_geojson=1

        // Obter o nome da cidade
        // https://nominatim.openstreetmap.org/reverse?format=json&lat=51.7728321&lon=19.4528033&osm_id=246291409&accept-language=en

        // Obter a relação da cidade
        // https://nominatim.openstreetmap.org/search.php?city=%C5%81%C3%B3d%C5%BA&format=json

        //https://nominatim.openstreetmap.org/search.php?city=%C5%81%C3%B3d%C5%BA&polygon_svg=1



        // Obter o reverso em polígonos
        // https://nominatim.openstreetmap.org/reverse?format=json&osm_id=1582777&osm_type=R&polygon_geojson=1

        private async void btnObterGeometria_Click(object sender, EventArgs e)
        {
            btnObterGeometria.Enabled = false;

            using HttpClient client = new();
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");

            Stream stream;
            try
            {
                stream = await client.GetStreamAsync(string.Format(_apiReversoPoligonosTerritorio, txtOsmId.Text));
            }
            catch (Exception ex)
            {
                btnObterGeometria.Enabled = true;
                return;
            }
            //string text;
            //using (StreamReader reader = new(stream, Encoding.UTF8))
            //{
            //    text = reader.ReadToEnd();
            //}

            StringBuilder sb = new();
            var enUS = new CultureInfo("en-US");

            var lista = await JsonSerializer.DeserializeAsync<RelacaoReverso>(stream);

            if (lista.geojson.type == "Polygon")
            {
                var coordinates = (JsonElement)lista.geojson.coordinates;

                foreach (var item in coordinates.EnumerateArray())
                {
                    sb.Append("Polygon((");
                    List<double> first = new();

                    int a = 0;
                    foreach (var item2 in item.EnumerateArray())
                    {
                        double lat = 0;
                        double lon = 0;

                        int i = 0;
                        foreach (var item3 in item2.EnumerateArray())
                        {
                            var value = item3.GetDouble();
                            switch (i)
                            {
                                case 0: lat = value; break;
                                case 1: lon = value; break;
                            }
                            i++;
                        }

                        if (a == 0)
                        {
                            first.Add(lat);
                            first.Add(lon);
                        }

                        sb.Append($"{lat.ToString(enUS)} {lon.ToString(enUS)},");
                        a++;
                    }

                    sb.Append($"{first[0].ToString(enUS)} {first[1].ToString(enUS)}))");
                    break;
                }
            }
            else if (lista.geojson.type == "MultiPolygon")
            {
                //90129

                var coordinates = (JsonElement)lista.geojson.coordinates;

                sb.Append("MultiPolygon(");

                foreach (var item0 in coordinates.EnumerateArray())
                {
                    sb.Append("((");
                    foreach (var item1 in item0.EnumerateArray())
                    {
                        List<double> first = new();

                        int a = 0;
                        foreach (var item2 in item1.EnumerateArray())
                        {
                            double lat = 0;
                            double lon = 0;

                            int i = 0;
                            foreach (var item3 in item2.EnumerateArray())
                            {
                                var value = item3.GetDouble();
                                switch (i)
                                {
                                    case 0: lat = value; break;
                                    case 1: lon = value; break;
                                }
                                i++;
                            }

                            if (a == 0)
                            {
                                first.Add(lat);
                                first.Add(lon);
                            }

                            sb.Append($"{lat.ToString(enUS)} {lon.ToString(enUS)},");
                            a++;
                        }
                        sb = sb.Remove(sb.Length - 1, 1);
                    }
                    sb.Append(")),");
                }

                sb = sb.Remove(sb.Length - 1, 1);
                sb.Append(')');
            }
            else
                throw new NotImplementedException(lista.geojson.type);

            string final = sb.ToString();

            if (btnAtualizarBancoDeDados.Enabled)
                txtGeometria.Text = final;
            else
                geometria_robo = final;
                
            btnObterGeometria.Enabled = true;
        }

        private async void btnCarregarMunicipios_Click(object sender, EventArgs e)
        {
            btnCarregarMunicipios.Enabled = false;

            string endpoint = $"{datasintese}/v2/datatarget/parametros?tipo=pessoasjuridicas&descricao=municipio";

            using HttpClient client = new();
            client.DefaultRequestHeaders.Add("X_Auth_Cpf", "02857455143");
            client.DefaultRequestHeaders.Add("X_Auth_Token", "b88575b9cfcc94888696c739a8a37d53");

            var stream = await client.GetStreamAsync(endpoint);
            var lista = await JsonSerializer.DeserializeAsync<List<Parametro>>(stream);

            listBox1.BeginUpdate();
            listBox1.DataSource = lista[0].valores;
            listBox1.EndUpdate();

            btnCarregarMunicipios.Enabled = true;
        }

        private async void btnObterRelacoes_Click(object sender, EventArgs e)
        {
            btnObterRelacoes.Enabled = false;
            geometria_robo = "";

            int tipoSearch = 1;
            using HttpClient client = new();

        Repetir:
            
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");

            Stream stream;
            if (tipoSearch == 1)
            {
                stream = await client.GetStreamAsync(string.Format(_apiReversoRelacaoTerritorio, listBox1.Text[3..]));
            }
            else
            {
                stream = await client.GetStreamAsync(string.Format(_apiReversoRelacaoTerritorio2, $"{listBox1.Text[3..]} {txtEstado.Text}" ));
            }

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
                if (listView1.Items.Count > 0) listView1.Items[0].Selected = true;

                var relation = listView1.Items.Cast<ListViewItem>().Where(x => 
                    x.SubItems.Cast<ListViewSubItem>().Where(y => y.Text == "relation").Any() &&                    // Tipo Relação
                    x.SubItems.Cast<ListViewSubItem>().Where(y => y.Text.ToUpper().Contains(txtEstado.Text + ",")   // Aumenta precisão usando o nome do Estado
                    ).Any()
                    ).Select(x => x.SubItems.Cast<ListViewSubItem>()).ToList();

                if (relation.Any())
                {
                    osm_id = relation.First().Skip(1).First().Text;
                    lat = relation.First().Skip(3).First().Text;
                    lon = relation.First().Skip(4).First().Text;
                }
                else
                {
                    if (tipoSearch == 1)
                    {
                        tipoSearch = 2;
                        goto Repetir;
                    }
                    else if (tipoSearch == 2 && relation.Count == 0)
                    {
                        var ponto = listView1.Items.Cast<ListViewItem>().Where(x =>
                            x.SubItems.Cast<ListViewSubItem>().Where(y => y.Text == "node").Any() &&                        // Tipo Relação
                            x.SubItems.Cast<ListViewSubItem>().Where(y => y.Text.ToUpper().Contains(txtEstado.Text + ",")   // Aumenta precisão usando o nome do Estado
                            ).Any()
                            ).Select(x => x.SubItems.Cast<ListViewSubItem>()).ToList();

                        if (ponto.Any())
                        {
                            lat = ponto.First().Skip(3).First().Text;
                            lon = ponto.First().Skip(4).First().Text;
                            geometria_robo = $"POINT({lon} {lat})";
                        }
                    }
                }
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

        private async void btnAtualizarBancoDeDados_Click(object sender, EventArgs e)
        {
            btnAtualizarBancoDeDados.Enabled = false;
            
            string stringConnection = "Server=148.72.158.153;Uid=root;Pwd=Ds2311teste123#;SslMode=Required;AllowPublicKeyRetrieval=false;Pooling=True;MinimumPoolSize=1;maximumpoolsize=1;ConnectionLifeTime=60;Default Command Timeout=120;ServerRSAPublicKeyFile=mysql.pem;AllowUserVariables=True;";
            await using MySqlConnection con = new (stringConnection);
            await con.OpenAsync();

            chkAutoCarregarRelacoes.Checked = true;

            int i = 0;
            if (listBox1.SelectedItems.Count > 0)
            {
                i = listBox1.SelectedIndices[0];
                btnObterRelacoes_Click(sender, e);
            }

            for (; i < listBox1.Items.Count; i++)
            {
                listBox1.SelectedItem = listBox1.Items[i];

                string uf = txtUF.Text;
                string mun = listBox1.Text[3..];

                await Task.Run(async () => {
                    while (!btnObterRelacoes.Enabled)
                    {
                        await Task.Delay(10);
                    }
                });

                btnObterGeometria_Click(sender, e);

                await Task.Run(async () => {
                    while (!btnObterGeometria.Enabled)
                    {
                        await Task.Delay(10);
                    }
                });

                var com = con.CreateCommand();
                com.CommandText =
                    @"INSERT INTO `sandbox_v1_ds_consulta_dados`.`mapa`
                    (
                    `osm_id`,
                    `tipo`,
                    `uf`,
                    `codigo_municipio`,
                    `municipio`,
                    `latitude`,
                    `longitude`,
                    `geometria`)
                VALUES
                    (
                    " + txtOsmId.Text + @",
                    'MUNICIPIO',
                    '" + uf + @"',
                    NULL,
                    '" + mun + @"',
                    " + lat + @",
                    " + lon + @",
                    ST_GeomFromText('" + geometria_robo + @"')
                );";

                int afetados = await com.ExecuteNonQueryAsync();

                // await Task.Delay(1000);
            }

            btnAtualizarBancoDeDados.Enabled = true;
        }
    }
}