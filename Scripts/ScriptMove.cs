using SFML.Graphics;
using SFML.System;
using System.Collections.Generic;

namespace Adderley
{
    class ScriptMove : Transformable, Drawable
    {
        public static Sprite bgspr1;
        public static Sprite bgspr2;
        public static Sprite bgspr3;
        public static Sprite bgspr4;
        public static Sprite bgspr5;
        public static Sprite bgspr6;
        public static Sprite bgspr7;
        public static Sprite bgspr8;
        public static Sprite bgspr9;
        public static Sprite bgspr10;

        public static Vector2f movement1;
        public static Vector2f movement2;
        public static Vector2f movement3;
        public static Vector2f movement4;
        public static Vector2f movement5;
        public static Vector2f movement6;
        public static Vector2f movement7;
        public static Vector2f movement8;
        public static Vector2f movement9;
        public static Vector2f movement10;

        public static Vector2f temp1;
        public static Vector2f temp2;
        public static Vector2f temp3;
        public static Vector2f temp4;
        public static Vector2f temp5;
        public static Vector2f temp6;
        public static Vector2f temp7;
        public static Vector2f temp8;
        public static Vector2f temp9;
        public static Vector2f temp10;

        public static Vector2f Pos2;
        public static Vector2f Pos3;
        public static Vector2f Pos5;
        public static Vector2f Pos4;
        public static Vector2f Pos7;
        public static Vector2f Pos8;
        public static Vector2f Pos9;
        public static Vector2f Pos10;
        public static Vector2f Pos6;
        public static Vector2f Pos1;

        public static Vector2f size1;
        public static Vector2f size2;
        public static Vector2f size3;
        public static Vector2f size4;
        public static Vector2f size5;
        public static Vector2f size6;
        public static Vector2f size7;
        public static Vector2f size8;
        public static Vector2f size9;
        public static Vector2f size10;

        public static float spd;

        public static float speed;
        public static float SpD;

        public static Vector2f Rot1;

        public static bool isStartPusk;
        public static bool isStartEnd;
        public static bool isValue;
        public static bool Rot;
        public static bool Rot_bl;
        public static bool NoDraw;
        public static bool Rot_sm;
        public static bool isPressDial;

        public static float timer;
        public static float timer1;

        public static Bezier Bezier1;
        public static Bezier Bezier2;
        public static Bezier Bezier3;
        public static Bezier Bezier4;
        public static Bezier Bezier5;
        public static Bezier Bezier6;
        public static Bezier Bezier7;
        public static Bezier Bezier8;
        public static Bezier Bezier9;
        public static Bezier Bezier10;

        public ScriptMove()
        {
            bgspr1 = new Sprite(Content.bgf1);
            bgspr2 = new Sprite(Content.bgf2);
            bgspr3 = new Sprite(Content.bgf3);
            bgspr4 = new Sprite(Content.bgf4);
            bgspr5 = new Sprite(Content.bgf5);
            bgspr6 = new Sprite(Content.bgf6);
            bgspr7 = new Sprite(Content.bgf7);
            bgspr8 = new Sprite(Content.bgf8);
            bgspr9 = new Sprite(Content.bgf9);
            bgspr10 = new Sprite(Content.bgf10);

            isStartPusk = false;
            isStartEnd = false;
            isValue = true;
            Rot = false;
            Rot_bl = false;
            NoDraw = false;
            Rot_sm = true;
            isPressDial = true;

            Bezier1 = new Bezier();
            Bezier2 = new Bezier();
            Bezier3 = new Bezier();
            Bezier4 = new Bezier();
            Bezier5 = new Bezier();
            Bezier6 = new Bezier();
            Bezier7 = new Bezier();
            Bezier8 = new Bezier();
            Bezier9 = new Bezier();
            Bezier10 = new Bezier();

            speed = 0.03f;
            SpD = 4.2f;
            timer = 0;
            timer1 = 0;

            Rot1 = new Vector2f(1, 1);

            spd = 7f;

            size1 = new Vector2f(bgspr1.GetGlobalBounds().Width, bgspr1.GetGlobalBounds().Height);
            size2 = new Vector2f(bgspr2.GetGlobalBounds().Width, bgspr2.GetGlobalBounds().Height);
            size3 = new Vector2f(bgspr3.GetGlobalBounds().Width, bgspr3.GetGlobalBounds().Height);
            size4 = new Vector2f(bgspr4.GetGlobalBounds().Width, bgspr4.GetGlobalBounds().Height);
            size5 = new Vector2f(bgspr5.GetGlobalBounds().Width, bgspr5.GetGlobalBounds().Height);
            size6 = new Vector2f(bgspr6.GetGlobalBounds().Width, bgspr6.GetGlobalBounds().Height);
            size7 = new Vector2f(bgspr7.GetGlobalBounds().Width, bgspr7.GetGlobalBounds().Height);
            size8 = new Vector2f(bgspr8.GetGlobalBounds().Width, bgspr8.GetGlobalBounds().Height);
            size9 = new Vector2f(bgspr9.GetGlobalBounds().Width, bgspr9.GetGlobalBounds().Height);
            size10 = new Vector2f(bgspr10.GetGlobalBounds().Width, bgspr10.GetGlobalBounds().Height);

            Pos2 = new Vector2f(0 + size2.X / 2, 0 + size2.Y / 2);
            Pos3 = new Vector2f(Program.Window.Size.X - size3.X + size3.X / 2, 0 + size3.Y / 2);
            Pos5 = new Vector2f(0 + size5.X / 2, Program.Window.Size.Y - size5.Y + size5.Y / 2);
            Pos4 = new Vector2f(Program.Window.Size.X - size4.X + size4.X / 2, Program.Window.Size.Y - size4.Y + size4.Y / 2);
            Pos7 = new Vector2f(0 + size7.X / 2, 0 + size2.Y - 121 + size7.Y / 2);
            Pos8 = new Vector2f(Program.Window.Size.X - size8.X + size8.X / 2, 0 + size3.Y - 140 + size8.Y / 2);
            Pos9 = new Vector2f(0 + size2.X - 228 + size9.X / 2, 0 + size9.Y / 2);
            Pos10 = new Vector2f(0 + size5.X - 220 + size10.X / 2, Program.Window.Size.Y - size10.Y + size10.Y / 2);
            Pos6 = new Vector2f(0 + size7.X - 8 + size6.X / 2, Program.Window.Size.Y - size10.Y - size6.Y + 3 + size6.Y / 2);
            Pos1 = new Vector2f(Program.Window.Size.X - size8.X - size1.X + 4 + size1.X / 2, 0 + size9.Y - 1 + size1.Y / 2);

            bgspr2.Position = Pos2;
            bgspr3.Position = Pos3;
            bgspr5.Position = Pos5;
            bgspr4.Position = Pos4;
            bgspr7.Position = Pos7;
            bgspr8.Position = Pos8;
            bgspr9.Position = Pos9;
            bgspr10.Position = Pos10;
            bgspr6.Position = Pos6;
            bgspr1.Position = Pos1;

            bgspr1.Origin = new Vector2f(size1.X / 2, size1.Y / 2);
            bgspr2.Origin = new Vector2f(size2.X / 2, size2.Y / 2);
            bgspr3.Origin = new Vector2f(size3.X / 2, size3.Y / 2);
            bgspr4.Origin = new Vector2f(size4.X / 2, size4.Y / 2);
            bgspr5.Origin = new Vector2f(size5.X / 2, size5.Y / 2);
            bgspr6.Origin = new Vector2f(size6.X / 2, size6.Y / 2);
            bgspr7.Origin = new Vector2f(size7.X / 2, size7.Y / 2);
            bgspr8.Origin = new Vector2f(size8.X / 2, size8.Y / 2);
            bgspr9.Origin = new Vector2f(size9.X / 2, size9.Y / 2);
            bgspr10.Origin = new Vector2f(size10.X / 2, size10.Y / 2);
        }

        public void Update()
        {
            timer += 0.05f;
            timer1 += 0.05f;
            if (timer1 >= 1 && !Level1.isStart && Game.Snow.Count < 60)
            {
                var s = new SnowFactory(Content.Snow, 150, 100, new Vector2f(0, 100), new Vector2f(50, 400));
                Game.Snow.Add(s);

                timer1 = 0;
            }
            if (timer >= 10 && isPressDial && !Level1.isStart)
            {
                Dialogs.isStart = true;
                isPressDial = false;
            }
            if (isStartPusk)
            {
                if (isValue)
                {
                    temp1 = new Vector2f(-445, -445);
                    temp2 = new Vector2f(Program.Window.Size.X + 474, -474);
                    temp3 = new Vector2f(-482, Program.Window.Size.Y + 482);
                    temp4 = new Vector2f(Program.Window.Size.X + 477, Program.Window.Size.Y + 477);
                    temp5 = new Vector2f(Program.Window.Size.X / 2, -861);
                    temp6 = new Vector2f(Program.Window.Size.X / 2, Program.Window.Size.Y + 816);
                    temp7 = new Vector2f(-670, Program.Window.Size.Y / 2);
                    temp8 = new Vector2f(Program.Window.Size.X + 597, Program.Window.Size.Y / 2);
                    temp9 = new Vector2f(Program.Window.Size.X / 2 - Program.Window.Size.X / 3, Program.Window.Size.Y + 811);
                    temp10 = new Vector2f(Program.Window.Size.X / 2 + Program.Window.Size.X / 3, -805);
                    
                    Bezier1.BezAdd(bgspr2.Position, temp1, new Vector2f(600, 300), new Vector2f(600, 600), 40, true, 30);
                    Bezier2.BezAdd(bgspr3.Position, temp2, new Vector2f(600, 600), new Vector2f(600, 300), 40, true, 30);
                    Bezier3.BezAdd(bgspr5.Position, temp3, new Vector2f(300, 600), new Vector2f(600, 600), 40, true, 30);
                    Bezier4.BezAdd(bgspr4.Position, temp4, new Vector2f(600, 600), new Vector2f(600, 300), 40, true, 30);
                    Bezier5.BezAdd(bgspr9.Position, temp5, new Vector2f(300, 300), new Vector2f(600, 600), 40, true, 30);
                    Bezier6.BezAdd(bgspr10.Position, temp6, new Vector2f(600, 300), new Vector2f(300, 600), 40, true, 30);
                    Bezier7.BezAdd(bgspr7.Position, temp7, new Vector2f(600, 300), new Vector2f(300, 600), 40, true, 30);
                    Bezier8.BezAdd(bgspr8.Position, temp8, new Vector2f(600, 300), new Vector2f(600, 600), 40, true, 30);
                    Bezier9.BezAdd(bgspr6.Position, temp9, new Vector2f(300, 300), new Vector2f(600, 300), 40, true, 30);
                    Bezier10.BezAdd(bgspr1.Position, temp10, new Vector2f(600, 300), new Vector2f(300, 600), 40, true, 30);

                    isValue = false;
                    Rot = true;
                    Level1.isStart = true;
                }

                spd *= 1.01f;

                movement2 = Bezier1.GetMovement(bgspr2.Position, spd);
                movement3 = Bezier2.GetMovement(bgspr3.Position, spd);
                movement5 = Bezier3.GetMovement(bgspr5.Position, spd);
                movement4 = Bezier4.GetMovement(bgspr4.Position, spd);
                movement9 = Bezier5.GetMovement(bgspr9.Position, spd);
                movement10 = Bezier6.GetMovement(bgspr10.Position, spd);
                movement7 = Bezier7.GetMovement(bgspr7.Position, spd);
                movement8 = Bezier8.GetMovement(bgspr8.Position, spd);
                movement6 = Bezier9.GetMovement(bgspr6.Position, spd);
                movement1 = Bezier10.GetMovement(bgspr1.Position, spd);
                
                if (Bezier1.ret.Count != 0)
                {
                    if (Bezier1.distance <= Bezier1.dist && Bezier1.kill)
                        movement2 = new Vector2f();
                    else if (Bezier1.distance <= Bezier1.dist)
                        Bezier1.ret.RemoveRange(0, Bezier1.ret.Count);
                    else if (Bezier1.distper <= Bezier1.dist)
                        Bezier1.i++;
                }
                if (Bezier2.ret.Count != 0)
                {
                    if (Bezier2.distance <= Bezier2.dist && Bezier2.kill)
                        movement3 = new Vector2f();
                    else if (Bezier2.distance <= Bezier2.dist)
                        Bezier2.ret.RemoveRange(0, Bezier2.ret.Count);
                    else if (Bezier2.distper <= Bezier2.dist)
                        Bezier2.i++;
                }
                if (Bezier3.ret.Count != 0)
                {
                    if (Bezier3.distance <= Bezier3.dist && Bezier3.kill)
                        movement5 = new Vector2f();
                    else if (Bezier3.distance <= Bezier3.dist)
                        Bezier3.ret.RemoveRange(0, Bezier3.ret.Count);
                    else if (Bezier3.distper <= Bezier3.dist)
                        Bezier3.i++;
                }
                if (Bezier4.ret.Count != 0)
                {
                    if (Bezier4.distance <= Bezier4.dist && Bezier4.kill)
                        movement4 = new Vector2f();
                    else if (Bezier4.distance <= Bezier4.dist)
                        Bezier4.ret.RemoveRange(0, Bezier4.ret.Count);
                    else if (Bezier4.distper <= Bezier4.dist)
                        Bezier4.i++;
                }
                if (Bezier5.ret.Count != 0)
                {
                    if (Bezier5.distance <= Bezier5.dist && Bezier5.kill)
                        movement9 = new Vector2f();
                    else if (Bezier5.distance <= Bezier5.dist)
                        Bezier5.ret.RemoveRange(0, Bezier5.ret.Count);
                    else if (Bezier5.distper <= Bezier5.dist)
                        Bezier5.i++;
                }
                if (Bezier6.ret.Count != 0)
                {
                    if (Bezier6.distance <= Bezier6.dist && Bezier6.kill)
                        movement10 = new Vector2f();
                    else if (Bezier6.distance <= Bezier6.dist)
                        Bezier6.ret.RemoveRange(0, Bezier6.ret.Count);
                    else if (Bezier6.distper <= Bezier6.dist)
                        Bezier6.i++;
                }
                if (Bezier7.ret.Count != 0)
                {
                    if (Bezier7.distance <= Bezier7.dist && Bezier7.kill)
                        movement7 = new Vector2f();
                    else if (Bezier7.distance <= Bezier7.dist)
                        Bezier7.ret.RemoveRange(0, Bezier7.ret.Count);
                    else if (Bezier7.distper <= Bezier7.dist)
                        Bezier7.i++;
                }
                if (Bezier8.ret.Count != 0)
                {
                    if (Bezier8.distance <= Bezier8.dist && Bezier8.kill)
                        movement8 = new Vector2f();
                    else if (Bezier8.distance <= Bezier8.dist)
                        Bezier8.ret.RemoveRange(0, Bezier8.ret.Count);
                    else if (Bezier8.distper <= Bezier8.dist)
                        Bezier8.i++;
                }
                if (Bezier9.ret.Count != 0)
                {
                    if (Bezier9.distance <= Bezier9.dist && Bezier9.kill)
                        movement6 = new Vector2f();
                    else if (Bezier9.distance <= Bezier9.dist)
                        Bezier9.ret.RemoveRange(0, Bezier9.ret.Count);
                    else if (Bezier9.distper <= Bezier9.dist)
                        Bezier9.i++;
                }
                if (Bezier10.ret.Count != 0)
                {
                    if (Bezier10.distance <= Bezier10.dist && Bezier10.kill)
                        movement1 = new Vector2f();
                    else if (Bezier10.distance <= Bezier10.dist)
                        Bezier10.ret.RemoveRange(0, Bezier10.ret.Count);
                    else if (Bezier10.distper <= Bezier10.dist)
                        Bezier10.i++;
                }

                if (movement1 == new Vector2f()
                    && movement2 == new Vector2f()
                    && movement3 == new Vector2f()
                    && movement4 == new Vector2f()
                    && movement5 == new Vector2f()
                    && movement6 == new Vector2f()
                    && movement7 == new Vector2f()
                    && movement8 == new Vector2f()
                    && movement9 == new Vector2f()
                    && movement10 == new Vector2f()
                    && bgspr1.Position != Pos1
                    && bgspr2.Position != Pos2
                    && bgspr3.Position != Pos3
                    && bgspr4.Position != Pos4
                    && bgspr5.Position != Pos5
                    && bgspr6.Position != Pos6
                    && bgspr7.Position != Pos7
                    && bgspr8.Position != Pos8
                    && bgspr9.Position != Pos9
                    && bgspr10.Position != Pos10)
                {
                    isStartPusk = false;
                    Rot = false;
                    isValue = true;
                    NoDraw = true;
                    Info.isZagMove = true;
                }
            }
            if (isStartEnd)
            {
                if (isValue)
                {
                    bgspr1.Position = new Vector2f(Program.Window.Size.X / 2 + Program.Window.Size.X / 3, -405);
                    bgspr2.Position = new Vector2f(-225, -225);
                    bgspr3.Position = new Vector2f(Program.Window.Size.X + 240, -240);
                    bgspr4.Position = new Vector2f(Program.Window.Size.X + 240, Program.Window.Size.Y + 240);
                    bgspr5.Position = new Vector2f(-244, Program.Window.Size.Y + 244);
                    bgspr6.Position = new Vector2f(Program.Window.Size.X / 2 - Program.Window.Size.X / 3, Program.Window.Size.Y + 408);
                    bgspr7.Position = new Vector2f(-337, Program.Window.Size.Y / 2);
                    bgspr8.Position = new Vector2f(Program.Window.Size.X + 301, Program.Window.Size.Y / 2);
                    bgspr9.Position = new Vector2f(Program.Window.Size.X / 2, -433);
                    bgspr10.Position = new Vector2f(Program.Window.Size.X / 2, Program.Window.Size.Y + 410);

                    temp1 = Pos2;
                    temp2 = Pos3;
                    temp3 = Pos5;
                    temp4 = Pos4;
                    temp5 = Pos9;
                    temp6 = Pos10;
                    temp7 = Pos7;
                    temp8 = Pos8;
                    temp9 = Pos6;
                    temp10 = Pos1;

                    Bezier1.BezAdd(bgspr2.Position, temp1, new Vector2f(Program.Window.Size.X, 0), new Vector2f(600, 600), 50, true, 15);
                    Bezier2.BezAdd(bgspr3.Position, temp2, new Vector2f(Program.Window.Size.X, Program.Window.Size.Y), new Vector2f(600, 600), 50, true, 15);
                    Bezier3.BezAdd(bgspr5.Position, temp3, new Vector2f(0, 0), new Vector2f(600, 600), 50, true, 15);
                    Bezier4.BezAdd(bgspr4.Position, temp4, new Vector2f(0, Program.Window.Size.Y), new Vector2f(600, 600), 50, true, 15);
                    Bezier5.BezAdd(bgspr9.Position, temp5, new Vector2f(Program.Window.Size.X, Program.Window.Size.Y), new Vector2f(0, 0), 50, true, 15);
                    Bezier6.BezAdd(bgspr10.Position, temp6, new Vector2f(Program.Window.Size.X, 0), new Vector2f(0, Program.Window.Size.Y), 50, true, 15);
                    Bezier7.BezAdd(bgspr7.Position, temp7, new Vector2f(Program.Window.Size.X, 0), new Vector2f(0, Program.Window.Size.Y), 50, true, 15);
                    Bezier8.BezAdd(bgspr8.Position, temp8, new Vector2f(0, 0), new Vector2f(Program.Window.Size.X, Program.Window.Size.Y), 50, true, 15);
                    Bezier9.BezAdd(bgspr6.Position, temp9, new Vector2f(300, 300), new Vector2f(600, 300), 50, true, 15);
                    Bezier10.BezAdd(bgspr1.Position, temp10, new Vector2f(Program.Window.Size.X, Program.Window.Size.Y), new Vector2f(0, Program.Window.Size.Y), 50, true, 15);

                    speed = 0.04f;

                    bgspr1.Scale = new Vector2f(1, 1);
                    bgspr2.Scale = new Vector2f(1, 1);
                    bgspr3.Scale = new Vector2f(1, 1);
                    bgspr4.Scale = new Vector2f(1, 1);
                    bgspr5.Scale = new Vector2f(1, 1);
                    bgspr6.Scale = new Vector2f(1, 1);
                    bgspr7.Scale = new Vector2f(1, 1);
                    bgspr8.Scale = new Vector2f(1, 1);
                    bgspr9.Scale = new Vector2f(1, 1);
                    bgspr10.Scale = new Vector2f(1, 1);

                    bgspr1.Rotation = 0;
                    bgspr2.Rotation = 0;
                    bgspr3.Rotation = 0;
                    bgspr4.Rotation = 0;
                    bgspr5.Rotation = 0;
                    bgspr6.Rotation = 0;
                    bgspr7.Rotation = 0;
                    bgspr8.Rotation = 0;
                    bgspr9.Rotation = 0;
                    bgspr10.Rotation = 0;

                    Rot1 = new Vector2f(1, -2);

                    isValue = false;
                    Rot_bl = true;
                    NoDraw = false;
                }

                movement2 = Bezier1.GetMovement(bgspr2.Position, 13);
                movement3 = Bezier2.GetMovement(bgspr3.Position, 13);
                movement5 = Bezier3.GetMovement(bgspr5.Position, 13);
                movement4 = Bezier4.GetMovement(bgspr4.Position, 13);
                movement9 = Bezier5.GetMovement(bgspr9.Position, 13);
                movement10 = Bezier6.GetMovement(bgspr10.Position, 13);
                movement7 = Bezier7.GetMovement(bgspr7.Position, 13);
                movement8 = Bezier8.GetMovement(bgspr8.Position, 13);
                movement6 = Bezier9.GetMovement(bgspr6.Position, 13);
                movement1 = Bezier10.GetMovement(bgspr1.Position, 13);

                movement1 *= 0.8f;
                movement2 *= 0.8f;
                movement3 *= 0.8f;
                movement4 *= 0.8f;
                movement5 *= 0.8f;
                movement6 *= 0.8f;
                movement7 *= 0.8f;
                movement8 *= 0.8f;
                movement9 *= 0.8f;
                movement10 *= 0.8f;

                if (Bezier1.ret.Count != 0)
                {
                    if (Bezier1.distance <= Bezier1.dist && Bezier1.kill)
                    {
                        movement2 = new Vector2f();
                        bgspr2.Position = Pos2;
                    }
                    else if (Bezier1.distance <= Bezier1.dist)
                        Bezier1.ret.RemoveRange(0, Bezier1.ret.Count);
                    else if (Bezier1.distper <= Bezier1.dist)
                        Bezier1.i++;
                }
                if (Bezier2.ret.Count != 0)
                {
                    if (Bezier2.distance <= Bezier2.dist && Bezier2.kill)
                    {
                        movement3 = new Vector2f();
                        bgspr3.Position = Pos3;
                    }
                    else if (Bezier2.distance <= Bezier2.dist)
                        Bezier2.ret.RemoveRange(0, Bezier2.ret.Count);
                    else if (Bezier2.distper <= Bezier2.dist)
                        Bezier2.i++;
                }
                if (Bezier3.ret.Count != 0)
                {
                    if (Bezier3.distance <= Bezier3.dist && Bezier3.kill)
                    {
                        movement5 = new Vector2f();
                        bgspr5.Position = Pos5;
                    }
                    else if (Bezier3.distance <= Bezier3.dist)
                        Bezier3.ret.RemoveRange(0, Bezier3.ret.Count);
                    else if (Bezier3.distper <= Bezier3.dist)
                        Bezier3.i++;
                }
                if (Bezier4.ret.Count != 0)
                {
                    if (Bezier4.distance <= Bezier4.dist && Bezier4.kill)
                    {
                        movement4 = new Vector2f();
                        bgspr4.Position = Pos4;
                    }
                    else if (Bezier4.distance <= Bezier4.dist)
                        Bezier4.ret.RemoveRange(0, Bezier4.ret.Count);
                    else if (Bezier4.distper <= Bezier4.dist)
                        Bezier4.i++;
                }
                if (Bezier5.ret.Count != 0)
                {
                    if (Bezier5.distance <= Bezier5.dist && Bezier5.kill)
                    {
                        movement9 = new Vector2f();
                        bgspr9.Position = Pos9;
                    }
                    else if (Bezier5.distance <= Bezier5.dist)
                        Bezier5.ret.RemoveRange(0, Bezier5.ret.Count);
                    else if (Bezier5.distper <= Bezier5.dist)
                        Bezier5.i++;
                }
                if (Bezier6.ret.Count != 0)
                {
                    if (Bezier6.distance <= Bezier6.dist && Bezier6.kill)
                    {
                        movement10 = new Vector2f();
                        bgspr10.Position = Pos10;
                    }
                    else if (Bezier6.distance <= Bezier6.dist)
                        Bezier6.ret.RemoveRange(0, Bezier6.ret.Count);
                    else if (Bezier6.distper <= Bezier6.dist)
                        Bezier6.i++;
                }
                if (Bezier7.ret.Count != 0)
                {
                    if (Bezier7.distance <= Bezier7.dist && Bezier7.kill)
                    {
                        movement7 = new Vector2f();
                        bgspr7.Position = Pos7;
                    }
                    else if (Bezier7.distance <= Bezier7.dist)
                        Bezier7.ret.RemoveRange(0, Bezier7.ret.Count);
                    else if (Bezier7.distper <= Bezier7.dist)
                        Bezier7.i++;
                }
                if (Bezier8.ret.Count != 0)
                {
                    if (Bezier8.distance <= Bezier8.dist && Bezier8.kill)
                    {
                        movement8 = new Vector2f();
                        bgspr8.Position = Pos8;
                    }
                    else if (Bezier8.distance <= Bezier8.dist)
                        Bezier8.ret.RemoveRange(0, Bezier8.ret.Count);
                    else if (Bezier8.distper <= Bezier8.dist)
                        Bezier8.i++;
                }
                if (Bezier9.ret.Count != 0)
                {
                    if (Bezier9.distance <= Bezier9.dist && Bezier9.kill)
                    {
                        movement6 = new Vector2f();
                        bgspr6.Position = Pos6;
                    }
                    else if (Bezier9.distance <= Bezier9.dist)
                        Bezier9.ret.RemoveRange(0, Bezier9.ret.Count);
                    else if (Bezier9.distper <= Bezier9.dist)
                        Bezier9.i++;
                }
                if (Bezier10.ret.Count != 0)
                {
                    if (Bezier10.distance <= Bezier10.dist && Bezier10.kill)
                    {
                        movement1 = new Vector2f();
                        bgspr1.Position = Pos1;
                    }
                    else if (Bezier10.distance <= Bezier10.dist)
                        Bezier10.ret.RemoveRange(0, Bezier10.ret.Count);
                    else if (Bezier10.distper <= Bezier10.dist)
                        Bezier10.i++;
                }

                if (movement1 == new Vector2f()
                    && movement2 == new Vector2f()
                    && movement3 == new Vector2f()
                    && movement4 == new Vector2f()
                    && movement5 == new Vector2f()
                    && movement6 == new Vector2f()
                    && movement7 == new Vector2f()
                    && movement8 == new Vector2f()
                    && movement9 == new Vector2f()
                    && movement10 == new Vector2f()
                    && bgspr1.Position == Pos1
                    && bgspr2.Position == Pos2
                    && bgspr3.Position == Pos3
                    && bgspr4.Position == Pos4
                    && bgspr5.Position == Pos5
                    && bgspr6.Position == Pos6
                    && bgspr7.Position == Pos7
                    && bgspr8.Position == Pos8
                    && bgspr9.Position == Pos9
                    && bgspr10.Position == Pos10)
                {
                    if (bgspr1.Rotation == 360
                        && bgspr2.Rotation == -360
                        && bgspr3.Rotation == 360
                        && bgspr4.Rotation == -360
                        && bgspr5.Rotation == 360
                        && bgspr6.Rotation == -360
                        && bgspr7.Rotation == 360
                        && bgspr8.Rotation == -360
                        && bgspr9.Rotation == 360
                        && bgspr10.Rotation == -360)
                    {
                        isStartEnd = false;
                        Rot_bl = false;
                        isValue = true;
                        Level1.isStart = false;
                    }
                }
            }
            if (Rot)
            {
                if (Rot_sm)
                {
                    if (Rot1.Y <= 0)
                    {
                        speed *= 0.93f;
                    }
                    else
                    {
                        speed *= 1.07f;
                    }
                    Rot1.Y -= speed;
                    if (Rot1.Y <= -1)
                    {
                        Rot_sm = false;
                        speed = 0.005f;
                    }
                }
                else
                {
                    if (Rot1.Y >= 0)
                    {
                        speed *= 0.93f;
                    }
                    else
                    {
                        speed *= 1.07f;
                    }
                    Rot1.Y += speed;
                    if (Rot1.Y >= 1)
                    {
                        Rot_sm = true;
                        speed = 0.005f;
                    }
                }

                bgspr1.Scale = Rot1;
                bgspr2.Scale = Rot1;
                bgspr3.Scale = Rot1;
                bgspr4.Scale = Rot1;
                bgspr5.Scale = Rot1;
                bgspr6.Scale = Rot1;
                bgspr7.Scale = Rot1;
                bgspr8.Scale = Rot1;
                bgspr9.Scale = Rot1;
                bgspr10.Scale = Rot1;

                bgspr1.Rotation += 1;
                bgspr2.Rotation -= 2;
                bgspr3.Rotation += 1;
                bgspr4.Rotation -= 2;
                bgspr5.Rotation += 1;
                bgspr6.Rotation -= 2;
                bgspr7.Rotation += 1;
                bgspr8.Rotation -= 2;
                bgspr9.Rotation += 1;
                bgspr10.Rotation -= 2;
            }
            if (Rot_bl)
            {
                Rot1.Y += speed;
                speed *= 0.99f;

                if (Rot1.Y >= 1)
                    Rot1.Y = 1;

                bgspr1.Scale = Rot1;
                bgspr2.Scale = Rot1;
                bgspr3.Scale = Rot1;
                bgspr4.Scale = Rot1;
                bgspr5.Scale = Rot1;
                bgspr6.Scale = Rot1;
                bgspr7.Scale = Rot1;
                bgspr8.Scale = Rot1;
                bgspr9.Scale = Rot1;
                bgspr10.Scale = Rot1;

                SpD *= 0.99f;

                bgspr1.Rotation += SpD;
                bgspr2.Rotation -= SpD;
                bgspr3.Rotation += SpD;
                bgspr4.Rotation -= SpD;
                bgspr5.Rotation += SpD;
                bgspr6.Rotation -= SpD;
                bgspr7.Rotation += SpD;
                bgspr8.Rotation -= SpD;
                bgspr9.Rotation += SpD;
                bgspr10.Rotation -= SpD;

                if (bgspr1.Rotation >= 360)
                    bgspr1.Rotation = 360;
                if (bgspr2.Rotation <= -360)
                    bgspr2.Rotation = -360;
                if (bgspr3.Rotation >= 360)
                    bgspr3.Rotation = 360;
                if (bgspr4.Rotation <= -360)
                    bgspr4.Rotation = -360;
                if (bgspr5.Rotation >= 360)
                    bgspr5.Rotation = 360;
                if (bgspr6.Rotation <= -360)
                    bgspr6.Rotation = -360;
                if (bgspr7.Rotation >= 360)
                    bgspr7.Rotation = 360;
                if (bgspr8.Rotation <= -360)
                    bgspr8.Rotation = -360;
                if (bgspr9.Rotation >= 360)
                    bgspr9.Rotation = 360;
                if (bgspr10.Rotation <= -360)
                    bgspr10.Rotation = -360;
            }
            if (isStartPusk || isStartEnd)
            {
                bgspr1.Position += movement1;
                bgspr2.Position += movement2;
                bgspr3.Position += movement3;
                bgspr4.Position += movement4;
                bgspr5.Position += movement5;
                bgspr6.Position += movement6;
                bgspr7.Position += movement7;
                bgspr8.Position += movement8;
                bgspr9.Position += movement9;
                bgspr10.Position += movement10;
            }
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            if (!NoDraw)
            {
                states.Transform *= Transform;

                target.Draw(bgspr1, states);
                target.Draw(bgspr2, states);
                target.Draw(bgspr3, states);
                target.Draw(bgspr4, states);
                target.Draw(bgspr5, states);
                target.Draw(bgspr6, states);
                target.Draw(bgspr7, states);
                target.Draw(bgspr8, states);
                target.Draw(bgspr9, states);
                target.Draw(bgspr10, states);
            }
        }
    }
}
