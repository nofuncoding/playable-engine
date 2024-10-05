namespace Playable.Graphics;

public interface IRenderer
{
    void Initializate(Action<double> onUpdate);
    void Start();
}
