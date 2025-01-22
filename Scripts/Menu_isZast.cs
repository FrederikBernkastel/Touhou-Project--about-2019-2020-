using SFML.Graphics;
using SFML.Window;

namespace Adderley
{
    class Menu_isZast : Menu
    {
        public override void Update()
        {
            if (isZast)
            {
                if (Keyboard.IsKeyPressed(Keyboard.Key.Z))
                {
                    isZast = false;
                    isMain = true;
                    isMain_do = true;
                }
            }
        }

        public override void Draw(RenderTarget target, RenderStates states)
        {
            states.
        }
    }
}
