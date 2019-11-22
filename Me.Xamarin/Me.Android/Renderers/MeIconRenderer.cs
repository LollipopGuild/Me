using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamForms = Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: XamForms.ExportRenderer(typeof(Me.Forms.Controls.MeIconLabel), typeof(When.Droid.Custom.Renderers.MeIconLabelRenderer))]
[assembly: XamForms.ExportRenderer(typeof(Me.Forms.Controls.MeIconButton), typeof(When.Droid.Custom.Renderers.MeIconButtonRenderer))]
namespace When.Droid.Custom.Renderers
{
    public class MeIconLabelRenderer : LabelRenderer
    {
        public MeIconLabelRenderer(Context ctx) : base(ctx)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<XamForms.Label> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Typeface = Typeface.CreateFromAsset(Context.Assets,
                    "Fonts/me.ttf");
            }
        }
    }

    public class MeIconButtonRenderer : ButtonRenderer
    {
        public MeIconButtonRenderer(Context ctx) : base(ctx)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<XamForms.Button> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Typeface = Typeface.CreateFromAsset(Context.Assets,
                    "Fonts/me.ttf");
            }
        }
    }
}