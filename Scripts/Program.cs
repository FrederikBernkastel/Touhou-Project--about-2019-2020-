Application.EntryApplication.Run();

abstract class DispatchObject
{
    public bool IsFlag { get; set; } = true;
    public abstract void DispatchEvents();
}
abstract class UpdateObject
{
    public bool IsFlag { get; set; } = true;
    public abstract void Update();
}
abstract class RenderObject
{
    public bool IsFlag { get; set; } = true;
    public abstract void Render(RenderStates states);
}
record class StyleTextureRender(Texture Texture, IntRect Zone, Vector2f Size, Color Color);
sealed class TextureRender : RenderObject
{
    private RectangleShape Rectangle { get; }
    private Transformable Transformable { get; }

    public TextureRender(Transformable transformable, StyleTextureRender style)
    {
        Transformable = transformable;
        Rectangle = new()
        {
            Texture = style.Texture,
            TextureRect = style.Zone,
            Size = style.Size,
            FillColor = style.Color,
        };
    }

    public override void Render(RenderStates states)
    {
        states.Transform *= Transformable.Transform;
        Application.EntryApplication.EntryRender.Draw(Rectangle, states);
    }
}
sealed class DispatchChangeContext : DispatchObject
{
    private Keyboard.Key Key { get; }
    public DispatchChangeContext(Keyboard.Key key) => Key = key;
    public override void DispatchEvents()
    {
        if (Keyboard.IsKeyPressed(Keyboard.Key.Z))
            Context.EntryContext = new MenuContext();
    }
}
abstract class Context
{
    public static Context EntryContext { get; set; } = new ZastavkaContext();
    protected DispatchObject[] ListDispatchObject { get; set; } = Array.Empty<DispatchObject>();
    protected UpdateObject[] ListUpdateObject { get; set; } = Array.Empty<UpdateObject>();
    protected RenderObject[] ListRenderObject { get; set; } = Array.Empty<RenderObject>();

    public void DispatchEvents()
    {
        foreach (var s in ListDispatchObject)
            if (s.IsFlag)
                s.DispatchEvents();
    }
    public void Update()
    {
        foreach (var s in ListUpdateObject)
            if (s.IsFlag)
                s.Update();
    }
    public void Render()
    {
        foreach (var s in ListRenderObject)
            if (s.IsFlag)
                s.Render();
    }
}

sealed class ZastavkaContext : Context
{
    public ZastavkaContext()
    {
        ListDispatchObject = new DispatchObject[]
        {
            new DispatchChangeContext(Keyboard.Key.Z),
        };
        ListUpdateObject = Array.Empty<UpdateObject>();
        ListRenderObject = new RenderObject[]
        {

        };
    }
}
sealed class MenuContext : Context
{
    public override void DispatchEvents()
    {
        throw new NotImplementedException();
    }

    public override void Render()
    {
        throw new NotImplementedException();
    }

    public override void Update()
    {
        throw new NotImplementedException();
    }
}
sealed class Application
{
    private RenderWindow Window { get; }
    public Window EntryWindow => Window;
    public RenderTarget EntryRender => Window;
    public static Application EntryApplication { get; } = new();

    private Application()
    {
        Window = new RenderWindow(
            new(1280, 960), "心理学 - 奇跡 ~ Landscape of Forgotten Accidention", Styles.Titlebar | Styles.Close);
        Window.SetVerticalSyncEnabled(true);
        Window.Closed += (_, _) => Window.Close();
    }

    public void Run()
    {
        while (Window.IsOpen)
        {
            Window.DispatchEvents();
            Context.EntryContext.DispatchEvents();
            Context.EntryContext.Update();
            Window.Clear();
            Context.EntryContext.Render();
            Window.Display();
        }
    }
}