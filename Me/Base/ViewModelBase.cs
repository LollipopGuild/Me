using System;
using System.Collections.Generic;
using System.Reactive.Concurrency;
using System.Text;

using ReactiveUI;

namespace Me.ViewModels
{
    public class ViewModelBase : ReactiveObject
    {
        protected IScheduler MainThreadScheduler { get; }
        protected IScheduler TaskPoolScheduler { get; }

        public ViewModelBase(
            IScheduler mainThreadScheduler = null, 
            IScheduler taskPoolScheduler = null)
        {
            MainThreadScheduler = mainThreadScheduler ?? RxApp.MainThreadScheduler;
            TaskPoolScheduler = taskPoolScheduler ?? RxApp.TaskpoolScheduler;
        }

    }
}
