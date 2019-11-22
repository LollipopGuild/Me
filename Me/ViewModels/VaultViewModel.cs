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
    public class VaultViewModel : RoutableViewModelBase
    {
        [Reactive]
        public string[] Seed { get; set; }
        [Reactive]
        public string Name { get; set; }
        [Reactive]
        public ObservableCollection<PersonaViewModel> Personas { get; set; }
        [Reactive]
        public PersonaViewModel SelectedPersona { get; set; }

        public VaultViewModel() : base("wallet")
        {
            this.WhenAnyValue(x => x.SelectedPersona)
                .Where(x => x != null)
                .SelectMany(x => HostScreen.Router.NavigateAndReset.Execute(x))
                .Subscribe();
        }
    }
}
