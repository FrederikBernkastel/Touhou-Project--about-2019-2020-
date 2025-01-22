using SFML.Graphics;
using SFML.System;
using System;

namespace Adderley
{
    class Info : Transformable, Drawable
    {
        public static Text info1;
        public static Text info2;
        public static Text info3;
        public static Text info6;
        public static Text info7;
        public static Text info8;

        public static Sprite inSp1;
        public static Sprite inSp2;
        public static Sprite inSp3;
        public static Sprite inSp4;
        public static Sprite inSp5;

        public static Sprite ZagSpr1;
        public static Sprite ZagSpr2;
        public static Sprite ZagSpr3;
        public static Sprite ZagSpr4;

        public static Clock clock;
        public static Time dt;
        public static Time statsTotalTimeElapsed;

        public static float statsNumberOfFrames = 0;
        public static long chet = 999999999;
        public static long record = 999999999;
        public static long ochk = 999999;
        public static int Pfull = 128;
        public static long Greyz = 999999;
        public static int proz2;

        public static bool isZagMove;

        public Info()
        {
            info6 = new Text("0", Content.font, 20);
            info7 = new Text("0", Content.font, 35);
            info8 = new Text("0", Content.font, 35);
            info1 = new Text("0", Content.font, 30);
            info2 = new Text("0", Content.font, 30);
            info3 = new Text("0", Content.font, 30);

            ZagSpr1 = new Sprite(Content.zanaz1);
            ZagSpr2 = new Sprite(Content.zanaz2);
            ZagSpr3 = new Sprite(Content.zanaz3);
            ZagSpr4 = new Sprite(Content.zanaz4);

            proz2 = 0;

            info6.FillColor = Color.White;
            info7.FillColor = new Color(175, 175, 175, 255);
            info8.FillColor = Color.White;
            info1.FillColor = new Color(221, 213, 0, 255);
            info2.FillColor = new Color(175, 151, 255, 255);
            info3.FillColor = new Color(76, 224, 125, 255);

            clock = new Clock();

            info7.Position = new Vector2f(795 - info7.GetGlobalBounds().Width, 1);
            info8.Position = new Vector2f(795 - info8.GetGlobalBounds().Width, 38);
            info1.Position = new Vector2f(890, info7.Position.Y);
            info2.Position = new Vector2f(info1.Position.X, info8.Position.Y);
            info3.Position = new Vector2f(1095, 21);

            ZagSpr4.Position = new Vector2f(0 - ZagSpr4.GetGlobalBounds().Width - 5, 20);
            ZagSpr1.Position = ZagSpr4.Position;
            ZagSpr2.Position = ZagSpr4.Position;
            ZagSpr3.Position = ZagSpr4.Position;

            inSp1 = new Sprite(Content.ChO);
            inSp2 = new Sprite(Content.ChP);
            inSp3 = new Sprite(Content.CH);
            inSp4 = new Sprite(Content.LiW);
            inSp5 = new Sprite(Content.LiW);

            inSp2.Position = new Vector2f(830, 3);
            inSp1.Position = new Vector2f(inSp2.Position.X, 40);
            inSp3.Position = new Vector2f(1066, 6);
            inSp4.Position = new Vector2f(51, 95);
            inSp5.Position = new Vector2f(inSp4.Position.X, 80);

            isZagMove = false;
        }

        public void Update()
        {
            statsTotalTimeElapsed += dt;
            statsNumberOfFrames += 1;

            if (statsTotalTimeElapsed >= Time.FromSeconds(1f))
            {
                info6.DisplayedString = Convert.ToString(statsNumberOfFrames);
                info6.Position = new Vector2f(Program.Window.Size.X - info6.GetGlobalBounds().Width - 5, Program.Window.Size.Y - info6.GetGlobalBounds().Height - 10);
                statsTotalTimeElapsed -= Time.FromSeconds(1f);
                statsNumberOfFrames = 0f;
            }

            dt = clock.Restart();

            if (record >= 999999999)
                record = 999999999;
            if (chet >= 999999999)
                chet = 999999999;
            if (ochk >= 999999999)
                ochk = 999999999;
            if (Greyz >= 999999999)
                Greyz = 999999999;
            if (Pfull >= 128)
                Pfull = 128;

            info7.DisplayedString = Convert.ToString(record);
            info8.DisplayedString = Convert.ToString(chet);
            info2.DisplayedString = Convert.ToString(ochk);
            info1.DisplayedString = Convert.ToString(Pfull) + " " + "/" + " " + "128";
            info3.DisplayedString = Convert.ToString(Greyz);

            info7.Position = new Vector2f(785 - info7.GetGlobalBounds().Width, -4);
            info8.Position = new Vector2f(785 - info8.GetGlobalBounds().Width, 33);

            if (isZagMove)
            {
                float dist1 = MathHelper.GetDistance(new Vector2f(0 - ZagSpr4.GetGlobalBounds().Width - 5, ZagSpr4.Position.Y), new Vector2f(40, ZagSpr4.Position.Y));
                float dist2 = MathHelper.GetDistance(new Vector2f(0 - ZagSpr4.GetGlobalBounds().Width - 5, ZagSpr4.Position.Y), new Vector2f(193, ZagSpr4.Position.Y));
                float dist3 = MathHelper.GetDistance(new Vector2f(0 - ZagSpr4.GetGlobalBounds().Width - 5, ZagSpr4.Position.Y), new Vector2f(234, ZagSpr4.Position.Y));
                float dist4 = MathHelper.GetDistance(new Vector2f(0 - ZagSpr4.GetGlobalBounds().Width - 5, ZagSpr4.Position.Y), new Vector2f(375, ZagSpr4.Position.Y));
                float dst1 = MathHelper.GetDistance(ZagSpr1.Position, new Vector2f(40, ZagSpr4.Position.Y));
                float dst2 = MathHelper.GetDistance(ZagSpr2.Position, new Vector2f(193, ZagSpr4.Position.Y));
                float dst3 = MathHelper.GetDistance(ZagSpr3.Position, new Vector2f(234, ZagSpr4.Position.Y));
                float dst4 = MathHelper.GetDistance(ZagSpr4.Position, new Vector2f(375, ZagSpr4.Position.Y));
                float speed1 = (dst1 / dist1) * 20;
                float speed2 = (dst2 / dist2) * 20;
                float speed3 = (dst3 / dist3) * 20;
                float speed4 = (dst4 / dist4) * 20;
                ZagSpr1.Position += new Vector2f(speed1, 0);
                ZagSpr2.Position += new Vector2f(speed2, 0);
                ZagSpr3.Position += new Vector2f(speed3, 0);
                ZagSpr4.Position += new Vector2f(speed4, 0);

                proz2 += 3;
                if (proz2 >= 255)
                    proz2 = 255;
                ZagSpr4.Color = new Color(255, 255, 255, (byte)proz2);
                ZagSpr1.Color = new Color(255, 255, 255, (byte)proz2);
                ZagSpr2.Color = new Color(255, 255, 255, (byte)proz2);
                ZagSpr3.Color = new Color(255, 255, 255, (byte)proz2);

                if (MathHelper.GetDistance(ZagSpr1.Position, new Vector2f(40, ZagSpr1.Position.Y)) < 1)
                {
                    ZagSpr1.Position = new Vector2f(40, ZagSpr1.Position.Y);
                }
                if (MathHelper.GetDistance(ZagSpr2.Position, new Vector2f(193, ZagSpr2.Position.Y)) < 1)
                {
                    ZagSpr2.Position = new Vector2f(193, ZagSpr2.Position.Y);
                }
                if (MathHelper.GetDistance(ZagSpr3.Position, new Vector2f(234, ZagSpr3.Position.Y)) < 1)
                {
                    ZagSpr3.Position = new Vector2f(234, ZagSpr3.Position.Y);
                }
                if (MathHelper.GetDistance(ZagSpr4.Position, new Vector2f(375, ZagSpr4.Position.Y)) < 1)
                {
                    ZagSpr4.Position = new Vector2f(375, ZagSpr4.Position.Y);
                }
                if (ZagSpr4.Position == new Vector2f(375, ZagSpr4.Position.Y))
                {
                    isZagMove = false;
                }
            }
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            states.Transform *= Transform;

            target.Draw(info6, states);

            target.Draw(info7, states);
            target.Draw(info8, states);
            target.Draw(info1, states);
            target.Draw(info2, states);
            target.Draw(info3, states);

            target.Draw(inSp2, states);
            target.Draw(inSp1, states);
            target.Draw(inSp3, states);
            target.Draw(inSp4, states);
            target.Draw(inSp5, states);
            target.Draw(ZagSpr1, states);
            target.Draw(ZagSpr2, states);
            target.Draw(ZagSpr3, states);
            target.Draw(ZagSpr4, states);
        }
    }
}
