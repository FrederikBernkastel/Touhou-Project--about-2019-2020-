namespace Adderley
{
    class Volns
    {
        public static float timer = 0;

        public void Update()
        {
            timer += 0.05f;

            if (timer >= 1f)
            {
                //var z = new Zlo(1);
                //zlo.Add(z);

                //var z1 = new Zlo(2);
                //zlo.Add(z1);

                timer = 0f;
            }
        }
    }
}
