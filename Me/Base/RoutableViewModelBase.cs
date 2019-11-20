using System;
using System.Collections.Generic;
using System.Text;

using ReactiveUI;
using Splat;

namespace Me.ViewModels
{
    public abstract class RoutableViewModelBase : ViewModelBase, IRoutableViewModel
    {
        public string UrlPathSegment { get; }
        public IScreen HostScreen { get; }

        public RoutableViewModelBase(string pathSegment)
        {
            UrlPathSegment = pathSegment;
            HostScreen = Locator.Current.GetService<IScreen>();
        }
    }
}
