using System;
using System.Collections.Generic;
using System.Text;

namespace Ex33
{
    internal class RectAngle : ISurface, ICircumference, IBounds
    {
        readonly public float width;
        readonly public float height;
        public RectAngle(float width, float height = 0)
        {
            this.width = width;
            this.height = height;
        } 
        public float GetSurface()
        {
            return width * height;
        }
        public float GetCircumference()
        {
            return (width * height) * 2;
        }
        public void GetBounds(out float width, out float height)
        {
            width = this.width;
            height = this.height;
        }
        public static bool operator ==(RectAngle rectAngle, RectAngle rectAngle2)
        {
            return rectAngle.width == rectAngle2.width
                && rectAngle.height == rectAngle2.height
                || rectAngle.width == rectAngle.height
                && rectAngle.height == rectAngle2.width;
        }

        public static bool operator !=(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            return !(rectAngle1 == rectAngle2);
        }

        public static RectAngle operator +(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            int num = 0;
            RectAngle[] pattern= new RectAngle[4];

            if(rectAngle1.height> rectAngle2.height)
            {
                pattern[0] = new RectAngle(rectAngle1.width + rectAngle2.width, rectAngle1.height);
            }
            else
            {
                pattern[0] = new RectAngle(rectAngle1.width + rectAngle2.width, rectAngle2.height);
            }

            if(rectAngle1.height > rectAngle2.width)
            {
                pattern[1] = new RectAngle(rectAngle1.width + rectAngle2.height, rectAngle1.height);
            }
            else
            {
                pattern[1] = new RectAngle(rectAngle1.width + rectAngle2.height, rectAngle2.width);
            }
            if (rectAngle1.width > rectAngle2.height)
            {
                pattern[2] = new RectAngle(rectAngle1.height + rectAngle2.width, rectAngle1.width);
            }
            else
            {
                pattern[2] = new RectAngle(rectAngle1.height + rectAngle2.width, rectAngle2.height);
            }

            if (rectAngle1.width > rectAngle2.width)
            {
                pattern[3] = new RectAngle(rectAngle1.height + rectAngle2.height, rectAngle1.width);
            }
            else
            {
                pattern[3] = new RectAngle(rectAngle1.height + rectAngle2.height, rectAngle2.width);
            }

            for (int i = 0; i < pattern.Length; i++)
            {
                if (pattern[i].width * pattern[i].height < pattern[num].width * pattern[num].height)
                {
                    num = i;
                }
            }
            return pattern[num];
        }
    }
}
