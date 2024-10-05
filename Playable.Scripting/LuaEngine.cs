using NLua;

namespace Playable.Scripting;

public class LuaEngine
{
    Lua lua = new();

    public void Initializate()
    {
        Log.Engine.LogInformation("Initializating Lua Engine");

        // setup the lua backend to use UTF8
        lua.State.Encoding = System.Text.Encoding.UTF8;
    }
}
