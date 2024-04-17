using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPanel.pnlRounded
{
    public class RoundedPanel : Panel
    {
        public int CornerRadius { get; set; } = 20;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (GraphicsPath path = new GraphicsPath())
            {
                int width = Width;
                int height = Height;
                int radius = CornerRadius;

                path.StartFigure();
                path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
                path.AddLine(radius, 0, width - radius, 0);
                path.AddArc(width - 2 * radius, 0, radius * 2, radius * 2, 270, 90);
                path.AddLine(width, radius, width, height - radius);
                path.AddArc(width - 2 * radius, height - 2 * radius, radius * 2, radius * 2, 0, 90);
                path.AddLine(width - radius, height, radius, height);
                path.AddArc(0, height - 2 * radius, radius * 2, radius * 2, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);
            }
        }
    }
}

