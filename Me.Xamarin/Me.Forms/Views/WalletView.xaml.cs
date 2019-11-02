using System;
using System.Collections.Generic;
using System.Reactive.Disposables;
using ReactiveUI;
using ReactiveUI.XamForms;
using Xamarin.Forms;

namespace Me.Forms
{
    public partial class WalletView : ReactiveContentView<WalletViewModel>
    {
        public WalletView()
        {
            InitializeComponent();

            this.WhenActivated(dispReg =>
            {
                this.OneWayBind(ViewModel,
                        viewModel => viewModel.Name,
                        view => view.__Name.Text)
                    .DisposeWith(dispReg);

                this.OneWayBind(ViewModel,
                        viewModel => viewModel.Personas,
                        view => view.__Personas.ItemsSource)
                    .DisposeWith(dispReg);
            });
        }
    }
}
