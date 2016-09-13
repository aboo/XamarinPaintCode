// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//

using System.CodeDom.Compiler;
using Foundation;

namespace XamarinPaintCode
{
    [Register("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode("iOS Designer", "1.0")]
        UIKit.UIButton BlackButton { get; set; }

        [Outlet]
        [GeneratedCode("iOS Designer", "1.0")]
        UIKit.UILabel LastActionTimeLabel { get; set; }

        [Outlet]
        [GeneratedCode("iOS Designer", "1.0")]
        UIKit.UIButton RedButton { get; set; }

        [Outlet]
        [GeneratedCode("iOS Designer", "1.0")]
        UIKit.UISwitch RedrawSwitch { get; set; }

        [Outlet]
        [GeneratedCode("iOS Designer", "1.0")]
        UIKit.UISlider SizeSlider { get; set; }

        [Outlet]
        [GeneratedCode("iOS Designer", "1.0")]
        UIKit.UIButton YellowButton { get; set; }

        void ReleaseDesignerOutlets()
        {
            if (BlackButton != null)
            {
                BlackButton.Dispose();
                BlackButton = null;
            }

            if (LastActionTimeLabel != null)
            {
                LastActionTimeLabel.Dispose();
                LastActionTimeLabel = null;
            }

            if (RedButton != null)
            {
                RedButton.Dispose();
                RedButton = null;
            }

            if (RedrawSwitch != null)
            {
                RedrawSwitch.Dispose();
                RedrawSwitch = null;
            }

            if (SizeSlider != null)
            {
                SizeSlider.Dispose();
                SizeSlider = null;
            }

            if (YellowButton != null)
            {
                YellowButton.Dispose();
                YellowButton = null;
            }
        }
    }
}