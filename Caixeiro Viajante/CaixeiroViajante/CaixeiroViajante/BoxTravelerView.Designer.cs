namespace CaixeiroViajante
{
    partial class BoxTravelerView
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSearch = new System.Windows.Forms.Button();
            this.richtxtboxCity = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richtxtboxStreet = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowserMaps = new System.Windows.Forms.WebBrowser();
            this.btnLatLong = new System.Windows.Forms.Button();
            this.richtxtboxLat = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richtxtboxLong = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.richtxtboxLong);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.richtxtboxLat);
            this.splitContainer1.Panel1.Controls.Add(this.btnLatLong);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.richtxtboxCity);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.richtxtboxStreet);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowserMaps);
            this.splitContainer1.Size = new System.Drawing.Size(713, 450);
            this.splitContainer1.SplitterDistance = 237;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(42, 74);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(126, 25);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // richtxtboxCity
            // 
            this.richtxtboxCity.Location = new System.Drawing.Point(42, 43);
            this.richtxtboxCity.Name = "richtxtboxCity";
            this.richtxtboxCity.Size = new System.Drawing.Size(126, 25);
            this.richtxtboxCity.TabIndex = 3;
            this.richtxtboxCity.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cidade:";
            // 
            // richtxtboxStreet
            // 
            this.richtxtboxStreet.Location = new System.Drawing.Point(42, 12);
            this.richtxtboxStreet.Name = "richtxtboxStreet";
            this.richtxtboxStreet.Size = new System.Drawing.Size(126, 25);
            this.richtxtboxStreet.TabIndex = 1;
            this.richtxtboxStreet.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rua:";
            // 
            // webBrowserMaps
            // 
            this.webBrowserMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserMaps.Location = new System.Drawing.Point(0, 0);
            this.webBrowserMaps.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserMaps.Name = "webBrowserMaps";
            this.webBrowserMaps.Size = new System.Drawing.Size(472, 450);
            this.webBrowserMaps.TabIndex = 0;
            // 
            // btnLatLong
            // 
            this.btnLatLong.Location = new System.Drawing.Point(42, 209);
            this.btnLatLong.Name = "btnLatLong";
            this.btnLatLong.Size = new System.Drawing.Size(126, 25);
            this.btnLatLong.TabIndex = 5;
            this.btnLatLong.Text = "Lat / Long";
            this.btnLatLong.UseVisualStyleBackColor = true;
            this.btnLatLong.Click += new System.EventHandler(this.btnLatLong_Click);
            // 
            // richtxtboxLat
            // 
            this.richtxtboxLat.Location = new System.Drawing.Point(42, 137);
            this.richtxtboxLat.Name = "richtxtboxLat";
            this.richtxtboxLat.Size = new System.Drawing.Size(126, 25);
            this.richtxtboxLat.TabIndex = 6;
            this.richtxtboxLat.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lat:";
            // 
            // richtxtboxLong
            // 
            this.richtxtboxLong.Location = new System.Drawing.Point(42, 168);
            this.richtxtboxLong.Name = "richtxtboxLong";
            this.richtxtboxLong.Size = new System.Drawing.Size(126, 25);
            this.richtxtboxLong.TabIndex = 8;
            this.richtxtboxLong.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Long:";
            // 
            // BoxTravelerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "BoxTravelerView";
            this.Text = "Traveling Salesman";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.WebBrowser webBrowserMaps;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RichTextBox richtxtboxCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richtxtboxStreet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLatLong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richtxtboxLong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richtxtboxLat;
    }
}

