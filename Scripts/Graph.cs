using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Adderley
{
    class Graph
    {
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

        public static void Show_dissolve(CircleShape cir, byte speed, byte a)
        {
            int proz = cir.FillColor.A + speed;
            if (proz >= a)
                cir.FillColor = new Color(cir.FillColor.R, cir.FillColor.G, cir.FillColor.B, a);
            else
                cir.FillColor = new Color(cir.FillColor.R, cir.FillColor.G, cir.FillColor.B, (byte)proz);
        }

        public static void Hide_dissolve(Text text, int speed, byte a)
        {
            int proz = text.FillColor.A - speed;
            if (proz <= a)
                text.FillColor = new Color(text.FillColor.R, text.FillColor.G, text.FillColor.B, a);
            else
                text.FillColor = new Color(text.FillColor.R, text.FillColor.G, text.FillColor.B, (byte)proz);
        }

        public static void Hide_dissolve(CircleShape cir, int speed, byte a)
        {
            int proz = cir.FillColor.A - speed;
            if (proz <= a)
                cir.FillColor = new Color(cir.FillColor.R, cir.FillColor.G, cir.FillColor.B, a);
            else
                cir.FillColor = new Color(cir.FillColor.R, cir.FillColor.G, cir.FillColor.B, (byte)proz);
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
            if (MathHelper.GetDistance(pos, pos1) < rad + rad1 && MathHelper.GetDistance(pos, pos1) > Math.Abs(rad - rad1))
            {
                return true;
            }
            return false;
        }

        public static IntRect GetIntRect(IntRect rect, bool b1, bool b2, bool b3, bool b4, Texture text)
        {
            Image image = text.CopyToImage();
            int left = 0;
            int top = 0;
            int width = 0;
            int height = 0;
            if (b1)
            {
                left = rect.Left;
            }
            else
            {
                for (int i = rect.Left, res = 0; res != 1; i++)
                {
                    for (int j = rect.Top, ris = 0; ris != 1 && j != rect.Top + rect.Height; j++)
                    {
                        if (image.GetPixel((uint)i, (uint)j).A != 0)
                        {
                            left = i;
                            res = 1;
                            ris = 1;
                        }
                    }
                }
            }
            if (b2)
            {
                top = rect.Top;
            }
            else
            {
                for (int i = rect.Top, res = 0; res != 1; i++)
                {
                    for (int j = rect.Left, ris = 0; ris != 1 && j != rect.Left + rect.Width; j++)
                    {
                        if (image.GetPixel((uint)j, (uint)i).A != 0)
                        {
                            top = i;
                            res = 1;
                            ris = 1;
                        }
                    }
                }
            }
            if (b3)
            {
                width = rect.Width;
            }
            else
            {
                for (int i = rect.Left + rect.Width, res = 0; res != 1; i--)
                {
                    for (int j = rect.Top, ris = 0; ris != 1 && j != rect.Top + rect.Height; j++)
                    {
                        if (image.GetPixel((uint)i, (uint)j).A != 0)
                        {
                            width = i;
                            res = 1;
                            ris = 1;
                        }
                    }
                }
            }
            if (b4)
            {
                height = rect.Height;
            }
            else
            {
                for (int i = rect.Top + rect.Height, res = 0; res != 1; i--)
                {
                    for (int j = rect.Left, ris = 0; ris != 1 && j != rect.Left + rect.Width; j++)
                    {
                        if (image.GetPixel((uint)j, (uint)i).A != 0)
                        {
                            height = i;
                            res = 1;
                            ris = 1;
                        }
                    }
                }
            }

            if (!b1 && !b3)
                width = width - left;
            if (!b2 && !b4)
                height = height - top;

            return new IntRect(left, top, width, height);
        }

        public static RectangleShape Rect(Texture texture)
        {
            RectangleShape rect = new RectangleShape();
            rect.Texture = texture;
            rect.TextureRect = new IntRect(0, 0, (int)texture.Size.X, (int)texture.Size.Y);

            return rect;
        }

        public static IntRect GetIntR(Texture texture)
        {
            return new IntRect(0, 0, (int)texture.Size.X, (int)texture.Size.Y);
        }
    }

    //class Bound
    //{
    //    public static float Left(object obj)
    //    {
    //        Type nm = obj.GetType();
    //        MethodInfo method = nm.GetMethod("GetGlobalBounds");
    //        FloatRect rect = method.Invoke(obj, new object[] { 3 });
    //    }
    //}
}
