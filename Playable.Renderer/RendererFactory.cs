using Playable.Graphics.OpenGL;

namespace Playable.Graphics;

public class RendererFactory
{
    private RendererType rendererType = RendererType.OpenGL;

    public enum RendererType
    {
        OpenGL,

        // Not Implemented
        Vulkan,
        DirectX,
    }

    public void SetType(RendererType type) => rendererType = type;
    

    public IRenderer CreateRenderer()
    {
        switch (rendererType)
        {
            case RendererType.OpenGL:
                Log.Render.LogInformation("Creating OpenGL renderer");
                return new RendererGL();
            case RendererType.Vulkan:
            case RendererType.DirectX:
                throw new NotImplementedException("Only OpenGL is available for now");
            default:
                throw new Exception("Not a known type of renderer");
        }
    }
}
