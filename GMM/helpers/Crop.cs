using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors;

namespace GMM.helpers
{
    public partial class Crop : DevExpress.XtraEditors.XtraForm
    {

        public DashStyle CropDashStyle = DashStyle.DashDot;
        private int _cropHeight;
        private Pen _cropPen;
        private int _cropWidth;
        private int _cropX;
        private int _cropY;
        private bool _makeselection;
        
        public Crop()
        {
            InitializeComponent();
        }

        private void pictureEdit1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureEdit1.Image == null)
                return;
            if (e.Button == MouseButtons.Left)
            {
                pictureEdit1.Refresh();
                _cropWidth = e.X - _cropX;
                _cropHeight = e.Y - _cropY;
                pictureEdit1.CreateGraphics().DrawRectangle(_cropPen, _cropX, _cropY, _cropWidth, _cropHeight);
                if (_cropWidth > 1)
                    windowsUIButtonPanel1.Buttons.First().Properties.Enabled = true;
                

            }
        }

        private void pictureEdit1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (_makeselection == false)
                {
                    _makeselection = true;
                    Cursor = Cursors.Cross;
                    _cropX = e.X;
                    _cropY = e.Y;
                    _cropPen = new Pen(Color.Blue, 1);
                    _cropPen.DashStyle = DashStyle.DashDotDot;
                    pictureEdit1.Refresh();
                }
                else
                {
                    _makeselection = false;
                    Cursor = Cursors.Default;
                }
            }
        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {

            string caption = ((WindowsUIButton)e.Button).Caption.ToString();
            switch (caption)
            {
                case "Crop":
                    Cursor = Cursors.Default;
                    if (_cropWidth < 1)
                        return;
                    var rect = new Rectangle(_cropX, _cropY, _cropWidth, _cropHeight);

                    //First we define a rectangle with the help of already calculated points
                    var originalImage = new Bitmap(pictureEdit1.Image, pictureEdit1.Width, pictureEdit1.Height);

                    //Original image
                    var img = new Bitmap(_cropWidth, _cropHeight);

                    // for cropinf image
                    var g = Graphics.FromImage(img);

                    // create graphics
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    g.CompositingQuality = CompositingQuality.HighQuality;

                    //set image attributes
                    g.DrawImage(originalImage, 0, 0, rect, GraphicsUnit.Pixel);
                    pictureEdit1.Image = img;
                    Fitimag();//btnCrop.Enabled = false;
                    windowsUIButtonPanel1.Buttons.First().Properties.Enabled = false;
                    break;
                case "Rotate":
                    pictureEdit1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    pictureEdit1.Refresh();
                    break;
                case "Save":
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    break;
                case "Cancel":
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                    break;
            }}

        private void pictureEdit1_MouseUp(object sender, MouseEventArgs e)
        {
            if (_makeselection)
            {
                Cursor = Cursors.Default;
                _makeselection = false;
            }
                

        }
        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }

        private void Crop_Shown(object sender, EventArgs e)
        {
            Fitimag();
        }

        private void Fitimag()
        {
            var originalImage = pictureEdit1.Image;
            pictureEdit1.Image = ScaleImage(originalImage, pictureEdit1.Width, pictureEdit1.Height);
            pictureEdit1.Width = pictureEdit1.Image.Width;
            pictureEdit1.Height = pictureEdit1.Image.Height;
        }
    }
}