using SFML.Graphics;

namespace Adderley
{
    class Menu_isExit : Menu
    {
        public override void Update()
        {
            if (isExit)
            {
                Program.Window.Close();
            }
        }

        public override void Draw(RenderTarget target, RenderStates states)
        {

        }
    }
}
