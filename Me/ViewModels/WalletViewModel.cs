using System;
using System.Collections.ObjectModel;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace Me
{
    public class WalletViewModel : ReactiveObject
    {
        [Reactive]
        public string[] Seed { get; set; }
        [Reactive]
        public string Name { get; set; }
        [Reactive]
        public ObservableCollection<PersonaViewModel> Personas { get; set; }
        [Reactive]
        public PersonaViewModel SelectedPersona { get; set; }
    }
}
