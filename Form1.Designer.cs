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
            this.btnObterTerritorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnObterTerritorio
            // 
            this.btnObterTerritorio.Location = new System.Drawing.Point(281, 116);
            this.btnObterTerritorio.Name = "btnObterTerritorio";
            this.btnObterTerritorio.Size = new System.Drawing.Size(190, 23);
            this.btnObterTerritorio.TabIndex = 0;
            this.btnObterTerritorio.Text = "Obter Território Goiânia";
            this.btnObterTerritorio.UseVisualStyleBackColor = true;
            this.btnObterTerritorio.Click += new System.EventHandler(this.btnObterTerritorio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObterTerritorio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnObterTerritorio;
    }
}