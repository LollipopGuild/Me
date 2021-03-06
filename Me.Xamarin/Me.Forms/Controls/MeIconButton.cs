﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Me.Forms.Controls
{
    public class MeIconButton : Button
    {
        public MeIconButton()
        {
            switch (Device.RuntimePlatform)
            {
                case Device.UWP:
                    {
                        FontFamily = @"/Assets/Fonts/me.ttf#me";
                        break;
                    }
                case Device.Android:
                    {
                        FontFamily = @"me";
                        break;
                    }
                case Device.iOS:
                    {
                        FontFamily = @"me";
                        break;
                    }
            }
        }
    }
}
