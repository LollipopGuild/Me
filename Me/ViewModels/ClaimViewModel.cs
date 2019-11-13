﻿using System;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace Me.ViewModels
{
    public class ClaimViewModel : ReactiveObject
    {
        [Reactive]
        public string Name { get; set; }
        [Reactive]
        public string Value { get; set; }
    }
}