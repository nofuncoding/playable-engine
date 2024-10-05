
namespace Playable;

internal class Layer
{
    protected string DebugName = "";

    public virtual void OnAttach() { }
    public virtual void OnDetach() { }
    public virtual void OnUpdate(double delta) { }
    public virtual void OnRender() { }
}
