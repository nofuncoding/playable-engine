using Playable.Graphics;

namespace Playable;

internal class Engine
{
    public void Start()
    {
        var renderer = new RendererFactory().CreateRenderer();
        renderer.Initializate();
        renderer.Start();
    }
}
