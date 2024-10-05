global using Playable.Logger;

namespace Playable;

public class Program
{
    public static void Main(string[] args)
    {
        var engine = new Engine();
        Log.EngineInitializate();

        engine.Start();
    }
}
