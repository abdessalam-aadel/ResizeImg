using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Threading;
using System.Diagnostics;

namespace ResizeImg
{
    public partial class FrmMain : Form
    {
        // Array of TIF Files found in Folder
        string[] IMGfiles;
        // Creat variable to Counting the number of files in a folder 
        int fileCount = 0;
        string selected_path;

        public FrmMain() => InitializeComponent();

        // Handle Methode Search Directory and Get all TIF files found,
        // and bring out to Array of string
        public static int SearchDirectoryTree(string path, out string[] IMGfiles)
        {
            IMGfiles = Directory.GetFiles(path, "*.tif", SearchOption.AllDirectories);
            return IMGfiles.Length;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // Check the Empty Folder
            if (fileCount == 0)
                return;

            try
            {
                Cursor = Cursors.WaitCursor;
                LabelDone.Text = "";
                ImgDone.Visible = false;

                // new Width
                int W = Convert.ToInt32(TxtW.Text);
                // new Height
                int H = Convert.ToInt32(TxtH.Text);

                foreach (string filePath in IMGfiles)
                {
                    Image img = Image.FromFile(filePath);
                    Bitmap b = new Bitmap(img);
                    // Get the current image width  
                    int sourceWidth = b.Width;
                    // skip over
                    // continues with the next iteration of the loop for-each
                    // if the image width < 3000 pixel
                    if (sourceWidth < 3000)
                        continue;

                    Image i = ResizeImg(b, new Size(W, H));
                    //Image i = ResizeImage3(b, W, H);
                    // Releases all reesources
                    b.Dispose();
                    img.Dispose();
                    i.Save(filePath);
                }
                Cursor = Cursors.Default;
                LabelDone.Text = "Done";
                ImgDone.Visible = true;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                LabelDone.Text = "";
                ImgDone.Visible = false;
                MessageBox.Show(ex.Message);
            }
        }

        public static Image ResizeImg(Image imgToResize, Size size) => (Image)(new Bitmap(imgToResize, size));

        // other methode to reserve quality of image
        private static Image ResizeImage2(Image imgToResize, Size size)
        {
            //Get the image current width  
            int sourceWidth = imgToResize.Width;
            //Get the image current height  
            int sourceHeight = imgToResize.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            //Calulate  width with new desired size  
            nPercentW = ((float)size.Width / (float)sourceWidth);
            //Calculate height with new desired size  
            nPercentH = ((float)size.Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //New Width  
            int destWidth = (int)(sourceWidth * nPercent);
            //New Height  
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Draw image with new width and height  
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (Image)b;
        }
        
        public static Bitmap ResizeImage3(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FD = new FolderBrowserDialog();
            if (selected_path != null)
                FD.SelectedPath = selected_path;

            if (FD.ShowDialog() == DialogResult.OK)
            {
                LabelDone.Text = "";
                ImgDone.Visible = false;
                selected_path = FD.SelectedPath;
                TxtBoxLoad.Text = FD.SelectedPath;
                fileCount = SearchDirectoryTree(FD.SelectedPath, out IMGfiles);
                TxtTotales.Text = fileCount + " files.";
            }
        }

        private void GoToGithub_Click(object sender, EventArgs e)
        {
            // Go to github repo
            Process.Start("https://github.com/abdessalam-aadel");
        }
    }
}
