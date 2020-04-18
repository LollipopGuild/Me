using System;
using System.Collections.Generic;
using System.Reactive.Concurrency;
using System.Text;

using ReactiveUI;
using Splat;

namespace Me.ViewModels
{
    public abstract class RoutableViewModelBase : ViewModelBase, IRoutableViewModel
    {
        public string UrlPathSegment { get; protected set; }
        public IScreen HostScreen { get; }

        public RoutableViewModelBase(string pathSegment,
            IScreen hostScreen = null, 
            IScheduler mainThreadScheduler = null, 
            IScheduler taskPoolScheduler = null) : base(mainThreadScheduler, taskPoolScheduler)
        {
            UrlPathSegment = pathSegment;
            HostScreen = hostScreen ?? Locator.Current.GetService<IScreen>();
        }
    }
}
