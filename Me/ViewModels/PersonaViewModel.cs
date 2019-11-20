using System;
using System.Collections.ObjectModel;
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
        public ReactiveCommand<IRoutableViewModel, Unit> NavToWallet { get; set; }

        public PersonaViewModel() : base("persona")
        {
            NavToWallet = ReactiveCommand.CreateFromObservable<IRoutableViewModel, Unit>(rvm =>
            {
                var wallet = Locator.Current.GetService<WalletViewModel>();
                wallet.SelectedPersona = null;
                return HostScreen.Router.NavigateAndReset.Execute(wallet).Select(_ => Unit.Default);
            });
        }
    }
}
