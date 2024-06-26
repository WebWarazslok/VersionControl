﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCC_Proba
{
    public class myProgressBar:Control
    {
        public myProgressBar()
        {
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, false);
            Maximum = 100;
            this.ForeColor = Color.DarkRed;
            this.BackColor = Color.DimGray;
        }
        public decimal Minimum { get; set; }  // fix: call Invalidate in setter
        public decimal Maximum { get; set; }  // fix as above

        private decimal mValue;
        public decimal Value
        {
            get { return mValue; }
            set { mValue = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var rc = new RectangleF(0, 0, (float)(this.Width * (Value - Minimum) / Maximum), this.Height);
            using (var br = new SolidBrush(this.ForeColor))
            {
                e.Graphics.FillRectangle(br, rc);
            }
            base.OnPaint(e);
        }
    }
}
