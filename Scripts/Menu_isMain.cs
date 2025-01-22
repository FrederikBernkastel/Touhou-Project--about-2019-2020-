using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Adderley
{
    class Menu_isMain : Menu
    {
        public override void Update()
        {
            if (isMain)
            {
                fon.Texture = Content.menufon;
                if (isMain_do)
                {
                    Menu_script.IsMainDoScript();
                }
                else if (isMain_do1)
                {
                    Menu_script.IsMainDoScript_1();
                }
                if (Keyboard.IsKeyPressed(Keyboard.Key.Down) && !isPress && !isMain_do && !isMain_do1)
                {
                    edx++;
                    if (edx > 6)
                        edx = 1;
                    isPress = true;
                }
                else if (Keyboard.IsKeyPressed(Keyboard.Key.Up) && !isPress && !isMain_do && !isMain_do1)
                {
                    edx--;
                    if (edx < 1)
                        edx = 6;
                    isPress = true;
                }
                else if (Keyboard.IsKeyPressed(Keyboard.Key.Z) && !isPress && !isMain_do && !isMain_do1)
                {
                    isMain_do1 = true;
                    isPress = true;
                }
                if (!Keyboard.IsKeyPressed(Keyboard.Key.Z) && !Keyboard.IsKeyPressed(Keyboard.Key.Up)
                    && !Keyboard.IsKeyPressed(Keyboard.Key.Down))
                    isPress = false;
                if (!isMain_do && !isMain_do1 && isMain)
                {
                    if (edx == 1)
                    {
                        text1.Position = new Vector2f(fonnaz3.Position.X + 55, text1.Position.Y);
                        text1.Color = new Color(255, 255, 255, 255);
                    }
                    else
                    {
                        text1.Position = new Vector2f(fonnaz3.Position.X + 60, text1.Position.Y);
                        text1.Color = new Color(128, 128, 128, 160);
                    }
                    if (edx == 2)
                    {
                        text2.Position = new Vector2f(fonnaz3.Position.X + 35, text2.Position.Y);
                        text2.Color = new Color(255, 255, 255, 255);
                    }
                    else
                    {
                        text2.Position = new Vector2f(fonnaz3.Position.X + 40, text2.Position.Y);
                        text2.Color = new Color(128, 128, 128, 160);
                    }
                    if (edx == 3)
                    {
                        text3.Position = new Vector2f(fonnaz3.Position.X + 15, text3.Position.Y);
                        text3.Color = new Color(255, 255, 255, 255);
                    }
                    else
                    {
                        text3.Position = new Vector2f(fonnaz3.Position.X + 20, text3.Position.Y);
                        text3.Color = new Color(128, 128, 128, 160);
                    }
                    if (edx == 4)
                    {
                        text4.Position = new Vector2f(fonnaz3.Position.X - 5, text4.Position.Y);
                        text4.Color = new Color(255, 255, 255, 255);
                    }
                    else
                    {
                        text4.Position = new Vector2f(fonnaz3.Position.X, text4.Position.Y);
                        text4.Color = new Color(128, 128, 128, 160);
                    }
                    if (edx == 5)
                    {
                        text5.Position = new Vector2f(fonnaz3.Position.X + 15, text5.Position.Y);
                        text5.Color = new Color(255, 255, 255, 255);
                    }
                    else
                    {
                        text5.Position = new Vector2f(fonnaz3.Position.X + 20, text5.Position.Y);
                        text5.Color = new Color(128, 128, 128, 160);
                    }
                    if (edx == 6)
                    {
                        text6.Position = new Vector2f(fonnaz3.Position.X + 35, text6.Position.Y);
                        text6.Color = new Color(255, 255, 255, 255);
                    }
                    else
                    {
                        text6.Position = new Vector2f(fonnaz3.Position.X + 40, text6.Position.Y);
                        text6.Color = new Color(128, 128, 128, 160);
                    }
                }
            }
        }

        public override void Draw(RenderTarget target, RenderStates states)
        {
            if (isMain)
            {
                target.Draw(text1, states);
                target.Draw(text2, states);
                target.Draw(text3, states);
                target.Draw(text4, states);
                target.Draw(text5, states);
                target.Draw(text6, states);

                target.Draw(fonnaz1, states);
                target.Draw(fonnaz2, states);
                target.Draw(fonnaz3, states);
                target.Draw(naz1, states);
                target.Draw(naz2, states);
                target.Draw(naz3, states);
            }
        }
    }
}
