using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Adderley
{
    abstract class Menu : Transformable, Drawable
    {
        public static Sprite text1;
        public static Sprite text2;
        public static Sprite text3;
        public static Sprite text4;
        public static Sprite text5;
        public static Sprite text6;

        public static Sprite text1op;
        public static Sprite text2op;
        public static Sprite text3op;
        public static Sprite text4op;
        public static Sprite text5op;
        public static Sprite text6op;
        public static Sprite text7op;
        public static Sprite text8op;
        public static Sprite text9op;
        public static Sprite text10op;
        public static Sprite text11op;
        public static Sprite text12op;

        public static Sprite fon;
        public static Sprite naz1;
        public static Sprite naz2;
        public static Sprite naz3;
        public static Sprite fonnaz1;
        public static Sprite fonnaz2;
        public static Sprite fonnaz3;

        public static Sprite Dark;
        public static Sprite StRH;
        public static Sprite StAA;
        public static Sprite InfoRH;
        public static Sprite InfoAA;

        public static Sprite VS;
        public static Sprite Leg;
        public static Sprite Nor;
        public static Sprite Slo;
        public static Sprite Lun;
        public static Sprite VP_L;
        public static Sprite VP_N;
        public static Sprite VP_S;
        public static Sprite VP_Lun;

        public static Sprite InfoOrRH1;
        public static Sprite InfoOrRH2;
        public static Sprite InfoOrAA1;
        public static Sprite InfoOrAA2;

        public static bool isMenu;
        public static bool isMain;
        public static bool isOption;
        public static bool isMain_do;
        public static bool isStart;
        public static bool isExtra;
        public static bool isPraction;
        public static bool isRecord;
        public static bool isMan;
        public static bool isExit;
        public static bool isPress;
        public static bool isMain_do1;
        public static bool isOption_do;
        public static bool isOption_do1;
        public static bool isYpr;
        public static bool isYpr_do;
        public static bool isZast;
        public static bool isStart_do;
        public static bool isStart_do1;
        public static bool isVS;
        public static bool isVP;
        public static bool isStart_vs;
        public static bool isStart_vs1;
        public static bool isStart_SP;

        public static int edx;
        public static int ecx;
        public static int ebx1;
        public static int ebx2;
        public static int ebx3;
        public static int LevelSlo;
        public static int LevelPer;
        public static int LevelOry;

        public static Vector2f movemt;
        public static Vector2f movemt1;

        public Menu()
        {
            isMenu = true;
            isOption = false;
            isMain = false;
            isMain_do = false;
            isStart = false;
            isExtra = false;
            isPraction = false;
            isRecord = false;
            isMan = false;
            isExit = false;
            isPress = false;
            isMain_do1 = false;
            isOption_do = false;
            isOption_do1 = false;
            isYpr = false;
            isYpr_do = false;
            isZast = true;
            isStart_do = false;
            isStart_do1 = false;
            isVS = false;
            isVP = false;
            isStart_vs = false;
            isStart_vs1 = false;
            isStart_SP = false;

            movemt = new Vector2f();
            movemt1 = new Vector2f();

            InfoOrRH1 = new Sprite(Content.InfoOrRH1);
            InfoOrRH2 = new Sprite(Content.InfoOrRH2);
            InfoOrAA1 = new Sprite(Content.InfoOrAA1);
            InfoOrAA2 = new Sprite(Content.InfoOrAA2);

            InfoOrRH1.Position = new Vector2f(0 - InfoOrRH1.GetGlobalBounds().Width - 5, 400);
            InfoOrRH2.Position = new Vector2f(InfoOrRH1.Position.X, InfoOrRH1.Position.Y + InfoOrRH1.GetGlobalBounds().Height + 20);
            InfoOrAA1.Position = new Vector2f(InfoOrRH1.Position.X, InfoOrRH1.Position.Y);
            InfoOrAA2.Position = new Vector2f(InfoOrRH2.Position.X, InfoOrRH2.Position.Y);

            InfoOrRH1.Color = new Color(255, 255, 255, 0);
            InfoOrRH2.Color = new Color(128, 128, 128, 0);
            InfoOrAA1.Color = new Color(255, 255, 255, 0);
            InfoOrAA2.Color = new Color(128, 128, 128, 0);

            edx = 1;
            ecx = 1;
            ebx1 = 2;
            ebx2 = 2;
            ebx3 = 2;
            LevelSlo = 0;
            LevelPer = 0;
            LevelOry = 0;

            fon = new Sprite(Content.zast);
            naz1 = new Sprite(Content.naz1);
            naz2 = new Sprite(Content.naz2);
            naz3 = new Sprite(Content.naz3);
            fonnaz1 = new Sprite(Content.fonnaz1);
            fonnaz2 = new Sprite(Content.fonnaz2);
            fonnaz3 = new Sprite(Content.fonnaz2);

            Dark = new Sprite(Content.Dark);
            StAA = new Sprite(Content.StAA);
            StRH = new Sprite(Content.StRH);
            InfoAA = new Sprite(Content.InfoAA);
            InfoRH = new Sprite(Content.InfoRH);

            Dark.Origin = new Vector2f(Dark.GetGlobalBounds().Width, Dark.GetGlobalBounds().Height);
            StAA.Origin = new Vector2f(0, StAA.GetGlobalBounds().Height);
            StRH.Origin = new Vector2f(0, StRH.GetGlobalBounds().Height);
            StAA.Position = new Vector2f(Program.Window.Size.X + 5, Program.Window.Size.Y);
            StRH.Position = new Vector2f(Program.Window.Size.X + 5, Program.Window.Size.Y);
            Dark.Position = new Vector2f(Program.Window.Size.X, Program.Window.Size.Y);
            InfoAA.Position = new Vector2f(Program.Window.Size.X + 300, 310);
            InfoRH.Position = new Vector2f(InfoAA.Position.X, 310);

            Dark.Color = new Color(255, 255, 255, 0);
            StAA.Color = new Color(255, 255, 255, 0);
            StRH.Color = new Color(255, 255, 255, 0);
            InfoRH.Color = new Color(255, 255, 255, 0);
            InfoAA.Color = new Color(255, 255, 255, 0);

            text1 = new Sprite(Content.text1);
            text2 = new Sprite(Content.text2);
            text3 = new Sprite(Content.text3);
            text4 = new Sprite(Content.text4);
            text5 = new Sprite(Content.text5);
            text6 = new Sprite(Content.text6);

            VS = new Sprite(Content.VS);
            Leg = new Sprite(Content.Leg);
            Nor = new Sprite(Content.Nor);
            Slo = new Sprite(Content.Slo);
            Lun = new Sprite(Content.Lun);
            VP_L = new Sprite(Content.VP_L);
            VP_N = new Sprite(Content.VP_N);
            VP_S = new Sprite(Content.VP_S);
            VP_Lun = new Sprite(Content.VP_Lun);

            VS.Position = new Vector2f(Program.Window.Size.X / 2 - 40, -VS.GetGlobalBounds().Height - 5);
            Leg.Position = new Vector2f(Program.Window.Size.X + 5, 260);
            Nor.Position = new Vector2f(Leg.Position.X, Leg.Position.Y + Leg.GetGlobalBounds().Height + 30);
            Slo.Position = new Vector2f(Leg.Position.X, Nor.Position.Y + Nor.GetGlobalBounds().Height + 30);
            Lun.Position = new Vector2f(Leg.Position.X, Slo.Position.Y + Slo.GetGlobalBounds().Height + 30);

            VP_L.Position = new Vector2f(VS.Position.X, -VP_L.GetGlobalBounds().Height - 10);
            VP_N.Position = new Vector2f(VS.Position.X, VP_L.Position.Y);
            VP_S.Position = new Vector2f(VS.Position.X, VP_L.Position.Y);
            VP_Lun.Position = new Vector2f(VS.Position.X, VP_L.Position.Y);

            VS.Color = new Color(255, 255, 255, 0);
            Leg.Color = new Color(255, 255, 255, 0);
            Nor.Color = new Color(128, 128, 128, 0);
            Slo.Color = new Color(128, 128, 128, 0);
            Lun.Color = new Color(128, 128, 128, 0);

            VP_L.Color = new Color(255, 255, 255, 0);
            VP_N.Color = new Color(255, 255, 255, 0);
            VP_S.Color = new Color(255, 255, 255, 0);
            VP_Lun.Color = new Color(255, 255, 255, 0);

            text1op = new Sprite(Content.text1op);
            text2op = new Sprite(Content.text2op);
            text3op = new Sprite(Content.text3op);
            text4op = new Sprite(Content.text4op);
            text5op = new Sprite(Content.text5op);
            text6op = new Sprite(Content.text6op);
            text7op = new Sprite(Content.text7op);
            text8op = new Sprite(Content.text8op);
            text9op = new Sprite(Content.text7op);
            text10op = new Sprite(Content.text8op);
            text11op = new Sprite(Content.text9op);
            text12op = new Sprite(Content.text10op);

            fonnaz1.Position = new Vector2f(100, 80);
            fonnaz2.Position = new Vector2f(fonnaz1.GetGlobalBounds().Left, fonnaz1.Position.Y + fonnaz1.GetGlobalBounds().Height - 15);
            fonnaz3.Position = new Vector2f(fonnaz1.GetGlobalBounds().Left, fonnaz2.Position.Y + fonnaz2.GetGlobalBounds().Height - 15);
            naz1.Position = new Vector2f(Program.Window.Size.X / 2, fonnaz1.Position.Y + 25);
            naz2.Position = new Vector2f(naz1.Position.X, fonnaz2.Position.Y + 10);
            naz3.Position = new Vector2f(naz1.Position.X, fonnaz3.Position.Y + 10);

            text1.Position = new Vector2f(0 - text1.GetGlobalBounds().Width - 10, fonnaz3.Position.Y + fonnaz3.GetGlobalBounds().Height + 70);
            text2.Position = new Vector2f(text1.GetGlobalBounds().Left - 20, text1.GetGlobalBounds().Top + text1.GetGlobalBounds().Height + 15);
            text3.Position = new Vector2f(text2.GetGlobalBounds().Left - 20, text2.GetGlobalBounds().Top + text2.GetGlobalBounds().Height + 15);
            text4.Position = new Vector2f(text3.GetGlobalBounds().Left - 20, text3.GetGlobalBounds().Top + text3.GetGlobalBounds().Height + 15);
            text5.Position = new Vector2f(text4.GetGlobalBounds().Left + 20, text4.GetGlobalBounds().Top + text4.GetGlobalBounds().Height + 15);
            text6.Position = new Vector2f(text5.GetGlobalBounds().Left + 20, text5.GetGlobalBounds().Top + text5.GetGlobalBounds().Height + 15);

            text1op.Position = new Vector2f(-285, 120);
            text2op.Position = new Vector2f(text1op.Position.X + text1op.GetGlobalBounds().Width / 2 - text2op.GetGlobalBounds().Width / 2, text1op.Position.Y + 140);
            text3op.Position = new Vector2f(text1op.Position.X + text1op.GetGlobalBounds().Width / 2 - text3op.GetGlobalBounds().Width / 2, text2op.Position.Y + 140);
            text4op.Position = new Vector2f(text1op.Position.X + text1op.GetGlobalBounds().Width / 2 - text4op.GetGlobalBounds().Width / 2, text3op.Position.Y + 210);
            text5op.Position = new Vector2f(text1op.Position.X + text1op.GetGlobalBounds().Width / 2 - text5op.GetGlobalBounds().Width / 2, text4op.Position.Y + 70);
            text6op.Position = new Vector2f(text1op.Position.X + text1op.GetGlobalBounds().Width / 2 - text6op.GetGlobalBounds().Width / 2, text5op.Position.Y + 70);
            text7op.Position = new Vector2f(text1op.Position.X, text1op.Position.Y + 70);
            text8op.Position = new Vector2f(text1op.Position.X + text1op.GetGlobalBounds().Width - text8op.GetGlobalBounds().Width, text7op.Position.Y);
            text9op.Position = new Vector2f(text7op.Position.X, text2op.Position.Y + 70);
            text10op.Position = new Vector2f(text8op.Position.X, text9op.Position.Y);
            text11op.Position = new Vector2f(text1op.Position.X + text1op.GetGlobalBounds().Width / 2 - text11op.GetGlobalBounds().Width / 2, text3op.Position.Y + 70);
            text12op.Position = new Vector2f(text1op.Position.X + text1op.GetGlobalBounds().Width / 2 - text12op.GetGlobalBounds().Width / 2, text11op.Position.Y + 70);

            text8op.Scale = new Vector2f(1.1f, 1.1f);
            text10op.Scale = new Vector2f(1.1f, 1.1f);
            text12op.Scale = new Vector2f(1.1f, 1.1f);

            text1.Color = new Color(255, 255, 255, 0);
            text2.Color = new Color(128, 128, 128, 0);
            text3.Color = new Color(128, 128, 128, 0);
            text4.Color = new Color(128, 128, 128, 0);
            text5.Color = new Color(128, 128, 128, 0);
            text6.Color = new Color(128, 128, 128, 0);

            naz1.Color = new Color(255, 255, 255, 0);
            naz2.Color = new Color(255, 255, 255, 0);
            naz3.Color = new Color(255, 255, 255, 0);
            fonnaz1.Color = new Color(255, 255, 255, 0);
            fonnaz2.Color = new Color(255, 255, 255, 0);
            fonnaz3.Color = new Color(255, 255, 255, 0);

            text1op.Color = new Color(255, 255, 255, 0);
            text2op.Color = new Color(128, 128, 128, 0);
            text3op.Color = new Color(128, 128, 128, 0);
            text4op.Color = new Color(128, 128, 128, 0);
            text5op.Color = new Color(128, 128, 128, 0);
            text6op.Color = new Color(128, 128, 128, 0);
            text7op.Color = new Color(255, 255, 255, 0);
            text8op.Color = new Color(255, 255, 255, 0);
            text9op.Color = new Color(128, 128, 128, 0);
            text10op.Color = new Color(255, 255, 255, 0);
            text11op.Color = new Color(128, 128, 128, 0);
            text12op.Color = new Color(255, 255, 255, 0);
        }

        public abstract void Update();
        public abstract void Draw(RenderTarget target, RenderStates states);
    }
}
