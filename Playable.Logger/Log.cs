using Microsoft.Extensions.Logging;

namespace Playable.Logger;

public static partial class Log
{
    private static ILogger? _engineLogger;
    private static ILogger? _renderLogger;
    private static ILogger? _appLogger;

    public static ILogger Engine
    {
        get
        {
            if (_engineLogger is not null)
                return _engineLogger;
            else
                throw new Exception("Logger not initializated");
        }
    }

    public static ILogger Render
    {
        get
        {
            if (_renderLogger is not null)
                return _renderLogger;
            else
                throw new Exception("Logger not initializated");
        }
    }

    public static void EngineInitializate()
    {
        using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
        _engineLogger = factory.CreateLogger("Engine");
        _renderLogger = factory.CreateLogger("Renderer");
    }
}
