using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Xamarin.Forms;
using JustificationMode_Label.Helpers;
using JustificationMode_Label.Droid;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomLabel), typeof(CustomLabelRender))]
namespace JustificationMode_Label.Droid
{
    public class CustomLabelRender: LabelRenderer
    {
        public CustomLabelRender(Context context): base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
                Control.JustificationMode = Android.Text.JustificationMode.InterWord;
        }
    }
}