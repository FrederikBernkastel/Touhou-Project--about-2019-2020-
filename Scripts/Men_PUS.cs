using SFML.Graphics;

namespace Adderley
{
    class Men_PUS : Menu
    {
        public static Menu_isZast Menu_isZast;
        public static Menu_isMain Menu_isMain;
        public static Menu_isStart Menu_isStart;
        public static Menu_isOption Menu_isOption;
        public static Menu_isExit Menu_isExit;

        public Men_PUS()
        {
            Menu_isZast = new Menu_isZast();
            Menu_isMain = new Menu_isMain();
            Menu_isStart = new Menu_isStart();
            Menu_isOption = new Menu_isOption();
            Menu_isExit = new Menu_isExit();
        }

        public override void Update()
        {
            Menu_isZast.Update();
            Menu_isMain.Update();
            Menu_isStart.Update();
            Menu_isOption.Update();
            Menu_isExit.Update();
        }

        public override void Draw(RenderTarget target, RenderStates states)
        {
            target.Draw(fon, states);
            target.Draw(Menu_isZast, states);
            target.Draw(Menu_isMain, states);
            target.Draw(Menu_isStart, states);
            target.Draw(Menu_isOption, states);
            target.Draw(Menu_isExit, states);
        }
    }
}
