﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DiHaoOA.WinForm.Common
{
    class AutoReSizeForm
    {
        public static float SH
        {
            get
            {
                return (float)Screen.PrimaryScreen.Bounds.Height;
            }
        }
        static float SW
        {
            get
            {
                return (float)Screen.PrimaryScreen.Bounds.Width;
            }
        }


        public static void SetFormSize(Control fm)
        {
            fm.Location = new Point((int)(fm.Location.X * SW), (int)(fm.Location.Y * SH));
            fm.Size = new Size((int)(fm.Size.Width * SW), (int)(fm.Size.Height * SH));
            fm.Font = new Font(fm.Font.Name, fm.Font.Size * SH, fm.Font.Style, fm.Font.Unit, fm.Font.GdiCharSet, fm.Font.GdiVerticalFont);
            if (fm.Controls.Count != 0)
            {
                SetControlSize(fm);
            }
        }

        private static void SetControlSize(Control InitC)
        {
            foreach (Control c in InitC.Controls)
            {
                c.Location = new Point((int)(c.Location.X * SW), (int)(c.Location.Y * SH));
                c.Size = new Size((int)(c.Size.Width * SW), (int)(c.Size.Height * SH));
                c.Font = new Font(c.Font.Name, c.Font.Size * SH, c.Font.Style, c.Font.Unit, c.Font.GdiCharSet, c.Font.GdiVerticalFont);
                if (c.Controls.Count != 0)
                {
                    SetControlSize(c);
                }
            }
        }
    }
}
