using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reactive;
using System.Reactive.Linq;

using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;

namespace Me.ViewModels
{
    public class PersonaViewModel : RoutableViewModelBase
    {
        [Reactive]
        public byte[] Avatar { get; set; }
        [Reactive]
        public string Title { get; set; }
        [Reactive]
        public ObservableCollection<ClaimViewModel> Claims { get; set; }
        public ReactiveCommand<Unit, IRoutableViewModel> NavToWallet { get; set; }

        public PersonaViewModel() : base("persona")
        {
            NavToWallet = ReactiveCommand.CreateFromObservable<Unit, IRoutableViewModel>(_ =>
            {
                var wallet = Locator.Current.GetService<VaultViewModel>();
                return HostScreen.Router.NavigateAndReset.Execute(wallet);
            });
            NavToWallet.Subscribe();
        }
    }
}
