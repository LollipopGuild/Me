using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Disposables;
using Xamarin.Forms;

using ReactiveUI.XamForms;
using ReactiveUI;
using System.IO;

namespace Me.Forms
{
    public class MeView_Reactive : ReactiveContentPage<MeViewModel> { }

    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MeView : MeView_Reactive
    {
        public MeView()
        {
            InitializeComponent();
            this.WhenActivated(dispReg =>
            {
                this.OneWayBind(ViewModel,
                    viewModel => viewModel.Picture,
                    view => view.__Picture.Source,
                    url => url == null ? null : ImageSource.FromStream(() => new MemoryStream(url)))
                    .DisposeWith(dispReg);

                this.OneWayBind(ViewModel,
                    viewModel => viewModel.GivenNames,
                    view => view.__GivenNames.Text,
                    names => names == null ? "" : string.Join(" ", names))
                    .DisposeWith(dispReg);

                this.OneWayBind(ViewModel,
                    viewModel => viewModel.FamilyName,
                    view => view.__FamilyName.Text)
                    .DisposeWith(dispReg);
            });
        }
    }
}
