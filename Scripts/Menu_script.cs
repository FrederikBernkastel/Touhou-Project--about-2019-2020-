using SFML.Graphics;
using SFML.System;
using System;

namespace Adderley
{
    class Menu_script : Menu
    {
        public override void Update()
        {

        }

        public override void Draw(RenderTarget target, RenderStates states)
        {

        }

        public static void IsMainDoScript()
        {
            naz1.Position = MathHelper.Lerp(naz1.Position, new Vector2f(fonnaz1.Position.X + 20, naz1.Position.Y), TimeMod.DeltaTime * 4.5f);
            text1.Position = MathHelper.Lerp(text1.Position, new Vector2f(fonnaz3.Position.X + 60, text1.Position.Y), TimeMod.DeltaTime * 4.5f);

            naz2.Position = new Vector2f(naz1.Position.X, naz2.Position.Y);
            naz3.Position = new Vector2f(naz1.Position.X, naz3.Position.Y);
            text2.Position = new Vector2f(text1.GetGlobalBounds().Left - 20, text2.Position.Y);
            text3.Position = new Vector2f(text2.GetGlobalBounds().Left - 20, text3.Position.Y);
            text4.Position = new Vector2f(text3.GetGlobalBounds().Left - 20, text4.Position.Y);
            text5.Position = new Vector2f(text4.GetGlobalBounds().Left + 20, text5.Position.Y);
            text6.Position = new Vector2f(text5.GetGlobalBounds().Left + 20, text6.Position.Y);

            MathHelper.Show_dissolve(text1, 3, 255);
            MathHelper.Show_dissolve(text2, 3, 160);
            MathHelper.Show_dissolve(text3, 3, 160);
            MathHelper.Show_dissolve(text4, 3, 160);
            MathHelper.Show_dissolve(text5, 3, 160);
            MathHelper.Show_dissolve(text6, 3, 160);
            MathHelper.Show_dissolve(naz1, 3, 255);
            MathHelper.Show_dissolve(naz2, 3, 255);
            MathHelper.Show_dissolve(naz3, 3, 255);
            MathHelper.Show_dissolve(fonnaz1, 3, 255);
            MathHelper.Show_dissolve(fonnaz2, 3, 255);
            MathHelper.Show_dissolve(fonnaz3, 3, 255);

            if (new Vector2f((float)Math.Round(naz1.Position.X),
                (float)Math.Round(naz1.Position.Y)) == new Vector2f(fonnaz1.Position.X + 20, naz1.Position.Y))
            {
                naz1.Position = new Vector2f(fonnaz1.Position.X + 20, naz1.Position.Y);
            }
            if (new Vector2f((float)Math.Round(text1.Position.X),
                (float)Math.Round(text1.Position.Y)) == new Vector2f(fonnaz3.Position.X + 60, text1.Position.Y))
            {
                text1.Position = new Vector2f(fonnaz3.Position.X + 60, text1.Position.Y);
            }
            if (text1.Position == new Vector2f(fonnaz3.Position.X + 60, text1.Position.Y)
                && naz1.Position == new Vector2f(fonnaz1.Position.X + 20, naz1.Position.Y))
            {
                isMain_do = false;
            }
        }

        public static void IsMainDoScript_1()
        {
            movemt.X += 1.5f;
            naz1.Position += movemt;
            text1.Position -= movemt;

            naz2.Position = new Vector2f(naz1.Position.X, naz2.Position.Y);
            naz3.Position = new Vector2f(naz1.Position.X, naz3.Position.Y);
            text2.Position = new Vector2f(text1.Position.X - 20, text2.Position.Y);
            text3.Position = new Vector2f(text2.Position.X - 20, text3.Position.Y);
            text4.Position = new Vector2f(text3.Position.X - 20, text4.Position.Y);
            text5.Position = new Vector2f(text4.Position.X + 20, text5.Position.Y);
            text6.Position = new Vector2f(text5.Position.X + 20, text6.Position.Y);

            MathHelper.Hide_dissolve(text1, 7, 0);
            MathHelper.Hide_dissolve(text2, 7, 0);
            MathHelper.Hide_dissolve(text3, 7, 0);
            MathHelper.Hide_dissolve(text4, 7, 0);
            MathHelper.Hide_dissolve(text5, 7, 0);
            MathHelper.Hide_dissolve(text6, 7, 0);
            MathHelper.Hide_dissolve(naz1, 7, 0);
            MathHelper.Hide_dissolve(naz2, 7, 0);
            MathHelper.Hide_dissolve(naz3, 7, 0);
            MathHelper.Hide_dissolve(fonnaz1, 7, 0);
            MathHelper.Hide_dissolve(fonnaz2, 7, 0);
            MathHelper.Hide_dissolve(fonnaz3, 7, 0);

            if (naz1.Color.A == 0)
            {
                naz1.Position = new Vector2f(Program.Window.Size.X / 2, naz1.Position.Y);
                text1.Position = new Vector2f(0 - text1.GetGlobalBounds().Width - 10, text1.Position.Y);

                if (edx == 1)
                {
                    isStart = true;
                    isStart_do = true;
                }
                else if (edx == 2)
                {
                    isExtra = true;
                }
                else if (edx == 3)
                {
                    isPraction = true;
                }
                else if (edx == 4)
                {
                    isRecord = true;
                }
                else if (edx == 5)
                {
                    isOption = true;
                    isOption_do = true;
                }
                else if (edx == 6)
                {
                    isExit = true;
                }
                isMain = false;
                isMain_do1 = false;
                edx = 1;
                movemt = new Vector2f();
                movemt1 = new Vector2f();
            }
        }

        public static void IsOptionDoScript()
        {
            text1op.Position = MathHelper.Lerp(text1op.Position, new Vector2f(200, 120), TimeMod.DeltaTime * 4.5f);

            text2op.Position = new Vector2f(text1op.Position.X + text1op.GetGlobalBounds().Width / 2 - text2op.GetGlobalBounds().Width / 2, text2op.Position.Y);
            text3op.Position = new Vector2f(text1op.Position.X + text1op.GetGlobalBounds().Width / 2 - text3op.GetGlobalBounds().Width / 2, text3op.Position.Y);
            text4op.Position = new Vector2f(text1op.Position.X + text1op.GetGlobalBounds().Width / 2 - text4op.GetGlobalBounds().Width / 2, text4op.Position.Y);
            text5op.Position = new Vector2f(text1op.Position.X + text1op.GetGlobalBounds().Width / 2 - text5op.GetGlobalBounds().Width / 2, text5op.Position.Y);
            text6op.Position = new Vector2f(text1op.Position.X + text1op.GetGlobalBounds().Width / 2 - text6op.GetGlobalBounds().Width / 2, text6op.Position.Y);
            text7op.Position = new Vector2f(text1op.Position.X, text7op.Position.Y);
            text8op.Position = new Vector2f(text1op.Position.X + text1op.GetGlobalBounds().Width - text8op.GetGlobalBounds().Width, text8op.Position.Y);
            text9op.Position = new Vector2f(text7op.Position.X, text9op.Position.Y);
            text10op.Position = new Vector2f(text8op.Position.X, text10op.Position.Y);
            text11op.Position = new Vector2f(text1op.Position.X + text1op.GetGlobalBounds().Width / 2 - text11op.GetGlobalBounds().Width / 2, text11op.Position.Y);
            text12op.Position = new Vector2f(text1op.Position.X + text1op.GetGlobalBounds().Width / 2 - text12op.GetGlobalBounds().Width / 2, text12op.Position.Y);

            if (ebx1 == 1)
            {
                MathHelper.Show_dissolve(text7op, 3, 255);
                MathHelper.Show_dissolve(text8op, 3, 160);
            }
            else
            {
                MathHelper.Show_dissolve(text7op, 3, 160);
                MathHelper.Show_dissolve(text8op, 3, 255);
            }
            if (ebx2 == 1)
            {
                MathHelper.Show_dissolve(text9op, 3, 255);
                MathHelper.Show_dissolve(text10op, 3, 160);
            }
            else
            {
                MathHelper.Show_dissolve(text9op, 3, 160);
                MathHelper.Show_dissolve(text10op, 3, 255);
            }
            if (ebx3 == 1)
            {
                MathHelper.Show_dissolve(text11op, 3, 255);
                MathHelper.Show_dissolve(text12op, 3, 160);
            }
            else
            {
                MathHelper.Show_dissolve(text11op, 3, 160);
                MathHelper.Show_dissolve(text12op, 3, 255);
            }
            MathHelper.Show_dissolve(text1op, 3, 255);
            MathHelper.Show_dissolve(text2op, 3, 160);
            MathHelper.Show_dissolve(text3op, 3, 160);
            MathHelper.Show_dissolve(text4op, 3, 160);
            MathHelper.Show_dissolve(text5op, 3, 160);
            MathHelper.Show_dissolve(text6op, 3, 160);

            if (new Vector2f((float)Math.Round(text1op.Position.X),
                (float)Math.Round(text1op.Position.Y)) == new Vector2f(200, 120))
            {
                text1op.Position = new Vector2f(200, 120);
                isOption_do = false;
            }
        }

        public static void IsOptionDoScript_1()
        {
            movemt.X += 1.5f;
            text1op.Position -= movemt;

            text2op.Position = new Vector2f(text1op.Position.X + text1op.GetGlobalBounds().Width / 2 - text2op.GetGlobalBounds().Width / 2, text2op.Position.Y);
            text3op.Position = new Vector2f(text1op.Position.X + text1op.GetGlobalBounds().Width / 2 - text3op.GetGlobalBounds().Width / 2, text3op.Position.Y);
            text4op.Position = new Vector2f(text1op.Position.X + text1op.GetGlobalBounds().Width / 2 - text4op.GetGlobalBounds().Width / 2, text4op.Position.Y);
            text5op.Position = new Vector2f(text1op.Position.X + text1op.GetGlobalBounds().Width / 2 - text5op.GetGlobalBounds().Width / 2, text5op.Position.Y);
            text6op.Position = new Vector2f(text1op.Position.X + text1op.GetGlobalBounds().Width / 2 - text6op.GetGlobalBounds().Width / 2, text6op.Position.Y);
            text7op.Position = new Vector2f(text1op.Position.X, text7op.Position.Y);
            text8op.Position = new Vector2f(text1op.Position.X + text1op.GetGlobalBounds().Width - text8op.GetGlobalBounds().Width, text8op.Position.Y);
            text9op.Position = new Vector2f(text7op.Position.X, text9op.Position.Y);
            text10op.Position = new Vector2f(text8op.Position.X, text10op.Position.Y);
            text11op.Position = new Vector2f(text1op.Position.X + text1op.GetGlobalBounds().Width / 2 - text11op.GetGlobalBounds().Width / 2, text11op.Position.Y);
            text12op.Position = new Vector2f(text1op.Position.X + text1op.GetGlobalBounds().Width / 2 - text12op.GetGlobalBounds().Width / 2, text12op.Position.Y);

            MathHelper.Hide_dissolve(text1op, 7, 0);
            MathHelper.Hide_dissolve(text2op, 7, 0);
            MathHelper.Hide_dissolve(text3op, 7, 0);
            MathHelper.Hide_dissolve(text4op, 7, 0);
            MathHelper.Hide_dissolve(text5op, 7, 0);
            MathHelper.Hide_dissolve(text6op, 7, 0);
            MathHelper.Hide_dissolve(text7op, 7, 0);
            MathHelper.Hide_dissolve(text8op, 7, 0);
            MathHelper.Hide_dissolve(text9op, 7, 0);
            MathHelper.Hide_dissolve(text10op, 7, 0);
            MathHelper.Hide_dissolve(text11op, 7, 0);
            MathHelper.Hide_dissolve(text12op, 7, 0);

            if (text1op.Color.A == 0)
            {
                text1op.Position = new Vector2f(-285, 120);

                if (edx == 4)
                {
                    isYpr = true;
                    isYpr_do = true;
                }
                else if (edx == 6)
                {
                    isMain = true;
                    isMain_do = true;
                }
                isOption_do1 = false;
                isOption = false;
                edx = 1;
                movemt = new Vector2f();
                movemt1 = new Vector2f();
            }
        }

        public static void IsStartDoScript()
        {
            VS.Position = MathHelper.Lerp(VS.Position, new Vector2f(VS.Position.X, 60), TimeMod.DeltaTime * 4.5f);
            Leg.Position = MathHelper.Lerp(Leg.Position, new Vector2f(Program.Window.Size.X / 2 - 20, Leg.Position.Y), TimeMod.DeltaTime * 4.5f);

            Nor.Position = new Vector2f(Leg.Position.X, Nor.Position.Y);
            Slo.Position = new Vector2f(Leg.Position.X, Slo.Position.Y);
            Lun.Position = new Vector2f(Leg.Position.X, Lun.Position.Y);

            MathHelper.Show_dissolve(VS, 3, 255);
            MathHelper.Show_dissolve(Leg, 3, 255);
            MathHelper.Show_dissolve(Nor, 3, 160);
            MathHelper.Show_dissolve(Slo, 3, 160);
            MathHelper.Show_dissolve(Lun, 3, 160);

            if (new Vector2f((float)Math.Round(VS.Position.X),
                (float)Math.Round(VS.Position.Y)) == new Vector2f(VS.Position.X, 60))
            {
                VS.Position = new Vector2f(VS.Position.X, 60);
            }
            if (new Vector2f((float)Math.Round(Leg.Position.X),
                (float)Math.Round(Leg.Position.Y)) == new Vector2f(Program.Window.Size.X / 2 - 20, Leg.Position.Y))
            {
                Leg.Position = new Vector2f(Program.Window.Size.X / 2 - 20, Leg.Position.Y);
            }
            if (VS.Position == new Vector2f(VS.Position.X, 60)
                && Leg.Position == new Vector2f(Program.Window.Size.X / 2 - 20, Leg.Position.Y))
            {
                isStart_do = false;
                isVS = true;
            }
        }

        public static void IsStartDoScript_1()
        {
            movemt.X += 1.5f;
            movemt1.Y += 1.5f;
            VS.Position -= movemt1;
            Leg.Position += movemt;

            Nor.Position = new Vector2f(Leg.Position.X, Nor.Position.Y);
            Slo.Position = new Vector2f(Leg.Position.X, Slo.Position.Y);
            Lun.Position = new Vector2f(Leg.Position.X, Lun.Position.Y);

            MathHelper.Hide_dissolve(VS, 7, 0);
            MathHelper.Hide_dissolve(Leg, 7, 0);
            MathHelper.Hide_dissolve(Nor, 7, 0);
            MathHelper.Hide_dissolve(Slo, 7, 0);
            MathHelper.Hide_dissolve(Lun, 7, 0);

            if (VS.Color.A == 0)
            {
                VS.Position = new Vector2f(600, -VS.GetGlobalBounds().Height - 5);
                Leg.Position = new Vector2f(Program.Window.Size.X + 5, Leg.Position.Y);

                isStart_do1 = false;
                isStart = false;
                isMain = true;
                isMain_do = true;
                edx = 1;
                movemt = new Vector2f();
                movemt1 = new Vector2f();
            }
        }

        public static void IsStartVSScript()
        {
            movemt.X += 1.5f;

            VS.Position += movemt;
            if (edx == 1)
                VP_L.Position = MathHelper.Lerp(VP_L.Position, new Vector2f(VP_L.Position.X, 60), TimeMod.DeltaTime * 4.5f);
            else if (edx == 2)
                VP_N.Position = MathHelper.Lerp(VP_N.Position, new Vector2f(VP_N.Position.X, 60), TimeMod.DeltaTime * 4.5f);
            else if (edx == 3)
                VP_S.Position = MathHelper.Lerp(VP_S.Position, new Vector2f(VP_S.Position.X, 60), TimeMod.DeltaTime * 4.5f);
            else if (edx == 4)
                VP_Lun.Position = MathHelper.Lerp(VP_Lun.Position, new Vector2f(VP_Lun.Position.X, 60), TimeMod.DeltaTime * 4.5f);
            InfoOrRH1.Position = MathHelper.Lerp(InfoOrRH1.Position, new Vector2f(100, InfoOrRH1.Position.Y), TimeMod.DeltaTime * 4.5f);
            StRH.Position = MathHelper.Lerp(StRH.Position, new Vector2f(570, StRH.Position.Y), TimeMod.DeltaTime * 4.5f);
            InfoRH.Position = MathHelper.Lerp(InfoRH.Position, new Vector2f(950, InfoRH.Position.Y), TimeMod.DeltaTime * 4.5f);

            Leg.Rotation += 2;
            Nor.Rotation += 2;
            Slo.Rotation += 2;
            Lun.Rotation += 2;

            InfoOrRH2.Position = new Vector2f(InfoOrRH1.Position.X, InfoOrRH2.Position.Y);

            if (edx == 1)
                MathHelper.Show_dissolve(VP_L, 3, 255);
            else if (edx == 2)
                MathHelper.Show_dissolve(VP_N, 3, 255);
            else if (edx == 3)
                MathHelper.Show_dissolve(VP_S, 3, 255);
            else if (edx == 4)
                MathHelper.Show_dissolve(VP_Lun, 3, 255);
            MathHelper.Show_dissolve(StRH, 3, 179);
            MathHelper.Show_dissolve(InfoRH, 3, 255);
            MathHelper.Show_dissolve(InfoOrRH1, 3, 255);
            MathHelper.Show_dissolve(InfoOrRH2, 3, 160);
            MathHelper.Show_dissolve(Dark, 3, 255);

            MathHelper.Hide_dissolve(VS, 7, 0);
            MathHelper.Hide_dissolve(Leg, 7, 0);
            MathHelper.Hide_dissolve(Nor, 7, 0);
            MathHelper.Hide_dissolve(Slo, 7, 0);
            MathHelper.Hide_dissolve(Lun, 7, 0);

            if (VS.Color.A == 0)
            {
                VS.Position = new Vector2f(Program.Window.Size.X + 5, VS.Position.Y);
                Leg.Position = new Vector2f(Program.Window.Size.X + 5, Leg.Position.Y);

                Leg.Rotation = 0;
                Nor.Rotation = 0;
                Slo.Rotation = 0;
                Lun.Rotation = 0;
            }
            if (edx == 1)
            {
                if (new Vector2f((float)Math.Round(VP_L.Position.X),
                (float)Math.Round(VP_L.Position.Y)) == new Vector2f(VP_L.Position.X, 60))
                {
                    VP_L.Position = new Vector2f(VP_L.Position.X, 60);
                }
            }
            else if (edx == 2)
            {
                if (new Vector2f((float)Math.Round(VP_N.Position.X),
                (float)Math.Round(VP_N.Position.Y)) == new Vector2f(VP_N.Position.X, 60))
                {
                    VP_N.Position = new Vector2f(VP_N.Position.X, 60);
                }
            }
            else if (edx == 3)
            {
                if (new Vector2f((float)Math.Round(VP_S.Position.X),
                (float)Math.Round(VP_S.Position.Y)) == new Vector2f(VP_S.Position.X, 60))
                {
                    VP_S.Position = new Vector2f(VP_S.Position.X, 60);
                }
            }
            else if (edx == 4)
            {
                if (new Vector2f((float)Math.Round(VP_Lun.Position.X),
                (float)Math.Round(VP_Lun.Position.Y)) == new Vector2f(VP_Lun.Position.X, 60))
                {
                    VP_Lun.Position = new Vector2f(VP_Lun.Position.X, 60);
                }
            }
            if (new Vector2f((float)Math.Round(StRH.Position.X),
                (float)Math.Round(StRH.Position.Y)) == new Vector2f(570, StRH.Position.Y))
            {
                StRH.Position = new Vector2f(570, StRH.Position.Y);
            }
            if (new Vector2f((float)Math.Round(InfoOrRH1.Position.X),
                (float)Math.Round(InfoOrRH1.Position.Y)) == new Vector2f(100, InfoOrRH1.Position.Y))
            {
                InfoOrRH1.Position = new Vector2f(100, InfoOrRH1.Position.Y);
            }
            if (new Vector2f((float)Math.Round(InfoRH.Position.X),
                (float)Math.Round(InfoRH.Position.Y)) == new Vector2f(950, InfoRH.Position.Y))
            {
                InfoRH.Position = new Vector2f(950, InfoRH.Position.Y);
            }
            if (StRH.Position == new Vector2f(570, StRH.Position.Y)
                && InfoRH.Position == new Vector2f(950, InfoRH.Position.Y)
                && InfoOrRH1.Position == new Vector2f(100, InfoOrRH1.Position.Y))
            {
                isStart_vs = false;
                isVP = true;
                isVS = false;
                edx = 1;
                movemt = new Vector2f();
                movemt1 = new Vector2f();
                LevelSlo = 1;
            }
        }

        public static void IsStartVSScript_1()
        {
            movemt.Y += 1.5f;
            
            if (edx == 1)
                VP_L.Position -= movemt;
            else if (edx == 2)
                VP_N.Position -= movemt;
            else if (edx == 3)
                VP_S.Position -= movemt;
            else if (edx == 4)
                VP_Lun.Position -= movemt;
            VS.Position = MathHelper.Lerp(VS.Position, new Vector2f(600, VS.Position.Y), TimeMod.DeltaTime * 4.5f);
            Leg.Position = MathHelper.Lerp(Leg.Position, new Vector2f(620, Leg.Position.Y), TimeMod.DeltaTime * 4.5f);

            Nor.Position = new Vector2f(Leg.Position.X, Nor.Position.Y);
            Slo.Position = new Vector2f(Leg.Position.X, Slo.Position.Y);
            Lun.Position = new Vector2f(Leg.Position.X, Lun.Position.Y);

            MathHelper.Hide_dissolve(Dark, 7, 0);
            MathHelper.Hide_dissolve(VP_L, 7, 0);
            MathHelper.Hide_dissolve(VP_N, 7, 0);
            MathHelper.Hide_dissolve(VP_S, 7, 0);
            MathHelper.Hide_dissolve(VP_Lun, 7, 0);
            MathHelper.Show_dissolve(VS, 3, 255);
            MathHelper.Hide_dissolve(InfoOrRH1, 7, 0);
            MathHelper.Hide_dissolve(InfoOrRH2, 7, 0);
            MathHelper.Hide_dissolve(InfoOrAA1, 7, 0);
            MathHelper.Hide_dissolve(InfoOrAA2, 7, 0);
            MathHelper.Hide_dissolve(StRH, 7, 0);
            MathHelper.Hide_dissolve(StAA, 7, 0);
            MathHelper.Hide_dissolve(InfoRH, 7, 0);
            MathHelper.Hide_dissolve(InfoAA, 7, 0);
            MathHelper.Show_dissolve(Leg, 3, 255);
            MathHelper.Show_dissolve(Nor, 3, 255);
            MathHelper.Show_dissolve(Slo, 3, 255);
            MathHelper.Show_dissolve(Lun, 3, 255);

            if (Dark.Color.A == 0)
            {
                InfoOrRH1.Position = new Vector2f(0 - InfoOrRH1.GetGlobalBounds().Width - 5, InfoOrRH1.Position.Y);
                InfoOrRH2.Position = new Vector2f(InfoOrRH1.Position.X, InfoOrRH2.Position.Y);
                InfoOrAA1.Position = new Vector2f(InfoOrRH1.Position.X, InfoOrAA1.Position.Y);
                InfoOrAA2.Position = new Vector2f(InfoOrRH1.Position.X, InfoOrAA2.Position.Y);
                StRH.Position = new Vector2f(Program.Window.Size.X + 5, StRH.Position.Y);
                StAA.Position = new Vector2f(Program.Window.Size.X + 5, StAA.Position.Y);
                InfoRH.Position = new Vector2f(Program.Window.Size.X + 300, InfoRH.Position.Y);
                InfoAA.Position = new Vector2f(InfoRH.Position.X, InfoAA.Position.Y);
                VP_L.Position = new Vector2f(VS.Position.X, -VP_L.GetGlobalBounds().Height - 10);
                VP_N.Position = new Vector2f(VP_L.Position.X, VP_L.Position.Y);
                VP_S.Position = new Vector2f(VP_L.Position.X, VP_L.Position.Y);
                VP_Lun.Position = new Vector2f(VP_L.Position.X, VP_L.Position.Y);
            }
            if (new Vector2f((float)Math.Round(VS.Position.X),
                (float)Math.Round(VS.Position.Y)) == new Vector2f(600, VS.Position.Y))
            {
                VS.Position = new Vector2f(600, VS.Position.Y);
            }
            if (new Vector2f((float)Math.Round(Leg.Position.X),
                (float)Math.Round(Leg.Position.Y)) == new Vector2f(620, Leg.Position.Y))
            {
                Leg.Position = new Vector2f(620, Leg.Position.Y);
            }
            if (VS.Position == new Vector2f(600, VS.Position.Y))
            {
                isStart_vs1 = false;
                isVP = false;
                isVS = true;
                edx = 1;
                ecx = 1;
                movemt = new Vector2f();
                movemt1 = new Vector2f();
                LevelSlo = 0;
            }
        }

        public static void IsStartSPScript()
        {
            if (ecx == 2)
            {
                InfoAA.Position = MathHelper.Lerp(InfoAA.Position, new Vector2f(950, InfoAA.Position.Y), TimeMod.DeltaTime * 4.5f);
                StAA.Position = MathHelper.Lerp(StAA.Position, new Vector2f(480, StAA.Position.Y), TimeMod.DeltaTime * 4.5f);
                InfoOrAA1.Position = MathHelper.Lerp(InfoOrAA1.Position, new Vector2f(100, InfoOrAA1.Position.Y), TimeMod.DeltaTime * 4.5f);

                InfoOrAA2.Position = new Vector2f(InfoOrAA1.Position.X, InfoOrAA2.Position.Y);

                MathHelper.Hide_dissolve(StRH, 7, 0);
                MathHelper.Hide_dissolve(InfoRH, 7, 0);
                MathHelper.Hide_dissolve(InfoOrRH1, 7, 0);
                MathHelper.Hide_dissolve(InfoOrRH2, 7, 0);

                MathHelper.Show_dissolve(InfoOrAA1, 3, 255);
                MathHelper.Show_dissolve(InfoOrAA2, 3, 160);
                MathHelper.Show_dissolve(StAA, 3, 255);
                MathHelper.Show_dissolve(InfoAA, 3, 255);

                if (StRH.Color.A == 0)
                {
                    InfoOrRH1.Position = new Vector2f(0 - InfoOrRH1.GetGlobalBounds().Width - 5, InfoOrRH1.Position.Y);
                    InfoOrRH2.Position = new Vector2f(InfoOrRH1.Position.X, InfoOrRH2.Position.Y);
                    StRH.Position = new Vector2f(Program.Window.Size.X + 5, StRH.Position.Y);
                    InfoRH.Position = new Vector2f(Program.Window.Size.X + 300, InfoRH.Position.Y);
                }
                if (new Vector2f((float)Math.Round(StAA.Position.X),
                (float)Math.Round(StAA.Position.Y)) == new Vector2f(480, StAA.Position.Y))
                {
                    StAA.Position = new Vector2f(480, StAA.Position.Y);
                }
                if (new Vector2f((float)Math.Round(InfoOrAA1.Position.X),
                    (float)Math.Round(InfoOrAA1.Position.Y)) == new Vector2f(100, InfoOrAA1.Position.Y))
                {
                    InfoOrAA1.Position = new Vector2f(100, InfoOrAA1.Position.Y);
                }
                if (new Vector2f((float)Math.Round(InfoAA.Position.X),
                    (float)Math.Round(InfoAA.Position.Y)) == new Vector2f(950, InfoAA.Position.Y))
                {
                    InfoAA.Position = new Vector2f(950, InfoAA.Position.Y);
                }
                if (StAA.Position == new Vector2f(480, StAA.Position.Y)
                    && InfoAA.Position == new Vector2f(950, InfoAA.Position.Y)
                    && InfoOrAA1.Position == new Vector2f(100, InfoOrAA1.Position.Y))
                {
                    isStart_SP = false;
                    edx = 1;
                    movemt = new Vector2f();
                    movemt1 = new Vector2f();
                }
            }
            else if (ecx == 1)
            {
                InfoRH.Position = MathHelper.Lerp(InfoRH.Position, new Vector2f(950, InfoRH.Position.Y), TimeMod.DeltaTime * 4.5f);
                StRH.Position = MathHelper.Lerp(StRH.Position, new Vector2f(570, StRH.Position.Y), TimeMod.DeltaTime * 4.5f);
                InfoOrRH1.Position = MathHelper.Lerp(InfoOrRH1.Position, new Vector2f(100, InfoOrRH1.Position.Y), TimeMod.DeltaTime * 4.5f);

                InfoOrRH2.Position = new Vector2f(InfoOrRH1.Position.X, InfoOrRH2.Position.Y);

                MathHelper.Hide_dissolve(StAA, 7, 0);
                MathHelper.Hide_dissolve(InfoAA, 7, 0);
                MathHelper.Hide_dissolve(InfoOrAA1, 7, 0);
                MathHelper.Hide_dissolve(InfoOrAA2, 7, 0);

                MathHelper.Show_dissolve(InfoOrRH1, 3, 255);
                MathHelper.Show_dissolve(InfoOrRH2, 3, 160);
                MathHelper.Show_dissolve(StRH, 3, 255);
                MathHelper.Show_dissolve(InfoRH, 3, 255);

                if (StAA.Color.A == 0)
                {
                    InfoOrAA1.Position = new Vector2f(0 - InfoOrAA1.GetGlobalBounds().Width - 5, InfoOrAA1.Position.Y);
                    InfoOrAA2.Position = new Vector2f(InfoOrAA1.Position.X, InfoOrAA2.Position.Y);
                    StAA.Position = new Vector2f(Program.Window.Size.X + 5, StAA.Position.Y);
                    InfoAA.Position = new Vector2f(Program.Window.Size.X + 300, InfoAA.Position.Y);
                }
                if (new Vector2f((float)Math.Round(StRH.Position.X),
                (float)Math.Round(StRH.Position.Y)) == new Vector2f(570, StRH.Position.Y))
                {
                    StRH.Position = new Vector2f(570, StRH.Position.Y);
                }
                if (new Vector2f((float)Math.Round(InfoOrRH1.Position.X),
                    (float)Math.Round(InfoOrRH1.Position.Y)) == new Vector2f(100, InfoOrRH1.Position.Y))
                {
                    InfoOrRH1.Position = new Vector2f(100, InfoOrRH1.Position.Y);
                }
                if (new Vector2f((float)Math.Round(InfoRH.Position.X),
                    (float)Math.Round(InfoRH.Position.Y)) == new Vector2f(950, InfoRH.Position.Y))
                {
                    InfoRH.Position = new Vector2f(950, InfoRH.Position.Y);
                }
                if (StRH.Position == new Vector2f(570, StRH.Position.Y)
                    && InfoRH.Position == new Vector2f(950, InfoRH.Position.Y)
                    && InfoOrRH1.Position == new Vector2f(100, InfoOrRH1.Position.Y))
                {
                    isStart_SP = false;
                    edx = 1;
                    movemt = new Vector2f();
                    movemt1 = new Vector2f();
                }
            }
        }
    }
}
