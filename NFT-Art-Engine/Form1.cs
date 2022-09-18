using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace NFT_Art_Engine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Globale Dec --------------------------------------------------------------------------
        FolderBrowserDialog layersfolder = new FolderBrowserDialog();
        string[] layers;
        string[] layers_details;
        //---------------------------------------------------------------------------------------


        private void load_layers_Click(object sender, EventArgs e)
        {
            layersfolder.ShowNewFolderButton = true;
            DialogResult result = layersfolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                logs.Text = layersfolder.SelectedPath;
                layers = Directory.GetDirectories(layersfolder.SelectedPath);
                for(int i = 0; i < layers.Length;i++)
                {
                    logs.Text += "\n" + layers[i];
                }
                
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Image imageBackground = Image.FromFile("C:/Users/sahba/OneDrive/Desktop/Layers/Background/Background#10.png");
            Image imageOverlay = Image.FromFile("C:/Users/sahba/OneDrive/Desktop/Layers/Men/Lotfi#10.png");
            Image head = Image.FromFile("C:/Users/sahba/OneDrive/Desktop/Layers/Face/doubt on emoticon square face#10.png");

            Image img = new Bitmap(imageBackground.Width, imageBackground.Height);
            using (Graphics gr = Graphics.FromImage(img))
            {
                gr.DrawImage(imageBackground, new Point(0, 0));
                gr.DrawImage(imageOverlay, new Point(0, 0));
                gr.DrawImage(head, new Point(0, 0));
            }
            img.Save("C:/Users/sahba/OneDrive/Desktop/r/output.png", ImageFormat.Png);
        }



        // Functions --------------------------------------------------------------------------
        //private Bitmap MergeImages(IEnumerable<Bitmap> images)
        //{
        //    var enumerable = images as IList<Bitmap> ?? images.ToList();

        //    var width = 0;
        //    var height = 0;

        //    foreach (var image in enumerable)
        //    {
        //        width += image.Width;
        //        height = image.Height > height
        //            ? image.Height
        //            : height;
        //    }

        //    var bitmap = new Bitmap(width, height);
        //    using (var g = Graphics.FromImage(bitmap))
        //    {
        //        var localWidth = 0;
        //        foreach (var image in enumerable)
        //        {
        //            g.DrawImage(image, localWidth, 0);
        //            localWidth += image.Width;
        //        }
        //    }
        //    return bitmap;
        //}



    }
}
