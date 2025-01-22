using SFML.Window;
using SFML.Graphics;
using SFML.System;
using System.Collections.Generic;

namespace Adderley
{
    class Game
    {
        public static Player Player;
        public static ScriptMove ScriptMove;
        public static Info Info;
        public static Level1 Level1;
        public static Dialogs Dialogs;
        public static Volns Volns;

        public static RectangleShape Game_Window;

        public static List<Bullet> Bullets;
        public static List<Zlo> Zlo;
        public static List<BulletZlo> BulletZlo;
        public static List<Item> Item;
        public static List<SnowFactory> Snow;

        public int i1;

        public Game()
        {
            Player = new Player();
            ScriptMove = new ScriptMove();
            Info = new Info();
            Level1 = new Level1();
            Dialogs = new Dialogs();
            Volns = new Volns();

            Bullets = new List<Bullet>();
            Zlo = new List<Zlo>();
            BulletZlo = new List<BulletZlo>();
            Item = new List<Item>();
            Snow = new List<SnowFactory>();

            Game_Window = new RectangleShape(new Vector2f(1219, 823));
            Game_Window.Position = new Vector2f(32, 117);
        }

        public void Update()
        {
            ScriptMove.Update();
            Player.Update();
            Info.Update();
            Level1.Update();
            Dialogs.Update();
            Volns.Update();

            i1 = 0;
            while (i1 < Bullets.Count)
            {
                Bullets[i1].Update();
                i1++;
            }

            i1 = 0;
            while (i1 < Snow.Count)
            {
                Snow[i1].Update();
                i1++;
            }

            i1 = 0;
            while (i1 < Zlo.Count)
            {
                Zlo[i1].Update();
                i1++;
            }

            i1 = 0;
            while (i1 < BulletZlo.Count)
            {
                BulletZlo[i1].Update();
                i1++;
            }

            i1 = 0;
            while (i1 < Item.Count)
            {
                Item[i1].Update();
                i1++;
            }

            if (Keyboard.IsKeyPressed(Keyboard.Key.Escape))
            {
                Menu.isMenu = true;
                Menu.isMain = true;
                Menu.isMain_do = true;
                Player.Spawn();
                Bullets.Clear();
                Zlo.Clear();
                BulletZlo.Clear();
                Item.Clear();
                Info.chet = 0;
                Info.Greyz = 0;
                Info.Pfull = 0;
                Info.ochk = 0;
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.N))
            {
                ScriptMove.isStartEnd = true;
            }
        }

        public void Draw()
        {
            Level1.Draw_fonlev();
            i1 = 0;
            while (i1 < Zlo.Count)
            {
                Program.Window.Draw(Zlo[i1]);
                i1++;
            }
            i1 = 0;
            while (i1 < Bullets.Count)
            {
                Program.Window.Draw(Bullets[i1]);
                i1++;
            }
            Program.Window.Draw(Player);
            i1 = 0;
            while (i1 < BulletZlo.Count)
            {
                Program.Window.Draw(BulletZlo[i1]);
                i1++;
            }
            i1 = 0;
            while (i1 < Item.Count)
            {
                Program.Window.Draw(Item[i1]);
                i1++;
            }
            Level1.Draw_fonF();
            Program.Window.Draw(Info);
            Program.Window.Draw(ScriptMove);
            i1 = 0;
            while (i1 < Snow.Count)
            {
                Program.Window.Draw(Snow[i1]);
                i1++;
            }
            Program.Window.Draw(Dialogs);
        }
    }
}
