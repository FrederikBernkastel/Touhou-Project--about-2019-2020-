using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;

namespace Adderley
{
    class MathHelper
    {
        // дистанция между точками
        public static float GetDistance(Vector2f v1, Vector2f v2)
        {
            return (float)Math.Sqrt((v2.X - v1.X) * (v2.X - v1.X) + (v2.Y - v1.Y) * (v2.Y - v1.Y));
        }

        // наведён ли курсор на данный текст
        public static bool IsMouseOver(Text text)
        {
            float mouseX = Mouse.GetPosition().X;
            float mouseY = Mouse.GetPosition().Y;

            float textPosX = text.GetGlobalBounds().Left;
            float textPosY = text.GetGlobalBounds().Top;

            float textxPosWidth = text.GetGlobalBounds().Left + text.GetGlobalBounds().Width;
            float textyPosHeight = text.GetGlobalBounds().Top + text.GetGlobalBounds().Height;

            if (mouseX < textxPosWidth && mouseX > textPosX && mouseY < textyPosHeight && mouseY > textPosY)
            {
                return true;
            }

            return false;
        }

        // угол точек относительно первой (в углах)
        public static float GetAngle(Vector2f v1, Vector2f v2)
        {
            return (float)(Math.PI * (Math.Atan2(v2.Y - v1.Y, v2.X - v1.X) / Math.PI * 180) / 180);
        }

        // дистанция между точками
        public static float GetDistance(float x1, float y1, float x2, float y2)
        {
            return (float)Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }

        // определяет длину вектора
        public static float GetDistance(Vector2f vec)
        {
            return (float)Math.Sqrt(vec.X * vec.X + vec.Y * vec.Y);
        }

        // нормализация вектора
        public static Vector2f Normalize(Vector2f vec)
        {
            float len = GetDistance(vec);
            vec.X /= len;
            vec.Y /= len;
            return vec;
        }

        public static List<Vector2f> CalcCubicBezier(Vector2f start, Vector2f end, Vector2f startControl, Vector2f endControl, int numSegments)
        {
            List<Vector2f> ret = new List<Vector2f>();

            ret.Add(start);
            float p = 1f / numSegments;
            float q = p;
            for (int i = 1; i < numSegments; i++, p += q)
                ret.Add(p * p * p * (end + 3f * (startControl - endControl) - start) +
                              3f * p * p * (start - 2f * startControl + endControl) +
                              3f * p * (startControl - start) + start);
            ret.Add(end);

            return ret;
        }

        public static void A(Sprite sprite, byte bit)
        {
            sprite.Color = new Color(sprite.Color.R, sprite.Color.G, sprite.Color.B, bit);
        }

        public static void A(Text text, byte bit)
        {
            text.FillColor = new Color(text.FillColor.R, text.FillColor.G, text.FillColor.B, bit);
        }

        public static void A(RectangleShape rect, byte bit)
        {
            rect.FillColor = new Color(rect.FillColor.R, rect.FillColor.G, rect.FillColor.B, bit);
        }

        public static Vector2f Lerp(Vector2f from, Vector2f to, float t)
        {
            t = Clamp01(t);
            return new Vector2f(from.X + ((to.X - from.X) * t), from.Y + ((to.Y - from.Y) * t));
        }

        public static float Clamp01(float value)
        {
            if (value < 0f) return 0f;
            if (value > 1f) return 1f;
            return value;
        }

        public static float Clamp(float f, float min, float max)
        {
            if (f < min) return min;
            else if (f > max) return max;
            else return f;
        }

        //public static float Smoothstep(float a, float b, float t)
        //{
        //    t = Clamp((t - a) / (b - a), 0.0f, 1.0f);
        //    return t * t * (3 - 2 * t);
        //}

        public static void Show_dissolve(Text text, byte speed, byte a)
        {
            int proz = text.FillColor.A + speed;
            if (proz >= a)
                text.FillColor = new Color(text.FillColor.R, text.FillColor.G, text.FillColor.B, a);
            else
                text.FillColor = new Color(text.FillColor.R, text.FillColor.G, text.FillColor.B, (byte)proz);
        }

        public static void Show_dissolve(Sprite sprite, byte speed, byte a)
        {
            int proz = sprite.Color.A + speed;
            if (proz >= a)
                sprite.Color = new Color(sprite.Color.R, sprite.Color.G, sprite.Color.B, a);
            else
                sprite.Color = new Color(sprite.Color.R, sprite.Color.G, sprite.Color.B, (byte)proz);
        }

        public static void Hide_dissolve(Text text, int speed, byte a)
        {
            int proz = text.FillColor.A - speed;
            if (proz <= a)
                text.FillColor = new Color(text.FillColor.R, text.FillColor.G, text.FillColor.B, a);
            else
                text.FillColor = new Color(text.FillColor.R, text.FillColor.G, text.FillColor.B, (byte)proz);
        }

        public static void Hide_dissolve(Sprite sprite, int speed, byte a)
        {
            int proz = sprite.Color.A - speed;
            if (proz <= a)
                sprite.Color = new Color(sprite.Color.R, sprite.Color.G, sprite.Color.B, a);
            else
                sprite.Color = new Color(sprite.Color.R, sprite.Color.G, sprite.Color.B, (byte)proz);
        }

        public static void Show_dissolve(RectangleShape rect, byte speed, byte a)
        {
            int proz = rect.FillColor.A + speed;
            if (proz >= a)
                rect.FillColor = new Color(rect.FillColor.R, rect.FillColor.G, rect.FillColor.B, a);
            else
                rect.FillColor = new Color(rect.FillColor.R, rect.FillColor.G, rect.FillColor.B, (byte)proz);
        }

        public static void Hide_dissolve(RectangleShape rect, int speed, byte a)
        {
            int proz = rect.FillColor.A - speed;
            if (proz <= a)
                rect.FillColor = new Color(rect.FillColor.R, rect.FillColor.G, rect.FillColor.B, a);
            else
                rect.FillColor = new Color(rect.FillColor.R, rect.FillColor.G, rect.FillColor.B, (byte)proz);
        }

        public static bool CirCollide(Vector2f pos, Vector2f pos1, float rad, float rad1)
        {
            if (GetDistance(pos, pos1) < rad + rad1 && GetDistance(pos, pos1) > Math.Abs(rad - rad1))
            {
                return true;
            }
            return false;
        }
    }
}
