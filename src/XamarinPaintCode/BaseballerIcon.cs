using System.ComponentModel;
using System.Diagnostics;
using CoreGraphics;
using Foundation;
using UIKit;

namespace XamarinPaintCode
{
    /// <summary>
    /// The actual view class which contains the icon.
    /// </summary>
    [Register("BaseballerIcon")]
    [DesignTimeVisible(true)]
    public class BaseballerIcon : UIView
    {
        private UIColor _iconColor = UIColor.Black;

        /// <summary>
        /// The time in ms took to draw the icon.
        /// </summary>
        public long DrawTime { get; set; }

        /// <summary>
        /// Indicates if need to redraw when the size changes.
        /// </summary>
        public bool Redraw { get; set; }

        /// <summary>
        /// Changes the new colot and automatically redraws the icon.
        /// </summary>
        public UIColor IconColor
        {
            get
            {
                return _iconColor;
            }

            set
            {
                _iconColor = value;
                SetNeedsDisplay();
            }
        }

        /// <summary>
        /// The icon frame. It can be changed without actually redrawing it.
        /// </summary>
        public override CGRect Frame
        {
            get
            {
                return base.Frame;
            }
            set
            {
                base.Frame = value;
                if (Redraw)
                    SetNeedsDisplay();
                else
                    DrawTime = 0;
            }
        }

        /// <summary>
        /// Constructor based on frame.
        /// </summary>
        /// <param name="frame"></param>
        public BaseballerIcon(CGRect frame) : base(frame)
        {
        }

        /// <summary>
        /// Overriding the draw method to manually draw this view.
        /// </summary>
        /// <param name="rect">The area that the view should be drawn in.</param>
        public override void Draw(CGRect rect)
        {
            // Timing the draw.
            var sw = new Stopwatch();
            sw.Start();

            // Drawing the icon.
            Icons.DrawBaseballer(rect, this, IconColor);
            sw.Stop();

            //Updating the time consumed.
            DrawTime = sw.ElapsedMilliseconds;
        }
    }
}