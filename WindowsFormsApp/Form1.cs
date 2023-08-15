using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class wmp : Form
    {
        public wmp()
        {
            InitializeComponent();
        }
        ResourceManager rm = new ResourceManager("WindowsFormsApp.Resources", typeof(Program).Assembly);

        private void wmp_Load(object sender, EventArgs e)
        {
            listView.Dock = DockStyle.Fill;
            listView.View = View.SmallIcon;

            ImageList imageList = new ImageList();
            imageList.Images.Add(Properties.Resources.favicon);
            listView.SmallImageList = imageList;


            ListViewItem ffx = new ListViewItem("Upbeat", 0);
            ffx.ImageIndex = 0;
            listView.Items.Add(ffx);


            ListViewItem hud = new ListViewItem("HUD", 1);
            hud.ImageIndex = 0;
            listView.Items.Add(hud);

            ListViewItem upbeat = new ListViewItem("FFX", 2);
            upbeat.ImageIndex = 0;
            listView.Items.Add(upbeat);

            ListViewItem nat = new ListViewItem("Nat", 2);
            nat.ImageIndex = 0;
            listView.Items.Add(nat);

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filePath = string.Empty;

            // Check if an item is selected
            if (listView.SelectedItems.Count > 0)
            {
                int selected = listView.SelectedIndices[0];
                switch (selected)
                {
                    case 0:
                        filePath = "C:\\Users\\sakub\\Downloads\\upbeat.mp3";
                        axWindowsMediaPlayer1.URL = filePath;
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        break;
                    case 1:
                        filePath = "C:\\Users\\sakub\\Downloads\\hud.mp4";
                        axWindowsMediaPlayer1.URL = filePath;
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        break;
                    case 2:
                        filePath = "C:\\Users\\sakub\\Downloads\\ffx.mp4";
                        axWindowsMediaPlayer1.URL = filePath;
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        break;
                    case 3:
                        filePath = "C:\\Users\\sakub\\Downloads\\nat.mp4";
                        axWindowsMediaPlayer1.URL = filePath;
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        break;
                    default:
                        filePath = "C:\\Users\\sakub\\Downloads\\upbeat.mp3";
                        axWindowsMediaPlayer1.URL = filePath;
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        break;
                }
            }
        }
    }
}
