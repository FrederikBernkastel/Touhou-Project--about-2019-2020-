using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Adderley
{
    class Dialogs : Transformable, Drawable
    {
        public static RectangleShape Shape;
        public static Text text;

        public static Sprite spriteRH;
        public static Sprite spriteRH_1;

        public static Sprite spriteAA;
        public static Sprite spriteAA_1;

        public static Sprite sprRH;
        public static Sprite sprAA;

        public static bool isStart;
        public static bool isPress;

        public static int i;
        public static string Str;
        public static float timer;
        public static int edx;

        public Dialogs()
        {
            Shape = new RectangleShape(new Vector2f(650, 150));
            Shape.FillColor = new Color(0, 0, 0, 0);
            Shape.Position = new Vector2f(Program.Window.Size.X / 2 - Shape.GetGlobalBounds().Width / 2, Program.Window.Size.Y - Shape.GetGlobalBounds().Height - 50);
            Shape.OutlineThickness = 1.5f;
            Shape.OutlineColor = Color.Blue;

            text = new Text("", Content.font1, 20);
            text.Position = new Vector2f(Shape.Position.X + 10, Shape.Position.Y + 10);
            MathHelper.A(text, 0);

            spriteRH = new Sprite(Content.RH);
            spriteRH.Position = new Vector2f(Shape.Position.X, Shape.Position.Y - spriteRH.GetGlobalBounds().Height - 5);
            MathHelper.A(spriteRH, 0);

            spriteRH_1 = new Sprite(Content.RH_1);
            spriteRH_1.Position = new Vector2f(Shape.Position.X, spriteRH.Position.Y - spriteRH_1.GetGlobalBounds().Height - 5);
            MathHelper.A(spriteRH_1, 0);

            spriteAA = new Sprite(Content.AA);
            spriteAA.Position = new Vector2f(Shape.Position.X + Shape.GetGlobalBounds().Width - spriteAA.GetGlobalBounds().Width,
                Shape.Position.Y - spriteAA.GetGlobalBounds().Height - 5);
            MathHelper.A(spriteAA, 0);

            spriteAA_1 = new Sprite(Content.AA_1);
            spriteAA_1.Position = new Vector2f(Shape.Position.X + Shape.GetGlobalBounds().Width - spriteAA_1.GetGlobalBounds().Width, spriteAA.Position.Y - spriteAA_1.GetGlobalBounds().Height - 5);
            MathHelper.A(spriteAA_1, 0);

            sprRH = new Sprite(Content.sprRH);
            sprRH.Origin = new Vector2f(0, sprRH.GetGlobalBounds().Height);
            sprRH.Position = new Vector2f(100, Program.Window.Size.Y);
            sprRH.Color = Color.Transparent;

            sprAA = new Sprite(Content.sprAA);
            sprAA.Origin = new Vector2f(0, sprAA.GetGlobalBounds().Height);
            sprAA.Position = new Vector2f(700, Program.Window.Size.Y);
            sprAA.Color = Color.White;

            isStart = false;
            isPress = false;

            i = 0;
            timer = 0;
            edx = 0;
        }

        public void Update()
        {
            if (isStart)
            {
                timer += 0.5f;

                MathHelper.A(Shape, 120);
                MathHelper.A(text, 255);

                if (edx == 0)
                {
                    Str = "Всего лишь тестовые диалоги.";
                    MathHelper.A(spriteRH, 255);
                    MathHelper.A(spriteRH_1, 255);
                    sprRH.Color = new Color(255, 255, 255, 255);
                    sprAA.Color = new Color(128, 128, 128, 190);
                }
                else if (edx == 1)
                {
                    Str = "Точно тестовые? Не обманываешь?";
                    MathHelper.A(spriteAA, 255);
                    MathHelper.A(spriteAA_1, 255);
                    MathHelper.A(spriteRH, 0);
                    MathHelper.A(spriteRH_1, 0);
                    sprRH.Color = new Color(128, 128, 128, 190);
                    sprAA.Color = new Color(255, 255, 255, 255);
                }
                else if (edx == 2)
                {
                    Str = "Нет, конечно нет. С чего бы мне тебя обманывать? Хе-хе.. хе..";
                    MathHelper.A(spriteAA, 0);
                    MathHelper.A(spriteAA_1, 0);
                    MathHelper.A(spriteRH, 255);
                    MathHelper.A(spriteRH_1, 255);
                    sprRH.Color = new Color(255, 255, 255, 255);
                    sprAA.Color = new Color(128, 128, 128, 190);
                }
                else if (edx == 3)
                {
                    Str = "Хорошо, если так.";
                    MathHelper.A(spriteAA, 255);
                    MathHelper.A(spriteAA_1, 255);
                    MathHelper.A(spriteRH, 0);
                    MathHelper.A(spriteRH_1, 0);
                    sprRH.Color = new Color(128, 128, 128, 190);
                    sprAA.Color = new Color(255, 255, 255, 255);
                }
                else if (edx == 4)
                {
                    ScriptMove.isStartPusk = true;
                    isStart = false;
                }

                if (text.DisplayedString != Str && timer >= 2)
                {
                    text.DisplayedString += Str[i];
                    i++;
                    timer = 0;
                }
                if (text.DisplayedString == Str)
                    i = 0;
                if (Keyboard.IsKeyPressed(Keyboard.Key.Z) && !isPress)
                {
                    if (text.DisplayedString != Str)
                    {
                        text.DisplayedString = Str;
                    }
                    else
                    {
                        edx++;
                        text.DisplayedString = "";
                    }
                    isPress = true;
                }
                if (!Keyboard.IsKeyPressed(Keyboard.Key.Z))
                    isPress = false;
            }
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            if (isStart)
            {
                target.Draw(sprRH, states);
                target.Draw(sprAA, states);

                target.Draw(Shape, states);
                target.Draw(text, states);
                target.Draw(spriteRH, states);
                target.Draw(spriteRH_1, states);
                target.Draw(spriteAA, states);
                target.Draw(spriteAA_1, states);
            }
        }
    }
}
