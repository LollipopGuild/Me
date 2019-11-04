using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Me.ViewModels;
using ReactiveUI.XamForms;

namespace Me.Forms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClaimView : ReactiveContentView<ClaimViewModel>
    {
        public ClaimView()
        {
            InitializeComponent();
        }
    }
}