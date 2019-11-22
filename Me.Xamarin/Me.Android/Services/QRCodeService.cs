using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Android.Graphics;

using Xamarin.Forms;

using Me.Services;

namespace Me.Android.Services
{
    public class QRCodeService : IQRCodeService
    {
        public ImageSource Render(string text, int width, int height, int margin = 0)
        {
            var writer = new ZXing.Mobile.BarcodeWriter
            {
                Format = ZXing.BarcodeFormat.QR_CODE,
                Options = new ZXing.Common.EncodingOptions
                {
                    Width = width,
                    Height = height,
                    Margin = margin
                },
                Renderer = new ZXing.Mobile.BitmapRenderer()
            };
            var bitmap = writer.Write(text);
            var stream = new MemoryStream();
            bitmap.Compress(Bitmap.CompressFormat.Png, 100, stream);
            stream.Position = 0;
            return ImageSource.FromStream(() => stream);
        }
    }
}