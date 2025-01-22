using SFML.Graphics;
using SFML.System;

namespace Adderley
{
    class Item : Transformable, Drawable
    {
        public const float MOVE_DISTANCE_TO_PLAYER = 100f;          // дистанция начала движения предмета в сторону игрока
        public const float TAKE_DISTANCE_TO_PLAYER = 15f;           // дистанция подбора предмета игроком
        public const float MOVE_SPEED_COEF = 3f;                    // коэффициент увеличения скорости движения

        public CircleShape rect;
        public CircleShape HP_ST;

        public bool isKill;
        
        public float dist;

        public Vector2f movement;

        public Item()
        {
            rect = new CircleShape(10, 3);
            rect.FillColor = Color.White;
            rect.OutlineThickness = 2;
            rect.OutlineColor = Color.Black;

            HP_ST = new CircleShape(9.5f);
            HP_ST.Origin = new Vector2f(HP_ST.GetGlobalBounds().Width / 2, HP_ST.GetGlobalBounds().Height / 2);

            movement = new Vector2f(0, 1 * 3);

            isKill = false;
            dist = 0;
        }

        public void Pos(Vector2f pos)
        {
            Position = pos;
        }

        public void Update()
        {
            dist = MathHelper.GetDistance(Position, Game.Player.Position);

            if (dist < MOVE_DISTANCE_TO_PLAYER)
            {
                Vector2f dir = MathHelper.Normalize(Game.Player.Position - Position);
                UpdateCollision();
                float speed = 4f - dist / MOVE_DISTANCE_TO_PLAYER;
                Position += dir * speed * MOVE_SPEED_COEF;
            }
            else
            {
                UpdateCollision();
                Position += movement;
            }

            IfKill();
        }

        public void IfKill()
        {
            if (Position.Y > 970)
            {
                isKill = true;
            }
            if (isKill)
            {
                Game.Item.Remove(this);
                Info.chet++;
                if (Info.chet > Info.record)
                    Info.record++;
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
                if (isKill)
                    break;
            }
        }
    }
}
