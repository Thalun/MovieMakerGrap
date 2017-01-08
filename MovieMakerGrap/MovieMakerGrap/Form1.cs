using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieMakerGrap
{

    public partial class MainWindow : Form
    {
        // initilize global variables
        String tSourceWlmp = String.Empty;
        String tTargetFolder = String.Empty;

        // initilize global variables
        Int64 iMove = 0;
        Int64 iAudio = 0;
        Int64 iPicture = 0;

        public MainWindow()
        {
           
            InitializeComponent();

            // Initilize the Text Box
            tAudio.Text = Convert.ToString(iAudio);
            tMovie.Text = Convert.ToString(iMove);
            tPicture.Text = Convert.ToString(iPicture);

        }

        private void bSelectWlmp_Click(object sender, EventArgs e)
        {
            // Select a Microsoft Movie maker Project File

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Movie Maker Project (*.wlmp) | *.wlmp";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                tSourceWlmp = openFile.FileName;
                textBoxWlmp.Text = openFile.FileName;
            }                
        }
    }
}