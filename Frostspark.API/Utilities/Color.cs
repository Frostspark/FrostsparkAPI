﻿using System;

namespace Frostspark.API.Utilities
{
    public struct Color : IEquatable<Color>
    {
        public Color(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }

        public readonly byte R;
        public readonly byte G;
        public readonly byte B;

        public uint PackedValue => (uint)(R | (G << 8) | (B << 16));

        public string Hex => $"{R:X2}{G:X2}{B:X2}";

        public override bool Equals(object obj)
        {
            return obj is Color color && Equals(color);
        }

        public bool Equals(Color other)
        {
            return R == other.R &&
                   G == other.G &&
                   B == other.B;
        }

        public override int GetHashCode()
        {
            var hashCode = -1520100960;
            hashCode = hashCode * -1521134295 + R.GetHashCode();
            hashCode = hashCode * -1521134295 + G.GetHashCode();
            hashCode = hashCode * -1521134295 + B.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Color left, Color right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Color left, Color right)
        {
            return !(left == right);
        }

        public static Color Transparent => new Color(255, 255, 255);

        public static Color AliceBlue => new Color(240, 248, 255);

        public static Color AntiqueWhite => new Color(250, 235, 215);

        public static Color Aqua => new Color(0, 255, 255);

        public static Color Aquamarine => new Color(127, 255, 212);

        public static Color Azure => new Color(240, 255, 255);

        public static Color Beige => new Color(245, 245, 220);

        public static Color Bisque => new Color(255, 228, 196);

        public static Color Black => new Color(0, 0, 0);

        public static Color BlanchedAlmond => new Color(255, 235, 205);

        public static Color Blue => new Color(0, 0, 255);

        public static Color BlueViolet => new Color(138, 43, 226);

        public static Color Brown => new Color(165, 42, 42);

        public static Color BurlyWood => new Color(222, 184, 135);

        public static Color CadetBlue => new Color(95, 158, 160);

        public static Color Chartreuse => new Color(127, 255, 0);

        public static Color Chocolate => new Color(210, 105, 30);

        public static Color Coral => new Color(255, 127, 80);

        public static Color CornflowerBlue => new Color(100, 149, 237);

        public static Color Cornsilk => new Color(255, 248, 220);

        public static Color Crimson => new Color(220, 20, 60);

        public static Color Cyan => new Color(0, 255, 255);

        public static Color DarkBlue => new Color(0, 0, 139);

        public static Color DarkCyan => new Color(0, 139, 139);

        public static Color DarkGoldenrod => new Color(184, 134, 11);

        public static Color DarkGray => new Color(169, 169, 169);

        public static Color DarkGreen => new Color(0, 100, 0);

        public static Color DarkKhaki => new Color(189, 183, 107);

        public static Color DarkMagenta => new Color(139, 0, 139);

        public static Color DarkOliveGreen => new Color(85, 107, 47);

        public static Color DarkOrange => new Color(255, 140, 0);

        public static Color DarkOrchid => new Color(153, 50, 204);

        public static Color DarkRed => new Color(139, 0, 0);

        public static Color DarkSalmon => new Color(233, 150, 122);

        public static Color DarkSeaGreen => new Color(143, 188, 139);

        public static Color DarkSlateBlue => new Color(72, 61, 139);

        public static Color DarkSlateGray => new Color(47, 79, 79);

        public static Color DarkTurquoise => new Color(0, 206, 209);

        public static Color DarkViolet => new Color(148, 0, 211);

        public static Color DeepPink => new Color(255, 20, 147);

        public static Color DeepSkyBlue => new Color(0, 191, 255);

        public static Color DimGray => new Color(105, 105, 105);

        public static Color DodgerBlue => new Color(30, 144, 255);

        public static Color Firebrick => new Color(178, 34, 34);

        public static Color FloralWhite => new Color(255, 250, 240);

        public static Color ForestGreen => new Color(34, 139, 34);

        public static Color Fuchsia => new Color(255, 0, 255);

        public static Color Gainsboro => new Color(220, 220, 220);

        public static Color GhostWhite => new Color(248, 248, 255);

        public static Color Gold => new Color(255, 215, 0);

        public static Color Goldenrod => new Color(218, 165, 32);

        public static Color Gray => new Color(128, 128, 128);

        public static Color Green => new Color(0, 128, 0);

        public static Color GreenYellow => new Color(173, 255, 47);

        public static Color Honeydew => new Color(240, 255, 240);

        public static Color HotPink => new Color(255, 105, 180);

        public static Color IndianRed => new Color(205, 92, 92);

        public static Color Indigo => new Color(75, 0, 130);

        public static Color Ivory => new Color(255, 255, 240);

        public static Color Khaki => new Color(240, 230, 140);

        public static Color Lavender => new Color(230, 230, 250);

        public static Color LavenderBlush => new Color(255, 240, 245);

        public static Color LawnGreen => new Color(124, 252, 0);

        public static Color LemonChiffon => new Color(255, 250, 205);

        public static Color LightBlue => new Color(173, 216, 230);

        public static Color LightCoral => new Color(240, 128, 128);

        public static Color LightCyan => new Color(224, 255, 255);

        public static Color LightGoldenrodYellow => new Color(250, 250, 210);

        public static Color LightGreen => new Color(144, 238, 144);

        public static Color LightGray => new Color(211, 211, 211);

        public static Color LightPink => new Color(255, 182, 193);

        public static Color LightSalmon => new Color(255, 160, 122);

        public static Color LightSeaGreen => new Color(32, 178, 170);

        public static Color LightSkyBlue => new Color(135, 206, 250);

        public static Color LightSlateGray => new Color(119, 136, 153);

        public static Color LightSteelBlue => new Color(176, 196, 222);

        public static Color LightYellow => new Color(255, 255, 224);

        public static Color Lime => new Color(0, 255, 0);

        public static Color LimeGreen => new Color(50, 205, 50);

        public static Color Linen => new Color(250, 240, 230);

        public static Color Magenta => new Color(255, 0, 255);

        public static Color Maroon => new Color(128, 0, 0);

        public static Color MediumAquamarine => new Color(102, 205, 170);

        public static Color MediumBlue => new Color(0, 0, 205);

        public static Color MediumOrchid => new Color(186, 85, 211);

        public static Color MediumPurple => new Color(147, 112, 219);

        public static Color MediumSeaGreen => new Color(60, 179, 113);

        public static Color MediumSlateBlue => new Color(123, 104, 238);

        public static Color MediumSpringGreen => new Color(0, 250, 154);

        public static Color MediumTurquoise => new Color(72, 209, 204);

        public static Color MediumVioletRed => new Color(199, 21, 133);

        public static Color MidnightBlue => new Color(25, 25, 112);

        public static Color MintCream => new Color(245, 255, 250);

        public static Color MistyRose => new Color(255, 228, 225);

        public static Color Moccasin => new Color(255, 228, 181);

        public static Color NavajoWhite => new Color(255, 222, 173);

        public static Color Navy => new Color(0, 0, 128);

        public static Color OldLace => new Color(253, 245, 230);

        public static Color Olive => new Color(128, 128, 0);

        public static Color OliveDrab => new Color(107, 142, 35);

        public static Color Orange => new Color(255, 165, 0);

        public static Color OrangeRed => new Color(255, 69, 0);

        public static Color Orchid => new Color(218, 112, 214);

        public static Color PaleGoldenrod => new Color(238, 232, 170);

        public static Color PaleGreen => new Color(152, 251, 152);

        public static Color PaleTurquoise => new Color(175, 238, 238);

        public static Color PaleVioletRed => new Color(219, 112, 147);

        public static Color PapayaWhip => new Color(255, 239, 213);

        public static Color PeachPuff => new Color(255, 218, 185);

        public static Color Peru => new Color(205, 133, 63);

        public static Color Pink => new Color(255, 192, 203);

        public static Color Plum => new Color(221, 160, 221);

        public static Color PowderBlue => new Color(176, 224, 230);

        public static Color Purple => new Color(128, 0, 128);

        public static Color Red => new Color(255, 0, 0);

        public static Color RosyBrown => new Color(188, 143, 143);

        public static Color RoyalBlue => new Color(65, 105, 225);

        public static Color SaddleBrown => new Color(139, 69, 19);

        public static Color Salmon => new Color(250, 128, 114);

        public static Color SandyBrown => new Color(244, 164, 96);

        public static Color SeaGreen => new Color(46, 139, 87);

        public static Color SeaShell => new Color(255, 245, 238);

        public static Color Sienna => new Color(160, 82, 45);

        public static Color Silver => new Color(192, 192, 192);

        public static Color SkyBlue => new Color(135, 206, 235);

        public static Color SlateBlue => new Color(106, 90, 205);

        public static Color SlateGray => new Color(112, 128, 144);

        public static Color Snow => new Color(255, 250, 250);

        public static Color SpringGreen => new Color(0, 255, 127);

        public static Color SteelBlue => new Color(70, 130, 180);

        public static Color Tan => new Color(210, 180, 140);

        public static Color Teal => new Color(0, 128, 128);

        public static Color Thistle => new Color(216, 191, 216);

        public static Color Tomato => new Color(255, 99, 71);

        public static Color Turquoise => new Color(64, 224, 208);

        public static Color Violet => new Color(238, 130, 238);

        public static Color Wheat => new Color(245, 222, 179);

        public static Color White => new Color(255, 255, 255);

        public static Color WhiteSmoke => new Color(245, 245, 245);

        public static Color Yellow => new Color(255, 255, 0);

        public static Color YellowGreen => new Color(154, 205, 50);
    }
}
