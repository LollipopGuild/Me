using System;
using System.Collections.Generic;
using System.IO;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ReactiveUI;
using ReactiveUI.XamForms;

using Me.ViewModels;

namespace Me.Forms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonaItemView : ReactiveViewCell<PersonaViewModel>
    {
        public PersonaItemView()
        {
            InitializeComponent();

            this.WhenAnyValue(x => x.ViewModel)
                .Where(x => x != null)
                .Do(PopulateFromViewModel)
                .Subscribe();
        }

        private void PopulateFromViewModel(PersonaViewModel viewModel)
        {
            var png = viewModel.Avatar;
            __Picture.Source = png == null ? null : ImageSource.FromStream(() => new MemoryStream(png));
            //__Picture.Command = viewModel.NavToWallet;

            var claims = viewModel.Claims;
            __GivenNames.Text = claims == null ? "" : string.Join(" ", claims.Where(c => c.Name == "Name_Given").Select(c => c.Value));
            __FamilyName.Text = claims == null ? "" : claims.FirstOrDefault(c => c.Name == "Name_Family")?.Value;
        }

    }
}