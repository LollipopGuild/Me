using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace Me
{
    public class MeViewModel : ReactiveObject
    {
        [Reactive]
        public WalletViewModel Wallet { get; set; }
        [Reactive]
        public PersonaViewModel CurrentPersona { get; set; }
    }
}
