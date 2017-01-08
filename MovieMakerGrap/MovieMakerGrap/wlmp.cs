using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieMakerGrapWlmp
{
    public class wlmp
    {
        public String name = String.Empty;
        public String strSourceFile = String.Empty;
        public String strDestinationFolder = String.Empty;
        public Int64 iMove = 0;
        public Int64 iAudio = 0;
        public Int64 iPicture = 0;

        public void SelectSourceFile (wlmp twlmp)
        {
            // Select a Microsoft Movie Maker Project File

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Movie Maker Project (*.wlmp) | *.wlmp";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                twlmp.strSourceFile = openFile.FileName;                
            }
            else { twlmp.strSourceFile = String.Empty; }
        }

        public void SelectDestinationFolder (wlmp twlmp)
        {
            // Select the folder to store your collected media

            FolderBrowserDialog selectFolder = new FolderBrowserDialog();
            selectFolder.Description = "Where do you want to collect your media files?";
            selectFolder.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            DialogResult objResult = selectFolder.ShowDialog();

            if (objResult == DialogResult.OK)
            {
                twlmp.strDestinationFolder = selectFolder.SelectedPath;
            }
            else
            {
                MessageBox.Show("You have aboard the Dialog !");
                twlmp.strDestinationFolder = String.Empty;
            }
        }
    }
}
