using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Reactive.Disposables;
using System.Reactive.Linq;

using Xamarin.Forms;
using ReactiveUI;
using ReactiveUI.XamForms;

using Me.ViewModels;
using Splat;

namespace Me.Forms.Views
{
    public partial class WalletView : ContentPageBase<WalletViewModel>
    {
        public WalletView()
        {
            InitializeComponent();

            this.WhenActivated(dispReg =>
            {
                this.OneWayBind(ViewModel, vm => vm.Name, v => v.__Name.Text)
                    .DisposeWith(dispReg);

                this.OneWayBind(ViewModel, vm => vm.Personas, v => v.__Personas.ItemsSource)
                    .DisposeWith(dispReg);

                this.Bind(ViewModel, vm => vm.SelectedPersona, v => v.__Personas.SelectedItem)
                    .DisposeWith(dispReg);

                this.WhenAnyValue(x => x.ViewModel.SelectedPersona)
                        .Where(x => x != null)
                        .Subscribe(p =>
                        {
                            Debug.WriteLine($"Persona selected: {p.Title}");
                            //__Personas.SelectedItem = null;
                            //ViewModel.NavToPersona.Execute(p);
                        })
                        .DisposeWith(dispReg);
            });
        }
    }
}
