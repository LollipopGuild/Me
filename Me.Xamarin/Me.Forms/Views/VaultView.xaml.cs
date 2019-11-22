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
    public partial class VaultView : ContentPageBase<VaultViewModel>
    {
        public VaultView() : base(false)
        {
            InitializeComponent();

            this.WhenActivated(dispReg =>
            {
                ViewModel.SelectedPersona = null;

                this.OneWayBind(ViewModel, vm => vm.Personas, v => v.__Personas.ItemsSource)
                    .DisposeWith(dispReg);

                this.Bind(ViewModel, vm => vm.SelectedPersona, v => v.__Personas.SelectedItem)
                    .DisposeWith(dispReg);
            });

            this.WhenAnyValue(x => x.ViewModel.SelectedPersona)
                .Where(x => x != null)
                .Subscribe(p =>
                {
                    Debug.WriteLine($"Persona selected: {p.Title}");
                });

        }
    }
}
