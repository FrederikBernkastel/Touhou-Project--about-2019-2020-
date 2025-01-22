using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adderley
{
    class SnowFactory : Transformable, Drawable
    {
        public Sprite image;
        public int speed;
        public int wind;
        public float xborder;
        public float yborder;
        public Random random;

        public SnowFactory(Texture image, int speed, int wind, Vector2f xborder, Vector2f yborder)
        {
            random = new Random();

            this.speed = speed;
            this.wind = random.Next(-wind, wind);
            this.xborder = random.Next((int)xborder.X, (int)xborder.Y);
            this.yborder = random.Next((int)yborder.X, (int)yborder.Y);
            this.image = new Sprite(image);

            Position = new Vector2f(random.Next(0 - (int)this.xborder, (int)Program.Window.Size.X + (int)this.xborder), -this.yborder);
        }

        public void Update()
        {
            Position += new Vector2f(TimeMod.DeltaTime * wind, TimeMod.DeltaTime * speed);

            if (Position.Y > Program.Window.Size.Y || (wind < 0 && Position.X < 0) || (wind > 0 && Position.X > Program.Window.Size.X))
            {
                Game.Snow.Remove(this);
            }
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            states.Transform *= Transform;

            target.Draw(image, states);
        }
    }
}
