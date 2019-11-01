using System;
using System.Collections.ObjectModel;

namespace Me.Mockup
{
    public static class Personas
    {
        public static PersonaViewModel JanePDoh => new PersonaViewModel()
        {
            Avatar = Convert.FromBase64String(Avatars._WomanDoesntExist),
            Title = "Self",
            Claims = new ObservableCollection<ClaimViewModel>()
            {
                new ClaimViewModel() { Name = "Name_Given", Value = "Jane" },
                new ClaimViewModel() { Name = "Name_Given", Value = "P" },
                new ClaimViewModel() { Name = "Name_Family", Value = "Doh" },
            }
        };
    }
}
