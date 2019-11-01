using System;
using System.Collections.ObjectModel;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace Me
{
    public class PersonaViewModel : ReactiveObject
    {
        [Reactive]
        public byte[] Avatar { get; set; }
        [Reactive]
        public string Title { get; set; }
        [Reactive]
        public ObservableCollection<ClaimViewModel> Claims { get; set; }
    }
}
