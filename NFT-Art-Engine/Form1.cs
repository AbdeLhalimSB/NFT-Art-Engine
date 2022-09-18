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
        //string[] layers_details;
        string[] target;
        List<string> elemnts = new List<string>();
        string krfhada;
        List<string> DNA = new List<string>();
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
            string dna_string = "";
            for (int nft = 0; nft < ntf_count.Value; nft++)
            {
                nftstart:
                for(int i=0;i < layers.Length; i++)
                {
                    target = Directory.GetFiles(layers[i]);
                    krfhada = target[randomer(0,target.Length)];
                    elemnts.Add(krfhada);
                }
                Image imageBackground = Image.FromFile(elemnts[0]);

                Image img = new Bitmap(imageBackground.Width, imageBackground.Height);
                using (Graphics gr = Graphics.FromImage(img))
                {
                    gr.DrawImage(imageBackground, new Point(0, 0));
                    for(int i = 1; i<elemnts.Count; i++)
                    {
                        gr.DrawImage(Image.FromFile(elemnts[i]), new Point(0, 0));
                    }
                }
                for (int sc = 0; sc < elemnts.Count; sc++)
                {
                    dna_string += elemnts[sc];
                }
                
                if (DNA.Contains(dna_string))
                {
                    logs.Text += "\n DNA Exist !!";
                    elemnts.Clear();
                    dna_string = "";
                    goto nftstart;
                }
                else
                {
                    logs.Text += "\n DNA : "+dna_string;
                    img.Save("C:/Users/sahba/OneDrive/Desktop/r/" + (nft + 1) + ".png", ImageFormat.Png);
                    DNA.Add(dna_string);
                }

                elemnts.Clear();
                dna_string = "";
            }

            logs.Text += "\n" + elemnts.Count;
            logs.Text += "\n" + DNA.Count;
        }



        // Functions --------------------------------------------------------------------------
        private int randomer(int start,int finish)
        {
            Random rnd = new Random();
            int num = rnd.Next(start,finish);
            return num;
        }



    }
}
