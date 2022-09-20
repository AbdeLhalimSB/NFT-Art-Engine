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
        FolderBrowserDialog output = new FolderBrowserDialog();
        string[] layers;
        string[] target;
        List<string> elemnts = new List<string>();
        string krfhada;
        List<string> DNA = new List<string>();
        List<string> MetaDNA = new List<string>();
        List<string> Atributes = new List<string>();
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
            string json_atre = "";
            string latesdna = "";
            for (int nft = 0; nft < ntf_count.Value; nft++)
            {
                nftstart:
                for(int i=0;i < layers.Length; i++)
                {
                    target = Directory.GetFiles(layers[i]);
                    krfhada = target[randomer(0,target.Length)];
                    elemnts.Add(krfhada);
                    Atributes.Add(krfhada);
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
                
                if (DNA.Contains(dna_string) || MetaDNA.Contains(latesdna))
                {
                    logs.Text += "\n DNA Exist !!";
                    elemnts.Clear();
                    dna_string = "";
                    latesdna = "";
                    Atributes.Clear();
                    goto nftstart;
                }
                else
                {
                    logs.Text += "\n DNA is created";
                    MetaDNA.Add(DNA_Generator());
                    latesdna = MetaDNA[nft];
                    logs.Text += "\n" + latesdna;
                    img.Save(output.SelectedPath+"/" + (nft + 1) + ".png", ImageFormat.Png);
                    DNA.Add(dna_string);
                    string layer="";
                    string atree = "";
                    for (int c = 0; c < Atributes.Count; c++)
                    {
                        Atributes[c] = Path.GetFileName(Atributes[c]);
                        layer = Path.GetFileName(layers[c]);
                        //Atributes[c] = Atributes[c].Substring(0, Atributes[c].IndexOf('.'));
                        atree = Atributes[c].Substring(0, Atributes[c].IndexOf('.'));
                        if (c == Atributes.Count-1)
                        {
                            json_atre += "\t{ \"trait_type\":  \"" + layer + "\", \"value\": \"" + atree + "\" }\n";
                        }
                        else
                        {
                            json_atre += "\t{ \"trait_type\":  \"" + layer + "\", \"value\": \"" + atree + "\" },\n";
                        }
                    }
                    Atributes.Clear();
                    string json = "{\n \"dna\": \""+latesdna+ "\" ,\n \"name\": \"" + project_name.Text + "" +(nft+1)+ "\", \n \"description\": \""+desci.Text+"\",\n \"image\": \""+image_link.Text+" \",\n \"edition\": \"1\",\n \"attributes\": [\n"+json_atre+"],\n \"compiler\": \"AbdeLhalim Art Engine\"\n }";
                    File.WriteAllText(output.SelectedPath + "/" + (nft+1)+".json", json);
                    json_atre = "";
                }
                elemnts.Clear();
                dna_string = "";
                Atributes.Clear();
            }
            DNA.Clear();
            MetaDNA.Clear();
        }



        private void output_path_Click(object sender, EventArgs e)
        {
            output.ShowNewFolderButton = true;
            DialogResult result = output.ShowDialog();
            if (result == DialogResult.OK)
            {
                logs.Text += output.SelectedPath;
            }
        }

        // Functions --------------------------------------------------------------------------
        private int randomer(int start, int finish)
        {
            Random rnd = new Random();
            int num = rnd.Next(start, finish);
            return num;
        }

        public static string DNA_Generator()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var stringChars = new char[40];
            var random = new Random();

            for (int i = 0; i < 40; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            return finalString;
        }

    }
}
