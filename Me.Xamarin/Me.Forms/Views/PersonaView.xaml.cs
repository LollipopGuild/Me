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
    public partial class PersonaView : ReactiveContentPage<PersonaViewModel>
    {
        public PersonaView()
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
                    claims => claims == null ? "" :
                        string.Join(" ", claims.Where(c => c.Name == "Name_Given")
                                               .Select(c => c.Value)))
                    .DisposeWith(dispReg);

                this.OneWayBind(ViewModel,
                    viewModel => viewModel.Claims,
                    view => view.__FamilyName.Text,
                    claims => claims == null ? "" :
                        claims.FirstOrDefault(c => c.Name == "Name_Family")?.Value)
                    .DisposeWith(dispReg);

                this.OneWayBind(ViewModel,
                    viewModel => viewModel.NavToWallet,
                    view => view.__Picture.Command)
                    .DisposeWith(dispReg);

            });
        }
    }
}
