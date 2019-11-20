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
    public class MeViewModel : ViewModelBase
    {
        [Reactive]
        public WalletViewModel Wallet { get; set; }
    }
}
