namespace Adderley;

sealed class Content
{
    private Dictionary<string, Font> ListFonts { get; } = new();
    private Dictionary<string, Texture> ListTextures { get; } = new();
    public static Content Resources { get; } = new(@"D:\code\resources\Content");
    
    private Content(string path)
    {
        foreach (var s in Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories))
        {
            var name = s.Split(@"\")[^1];
            var format = name.Split('.')[^1];
            switch (format)
            {
                case "otf":
                    ListFonts[name] = new(s);
                    break;
                case "ttf":
                    goto case "otf";
                case "jpg":
                    ListTextures[name] = new(s);
                    break;
                case "png":
                    goto case "png";
            }
        }
    }

    public Font GetFont(string name)
    {
        return ListFonts[name];
    }
    public Texture GetTexture(string name)
    {
        return ListTextures[name];
    }
    
    public static IntRect player_idle1;
    public static IntRect player_idle2;
    public static IntRect player_idle3;
    public static IntRect player_idle4;
    public static IntRect player_run1;
    public static IntRect player_run2;
    public static IntRect player_run3;
    public static IntRect player_run4;
    public static IntRect player_run5;
    public static IntRect player_run6;
    public static IntRect player_run7;

    public static IntRect boss1_idle1;
    public static IntRect boss1_idle2;
    public static IntRect boss1_idle3;
    public static IntRect boss1_idle4;
    public static IntRect boss1_idle5;
    public static IntRect boss1_run1;
    public static IntRect boss1_run2;
    public static IntRect boss1_run3;
    public static IntRect boss1_run4;
    public static IntRect boss1_run5;
    public static IntRect boss1_run6;

    
    public static void Load()
    {
        player_idle1 = Graph.GetIntRect(new IntRect(0, 80, 53, 80), false, true, false, true, player);
        player_idle2 = Graph.GetIntRect(new IntRect(53, 80, 54, 80), false, true, false, true, player);
        player_idle3 = Graph.GetIntRect(new IntRect(107, 80, 53, 80), false, true, false, true, player);
        player_idle4 = Graph.GetIntRect(new IntRect(160, 80, 60, 80), false, true, false, true, player);

        player_run1 = Graph.GetIntRect(new IntRect(0, 0, 54, 80), false, true, false, true, player);
        player_run2 = Graph.GetIntRect(new IntRect(54, 0, 54, 80), false, true, false, true, player);
        player_run3 = Graph.GetIntRect(new IntRect(108, 0, 54, 80), false, true, false, true, player);
        player_run4 = Graph.GetIntRect(new IntRect(162, 0, 55, 80), false, true, false, true, player);
        player_run5 = Graph.GetIntRect(new IntRect(217, 0, 55, 80), false, true, false, true, player);
        player_run6 = Graph.GetIntRect(new IntRect(272, 0, 55, 80), false, true, false, true, player);
        player_run7 = Graph.GetIntRect(new IntRect(327, 0, 51, 80), false, true, false, true, player);

        boss1_idle1 = Graph.GetIntRect(new IntRect(0, 0, 58, 85), false, true, false, true, player);
        boss1_idle2 = Graph.GetIntRect(new IntRect(58, 0, 56, 85), false, true, false, true, player);
        boss1_idle3 = Graph.GetIntRect(new IntRect(114, 0, 58, 85), false, true, false, true, player);
        boss1_idle4 = Graph.GetIntRect(new IntRect(172, 0, 58, 85), false, true, false, true, player);
        boss1_idle5 = Graph.GetIntRect(new IntRect(230, 0, 56, 85), false, true, false, true, player);

        boss1_run1 = Graph.GetIntRect(new IntRect(286, 0, 60, 85), false, true, false, true, player);
        boss1_run2 = Graph.GetIntRect(new IntRect(345, 0, 61, 85), false, true, false, true, player);
        boss1_run3 = Graph.GetIntRect(new IntRect(406, 0, 53, 85), false, true, false, true, player);
        boss1_run4 = Graph.GetIntRect(new IntRect(0, 85, 59, 85), false, true, false, true, player);
        boss1_run5 = Graph.GetIntRect(new IntRect(58, 85, 58, 85), false, true, false, true, player);
        boss1_run6 = Graph.GetIntRect(new IntRect(116, 85, 58, 85), false, true, false, true, player);
    }
}
