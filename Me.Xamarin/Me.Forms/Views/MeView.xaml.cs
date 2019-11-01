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
using System.Collections.ObjectModel;

namespace Me.Forms
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MeView : ReactiveContentPage<MeViewModel>
    {
        public MeView()
        {
            InitializeComponent();

            ViewModel = new MeViewModel()
            {
                Wallet = Mockup.Mocks.MockupWallet
            };

            this.WhenActivated(dispReg =>
            {
                this.OneWayBind(ViewModel,
                    viewModel => viewModel.Wallet.SelectedPersona,
                    view => view.__SelectedPersona.ViewModel)
                    .DisposeWith(dispReg);
            });
        }
    }
}
