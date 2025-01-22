using SFML.Graphics;
using SFML.System;

namespace Adderley
{
    class BulletZlo : Transformable, Drawable
    {
        public CircleShape bullet;
        public CircleShape HP_ST;

        public Vector2f movement;

        public bool isKill;

        public BulletZlo()
        {
            bullet = new CircleShape(10f);
            bullet.FillColor = Color.Yellow;
            bullet.OutlineThickness = 2;
            bullet.OutlineColor = Color.Black;
            bullet.Origin = new Vector2f(bullet.GetGlobalBounds().Width / 2, bullet.GetGlobalBounds().Height / 2);

            HP_ST = new CircleShape(9.5f);
            HP_ST.Origin = new Vector2f(HP_ST.GetGlobalBounds().Width / 2, HP_ST.GetGlobalBounds().Height / 2);

            isKill = false;
        }

        public void Update()
        {
            UpdateCollision();

            Position += movement;

            IfKill();
        }

        public void Pos(Vector2f pos)
        {
            Position = pos;
        }

        public void MoveAdd(Vector2f movement)
        {
            this.movement = movement;
        }

        public void IfKill()
        {
            if (Position.Y < 87 || Position.Y > 970 || Position.X > 1281 || Position.X < 2)
            {
                isKill = true;
            }
            if (isKill)
            {
                Game.BulletZlo.Remove(this);
            }
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            states.Transform *= Transform;

            target.Draw(bullet, states);
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
                if (isKill)
                    break;
            }
        }
    }
}
