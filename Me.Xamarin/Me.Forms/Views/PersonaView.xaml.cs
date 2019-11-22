using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive.Disposables;

using Xamarin.Forms;
using ReactiveUI;
using ReactiveUI.XamForms;

using Me.ViewModels;

namespace Me.Forms.Views
{
    public partial class PersonaView : ContentPageBase<PersonaViewModel>
    {
        public PersonaView() : base(false)
        {
            InitializeComponent();

            this.WhenActivated(dispReg =>
            {
                this.OneWayBind(ViewModel,
                        viewModel => viewModel.Avatar,
                        view => view.__Picture.Source,
                        png => png == null ? null : ImageSource.FromStream(() => new MemoryStream(png)))
                    .DisposeWith(dispReg);

                this.OneWayBind(ViewModel,
                        viewModel => viewModel.Claims,
                        view => view.__GivenNames.Text,
                        claims => claims == null ? "" : claims.GivenName())
                    .DisposeWith(dispReg);

                this.OneWayBind(ViewModel,
                        viewModel => viewModel.Claims,
                        view => view.__FamilyName.Text,
                        claims => claims == null ? "" : claims.FamilyName())
                    .DisposeWith(dispReg);

                this.OneWayBind(ViewModel,
                        viewModel => viewModel.Claims,
                        view => view.__QRCode.Source,
                        claims => claims.QRCodeImage(300, 300))
                    .DisposeWith(dispReg);

                this.OneWayBind(ViewModel,
                        viewModel => viewModel.NavToWallet,
                        view => view.__Close.Command)
                    .DisposeWith(dispReg);

            });
        }
    }
}
