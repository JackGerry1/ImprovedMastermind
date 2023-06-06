using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImprovedMastermind
{
    /// <summary>
    /// Inherits all of the functionality of a regular button, but allowing it to be an elipse.
    /// </summary>
    public class CircleButtons : Button
    {
        /// <summary>
        /// Overrides the default OnPaint method, so it has the same functions as a regular button.
        /// This is allows the user to change colour, size and position like a regular button.
        /// </summary>
        /// <param name="paint">Allows the base class to perform any OnPaint Methods</param>
        protected override void OnPaint(PaintEventArgs paint)
        {
            GraphicsPath graphics = new();
            graphics.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            Region = new Region(graphics);
            base.OnPaint(paint);
        }
    }
}
