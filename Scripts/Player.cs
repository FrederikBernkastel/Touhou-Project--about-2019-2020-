using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System.Collections.Generic;

namespace Adderley
{
    class Player : Transformable, Drawable
    {
        public SortedDictionary<string, dynamic> all;

        public Player()
        {
            all = new SortedDictionary<string, dynamic>();

            all["HP_ST"] = new CircleShape(5);
            all["Player_Rect"] = new RectangleShape(new Vector2f(21, 44));
            all["oryd"] = Graph.Rect(Content.Oryd);
            all["oryd1"] = Graph.Rect(Content.Oryd);
            all["StartPosition"] = new Vector2f(400, 800);
            all["movement"] = new Vector2f();
            all["player_idle"] = new Animations(Content.player, true);
            all["player_run"] = new Animations(Content.player, true);
            all["player_run_bef"] = new Animations(Content.player, true);
            all["timer"] = 0;
            all["player_move_speed"] = 0;
            all["trig_bullet"] = 0;
            all["isKill"] = false;
            all["IsMoveLeft"] = false;
            all["IsMoveRight"] = false;
            all["IsMoveUp"] = false;
            all["IsMoveDown"] = false;
            all["IsMoveSm"] = false;
            all["IsPressedZ"] = false;
            all["IsMove"] = false;
            all["animatedSprite"] = new AnimatedSprite(false);

            all["HP_ST"].FillColor = Color.Black;
            all["HP_ST"].FillColor = Color.Transparent;
            all["HP_ST"].Origin = new Vector2f(all["HP_ST"].GetGlobalBounds().Width / 2, all["HP_ST"].GetGlobalBounds().Height / 2);

            all["Player_Rect"].Origin = new Vector2f(all["Player_Rect"].GetGlobalBounds().Width / 2, all["Player_Rect"].GetGlobalBounds().Height / 2);

            all["oryd1"].Scale = new Vector2f(-1, 1);
            all["oryd"].Origin = new Vector2f(all["oryd"].GetGlobalBounds().Width / 2, all["oryd"].GetGlobalBounds().Height / 2);
            all["oryd1"].Origin = new Vector2f(all["oryd1"].GetGlobalBounds().Width / 2, all["oryd1"].GetGlobalBounds().Height / 2);
            
            all["player_idle"].AddFrame(Content.player_idle2, 0.6f);
            all["player_idle"].AddFrame(Content.player_idle3, 0.6f);
            all["player_idle"].AddFrame(Content.player_idle4, 0.6f);
            all["player_idle"].AddFrame(Content.player_idle3, 0.6f);
            all["player_idle"].AddFrame(Content.player_idle2, 0.6f);

            all["player_run"].AddFrame(Content.player_run2, 0.3f);
            all["player_run"].AddFrame(Content.player_run3, 0.3f);
            all["player_run"].AddFrame(Content.player_run4, 0.3f);
            all["player_run"].AddFrame(Content.player_run5, 0.3f);
            all["player_run"].AddFrame(Content.player_run6, 0.3f);

            all["player_run_bef"].AddFrame(Content.player_run7, 0.6f);
            all["player_run_bef"].AddFrame(Content.player_run6, 0.6f);
            all["player_run_bef"].AddFrame(Content.player_run5, 0.6f);
            all["player_run_bef"].AddFrame(Content.player_run6, 0.6f);

            Spawn();

            all["oryd"].Position = new Vector2f(-45, 0);
            all["oryd1"].Position = new Vector2f(45, 0);

            //asGG1.RadSpr = -40;
            //asGG2.RadSpr = -70;
            //asGG3.RadSpr = -110;
            //asGG4.RadSpr = -140;
            //asGG5.RadSpr = 40;
            //asGG6.RadSpr = 70;
            //asGG7.RadSpr = 110;
            //asGG8.RadSpr = 140;

            //asYY1.RadSpr = -55;
            //asYY2.RadSpr = -90;
            //asYY3.RadSpr = -125;
            //asYY4.RadSpr = 55;
            //asYY5.RadSpr = 90;
            //asYY6.RadSpr = 125;
        }

        public void Update()
        {
            all["timer"] += 0.5f;

            UpdateMovement();
            UpdateCollision();

            Position += all["movement"];

            IfKill();
            UpdateWallCollision();
        }

        public void Spawn()
        {
            Position = all["StartPosition"];
        }

        public void IfKill()
        {
            if (all["isKill"])
            {
                Game.Player.Spawn();
                Info.chet = 0;
            }
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            states.Transform *= Transform;

            target.Draw(all["animatedSprite"], states);
            target.Draw(all["HP_ST"], states);
            target.Draw(all["oryd"], states);
            target.Draw(all["oryd1"], states);
        }

        private void UpdateMovement()
        {
            all["IsMoveLeft"] = Keyboard.IsKeyPressed(Keyboard.Key.Left);
            all["IsMoveRight"] = Keyboard.IsKeyPressed(Keyboard.Key.Right);
            all["IsMoveUp"] = Keyboard.IsKeyPressed(Keyboard.Key.Up);
            all["IsMoveDown"] = Keyboard.IsKeyPressed(Keyboard.Key.Down);
            all["IsMoveSm"] = Keyboard.IsKeyPressed(Keyboard.Key.LShift);
            all["IsPressedZ"] = Keyboard.IsKeyPressed(Keyboard.Key.Z);

            all["IsMove"] = all["IsMoveLeft"] || all["IsMoveRight"] || all["IsMoveUp"] || all["IsMoveDown"];

            all["movement"] = new Vector2f();

            if (all["IsMove"])
            {
                if (all["IsMoveLeft"] && !all["IsMoveRight"])
                {
                    all["movement"].X = -all["player_move_speed"];
                }
                if (all["IsMoveRight"] && !all["IsMoveLeft"])
                {
                    all["movement"].X = all["player_move_speed"];
                }
                if (all["IsMoveUp"] && !all["IsMoveDown"])
                {
                    all["movement"].Y = -all["player_move_speed"];
                }
                if (all["IsMoveDown"] && !all["IsMoveUp"])
                {
                    all["movement"].Y = all["player_move_speed"];
                }
                if (!all["IsMoveLeft"] && !all["IsMoveRight"])
                    all["movement"].X = 0f;
                if (!all["IsMoveUp"] && !all["IsMoveDown"])
                    all["movement"].Y = 0f;
                if (all["IsMoveLeft"] || all["IsMoveRight"])
                {
                    if (all["currAnim"] != all["player_run"] && all["currAnim"] != all["player_run_bef"])
                    {
                        all["currAnim"] = all["player_run"];
                    }
                    else if (all["animatedSprite"].isPaused == true)
                    {
                        all["currAnim"] = all["player_run_bef"];
                    }
                }
                if (all["IsMoveLeft"] && !all["IsMoveRight"])
                {
                    all["animatedSprite"].Scale = new Vector2f(1, 1);
                }
                if (all["IsMoveRight"] && !all["IsMoveLeft"])
                {
                    all["animatedSprite"].Scale = new Vector2f(-1, 1);
                }
            }
            if (!all["IsMoveRight"] && !all["IsMoveLeft"])
            {
                all["currAnim"] = all["player_idle"];
            }
            if (all["IsMoveSm"])
            {
                all["player_move_speed"] = 3f;
                Graph.Show_dissolve(all["HP_ST"], 20, 255);
            }
            else
            {
                all["player_move_speed"] = 7f;
                Graph.Hide_dissolve(all["HP_ST"], 20, 0);
            }
            if (all["IsPressedZ"] && Level1.isStart)
            {
                all["trig_bullet"] = 3;
            }
            if (all["timer"] >= 3 && all["trig_bullet"] > 0)
            {
                var b = new Bullet(new Vector2f(Position.X + 15, Position.Y + 10));
                var b1 = new Bullet(new Vector2f(Position.X - 15, Position.Y + 10));
                Game.Bullets.Add(b);
                Game.Bullets.Add(b1);

                all["timer"] = 0;
                all["trig_bullet"]--;
            }

            all["animatedSprite"].Play(all["currAnim"]);
            all["animatedSprite"].Update();

            all["oryd"].Rotation += 2;
            all["oryd1"].Rotation -= 2;
            //asII.RadPlSpr = 0.5f;
            //asII.RadPlSpr = 0.5f;
        }

        public void UpdateWallCollision()
        {
            if (Position.Y + all["Player_Rect"].GetGlobalBounds().Height / 2 > Game.Game_Window.Position.Y + Game.Game_Window.GetGlobalBounds().Height)
                Position = new Vector2f(Position.X, Game.Game_Window.Position.Y + Game.Game_Window.GetGlobalBounds().Height - all["Player_Rect"].GetGlobalBounds().Height / 2 + 5);
            if (Position.Y - all["Player_Rect"].GetGlobalBounds().Height / 2 < Game.Game_Window.Position.Y)
                Position = new Vector2f(Position.X, Game.Game_Window.Position.Y + all["Player_Rect"].GetGlobalBounds().Height / 2 - 5);
            if (Position.X + all["Player_Rect"].GetGlobalBounds().Width / 2 > Game.Game_Window.Position.X + Game.Game_Window.GetGlobalBounds().Width)
                Position = new Vector2f(Game.Game_Window.Position.X + Game.Game_Window.GetGlobalBounds().Width - all["Player_Rect"].GetGlobalBounds().Width + 5, Position.Y);
            if (Position.X - all["Player_Rect"].GetGlobalBounds().Width / 2 < Game.Game_Window.Position.X)
                Position = new Vector2f(Game.Game_Window.Position.X + all["Player_Rect"].GetGlobalBounds().Width - 5, Position.Y);
        }

        public void UpdateCollision()
        {
            var offset = all["movement"];
            float dist = MathHelper.GetDistance(offset);

            int countStep = 1;
            float stepSize = all["HP_ST"].Radius;
            if (dist > stepSize)
                countStep = (int)(dist / stepSize);
            Vector2f nextPos = Position + offset;
            Vector2f stepPos = Position - all["HP_ST"].Origin;
            CircleShape stepCir = new CircleShape(all["HP_ST"].Radius);
            stepCir.Position = stepPos;
            Vector2f stepVec = (nextPos - Position) / countStep;

            for (int step = 0; step < countStep; step++)
            {
                stepPos += stepVec;
                stepCir.Position = stepPos;

                foreach (var nm in Game.BulletZlo)
                {
                    if (Graph.CirCollide(stepCir.Position, nm.Position, stepCir.Radius, nm.HP_ST.Radius))
                    {
                        nm.isKill = true;
                        all["isKill"] = true;
                    }
                }
                foreach (var nm in Game.Zlo)
                {
                    if (Graph.CirCollide(stepCir.Position, nm.Position, stepCir.Radius, nm.HP_ST.Radius))
                    {
                        nm.isKill = true;
                        all["isKill"] = true;
                    }
                }
                if (all["isKill"])
                    break;
            }
        }
    }
}
