using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using ImageIO;
using CoreGraphics;

using Foundation;
using UIKit;
using ZXing;

using Me.Services;
using Xamarin.Forms;

namespace Me.iOS.Services
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
            var stream = bitmap.AsPNG().AsStream();
            stream.Position = 0;
            return ImageSource.FromStream(() => stream);
        }
    }
}