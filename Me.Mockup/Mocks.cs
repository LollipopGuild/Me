using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Me.ViewModels;
using Me.Mockup.Fakes;

namespace Me.Mockup
{
    public static class Mocks
    {
        public static WalletViewModel MockupWallet => CreateMockupWallet();

        static WalletViewModel CreateMockupWallet()
        {
            var wallet = new WalletViewModel() { Name = "MOCKUP" };
            wallet.Personas = new ObservableCollection<PersonaViewModel>()
            {
                Personas.JanePDoh,
                Personas.RitaHTyler,
            };
            return wallet;
        }
    }
}
