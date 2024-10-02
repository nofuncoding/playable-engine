using Silk.NET.OpenGL;
using Silk.NET.Windowing;

namespace Playable.Graphics.OpenGL;

internal class RendererGL : IRenderer
{
    private IWindow _window;

    public void Initializate()
    {
        _window = Window.Create(WindowOptions.Default);

        // The loading function on window just only used from renderer.
        // Other component should be managed in ECS system.
        _window.Load += CreateContext;

        _window.Update += (double delta) => { };

        // Same to `Load`, only used in renderer.
        _window.Closing += FreeContext;
    }

    public void Start()
    {
        _window?.Run();
    }

    private void CreateContext()
    {
        Log.Render.LogInformation("Creating render context");
    }

    private void FreeContext()
    {
        Log.Render.LogInformation("Freeing render context");
    }
}
