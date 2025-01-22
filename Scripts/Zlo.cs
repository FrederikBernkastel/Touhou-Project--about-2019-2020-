using SFML.Graphics;
using SFML.System;
using System;

namespace Adderley
{
    class Zlo : Transformable, Drawable
    {
        public CircleShape rect;
        public CircleShape HP_ST;

        public Vector2f movement;

        public Random rand;
        public Bezier Bezier;

        public int nomer;
        public float cou;

        public bool isKill;

        public Zlo(int nomer)
        {
            rect = new CircleShape(15);
            rect.FillColor = Color.Red;
            rect.Origin = new Vector2f(rect.GetGlobalBounds().Width / 2, rect.GetGlobalBounds().Height / 2);
            rect.OutlineThickness = 2;
            rect.OutlineColor = Color.White;

            HP_ST = new CircleShape(10);
            HP_ST.Origin = new Vector2f(HP_ST.GetGlobalBounds().Width / 2, HP_ST.GetGlobalBounds().Height / 2);

            this.nomer = nomer;

            isKill = false;

            rand = new Random();
            Bezier = new Bezier();
        }

        public void Update()
        {
            movement = Bezier.GetMovement(Position, 40);
            if (Bezier.ret.Count != 0)
            {
                if (Bezier.distance <= Bezier.dist && Bezier.kill)
                    isKill = true;
                else if (Bezier.distance <= Bezier.dist)
                    Bezier.ret.RemoveRange(0, Bezier.ret.Count);
                else if (Bezier.distper <= Bezier.dist)
                    Bezier.i++;
            }
            UpdateCollision();

            UpdateBull();
            UpdateMove();

            Position += movement;

            IfKill();
        }

        public void UpdateMove()
        {
            if (nomer == 1)
            {
                cou = MathHelper.GetAngle(Position, Game.Player.Position);
            }
        }

        public void UpdateBull()
        {
            if (nomer == 1)
            {
                float rnd = (float)rand.NextDouble();
                if (rnd > 0.95)
                {
                    rnd = (float)rand.NextDouble();
                    if (rnd > 0.95)
                    {
                        var b = new BulletZlo();
                        b.MoveAdd(new Vector2f(3 * (float)Math.Cos(cou), 3 * (float)Math.Sin(cou)));
                        b.Pos(new Vector2f(Position.X, Position.Y));
                        Game.BulletZlo.Add(b);
                    }
                }
            }
        }

        public void PosTemp()
        {
            if (nomer == 1)
            {
                Bezier.BezAdd(Position, new Vector2f(850, 940), new Vector2f(100, 40), new Vector2f(420, 40), 4, true, 5);
            }
            else if (nomer == 2)
            {
                Bezier.BezAdd(Position, new Vector2f(420, 10), new Vector2f(420, 200), new Vector2f(100, 200), 4, true, 5);
            }
        }

        public void IfKill()
        {
            if (MathHelper.CirCollide(Position, Game.Player.Position, HP_ST.Radius, Game.Player.all["HP_ST"].Radius))
            {
                isKill = true;
                Game.Player.all["isKill"] = true;
            }
            if (isKill)
            {
                Game.Zlo.Remove(this);
                //var it = new Item();
                //it.Pos(new Vector2f(Position.X, Position.Y - 15));
                //Game.Item.Add(it);
            }
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            states.Transform *= Transform;

            target.Draw(rect, states);
        }

        public void UpdateCollision()
        {
            var offset = movement;
            float dist = MathHelper.GetDistance(offset);

            int countStep = 1;
            float stepSize = HP_ST.Radius;
            if (dist > stepSize)
                countStep = (int)(dist / stepSize);
            Vector2f nextPos = Position + offset;
            Vector2f stepPos = Position - HP_ST.Origin;
            CircleShape stepCir = new CircleShape(HP_ST.Radius);
            stepCir.Position = stepPos;
            Vector2f stepVec = (nextPos - Position) / countStep;

            for (int step = 0; step < countStep; step++)
            {
                stepPos += stepVec;
                stepCir.Position = stepPos;

                if (MathHelper.CirCollide(stepCir.Position, Game.Player.Position, stepCir.Radius, Game.Player.all["HP_ST"].Radius))
                {
                    Game.Player.all["isKill"] = true;
                    isKill = true;
                }
                foreach (var nm in Game.Bullets)
                {
                    if (MathHelper.CirCollide(stepCir.Position, nm.all["position"], stepCir.Radius, nm.all["HP_ST"].Radius))
                    {
                        nm.all["isKill"] = true;
                        isKill = true;
                    }
                }
                if (isKill)
                    break;
            }
        }
    }
}
