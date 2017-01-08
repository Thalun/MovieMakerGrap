using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieMakerGrapWlmp;

namespace MovieMakerGrap
{
    public partial class MainWindow : Form
    {
        // initilize global variables
        String tSourceWlmp = String.Empty;
        String tTargetFolder = String.Empty;

        wlmp mywlmp = new wlmp();

        public MainWindow()
        {
            InitializeComponent();

            // Initilize the Text Box
            tAudio.Text = Convert.ToString(mywlmp.iAudio);
            tMovie.Text = Convert.ToString(mywlmp.iMove);
            tPicture.Text = Convert.ToString(mywlmp.iPicture);
        }

        private void bSelectWlmp_Click(object sender, EventArgs e)
        {
            // Select a Microsoft Movie Maker Project File
            mywlmp.SelectSourceFile (mywlmp);            
            if (mywlmp.strSourceFile != String.Empty)
            {
                textBoxWlmp.Text = mywlmp.strSourceFile;
            }
        }

        private void bSelectFolder_Click(object sender, EventArgs e)
        {
            // Select the folder to store your collected media
            mywlmp.SelectDestinationFolder(mywlmp);
            if (mywlmp.strDestinationFolder != String.Empty)
            {
                textBoxPath2Store.Text = mywlmp.strDestinationFolder;
            }
        }
    }
}