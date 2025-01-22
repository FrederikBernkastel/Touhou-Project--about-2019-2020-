using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;

namespace Adderley
{
    class Bullet : Drawable
    {
        public SortedDictionary<string, dynamic> all;

        //public CircleShape HP_ST;
        //public Sprite OsnDam1;
        //public Sprite OsnDam2;

        //public float speed_bullet;
        //public float speed_rad;

        //public Vector2f movement;
        //public Vector2f position;
        //public float rotation;

        //public bool isKill;

        public Bullet(Vector2f pos)
        {
            all = new SortedDictionary<string, dynamic>();

            all["speed_bullet"] = 5f;
            all["speed_rad"] = 0.3f;
            all["HP_ST"] = new CircleShape(10);
            all["OsnDam1"] = new Sprite(Content.OsnDam);
            all["position"] = new Vector2f();
            all["movement"] = new Vector2f();
            all["rotation"] = all["OsnDam1"].Rotation;
            all["OsnDam2"] = new Sprite(Content.OsnDam);
            all["isKill"] = false;

            //speed_bullet = 5f;
            //speed_rad = 0.3f;

            //HP_ST = new CircleShape(10);
            all["HP_ST"].Origin = new Vector2f(all["HP_ST"].GetGlobalBounds().Width / 2, all["HP_ST"].GetGlobalBounds().Height / 2);

            //OsnDam1 = new Sprite(Content.OsnDam);
            all["OsnDam1"].Color = new Color(66, 170, 255, 160);
            all["OsnDam1"].Origin = new Vector2f(all["OsnDam1"].GetGlobalBounds().Width / 2, all["OsnDam1"].GetGlobalBounds().Height / 2);
            all["OsnDam1"].Rotation = -30;

            //position = new Vector2f();
            //rotation = OsnDam1.Rotation;

            //OsnDam2 = new Sprite(Content.OsnDam);
            all["OsnDam2"].Color = new Color(66, 170, 255, 45);
            all["OsnDam2"].Origin = new Vector2f(all["OsnDam2"].GetGlobalBounds().Width / 2, all["OsnDam2"].GetGlobalBounds().Height / 2);

            all["OsnDam1"].Position = pos;

            //isKill = false;

            //movement = new Vector2f();
        }

        public void Update()
        {
            all["OsnDam2"].Position = all["position"];
            all["OsnDam2"].Rotation = all["rotation"];

            all["OsnDam1"].Rotation -= all["speed_rad"];
            all["speed_bullet"] *= 1.3f;
            all["speed_rad"] *= 1.3f;
            if (all["speed_bullet"] >= 30)
                all["speed_bullet"] = 30;
            if (all["speed_rad"] >= 3)
                all["speed_rad"] = 3;

            all["movement"].Y = -all["speed_bullet"];

            UpdateCollision();

            all["OsnDam1"].Position += all["movement"];

            all["position"] = all["OsnDam1"].Position - all["movement"] * 0.05f;
            all["rotation"] = all["OsnDam1"].Rotation;

            IfKill();
        }

        public void IfKill()
        {
            if (all["OsnDam1"].Position.Y < 0)
            {
                all["isKill"] = true;
            }
            if (all["isKill"])
                Game.Bullets.Remove(this);
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            target.Draw(all["OsnDam2"], states);
            target.Draw(all["OsnDam1"], states);
        }

        public void UpdateCollision()
        {
            var offset = all["movement"];
            float dist = MathHelper.GetDistance(offset);

            int countStep = 1;
            float stepSize = all["HP_ST"].Radius;
            if (dist > stepSize)
                countStep = (int)(dist / stepSize);
            Vector2f nextPos = all["OsnDam1"].Position + offset;
            Vector2f stepPos = all["OsnDam1"].Position - all["HP_ST"].Origin;
            CircleShape stepCir = new CircleShape(all["HP_ST"].Radius);
            stepCir.Position = stepPos;
            Vector2f stepVec = (nextPos - all["OsnDam1"].Position) / countStep;

            for (int step = 0; step < countStep; step++)
            {
                stepPos += stepVec;
                stepCir.Position = stepPos;

                foreach (var nm in Game.Zlo)
                {
                    if (MathHelper.CirCollide(stepCir.Position, nm.Position, stepCir.Radius, nm.HP_ST.Radius))
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
