﻿namespace ConverterTerritorioEmGeometriaMySql
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
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.btnObterGeometria.Click += new System.EventHandler(this.btnObterTerritorio_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(279, 559);
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
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(307, 437);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(926, 143);
            this.textBox2.TabIndex = 5;
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
            this.listView1.Size = new System.Drawing.Size(926, 332);
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
            this.btnAbrirMapa.Location = new System.Drawing.Point(849, 40);
            this.btnAbrirMapa.Name = "btnAbrirMapa";
            this.btnAbrirMapa.Size = new System.Drawing.Size(156, 23);
            this.btnAbrirMapa.TabIndex = 8;
            this.btnAbrirMapa.Text = "Abrir Mapa";
            this.btnAbrirMapa.UseVisualStyleBackColor = true;
            this.btnAbrirMapa.Click += new System.EventHandler(this.btnAbrirMapa_Click);
            // 
            // txtOsmId
            // 
            this.txtOsmId.Location = new System.Drawing.Point(700, 408);
            this.txtOsmId.Name = "txtOsmId";
            this.txtOsmId.ReadOnly = true;
            this.txtOsmId.Size = new System.Drawing.Size(150, 23);
            this.txtOsmId.TabIndex = 9;
            this.txtOsmId.Text = "0";
            this.txtOsmId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(642, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "OSM_ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 606);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOsmId);
            this.Controls.Add(this.btnAbrirMapa);
            this.Controls.Add(this.chkAutoCarregarRelacoes);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox2);
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
        private TextBox textBox2;
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
    }
}