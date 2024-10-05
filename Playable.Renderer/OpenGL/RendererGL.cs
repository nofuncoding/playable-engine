using Silk.NET.OpenGL;
using Silk.NET.Windowing;
using System.Drawing;

namespace Playable.Graphics.OpenGL;

internal class RendererGL : IRenderer
{
    private IWindow _window;
    private GL _gl;

    public void Initializate(Action<double> onUpdate)
    {
        _window = Window.Create(WindowOptions.Default);

        // TODO: Refactor these logic into ECS System
        //   aka make render as a system.

        // The loading function on window just only used from renderer.
        // Other component should be managed in ECS system.
        _window.Load += CreateContext;

        // Do in engine
        _window.Update += onUpdate;

        _window.Render += (delta) => {
            _gl.ClearColor(Color.CornflowerBlue);
            _gl.Clear(ClearBufferMask.ColorBufferBit);
        };

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
        _gl = _window.CreateOpenGL();
    }

    private void FreeContext()
    {
        Log.Render.LogInformation("Freeing render context");
    }
}
