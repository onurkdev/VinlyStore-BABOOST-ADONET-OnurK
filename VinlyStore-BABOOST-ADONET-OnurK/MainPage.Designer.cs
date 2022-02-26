namespace VinlyStore_BABOOST_ADONET_OnurK
{
    partial class MainPage
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Bestseller = new System.Windows.Forms.TabPage();
            this.BestSellersWithArtists = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.albumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newArtistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artistListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.top10 = new System.Windows.Forms.TabPage();
            this.cheap15 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.Bestseller.SuspendLayout();
            this.BestSellersWithArtists.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.top10.SuspendLayout();
            this.cheap15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Bestseller);
            this.tabControl1.Controls.Add(this.BestSellersWithArtists);
            this.tabControl1.Controls.Add(this.top10);
            this.tabControl1.Controls.Add(this.cheap15);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // Bestseller
            // 
            this.Bestseller.Controls.Add(this.dataGridView1);
            this.Bestseller.Location = new System.Drawing.Point(4, 22);
            this.Bestseller.Name = "Bestseller";
            this.Bestseller.Padding = new System.Windows.Forms.Padding(3);
            this.Bestseller.Size = new System.Drawing.Size(792, 400);
            this.Bestseller.TabIndex = 0;
            this.Bestseller.Text = "Best Sellers";
            this.Bestseller.UseVisualStyleBackColor = true;
            // 
            // BestSellersWithArtists
            // 
            this.BestSellersWithArtists.Controls.Add(this.dataGridView2);
            this.BestSellersWithArtists.Location = new System.Drawing.Point(4, 22);
            this.BestSellersWithArtists.Name = "BestSellersWithArtists";
            this.BestSellersWithArtists.Padding = new System.Windows.Forms.Padding(3);
            this.BestSellersWithArtists.Size = new System.Drawing.Size(792, 400);
            this.BestSellersWithArtists.TabIndex = 1;
            this.BestSellersWithArtists.Text = "Best Sellers With Artists";
            this.BestSellersWithArtists.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.albumsToolStripMenuItem,
            this.artistsToolStripMenuItem,
            this.genresToolStripMenuItem,
            this.ordersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // albumsToolStripMenuItem
            // 
            this.albumsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAlbumToolStripMenuItem,
            this.albumInventoryToolStripMenuItem});
            this.albumsToolStripMenuItem.Name = "albumsToolStripMenuItem";
            this.albumsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.albumsToolStripMenuItem.Text = "Albums";
            // 
            // artistsToolStripMenuItem
            // 
            this.artistsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newArtistToolStripMenuItem,
            this.artistListToolStripMenuItem});
            this.artistsToolStripMenuItem.Name = "artistsToolStripMenuItem";
            this.artistsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.artistsToolStripMenuItem.Text = "Artists";
            // 
            // genresToolStripMenuItem
            // 
            this.genresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genreListToolStripMenuItem,
            this.searchByGenreToolStripMenuItem});
            this.genresToolStripMenuItem.Name = "genresToolStripMenuItem";
            this.genresToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.genresToolStripMenuItem.Text = "Genres";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderListToolStripMenuItem,
            this.newOrderToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // newAlbumToolStripMenuItem
            // 
            this.newAlbumToolStripMenuItem.Name = "newAlbumToolStripMenuItem";
            this.newAlbumToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newAlbumToolStripMenuItem.Text = "New Album";
            this.newAlbumToolStripMenuItem.Click += new System.EventHandler(this.newAlbumToolStripMenuItem_Click);
            // 
            // albumInventoryToolStripMenuItem
            // 
            this.albumInventoryToolStripMenuItem.Name = "albumInventoryToolStripMenuItem";
            this.albumInventoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.albumInventoryToolStripMenuItem.Text = "Album Inventory";
            this.albumInventoryToolStripMenuItem.Click += new System.EventHandler(this.albumInventoryToolStripMenuItem_Click);
            // 
            // newArtistToolStripMenuItem
            // 
            this.newArtistToolStripMenuItem.Name = "newArtistToolStripMenuItem";
            this.newArtistToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newArtistToolStripMenuItem.Text = "New Artist";
            this.newArtistToolStripMenuItem.Click += new System.EventHandler(this.newArtistToolStripMenuItem_Click);
            // 
            // artistListToolStripMenuItem
            // 
            this.artistListToolStripMenuItem.Name = "artistListToolStripMenuItem";
            this.artistListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.artistListToolStripMenuItem.Text = "Artist List";
            this.artistListToolStripMenuItem.Click += new System.EventHandler(this.artistListToolStripMenuItem_Click);
            // 
            // genreListToolStripMenuItem
            // 
            this.genreListToolStripMenuItem.Name = "genreListToolStripMenuItem";
            this.genreListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.genreListToolStripMenuItem.Text = "Genre List";
            this.genreListToolStripMenuItem.Click += new System.EventHandler(this.genreListToolStripMenuItem_Click);
            // 
            // searchByGenreToolStripMenuItem
            // 
            this.searchByGenreToolStripMenuItem.Name = "searchByGenreToolStripMenuItem";
            this.searchByGenreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchByGenreToolStripMenuItem.Text = "Search by Genre";
            this.searchByGenreToolStripMenuItem.Click += new System.EventHandler(this.searchByGenreToolStripMenuItem_Click);
            // 
            // orderListToolStripMenuItem
            // 
            this.orderListToolStripMenuItem.Name = "orderListToolStripMenuItem";
            this.orderListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.orderListToolStripMenuItem.Text = "Order List";
            this.orderListToolStripMenuItem.Click += new System.EventHandler(this.orderListToolStripMenuItem_Click);
            // 
            // newOrderToolStripMenuItem
            // 
            this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newOrderToolStripMenuItem.Text = "New Order";
            this.newOrderToolStripMenuItem.Click += new System.EventHandler(this.newOrderToolStripMenuItem_Click);
            // 
            // top10
            // 
            this.top10.Controls.Add(this.dataGridView3);
            this.top10.Location = new System.Drawing.Point(4, 22);
            this.top10.Name = "top10";
            this.top10.Size = new System.Drawing.Size(792, 400);
            this.top10.TabIndex = 2;
            this.top10.Text = "Top 10";
            this.top10.UseVisualStyleBackColor = true;
            // 
            // cheap15
            // 
            this.cheap15.Controls.Add(this.dataGridView4);
            this.cheap15.Location = new System.Drawing.Point(4, 22);
            this.cheap15.Name = "cheap15";
            this.cheap15.Size = new System.Drawing.Size(792, 400);
            this.cheap15.TabIndex = 3;
            this.cheap15.Text = "Top 15 Deals";
            this.cheap15.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 394);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(786, 394);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(792, 400);
            this.dataGridView3.TabIndex = 1;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(792, 400);
            this.dataGridView4.TabIndex = 1;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.tabControl1.ResumeLayout(false);
            this.Bestseller.ResumeLayout(false);
            this.BestSellersWithArtists.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.top10.ResumeLayout(false);
            this.cheap15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Bestseller;
        private System.Windows.Forms.TabPage BestSellersWithArtists;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem albumsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artistsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newArtistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artistListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByGenreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage top10;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage cheap15;
        private System.Windows.Forms.DataGridView dataGridView4;
    }
}