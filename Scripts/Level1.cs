using SFML.Graphics;
using SFML.System;

namespace Adderley
{
    class Level1
    {
        public static Sprite fonF;
        public static Sprite fonlev;
        public static Sprite fonlev1;

        public static bool isStart;

        public static bool isBool;

        public Level1()
        {
            fonF = new Sprite(Content.fonF);
            fonlev = new Sprite(Content.fonlev);
            fonlev1 = new Sprite(Content.fonlev);
            fonlev1.Scale = new Vector2f(1, -1);

            fonlev1.Position = new Vector2f(fonlev.Position.X, fonlev.Position.Y);

            isStart = false;

            isBool = false;
        }

        public void Update()
        {
            if (isStart)
            {
                fonlev.Position += new Vector2f(0, 1);
                fonlev1.Position += new Vector2f(0, 1);

                if (fonlev.Position.Y >= Program.Window.Size.Y)
                    fonlev.Position = new Vector2f(fonlev1.Position.X, fonlev1.Position.Y - fonlev.GetGlobalBounds().Height);
                if (fonlev1.Position.Y + fonlev1.GetGlobalBounds().Height >= Program.Window.Size.Y)
                    fonlev1.Position = new Vector2f(fonlev.Position.X, fonlev.Position.Y);
            }
        }

        public void Draw_fonF()
        {
            Program.Window.Draw(fonF);
        }

        public void Draw_fonlev()
        {
            Program.Window.Draw(fonlev);
            Program.Window.Draw(fonlev1);
        }
    }
}
