using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Me.Mockup
{
    public static class Mocks
    {
        public static WalletViewModel MockupWallet => CreateMockupWallet();

        static WalletViewModel CreateMockupWallet()
        {
            var wallet = new WalletViewModel();
            wallet.SelectedPersona = Personas.JanePDoh;
            wallet.Personas = new ObservableCollection<PersonaViewModel>()
            {
                wallet.SelectedPersona
            };
            return wallet;
        }
    }
}
