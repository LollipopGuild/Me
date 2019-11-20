using System;
using System.Collections.Generic;
using System.Text;
using XamForms = Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

using ReactiveUI.XamForms;
using Me.ViewModels;

namespace Me.Forms.Views
{
    public class ContentPageBase<TViewModel> : ReactiveContentPage<TViewModel>
             where TViewModel : ViewModelBase
    {
        public ContentPageBase()
        {
            XamForms.NavigationPage.SetHasNavigationBar(this, false);
            this.BackgroundColor = MeColors.bodyBG;
            On<XamForms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
    }
}
