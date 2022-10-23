using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using System.Linq;

namespace ResizeImg
{
    public partial class FrmMain : Form
    {
        // call gdi32.dll
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);
        FontFamily ff;

        // Array of TIF Files found in sub Folder
        string[] IMGfiles;
        // Create integer variable to Counting the number of files in sub folder 
        int fileCount = 0;
        string selected_path;

        // Create boolean variable to check if the radio button of Quality is checked or not
        bool IsCheckedSQ = true;
        // Create boolean variable to check if the CheckBox (Add condition) is checked or not
        bool IsCheckedCond = false;
        // Create boolean variable to check if the radio button of Type is checked or not
        public static bool IsCheckedTIF = true;
        
        private void AddPrivateFontCollection()
        {
            // Create the byte array and get its length
            byte[] fontArray = Properties.Resources.Blanche_de_la_Fontaine;
            int dataLength = Properties.Resources.Blanche_de_la_Fontaine.Length;

            // Assign memory and copy byte[] on that memory address
            IntPtr ptrData = Marshal.AllocCoTaskMem(dataLength);

            // Copying the fontdata into the memory designated by the pointer
            Marshal.Copy(fontArray, 0, ptrData, dataLength);

            uint cFonts = 0;

            // Register the font with the system.
            AddFontMemResourceEx(ptrData, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);

            PrivateFontCollection pfc = new PrivateFontCollection();

            // pass the font to the PRIVATEFONTCOLLECTION object
            // Finally, we can actually add the font to our collection
            pfc.AddMemoryFont(ptrData, dataLength);

            // FREE THE "UNSAFE" MEMORY
            Marshal.FreeCoTaskMem(ptrData);

            ff = pfc.Families[0];
        }

        public FrmMain() => InitializeComponent();

        // Handle Methode Search Directory and Get all TIF files found,
        // and bring out to Array of string
        public static int SearchDirectoryTree(string path, out string[] IMGfiles)
        {
            if(IsCheckedTIF)
            {
                IMGfiles = Directory.GetFiles(path, "*.tif", SearchOption.AllDirectories);
            }
            else
            {
                var IMGfilesvar = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories)
                    .Where(s => s.EndsWith(".jpg") || 
                                s.EndsWith(".jpeg") || 
                                s.EndsWith(".png") || 
                                s.EndsWith(".tif") || 
                                s.EndsWith(".bmp"));
                // Convert var to Array
                IMGfiles = IMGfilesvar.ToArray();
            }
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

                    Image i = IsCheckedSQ ? ResizeImgSQ(b, new Size(W, H)) : ResizeImageHQ(b, W, H);

                    // skip over
                    // continues with the next iteration of the loop for-each
                    // if the image width < 3000 pixel for exemple
                    if(IsCheckedCond)
                        if (sourceWidth < Convert.ToInt32(TxtBoxWCond.Text))
                            continue;

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
                MessageBox.Show(ex.Message,"Exception message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        // Methode Resize image for Standard Quality
        public static Image ResizeImgSQ(Image imgToResize, Size size) => (Image)(new Bitmap(imgToResize, size));

        // Methode Resize image for Hight Quality
        public static Bitmap ResizeImageHQ(Image image, int width, int height)
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
            Process.Start("https://github.com/abdessalam-aadel/ResizeImg");
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            AddPrivateFontCollection();
            BtnStart.Font = new Font(ff, 24, FontStyle.Underline);
        }

        private void RdButtonSQ_CheckedChanged(object sender, EventArgs e)
        {
            IsCheckedSQ = RdButtonSQ.Checked ? true : false;
        }

        private void CheckBoxCond_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckBoxCond.Checked)
            {
                IsCheckedCond = true;
                TxtBoxWCond.Enabled = true;
            }
            else
            {
                IsCheckedCond = false;
                TxtBoxWCond.Enabled = false;
            }
        }

        private void RdButtonTif_CheckedChanged(object sender, EventArgs e)
        {
            IsCheckedTIF = RdButtonTif.Checked ? true : false;
        }

        // Start methode : Not Enter a Key String just a Key Number
        private static void Not_KeyString(KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                // if you press the BACKSPACE key, the Handled property is set to false, 
                e.Handled = e.KeyChar == 8 ? false : true;
            }
        }

        private void TxtW_KeyPress(object sender, KeyPressEventArgs e) => Not_KeyString(e);

        private void TxtH_KeyPress(object sender, KeyPressEventArgs e) => Not_KeyString(e);

        private void TxtBoxWCond_KeyPress(object sender, KeyPressEventArgs e) => Not_KeyString(e);
    }
}
