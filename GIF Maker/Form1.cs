using ImageMagick;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GIF_Maker
{
    public partial class GIFMaker : Form
    {
        public GIFMaker()
        {
            InitializeComponent();
        }


        //class for images
        class newGIF
        {
            public string name;
            public string path;
        }
        List<newGIF> GifMaker = new List<newGIF>(); //create a list of the newGIF class
        private void ImageOpenBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // open file dialog
                OpenFileDialog open = new OpenFileDialog();
                // image filters
                open.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
                open.Multiselect = true;


                if (open.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in open.FileNames)
                    {
                        MessageBox.Show(file);

                        //new image object
                        newGIF images = new newGIF();
                        images.name = Path.GetFileName(file);
                        images.path = file;

                        //add to final array
                        GifMaker.Add(images);
                    }

                    refreshListBox(GifMaker);
                }
            }
        }


        private void refreshListBox(List<newGIF> GifMaker)
        {
            //delete all items in listbox
            imageList.Items.Clear();

            foreach (var item in GifMaker)
            {
                imageList.Items.Add(item.name);
            }
            imageList.Refresh();
        }

        private void imageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //search Gif objects for corresponding image name, which is linked to the path of the image, this is then displayed
            int index = GifMaker.FindIndex(x => x.name == imageList.SelectedItem.ToString());

            //use index to find image
            if (index != -1)
            {
                displayImage(GifMaker[index].path);
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void displayImage(string path)
        {
            imageDisplayBox.ImageLocation = path;
        }

        private void imageUpBtn_Click(object sender, EventArgs e)
        {
            int CurrentIndex = GifMaker.FindIndex(x => x.name == imageList.SelectedItem.ToString());
            int ReplacedIndex = CurrentIndex - 1;
            if ((CurrentIndex - 1) != -1)
            {
                MoveImage(CurrentIndex, ReplacedIndex);
            }
            else
            {
                MessageBox.Show("Already at the back.");
            }
        }

        private void imageDownBtn_Click(object sender, EventArgs e)
        {
            int CurrentIndex = GifMaker.FindIndex(x => x.name == imageList.SelectedItem.ToString());
            int ReplacedIndex = CurrentIndex + 1;
            if ((CurrentIndex + 1) > (imageList.Items.Count - 1) && imageList.SelectedIndex != -1)
            {
                MessageBox.Show("Already at the front.");
            }
            else
            {
                MoveImage(CurrentIndex, ReplacedIndex);
            }
        }

        private void MoveImage(int CurrentIndex, int ReplacedIndex)
        {
            if (imageList.SelectedIndex != -1)
            {
                string CurrentIndexTempName = GifMaker[CurrentIndex].name;
                string CurrentIndexTempPath = GifMaker[CurrentIndex].path;


                string ReplacedIndexTempName = GifMaker[ReplacedIndex].name;
                string ReplacedIndexTempPath = GifMaker[ReplacedIndex].path;


                //flip them
                GifMaker[ReplacedIndex].name = CurrentIndexTempName;
                GifMaker[ReplacedIndex].path = CurrentIndexTempPath;

                GifMaker[CurrentIndex].name = ReplacedIndexTempName;
                GifMaker[CurrentIndex].path = ReplacedIndexTempPath;

                refreshListBox(GifMaker);

                //keep the original image selected
                imageList.SelectedIndex = ReplacedIndex;
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (imageList.SelectedIndex != -1)
            {
                int index = GifMaker.FindIndex(x => x.name == imageList.SelectedItem.ToString());

                //removes object in list at the index selected and updates listbox
                GifMaker.RemoveAt(index);
                refreshListBox(GifMaker);
            }
        }

        private void deleteAllImages_Click(object sender, EventArgs e)
        {
            //removes all objects in list and updates the listbox
            GifMaker.Clear();
            refreshListBox(GifMaker);
        }

        private void CreateGif()
        {
            //may have to convert images into bmp and use some sort of encoder?? or maybe have to use a library on top
            using (MagickImageCollection collection = new MagickImageCollection())
            {
                foreach (var item in GifMaker)
                {
                    MagickImage image = new MagickImage(item.path);

                    //per frame
                    image.AnimationDelay = 50; //milliseconds maybe include option to customise the speed of the animation
                    image.Resize(1920, 1080);
                    collection.Add(image);
                }
                //optimise
                collection.OptimizeTransparency();
                //      collection.Optimize();

                //save the gif
                collection.Write(@"C:\Users\user\Desktop\output\output.gif", MagickFormat.Gif);

                //create window for file name, location of save etc.
            }
            MessageBox.Show("Gif created successfully");
        }

        private void createGIFBtn_Click(object sender, EventArgs e)
        {
            CreateGif();
        }

        private void OpenVideoBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // open file dialog
                OpenFileDialog open = new OpenFileDialog();
                // image filters
                open.Filter = "Video files |*.wmv; *.3g2; *.3gp; *.3gp2; *.3gpp; *.amv; *.asf;  *.avi; *.bin; *.cue; *.divx; *.dv; *.flv; *.gxf; *.iso; *.m1v; *.m2v; *.m2t; *.m2ts; *.m4v; " +
                          " *.mkv; *.mov; *.mp2; *.mp2v; *.mp4; *.mp4v; *.mpa; *.mpe; *.mpeg; *.mpeg1; *.mpeg2; *.mpeg4; *.mpg; *.mpv2; *.mts; *.nsv; *.nuv; *.ogg; *.ogm; *.ogv; *.ogx; *.ps; *.rec; *.rm; *.rmvb; *.tod; *.ts; *.tts; *.vob; *.vro; *.webm; *.dat; ";
                open.Multiselect = true;


                if (open.ShowDialog() == DialogResult.OK)
                {
                    using (var videoFrames = new MagickImageCollection(open.FileName.ToString()))
                    {
                        foreach (var frame in videoFrames)
                        {
                            MessageBox.Show(frame.ToString());
                        }
                    }
                    foreach (string file in open.FileNames)
                    {
                        MessageBox.Show(file);

                        //new image object
                        newGIF images = new newGIF();
                        images.name = Path.GetFileName(file);
                        images.path = file;

                        //add to final array
                        GifMaker.Add(images);
                    }

                    refreshListBox(GifMaker);
                }
            }
        }

        private void ReplaceImageBtn_Click(object sender, EventArgs e)
        {
            if (imageList.SelectedItem != null)
            {
                int index = GifMaker.FindIndex(x => x.name == imageList.SelectedItem.ToString());
                GifMaker.RemoveAt(index);

                // open file dialog
                OpenFileDialog open = new OpenFileDialog();
                // image filters
                open.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";


                if (open.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(open.FileName);

                    //new image object
                    newGIF images = new newGIF();
                    images.name = Path.GetFileName(open.ToString());
                    images.path = open.FileName;

                    //add to final array
                    GifMaker.Insert(index, images);

                    refreshListBox(GifMaker);
                }
            }
        }
            

    }
}
