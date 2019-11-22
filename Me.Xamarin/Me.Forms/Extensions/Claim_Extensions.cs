using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;

using Xamarin.Forms;
using Splat;
using ZXing;

using Me.Services;
using Me.ViewModels;

namespace Me.Forms
{
    public static class Claim_Extensions
    {
        public static ImageSource QRCodeImage(this ObservableCollection<ClaimViewModel> claims, int height, int width, int margin = 0)
        {
            string qrCode = claims.QRCodeString();
            var qrService = Locator.Current.GetService<IQRCodeService>();
            return qrService == null ? null : qrService.Render(qrCode, width, height, margin);
        }
    }
}
