namespace Projekt_17_Podcast
{
    partial class PodcastForm

    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvPodcasts = new System.Windows.Forms.ListView();
            this.Namn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Avsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Frekvens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.cbUpdFreq = new System.Windows.Forms.ComboBox();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblUFrekvens = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.btnNyPodcast = new System.Windows.Forms.Button();
            this.btnSparaPodcast = new System.Windows.Forms.Button();
            this.btnTabortPodcast = new System.Windows.Forms.Button();
            this.lvAvsnitt = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKategori = new System.Windows.Forms.TextBox();
            this.btnNyKategori = new System.Windows.Forms.Button();
            this.btnSparaKategori = new System.Windows.Forms.Button();
            this.btnTabortKategori = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbBeskrivning = new System.Windows.Forms.RichTextBox();
            this.lbKategorier = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lvPodcasts
            // 
            this.lvPodcasts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Namn,
            this.Kategori,
            this.Avsnitt,
            this.Frekvens});
            this.lvPodcasts.Location = new System.Drawing.Point(18, 15);
            this.lvPodcasts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvPodcasts.Name = "lvPodcasts";
            this.lvPodcasts.Size = new System.Drawing.Size(546, 290);
            this.lvPodcasts.TabIndex = 0;
            this.lvPodcasts.UseCompatibleStateImageBehavior = false;
            this.lvPodcasts.View = System.Windows.Forms.View.Details;
            this.lvPodcasts.ItemActivate += new System.EventHandler(this.lvPodcasts_ItemActivate);
            // 
            // Namn
            // 
            this.Namn.Text = "Namn";
            this.Namn.Width = 100;
            // 
            // Kategori
            // 
            this.Kategori.Text = "Kategori";
            // 
            // Avsnitt
            // 
            this.Avsnitt.Text = "Avsnitt";
            // 
            // Frekvens
            // 
            this.Frekvens.Text = "Frekvens";
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(14, 356);
            this.tbUrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(218, 26);
            this.tbUrl.TabIndex = 1;
            // 
            // cbUpdFreq
            // 
            this.cbUpdFreq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUpdFreq.FormattingEnabled = true;
            this.cbUpdFreq.Items.AddRange(new object[] {
            "2 minuter",
            "5 minuter",
            "10 minuter",
            "30 minuter"});
            this.cbUpdFreq.Location = new System.Drawing.Point(248, 356);
            this.cbUpdFreq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbUpdFreq.Name = "cbUpdFreq";
            this.cbUpdFreq.Size = new System.Drawing.Size(162, 28);
            this.cbUpdFreq.TabIndex = 2;
            // 
            // cbKategori
            // 
            this.cbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(424, 356);
            this.cbKategori.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(136, 28);
            this.cbKategori.TabIndex = 3;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(14, 321);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(46, 20);
            this.lblUrl.TabIndex = 4;
            this.lblUrl.Text = "URL:";
            // 
            // lblUFrekvens
            // 
            this.lblUFrekvens.AutoSize = true;
            this.lblUFrekvens.Location = new System.Drawing.Point(244, 321);
            this.lblUFrekvens.Name = "lblUFrekvens";
            this.lblUFrekvens.Size = new System.Drawing.Size(169, 20);
            this.lblUFrekvens.TabIndex = 5;
            this.lblUFrekvens.Text = "Uppdateringsfrekvens:";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(421, 321);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(72, 20);
            this.lblKategori.TabIndex = 6;
            this.lblKategori.Text = "Kategori:";
            // 
            // btnNyPodcast
            // 
            this.btnNyPodcast.Location = new System.Drawing.Point(122, 410);
            this.btnNyPodcast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNyPodcast.Name = "btnNyPodcast";
            this.btnNyPodcast.Size = new System.Drawing.Size(102, 29);
            this.btnNyPodcast.TabIndex = 7;
            this.btnNyPodcast.Text = "Ny...";
            this.btnNyPodcast.UseVisualStyleBackColor = true;
            this.btnNyPodcast.Click += new System.EventHandler(this.btnNyPodcast_Click);
            // 
            // btnSparaPodcast
            // 
            this.btnSparaPodcast.Location = new System.Drawing.Point(231, 410);
            this.btnSparaPodcast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSparaPodcast.Name = "btnSparaPodcast";
            this.btnSparaPodcast.Size = new System.Drawing.Size(104, 29);
            this.btnSparaPodcast.TabIndex = 8;
            this.btnSparaPodcast.Text = "Spara";
            this.btnSparaPodcast.UseVisualStyleBackColor = true;
            this.btnSparaPodcast.Click += new System.EventHandler(this.btnSparaPodcast_Click);
            // 
            // btnTabortPodcast
            // 
            this.btnTabortPodcast.Location = new System.Drawing.Point(341, 410);
            this.btnTabortPodcast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTabortPodcast.Name = "btnTabortPodcast";
            this.btnTabortPodcast.Size = new System.Drawing.Size(104, 29);
            this.btnTabortPodcast.TabIndex = 9;
            this.btnTabortPodcast.Text = "Ta bort";
            this.btnTabortPodcast.UseVisualStyleBackColor = true;
            this.btnTabortPodcast.Click += new System.EventHandler(this.btnTabortPodcast_Click);
            // 
            // lvAvsnitt
            // 
            this.lvAvsnitt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lvAvsnitt.Location = new System.Drawing.Point(14, 486);
            this.lvAvsnitt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvAvsnitt.Name = "lvAvsnitt";
            this.lvAvsnitt.Size = new System.Drawing.Size(546, 195);
            this.lvAvsnitt.TabIndex = 10;
            this.lvAvsnitt.UseCompatibleStateImageBehavior = false;
            this.lvAvsnitt.View = System.Windows.Forms.View.Details;
            this.lvAvsnitt.ItemActivate += new System.EventHandler(this.lvAvsnitt_ItemActivate);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Titel";
            this.columnHeader2.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Avsnitt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kategorier:";
            // 
            // tbKategori
            // 
            this.tbKategori.Location = new System.Drawing.Point(636, 318);
            this.tbKategori.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbKategori.Name = "tbKategori";
            this.tbKategori.Size = new System.Drawing.Size(420, 26);
            this.tbKategori.TabIndex = 14;
            // 
            // btnNyKategori
            // 
            this.btnNyKategori.Location = new System.Drawing.Point(687, 359);
            this.btnNyKategori.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNyKategori.Name = "btnNyKategori";
            this.btnNyKategori.Size = new System.Drawing.Size(104, 29);
            this.btnNyKategori.TabIndex = 15;
            this.btnNyKategori.Text = "Ny...";
            this.btnNyKategori.UseVisualStyleBackColor = true;
            this.btnNyKategori.Click += new System.EventHandler(this.btnNyKategori_Click);
            // 
            // btnSparaKategori
            // 
            this.btnSparaKategori.Location = new System.Drawing.Point(798, 359);
            this.btnSparaKategori.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSparaKategori.Name = "btnSparaKategori";
            this.btnSparaKategori.Size = new System.Drawing.Size(104, 29);
            this.btnSparaKategori.TabIndex = 16;
            this.btnSparaKategori.Text = "Spara";
            this.btnSparaKategori.UseVisualStyleBackColor = true;
            this.btnSparaKategori.Click += new System.EventHandler(this.btnSparaKategori_Click);
            // 
            // btnTabortKategori
            // 
            this.btnTabortKategori.Location = new System.Drawing.Point(908, 359);
            this.btnTabortKategori.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTabortKategori.Name = "btnTabortKategori";
            this.btnTabortKategori.Size = new System.Drawing.Size(104, 29);
            this.btnTabortKategori.TabIndex = 17;
            this.btnTabortKategori.Text = "Ta bort";
            this.btnTabortKategori.UseVisualStyleBackColor = true;
            this.btnTabortKategori.Click += new System.EventHandler(this.btnTabortKategori_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(606, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(450, 2);
            this.label3.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(598, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 669);
            this.label4.TabIndex = 19;
            // 
            // rtbBeskrivning
            // 
            this.rtbBeskrivning.Location = new System.Drawing.Point(636, 439);
            this.rtbBeskrivning.Name = "rtbBeskrivning";
            this.rtbBeskrivning.Size = new System.Drawing.Size(420, 242);
            this.rtbBeskrivning.TabIndex = 20;
            this.rtbBeskrivning.Text = "";
            // 
            // lbKategorier
            // 
            this.lbKategorier.FormattingEnabled = true;
            this.lbKategorier.ItemHeight = 20;
            this.lbKategorier.Location = new System.Drawing.Point(636, 39);
            this.lbKategorier.Name = "lbKategorier";
            this.lbKategorier.Size = new System.Drawing.Size(420, 264);
            this.lbKategorier.TabIndex = 21;
            this.lbKategorier.SelectedIndexChanged += new System.EventHandler(this.lbKategorier_SelectedIndexChanged);
            this.lbKategorier.Leave += new System.EventHandler(this.lbKategorier_Leave);
            // 
            // PodcastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 698);
            this.Controls.Add(this.lbKategorier);
            this.Controls.Add(this.rtbBeskrivning);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTabortKategori);
            this.Controls.Add(this.btnSparaKategori);
            this.Controls.Add(this.btnNyKategori);
            this.Controls.Add(this.tbKategori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvAvsnitt);
            this.Controls.Add(this.btnTabortPodcast);
            this.Controls.Add(this.btnSparaPodcast);
            this.Controls.Add(this.btnNyPodcast);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblUFrekvens);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.cbUpdFreq);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.lvPodcasts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PodcastForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podcastlista";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PodcastForm_FormClosing);
            this.Load += new System.EventHandler(this.PodcastForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvPodcasts;
        private System.Windows.Forms.ColumnHeader Avsnitt;
        private System.Windows.Forms.ColumnHeader Namn;
        private System.Windows.Forms.ColumnHeader Frekvens;
        private System.Windows.Forms.ColumnHeader Kategori;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.ComboBox cbUpdFreq;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblUFrekvens;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Button btnNyPodcast;
        private System.Windows.Forms.Button btnSparaPodcast;
        private System.Windows.Forms.Button btnTabortPodcast;
        private System.Windows.Forms.ListView lvAvsnitt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKategori;
        private System.Windows.Forms.Button btnNyKategori;
        private System.Windows.Forms.Button btnSparaKategori;
        private System.Windows.Forms.Button btnTabortKategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.RichTextBox rtbBeskrivning;
        private System.Windows.Forms.ListBox lbKategorier;
    }
}

