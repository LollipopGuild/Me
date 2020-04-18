using System;
using System.Collections.ObjectModel;

using Me.ViewModels;

namespace Me.Mockup.Fakes
{
    public static class Personas
    {
        public static PersonaViewModel JanePDoh => new PersonaViewModel()
        {
            Avatar = Convert.FromBase64String(Avatars._WomanDoesntExist),
            Title = "Jane",
            Claims = new ObservableCollection<ClaimViewModel>()
            {
                new ClaimViewModel() { Name = "Name_Given", Value = "Jane" },
                new ClaimViewModel() { Name = "Name_Given", Value = "P" },
                new ClaimViewModel() { Name = "Name_Family", Value = "Doh" },
            }
        };
        public static PersonaViewModel RitaHTyler => new PersonaViewModel()
        {
            Avatar = Convert.FromBase64String(Avatars._WomanDoesntExist_2),
            Title = "Rita Hillary Tyler",
            Claims = new ObservableCollection<ClaimViewModel>()
            {
                new ClaimViewModel() { Name = "Name_Given", Value = "Rita" },
                new ClaimViewModel() { Name = "Name_Given", Value = "H" },
                new ClaimViewModel() { Name = "Name_Family", Value = "Tyler" },
            }
        };
    }
}
