using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

using ReactiveUI;
using Splat;

using Me.Forms.Views;
using Me.ViewModels;
using Me.Mockup;

namespace Me.Forms
{
    public class AppBootstrapper : IScreen
    {
        public RoutingState Router => new RoutingState();

        public AppBootstrapper()
        {
            Locator.CurrentMutable.RegisterConstant(this, typeof(IScreen));
            // inject mockup wallet for now
            Locator.CurrentMutable.RegisterConstant(Mocks.MockupWallet, typeof(WalletViewModel));

            RegisterViews();
            RegisterViewModels();
            Locator.CurrentMutable.RegisterViewsForViewModels(Assembly.GetCallingAssembly());
        }

        private void RegisterViews()
        {
            // pages (routable)
            Locator.CurrentMutable.Register(() => new WalletView(), typeof(IViewFor<WalletViewModel>));
            Locator.CurrentMutable.Register(() => new PersonaView(), typeof(IViewFor<PersonaViewModel>));
            // cells
            Locator.CurrentMutable.Register(() => new ClaimView(), typeof(IViewFor<ClaimViewModel>));
        }

        private void RegisterViewModels()
        {
            // Here, we use contracts to distinguish which routable view model we want to instantiate.
            // This helps us avoid a manual cast to IRoutableViewModel when calling Router.Navigate.Execute(...)
            Locator.CurrentMutable.Register(() => new WalletViewModel(), typeof(IRoutableViewModel), typeof(WalletViewModel).FullName);
            Locator.CurrentMutable.Register(() => new PersonaViewModel(), typeof(IRoutableViewModel), typeof(PersonaViewModel).FullName);
        }
    }
}
