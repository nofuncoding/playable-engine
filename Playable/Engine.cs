using Playable.Graphics;
using Flecs.NET.Core;
using Flecs.NET.Bindings;

namespace Playable;

internal class Engine
{
    World ecs;

    public void Start()
    {
        ecs = World.Create();

        // Create a REST server on default port (27750) for debugging,
        // allow the Flecs explorer to access an application,
        // open https://www.flecs.dev/explorer/ while running
        ecs.Import<Ecs.Stats>();
        ecs.Set<flecs.EcsRest>(default);
        Log.Engine.LogInformation("Successfully created Flecs REST server! Check https://www.flecs.dev/explorer/ for debug");

        var e = ecs.Entity().Add<Component.GameObject>();

        var renderer = new RendererFactory().CreateRenderer();
        renderer.Initializate(Update);
        renderer.Start();
    }

    public void Update(double delta)
    {
        ecs.Progress((float)delta);
    }
}
