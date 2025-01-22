using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Adderley
{
    class Menu_isOption : Menu
    {
        public override void Update()
        {
            if (isOption)
            {
                fon.Texture = Content.fonop;
                if (isOption_do)
                {
                    Menu_script.IsOptionDoScript();
                }
                if (isOption_do1)
                {
                    Menu_script.IsOptionDoScript_1();
                }
                if (Keyboard.IsKeyPressed(Keyboard.Key.Down) && !isPress && !isOption_do && !isOption_do1)
                {
                    edx++;
                    if (edx > 6)
                        edx = 1;
                    isPress = true;
                }
                else if (Keyboard.IsKeyPressed(Keyboard.Key.Up) && !isPress && !isOption_do && !isOption_do1)
                {
                    edx--;
                    if (edx < 1)
                        edx = 6;
                    isPress = true;
                }
                else if (Keyboard.IsKeyPressed(Keyboard.Key.Left) && !isPress && !isOption_do && !isOption_do1)
                {
                    if (edx == 1)
                    {
                        ebx1--;
                        if (ebx1 < 1)
                            ebx1 = 2;
                        if (ebx1 == 1)
                        {

                        }
                        else if (ebx1 == 2)
                        {

                        }
                    }
                    else if (edx == 2)
                    {
                        ebx2--;
                        if (ebx2 < 1)
                            ebx2 = 2;
                        if (ebx2 == 1)
                        {

                        }
                        else if (ebx2 == 2)
                        {

                        }
                    }
                    else if (edx == 3)
                    {
                        ebx3--;
                        if (ebx3 < 1)
                            ebx3 = 2;
                        if (ebx3 == 1)
                        {
                            Program.Window.Close();
                            Program.Window = new RenderWindow(new VideoMode(1280, 960), "POM ~ ETAE ~ Accidental is inevitable", Styles.Fullscreen, Program.Settings);
                            Program.Window.SetVerticalSyncEnabled(true);
                        }
                        else if (ebx3 == 2)
                        {
                            Program.Window.Close();
                            Program.Window = new RenderWindow(new VideoMode(1280, 960), "POM ~ ETAE ~ Accidental is inevitable", Styles.Default, Program.Settings);
                            Program.Window.SetVerticalSyncEnabled(true);
                        }
                    }
                    isPress = true;
                }
                else if (Keyboard.IsKeyPressed(Keyboard.Key.Right) && !isPress && !isOption_do && !isOption_do1)
                {
                    if (edx == 1)
                    {
                        ebx1++;
                        if (ebx1 > 2)
                            ebx1 = 1;
                        if (ebx1 == 1)
                        {

                        }
                        else if (ebx1 == 2)
                        {

                        }
                    }
                    else if (edx == 2)
                    {
                        ebx2++;
                        if (ebx2 > 2)
                            ebx2 = 1;
                        if (ebx2 == 1)
                        {

                        }
                        else if (ebx2 == 2)
                        {

                        }
                    }
                    else if (edx == 3)
                    {
                        ebx3++;
                        if (ebx3 > 2)
                            ebx3 = 1;
                        if (ebx3 == 1)
                        {
                            Program.Window.Close();
                            Program.Window = new RenderWindow(new VideoMode(1280, 960), "POM ~ ETAE ~ Accidental is inevitable", Styles.Fullscreen, Program.Settings);
                            Program.Window.SetVerticalSyncEnabled(true);
                        }
                        else if (ebx3 == 2)
                        {
                            Program.Window.Close();
                            Program.Window = new RenderWindow(new VideoMode(1280, 960), "POM ~ ETAE ~ Accidental is inevitable", Styles.Default, Program.Settings);
                            Program.Window.SetVerticalSyncEnabled(true);
                        }
                    }
                    isPress = true;
                }
                if (Keyboard.IsKeyPressed(Keyboard.Key.Z) && !isPress && !isOption_do && !isOption_do1)
                {
                    if (edx == 4)
                    {
                        isOption_do1 = true;
                    }
                    else if (edx == 5)
                    {

                    }
                    else if (edx == 6)
                    {
                        isOption_do1 = true;
                    }
                    isPress = true;
                }
                if (!Keyboard.IsKeyPressed(Keyboard.Key.Z) && !Keyboard.IsKeyPressed(Keyboard.Key.Up) && !Keyboard.IsKeyPressed(Keyboard.Key.Down) && !Keyboard.IsKeyPressed(Keyboard.Key.Left) && !Keyboard.IsKeyPressed(Keyboard.Key.Right))
                    isPress = false;
                if (!isOption_do && !isOption_do1 && isOption)
                {
                    if (ebx1 == 1)
                    {
                        text7op.Scale = new Vector2f(1.1f, 1.1f);
                        text8op.Scale = new Vector2f(1, 1);
                        text7op.Color = Color.White;
                        text8op.Color = new Color(128, 128, 128, 160);
                    }
                    else
                    {
                        text7op.Scale = new Vector2f(1, 1);
                        text8op.Scale = new Vector2f(1.1f, 1.1f);
                        text7op.Color = new Color(128, 128, 128, 160);
                        text8op.Color = Color.White;
                    }
                    if (ebx2 == 1)
                    {
                        text9op.Scale = new Vector2f(1.1f, 1.1f);
                        text10op.Scale = new Vector2f(1, 1);
                        text9op.Color = Color.White;
                        text10op.Color = new Color(128, 128, 128, 160);
                    }
                    else
                    {
                        text9op.Scale = new Vector2f(1, 1);
                        text10op.Scale = new Vector2f(1.1f, 1.1f);
                        text9op.Color = new Color(128, 128, 128, 160);
                        text10op.Color = Color.White;
                    }
                    if (ebx3 == 1)
                    {
                        text11op.Scale = new Vector2f(1.1f, 1.1f);
                        text12op.Scale = new Vector2f(1, 1);
                        text11op.Color = Color.White;
                        text12op.Color = new Color(128, 128, 128, 160);
                    }
                    else
                    {
                        text11op.Scale = new Vector2f(1, 1);
                        text12op.Scale = new Vector2f(1.1f, 1.1f);
                        text11op.Color = new Color(128, 128, 128, 160);
                        text12op.Color = Color.White;
                    }
                    if (edx == 1)
                    {
                        text1op.Color = Color.White;
                        if (ebx1 == 1)
                        {
                            text8op.Color = new Color(128, 128, 128, 255);
                        }
                        else if (ebx1 == 2)
                        {
                            text7op.Color = new Color(128, 128, 128, 255);
                        }
                    }
                    else
                    {
                        text1op.Color = new Color(128, 128, 128, 160);
                        if (ebx1 == 1)
                        {
                            text8op.Color = new Color(128, 128, 128, 160);
                        }
                        else if (ebx1 == 2)
                        {
                            text7op.Color = new Color(128, 128, 128, 160);
                        }
                    }
                    if (edx == 2)
                    {
                        text2op.Color = Color.White;
                        if (ebx2 == 1)
                        {
                            text10op.Color = new Color(128, 128, 128, 255);
                        }
                        else if (ebx2 == 2)
                        {
                            text9op.Color = new Color(128, 128, 128, 255);
                        }
                    }
                    else
                    {
                        text2op.Color = new Color(128, 128, 128, 160);
                        if (ebx2 == 1)
                        {
                            text10op.Color = new Color(128, 128, 128, 160);
                        }
                        else if (ebx2 == 2)
                        {
                            text9op.Color = new Color(128, 128, 128, 160);
                        }
                    }
                    if (edx == 3)
                    {
                        text3op.Color = Color.White;
                        if (ebx3 == 1)
                        {
                            text12op.Color = new Color(128, 128, 128, 255);
                        }
                        else if (ebx3 == 2)
                        {
                            text11op.Color = new Color(128, 128, 128, 255);
                        }
                    }
                    else
                    {
                        text3op.Color = new Color(128, 128, 128, 160);
                        if (ebx3 == 1)
                        {
                            text12op.Color = new Color(128, 128, 128, 160);
                        }
                        else if (ebx3 == 2)
                        {
                            text11op.Color = new Color(128, 128, 128, 160);
                        }
                    }
                    if (edx == 4)
                    {
                        text4op.Color = Color.White;
                    }
                    else
                    {
                        text4op.Color = new Color(128, 128, 128, 160);
                    }
                    if (edx == 5)
                    {
                        text5op.Color = Color.White;
                    }
                    else
                    {
                        text5op.Color = new Color(128, 128, 128, 160);
                    }
                    if (edx == 6)
                    {
                        text6op.Color = Color.White;
                    }
                    else
                    {
                        text6op.Color = new Color(128, 128, 128, 160);
                    }
                }
            }
        }

        public override void Draw(RenderTarget target, RenderStates states)
        {
            if (isOption)
            {
                target.Draw(text1op, states);
                target.Draw(text2op, states);
                target.Draw(text3op, states);
                target.Draw(text4op, states);
                target.Draw(text5op, states);
                target.Draw(text6op, states);
                target.Draw(text7op, states);
                target.Draw(text8op, states);
                target.Draw(text9op, states);
                target.Draw(text10op, states);
                target.Draw(text11op, states);
                target.Draw(text12op, states);
            }
        }
    }
}
