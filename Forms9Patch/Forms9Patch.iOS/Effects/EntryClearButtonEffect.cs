using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportEffect(typeof(Forms9Patch.iOS.EntryClearButtonEffect), "EntryClearButtonEffect")]
namespace Forms9Patch.iOS
{
    [Xamarin.Forms.Internals.Preserve(AllMembers = true)]
    public class EntryClearButtonEffect : PlatformEffect
    {
        protected override void OnAttached()
            => ((UITextField)Control).ClearButtonMode = UITextFieldViewMode.WhileEditing;


        protected override void OnDetached() { }
    }
}
