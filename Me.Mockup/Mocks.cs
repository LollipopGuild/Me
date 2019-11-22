using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Me.ViewModels;
using Me.Mockup.Fakes;

namespace Me.Mockup
{
    public static class Mocks
    {
        public static VaultViewModel MockupWallet => CreateMockupWallet();

        static VaultViewModel CreateMockupWallet()
        {
            var wallet = new VaultViewModel() { Name = "MOCKUP" };
            wallet.Personas = new ObservableCollection<PersonaViewModel>()
            {
                Personas.JanePDoh,
                Personas.RitaHTyler,
            };
            return wallet;
        }
    }
}
