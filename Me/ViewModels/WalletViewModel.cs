using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;

using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;

namespace Me.ViewModels
{
    public class WalletViewModel : RoutableViewModelBase
    {
        [Reactive]
        public string[] Seed { get; set; }
        [Reactive]
        public string Name { get; set; }
        [Reactive]
        public ObservableCollection<PersonaViewModel> Personas { get; set; }
        [Reactive]
        public PersonaViewModel SelectedPersona { get; set; }

        public ReactiveCommand<IRoutableViewModel, Unit> NavToPersona { get; }

        public WalletViewModel() : base("wallet")
        {
            NavToPersona = ReactiveCommand.CreateFromObservable<IRoutableViewModel, Unit>(rvm => 
                                HostScreen.Router.NavigateAndReset.Execute(rvm).Select(_ => Unit.Default));

            //this.WhenAnyValue(x => x.SelectedPersona)
            //    .Where(x => x != null)
            //    //.StartWith(Personas.First())
            //    .InvokeCommand<PersonaViewModel>(NavToPersona);
        }
    }
}
