using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinlyStore_BABOOST_ADONET_OnurK.Entities;

namespace VinlyStore_BABOOST_ADONET_OnurK
{
    public partial class MainPage : Form
    {
        public User LoggedInUser;
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            LoggedInUser = new User();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void albumInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newArtistToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void artistListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void genreListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchByGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void orderListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
