using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace Me.Services
{
    public interface IQRCodeService
    {
        ImageSource Render(string text, int width, int height, int margin = 0);
    }
}
