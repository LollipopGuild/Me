using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using ReactiveUI.XamForms;

namespace Me.Forms
{
    public class MeView_Reactive : ReactiveContentPage<MeViewModel> { }

    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MeView : MeView_Reactive
    {
        public MeView()
        {
            InitializeComponent();
        }
    }
}
