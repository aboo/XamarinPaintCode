using System;
using CoreGraphics;
using UIKit;

namespace XamarinPaintCode
{
    public partial class ViewController : UIViewController
    {
        private BaseballerIcon _baseballerIcon;

        protected ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            CreateIcon(SizeSlider.Value);

            RedrawSwitch.ValueChanged += (sender, args) => { if (_baseballerIcon != null) _baseballerIcon.Redraw = RedrawSwitch.On; };
            RedButton.TouchUpInside += (sender, e) => ChangeColor(UIColor.Red);
            YellowButton.TouchUpInside += (sender, e) => ChangeColor(UIColor.Blue);
            BlackButton.TouchUpInside += (sender, e) => ChangeColor(UIColor.Black);
            SizeSlider.ValueChanged += ChangeSize;

            Add(_baseballerIcon);
        }

        private void ChangeColor(UIColor color)
        {
            if (_baseballerIcon == null)
                return;
            _baseballerIcon.IconColor = color;
            UpdateTimeLabel();
        }

        private void ChangeSize(object sender, EventArgs e)
        {
            CreateIcon(SizeSlider.Value);
        }

        /// <summary>
        /// Create the icon based on the slider value.
        /// </summary>
        /// <param name="multiplier">The scale.</param>
        private void CreateIcon(float multiplier)
        {
            var bounds = UIScreen.MainScreen.Bounds;
            var newWidth = bounds.Width * multiplier / 100;
            CreateIcon(new CGSize(newWidth, newWidth), bounds);
        }

        /// <summary>
        /// Create the icon with a specific size and bounds.
        /// </summary>
        /// <param name="size">The size of the icon.</param>
        /// <param name="bounds">The bounds.</param>
        private void CreateIcon(CGSize size, CGRect bounds)
        {
            var x = (bounds.Width - size.Width) / 2;
            var y = (bounds.Height - size.Height) / 2;
            var frame = new CGRect(x, y, size.Width, size.Height);

            if (_baseballerIcon == null)
            {
                _baseballerIcon = new BaseballerIcon(frame)
                {
                    Opaque = false,
                    Redraw = RedrawSwitch.On
                };
            }
            else
            {
                _baseballerIcon.Frame = frame;
            }

            UpdateTimeLabel();
        }

        /// <summary>
        /// Update the time consumed label with the time consumed by last action to draw icon.
        /// </summary>
        private void UpdateTimeLabel()
        {
            LastActionTimeLabel.Text = $"{_baseballerIcon.DrawTime} ms";
        }
    }
}