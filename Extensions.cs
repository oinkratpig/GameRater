using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GameRater
{
    public static class Extensions
    {
        public static Color Blend(this Color color, Color endColor, float lerpValue)
        {
            int r = (int)Lerp(color.R, endColor.R, lerpValue);
            int g = (int)Lerp(color.G, endColor.G, lerpValue);
            int b = (int)Lerp(color.B, endColor.B, lerpValue);

            return Color.FromArgb(r, g, b);

        } // end Blend

        public static float Lerp(float startValue, float endValue, float lerpValue)
        {
            return startValue * (1f - lerpValue) + endValue * lerpValue;

        } // end Lerp

    } // end class

} // end namespace