using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fatcatgui.controls.image
{
    public partial class ImageUC : UserControl
    {

        public Bitmap bitmap = null;
        private Pen pen = new Pen(basestyles.colorhigh, 1);
        private Rectangle rect = new Rectangle(0, 0, 10, 10);
        public ImageUC()
        {
            InitializeComponent();
        }

        private void ImageUC_Load(object sender, EventArgs e)
        {

        }

        private void ImageUC_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(basestyles.colordim);

            pen.Color = basestyles.colorhigh;

            rect.Width = this.Width - 1;
            rect.Height = this.Height - 1;

          //  e.Graphics.DrawRectangle(pen, rect);

            if (bitmap  != null) {

                Image scaledImage = ScaleImage(bitmap, rect.Width, rect.Height);

                using (scaledImage)
                {

                    ColorMap[] colorMap = new ColorMap[1];
                    colorMap[0] = new ColorMap();
                    colorMap[0].OldColor = Color.Black;
                    colorMap[0].NewColor =  basestyles.colorhigh;
                    ImageAttributes attr = new ImageAttributes();
                    attr.SetRemapTable(colorMap);

                    Rectangle dest = new Rectangle((int)((rect.Width - scaledImage.Width) / 2), 0, scaledImage.Width, scaledImage.Height);
                    e.Graphics.DrawImage(scaledImage, dest, 0, 0, dest.Width, dest.Height, GraphicsUnit.Pixel, attr);
                    //e.Graphics.DrawImage(scaledImage, new Point((int)((rect.Width - scaledImage.Width) / 2), 0), rect, GraphicsUnit.Pixel, attr);
                }
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
    }
}
