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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lvKategorier = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKategori = new System.Windows.Forms.TextBox();
            this.btnNyKategori = new System.Windows.Forms.Button();
            this.btnSparaKategori = new System.Windows.Forms.Button();
            this.btnTabortKategori = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvPodcasts
            // 
            this.lvPodcasts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Namn,
            this.Kategori,
            this.Avsnitt,
            this.Frekvens});
            this.lvPodcasts.Location = new System.Drawing.Point(16, 12);
            this.lvPodcasts.Name = "lvPodcasts";
            this.lvPodcasts.Size = new System.Drawing.Size(486, 233);
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
            this.tbUrl.Location = new System.Drawing.Point(12, 285);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(194, 22);
            this.tbUrl.TabIndex = 1;
            // 
            // cbUpdFreq
            // 
            this.cbUpdFreq.FormattingEnabled = true;
            this.cbUpdFreq.Items.AddRange(new object[] {
            "1 minut",
            "5 minuter",
            "10 minuter",
            "30 minuter"});
            this.cbUpdFreq.Location = new System.Drawing.Point(220, 285);
            this.cbUpdFreq.Name = "cbUpdFreq";
            this.cbUpdFreq.Size = new System.Drawing.Size(144, 24);
            this.cbUpdFreq.TabIndex = 2;
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(377, 285);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(121, 24);
            this.cbKategori.TabIndex = 3;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(12, 257);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(40, 17);
            this.lblUrl.TabIndex = 4;
            this.lblUrl.Text = "URL:";
            // 
            // lblUFrekvens
            // 
            this.lblUFrekvens.AutoSize = true;
            this.lblUFrekvens.Location = new System.Drawing.Point(217, 257);
            this.lblUFrekvens.Name = "lblUFrekvens";
            this.lblUFrekvens.Size = new System.Drawing.Size(151, 17);
            this.lblUFrekvens.TabIndex = 5;
            this.lblUFrekvens.Text = "Uppdateringsfrekvens:";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(374, 257);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(65, 17);
            this.lblKategori.TabIndex = 6;
            this.lblKategori.Text = "Kategori:";
            // 
            // btnNyPodcast
            // 
            this.btnNyPodcast.Location = new System.Drawing.Point(108, 328);
            this.btnNyPodcast.Name = "btnNyPodcast";
            this.btnNyPodcast.Size = new System.Drawing.Size(91, 23);
            this.btnNyPodcast.TabIndex = 7;
            this.btnNyPodcast.Text = "Ny...";
            this.btnNyPodcast.UseVisualStyleBackColor = true;
            this.btnNyPodcast.Click += new System.EventHandler(this.btnNyPodcast_Click);
            // 
            // btnSparaPodcast
            // 
            this.btnSparaPodcast.Location = new System.Drawing.Point(205, 328);
            this.btnSparaPodcast.Name = "btnSparaPodcast";
            this.btnSparaPodcast.Size = new System.Drawing.Size(92, 23);
            this.btnSparaPodcast.TabIndex = 8;
            this.btnSparaPodcast.Text = "Spara";
            this.btnSparaPodcast.UseVisualStyleBackColor = true;
            // 
            // btnTabortPodcast
            // 
            this.btnTabortPodcast.Location = new System.Drawing.Point(303, 328);
            this.btnTabortPodcast.Name = "btnTabortPodcast";
            this.btnTabortPodcast.Size = new System.Drawing.Size(92, 23);
            this.btnTabortPodcast.TabIndex = 9;
            this.btnTabortPodcast.Text = "Ta bort";
            this.btnTabortPodcast.UseVisualStyleBackColor = true;
            // 
            // lvAvsnitt
            // 
            this.lvAvsnitt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvAvsnitt.Location = new System.Drawing.Point(12, 389);
            this.lvAvsnitt.Name = "lvAvsnitt";
            this.lvAvsnitt.Size = new System.Drawing.Size(486, 157);
            this.lvAvsnitt.TabIndex = 10;
            this.lvAvsnitt.UseCompatibleStateImageBehavior = false;
            this.lvAvsnitt.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Podcast";
            this.columnHeader1.Width = 132;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Titel";
            this.columnHeader2.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Avsnitt";
            // 
            // lvKategorier
            // 
            this.lvKategorier.Location = new System.Drawing.Point(565, 44);
            this.lvKategorier.Name = "lvKategorier";
            this.lvKategorier.Size = new System.Drawing.Size(374, 201);
            this.lvKategorier.TabIndex = 12;
            this.lvKategorier.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(562, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kategorier:";
            // 
            // tbKategori
            // 
            this.tbKategori.Location = new System.Drawing.Point(565, 254);
            this.tbKategori.Name = "tbKategori";
            this.tbKategori.Size = new System.Drawing.Size(374, 22);
            this.tbKategori.TabIndex = 14;
            // 
            // btnNyKategori
            // 
            this.btnNyKategori.Location = new System.Drawing.Point(611, 287);
            this.btnNyKategori.Name = "btnNyKategori";
            this.btnNyKategori.Size = new System.Drawing.Size(92, 23);
            this.btnNyKategori.TabIndex = 15;
            this.btnNyKategori.Text = "Ny...";
            this.btnNyKategori.UseVisualStyleBackColor = true;
            // 
            // btnSparaKategori
            // 
            this.btnSparaKategori.Location = new System.Drawing.Point(709, 287);
            this.btnSparaKategori.Name = "btnSparaKategori";
            this.btnSparaKategori.Size = new System.Drawing.Size(92, 23);
            this.btnSparaKategori.TabIndex = 16;
            this.btnSparaKategori.Text = "Spara";
            this.btnSparaKategori.UseVisualStyleBackColor = true;
            // 
            // btnTabortKategori
            // 
            this.btnTabortKategori.Location = new System.Drawing.Point(807, 287);
            this.btnTabortKategori.Name = "btnTabortKategori";
            this.btnTabortKategori.Size = new System.Drawing.Size(92, 23);
            this.btnTabortKategori.TabIndex = 17;
            this.btnTabortKategori.Text = "Ta bort";
            this.btnTabortKategori.UseVisualStyleBackColor = true;
            this.btnTabortKategori.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(539, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 2);
            this.label3.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(532, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 535);
            this.label4.TabIndex = 19;
            // 
            // PodcastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 558);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTabortKategori);
            this.Controls.Add(this.btnSparaKategori);
            this.Controls.Add(this.btnNyKategori);
            this.Controls.Add(this.tbKategori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvKategorier);
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
            this.Name = "PodcastForm";
            this.Text = "Podcastlista";
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
        private System.Windows.Forms.ListView lvKategorier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKategori;
        private System.Windows.Forms.Button btnNyKategori;
        private System.Windows.Forms.Button btnSparaKategori;
        private System.Windows.Forms.Button btnTabortKategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

