using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Adderley
{
    class Menu_isStart : Menu
    {
        public override void Update()
        {
            if (isStart)
            {
                fon.Texture = Content.fonstart;
                if (isStart_do)
                {
                    Menu_script.IsStartDoScript();
                }
                if (isStart_do1)
                {
                    Menu_script.IsStartDoScript_1();
                }
                if (isStart_vs)
                {
                    Menu_script.IsStartVSScript();
                }
                if (isStart_vs1)
                {
                    Menu_script.IsStartVSScript_1();
                }
                if (isStart_SP)
                {
                    Menu_script.IsStartSPScript();
                }
                if (Keyboard.IsKeyPressed(Keyboard.Key.Z) && !isStart_do && !isStart_do1 && !isStart_vs && !isStart_vs1 && !isStart_SP && !isPress)
                {
                    if (isVS)
                    {
                        isStart_vs = true;
                    }
                    else if (isVP)
                    {
                        isStart = false;
                        isVP = false;
                        isMenu = false;
                        LevelOry = edx;
                        LevelPer = ecx;

                        VS.Position = new Vector2f(Program.Window.Size.X / 2 - 40, -VS.GetGlobalBounds().Height - 5);
                        VP_L.Position = new Vector2f(VS.Position.X, -VP_L.GetGlobalBounds().Height - 10);
                        VP_N.Position = new Vector2f(VS.Position.X, VP_L.Position.Y);
                        VP_S.Position = new Vector2f(VS.Position.X, VP_L.Position.Y);
                        VP_Lun.Position = new Vector2f(VS.Position.X, VP_L.Position.Y);
                        InfoOrRH1.Position = new Vector2f(0 - InfoOrRH1.GetGlobalBounds().Width - 5, InfoOrRH1.Position.Y);
                        InfoOrRH2.Position = new Vector2f(InfoOrRH1.Position.X, InfoOrRH2.Position.Y);
                        InfoOrAA1.Position = new Vector2f(InfoOrRH1.Position.X, InfoOrAA1.Position.Y);
                        InfoOrAA2.Position = new Vector2f(InfoOrRH1.Position.X, InfoOrAA2.Position.Y);
                        StRH.Position = new Vector2f(Program.Window.Size.X + 5, StRH.Position.Y);
                        StAA.Position = new Vector2f(Program.Window.Size.X + 5, StAA.Position.Y);
                        InfoRH.Position = new Vector2f(Program.Window.Size.X + 300, InfoRH.Position.Y);
                        InfoAA.Position = new Vector2f(Program.Window.Size.X + 300, InfoAA.Position.Y);

                        MathHelper.A(VP_L, 0);
                        MathHelper.A(Dark, 0);
                        MathHelper.A(VP_N, 0);
                        MathHelper.A(VP_S, 0);
                        MathHelper.A(VP_Lun, 0);
                        MathHelper.A(InfoOrRH1, 0);
                        MathHelper.A(InfoOrRH2, 0);
                        MathHelper.A(InfoOrAA1, 0);
                        MathHelper.A(InfoOrAA2, 0);
                        MathHelper.A(StRH, 0);
                        MathHelper.A(StAA, 0);
                        MathHelper.A(InfoRH, 0);
                        MathHelper.A(StAA, 0);
                    }
                    isPress = true;
                }
                if (isVS)
                {
                    if (Keyboard.IsKeyPressed(Keyboard.Key.Down) && !isStart_do && !isStart_do1 && !isStart_vs && !isStart_vs1 && !isStart_SP && !isPress)
                    {
                        edx++;
                        if (edx > 4)
                            edx = 1;
                        isPress = true;
                    }
                    else if (Keyboard.IsKeyPressed(Keyboard.Key.Up) && !isStart_do && !isStart_do1 && !isStart_vs && !isStart_vs1 && !isStart_SP && !isPress)
                    {
                        edx--;
                        if (edx < 1)
                            edx = 4;
                        isPress = true;
                    }
                    if (!isStart_do && !isStart_do1 && !isStart_vs && !isStart_vs1 && !isStart_SP && isStart && isVS)
                    {
                        if (edx == 1)
                        {
                            Leg.Position = new Vector2f(620 - 5, Leg.Position.Y);
                            Leg.Color = new Color(255, 255, 255, 255);
                        }
                        else
                        {
                            Leg.Position = new Vector2f(620, Leg.Position.Y);
                            Leg.Color = new Color(128, 128, 128, 160);
                        }
                        if (edx == 2)
                        {
                            Nor.Position = new Vector2f(620 - 5, Nor.Position.Y);
                            Nor.Color = new Color(255, 255, 255, 255);
                        }
                        else
                        {
                            Nor.Position = new Vector2f(620, Nor.Position.Y);
                            Nor.Color = new Color(128, 128, 128, 160);
                        }
                        if (edx == 3)
                        {
                            Slo.Position = new Vector2f(620 - 5, Slo.Position.Y);
                            Slo.Color = new Color(255, 255, 255, 255);
                        }
                        else
                        {
                            Slo.Position = new Vector2f(620, Slo.Position.Y);
                            Slo.Color = new Color(128, 128, 128, 160);
                        }
                        if (edx == 4)
                        {
                            Lun.Position = new Vector2f(620 - 5, Lun.Position.Y);
                            Lun.Color = new Color(255, 255, 255, 255);
                        }
                        else
                        {
                            Lun.Position = new Vector2f(620, Lun.Position.Y);
                            Lun.Color = new Color(128, 128, 128, 160);
                        }
                    }
                }
                else if (isVP)
                {
                    if (Keyboard.IsKeyPressed(Keyboard.Key.Down) && !isStart_do && !isStart_do1 && !isStart_vs && !isStart_vs1 && !isStart_SP && !isPress)
                    {
                        edx++;
                        if (edx > 2)
                            edx = 1;
                        isPress = true;
                    }
                    else if (Keyboard.IsKeyPressed(Keyboard.Key.Up) && !isStart_do && !isStart_do1 && !isStart_vs && !isStart_vs1 && !isStart_SP && !isPress)
                    {
                        edx--;
                        if (edx < 1)
                            edx = 2;
                        isPress = true;
                    }
                    else if (Keyboard.IsKeyPressed(Keyboard.Key.Left) && !isStart_do && !isStart_do1 && !isStart_vs && !isStart_vs1 && !isStart_SP && !isPress)
                    {
                        ecx--;
                        if (ecx < 1)
                            ecx = 2;
                        isStart_SP = true;
                        isPress = true;
                    }
                    else if (Keyboard.IsKeyPressed(Keyboard.Key.Right) && !isStart_do && !isStart_do1 && !isStart_vs && !isStart_vs1 && !isStart_SP && !isPress)
                    {
                        ecx++;
                        if (ecx > 2)
                            ecx = 1;
                        isStart_SP = true;
                        isPress = true;
                    }
                    if (!isStart_do && !isStart_do1 && !isStart_vs && !isStart_vs1 && !isStart_SP && isStart && isVP)
                    {
                        if (ecx == 1)
                        {
                            if (edx == 1)
                            {
                                InfoOrRH1.Position = new Vector2f(100 - 5, InfoOrRH1.Position.Y);
                                InfoOrRH1.Color = new Color(255, 255, 255, 255);
                            }
                            else
                            {
                                InfoOrRH1.Position = new Vector2f(100, InfoOrRH1.Position.Y);
                                InfoOrRH1.Color = new Color(128, 128, 128, 160);
                            }
                            if (edx == 2)
                            {
                                InfoOrRH2.Position = new Vector2f(100 - 5, InfoOrRH2.Position.Y);
                                InfoOrRH2.Color = new Color(255, 255, 255, 255);
                            }
                            else
                            {
                                InfoOrRH2.Position = new Vector2f(100, InfoOrRH2.Position.Y);
                                InfoOrRH2.Color = new Color(128, 128, 128, 160);
                            }
                        }
                        if (ecx == 2)
                        {
                            if (edx == 1)
                            {
                                InfoOrAA1.Position = new Vector2f(100 - 5, InfoOrAA1.Position.Y);
                                InfoOrAA1.Color = new Color(255, 255, 255, 255);
                            }
                            else
                            {
                                InfoOrAA1.Position = new Vector2f(100, InfoOrAA1.Position.Y);
                                InfoOrAA1.Color = new Color(128, 128, 128, 160);
                            }
                            if (edx == 2)
                            {
                                InfoOrAA2.Position = new Vector2f(100 - 5, InfoOrAA2.Position.Y);
                                InfoOrAA2.Color = new Color(255, 255, 255, 255);
                            }
                            else
                            {
                                InfoOrAA2.Position = new Vector2f(100, InfoOrAA2.Position.Y);
                                InfoOrAA2.Color = new Color(128, 128, 128, 160);
                            }
                        }
                    }
                }
                if (Keyboard.IsKeyPressed(Keyboard.Key.Escape) && !isStart_do && !isStart_do1 && !isStart_vs && !isStart_vs1 && !isStart_SP)
                {
                    if (isVS)
                    {
                        isStart_do1 = true;
                    }
                    else if (isVP)
                    {
                        isStart_vs1 = true;
                    }
                    isPress = true;
                }
                if (!Keyboard.IsKeyPressed(Keyboard.Key.Z) && !Keyboard.IsKeyPressed(Keyboard.Key.Up)
                    && !Keyboard.IsKeyPressed(Keyboard.Key.Down)
                    && !Keyboard.IsKeyPressed(Keyboard.Key.Left)
                    && !Keyboard.IsKeyPressed(Keyboard.Key.Right)
                    && !Keyboard.IsKeyPressed(Keyboard.Key.Escape))
                    isPress = false;
            }
        }

        public override void Draw(RenderTarget target, RenderStates states)
        {
            if (isStart)
            {
                target.Draw(VS, states);
                target.Draw(Leg, states);
                target.Draw(Nor, states);
                target.Draw(Slo, states);
                target.Draw(Lun, states);
                target.Draw(VP_L, states);
                target.Draw(VP_N, states);
                target.Draw(VP_S, states);
                target.Draw(VP_Lun, states);
                target.Draw(Dark, states);
                target.Draw(StAA, states);
                target.Draw(StRH, states);
                target.Draw(InfoRH, states);
                target.Draw(InfoAA, states);
                target.Draw(InfoOrRH1, states);
                target.Draw(InfoOrRH2, states);
                target.Draw(InfoOrAA1, states);
                target.Draw(InfoOrAA2, states);
            }
        }
    }
}
