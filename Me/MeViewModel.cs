using System;
using System.Collections.Generic;
using System.Text;

using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace Me
{
    public class MeViewModel : ReactiveObject
    {
        [Reactive]
        public Byte[] Picture { get; set; }

        [Reactive]
        public string[] GivenNames { get; set; }

        [Reactive]
        public string FamilyName { get; set; }
    }
}
