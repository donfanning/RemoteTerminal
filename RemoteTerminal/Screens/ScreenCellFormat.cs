﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace RemoteTerminal.Screens
{
    public class ScreenCellFormat
    {
        public static readonly Color DefaultForegroundColor = Colors.White;
        public static readonly Color DefaultBackgroundColor = Colors.Black;

        public ScreenCellFormat()
        {
            this.Reset();
        }

        public Color ForegroundColor { get; set; }
        public Color BackgroundColor { get; set; }
        public bool BoldMode { get; set; }
        public bool UnderlineMode { get; set; }
        public bool ReverseMode { get; set; }

        public void Reset()
        {
            this.ForegroundColor = DefaultForegroundColor;
            this.BackgroundColor = DefaultBackgroundColor;
            this.BoldMode = false;
            this.UnderlineMode = false;
            this.ReverseMode = false;
        }

        public ScreenCellFormat Clone()
        {
            return new ScreenCellFormat()
            {
                ForegroundColor = this.ForegroundColor,
                BackgroundColor = this.BackgroundColor,
                BoldMode = this.BoldMode,
                UnderlineMode = this.UnderlineMode,
                ReverseMode = this.ReverseMode,
            };
        }
    }
}