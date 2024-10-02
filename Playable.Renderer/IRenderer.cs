// loggers
global using Playable.Logger;
global using Microsoft.Extensions.Logging;

namespace Playable.Graphics;

public interface IRenderer
{
    void Initializate();
    void Start();
}
