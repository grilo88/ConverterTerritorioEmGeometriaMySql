namespace ConverterTerritorioEmGeometriaMySql
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnObterGeometria = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCarregarMunicipios = new System.Windows.Forms.Button();
            this.btnObterRelacoes = new System.Windows.Forms.Button();
            this.txtGeometria = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.chkAutoCarregarRelacoes = new System.Windows.Forms.CheckBox();
            this.btnAbrirMapa = new System.Windows.Forms.Button();
            this.txtOsmId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnAtualizarBancoDeDados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnObterGeometria
            // 
            this.btnObterGeometria.Location = new System.Drawing.Point(307, 408);
            this.btnObterGeometria.Name = "btnObterGeometria";
            this.btnObterGeometria.Size = new System.Drawing.Size(244, 23);
            this.btnObterGeometria.TabIndex = 0;
            this.btnObterGeometria.Text = "Obter Geometria";
            this.btnObterGeometria.UseVisualStyleBackColor = true;
            this.btnObterGeometria.Click += new System.EventHandler(this.btnObterGeometria_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(279, 634);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnCarregarMunicipios
            // 
            this.btnCarregarMunicipios.Location = new System.Drawing.Point(307, 12);
            this.btnCarregarMunicipios.Name = "btnCarregarMunicipios";
            this.btnCarregarMunicipios.Size = new System.Drawing.Size(244, 23);
            this.btnCarregarMunicipios.TabIndex = 2;
            this.btnCarregarMunicipios.Text = "Carregar Municípios";
            this.btnCarregarMunicipios.UseVisualStyleBackColor = true;
            this.btnCarregarMunicipios.Click += new System.EventHandler(this.btnCarregarMunicipios_Click);
            // 
            // btnObterRelacoes
            // 
            this.btnObterRelacoes.Location = new System.Drawing.Point(307, 41);
            this.btnObterRelacoes.Name = "btnObterRelacoes";
            this.btnObterRelacoes.Size = new System.Drawing.Size(244, 23);
            this.btnObterRelacoes.TabIndex = 3;
            this.btnObterRelacoes.Text = "Obter Relacões";
            this.btnObterRelacoes.UseVisualStyleBackColor = true;
            this.btnObterRelacoes.Click += new System.EventHandler(this.btnObterRelacoes_Click);
            // 
            // txtGeometria
            // 
            this.txtGeometria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGeometria.Location = new System.Drawing.Point(307, 437);
            this.txtGeometria.Multiline = true;
            this.txtGeometria.Name = "txtGeometria";
            this.txtGeometria.Size = new System.Drawing.Size(937, 233);
            this.txtGeometria.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(307, 70);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(937, 332);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "place_id";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "osm_id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "osm_type";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "lat";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "lon";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "display";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "class";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "type";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "importante";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "icon";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "license";
            // 
            // chkAutoCarregarRelacoes
            // 
            this.chkAutoCarregarRelacoes.AutoSize = true;
            this.chkAutoCarregarRelacoes.Location = new System.Drawing.Point(557, 44);
            this.chkAutoCarregarRelacoes.Name = "chkAutoCarregarRelacoes";
            this.chkAutoCarregarRelacoes.Size = new System.Drawing.Size(100, 19);
            this.chkAutoCarregarRelacoes.TabIndex = 7;
            this.chkAutoCarregarRelacoes.Text = "Auto Carregar";
            this.chkAutoCarregarRelacoes.UseVisualStyleBackColor = true;
            // 
            // btnAbrirMapa
            // 
            this.btnAbrirMapa.Location = new System.Drawing.Point(735, 40);
            this.btnAbrirMapa.Name = "btnAbrirMapa";
            this.btnAbrirMapa.Size = new System.Drawing.Size(156, 23);
            this.btnAbrirMapa.TabIndex = 8;
            this.btnAbrirMapa.Text = "Abrir Mapa";
            this.btnAbrirMapa.UseVisualStyleBackColor = true;
            this.btnAbrirMapa.Click += new System.EventHandler(this.btnAbrirMapa_Click);
            // 
            // txtOsmId
            // 
            this.txtOsmId.Location = new System.Drawing.Point(642, 408);
            this.txtOsmId.Name = "txtOsmId";
            this.txtOsmId.ReadOnly = true;
            this.txtOsmId.Size = new System.Drawing.Size(113, 23);
            this.txtOsmId.TabIndex = 9;
            this.txtOsmId.Text = "0";
            this.txtOsmId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "OSM_ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(781, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "UF:";
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(811, 408);
            this.txtUF.Name = "txtUF";
            this.txtUF.ReadOnly = true;
            this.txtUF.Size = new System.Drawing.Size(53, 23);
            this.txtUF.TabIndex = 11;
            this.txtUF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(874, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Estado:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(925, 408);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(125, 23);
            this.txtEstado.TabIndex = 13;
            this.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAtualizarBancoDeDados
            // 
            this.btnAtualizarBancoDeDados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizarBancoDeDados.Location = new System.Drawing.Point(1048, 40);
            this.btnAtualizarBancoDeDados.Name = "btnAtualizarBancoDeDados";
            this.btnAtualizarBancoDeDados.Size = new System.Drawing.Size(196, 23);
            this.btnAtualizarBancoDeDados.TabIndex = 15;
            this.btnAtualizarBancoDeDados.Text = "Atualizar Banco de Dados";
            this.btnAtualizarBancoDeDados.UseVisualStyleBackColor = true;
            this.btnAtualizarBancoDeDados.Click += new System.EventHandler(this.btnAtualizarBancoDeDados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 696);
            this.Controls.Add(this.btnAtualizarBancoDeDados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOsmId);
            this.Controls.Add(this.btnAbrirMapa);
            this.Controls.Add(this.chkAutoCarregarRelacoes);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtGeometria);
            this.Controls.Add(this.btnObterRelacoes);
            this.Controls.Add(this.btnCarregarMunicipios);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnObterGeometria);
            this.Name = "Form1";
            this.Text = "Gerador de Mapas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnObterGeometria;
        private ListBox listBox1;
        private Button btnCarregarMunicipios;
        private Button btnObterRelacoes;
        private TextBox txtGeometria;
        private ListView listView1;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private CheckBox chkAutoCarregarRelacoes;
        private Button btnAbrirMapa;
        private TextBox txtOsmId;
        private Label label1;
        private Label label2;
        private TextBox txtUF;
        private Label label3;
        private TextBox txtEstado;
        private Button btnAtualizarBancoDeDados;
    }
}