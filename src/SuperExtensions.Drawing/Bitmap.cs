﻿using System.Drawing;
using System.Drawing.Imaging;

namespace SuperExtensions.Drawing
{
    public static class BitmapExtensions
    {
        public static Bitmap ToGrayScale(this Bitmap bitmap)
        {
            var newBitmap = new Bitmap(bitmap.Width, bitmap.Height);

            using (var g = Graphics.FromImage(newBitmap))
            {
                //The grayscale ColorMatrix
                var colorMatrix = new ColorMatrix(new float[][] {
                    new float[] {.3f, .3f, .3f, 0, 0},
                    new float[] {.59f, .59f, .59f, 0, 0},
                    new float[] {.11f, .11f, .11f, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1}
                });

                using (var attributes = new ImageAttributes())
                {
                    attributes.SetColorMatrix(colorMatrix);
                    g.DrawImage(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height), 0, 0, bitmap.Width, bitmap.Height, GraphicsUnit.Pixel, attributes);
                    g.Dispose();
                    return newBitmap;
                }
            }
        }
    }
}
