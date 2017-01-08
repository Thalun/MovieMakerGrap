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
        public MainWindow()
        {

            // initilize global variables
            String tSourceWlmp = String.Empty;
            String tTargetFolder = String.Empty;

            Int64 iMove = 0;
            Int64 iAudio = 0;
            Int64 iPicture = 0;
            
            InitializeComponent();

            // Initilize the Text Box
            tAudio.Text = Convert.ToString(iAudio);
            tMovie.Text = Convert.ToString(iMove);
            tPicture.Text = Convert.ToString(iPicture);

        }
    }
}
