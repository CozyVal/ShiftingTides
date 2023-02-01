using System.Collections.Generic;
using SadConsole;
using SadRogue.Primitives;
using Console = SadConsole.Console;
using SadConsole.Input;
using System;
using SadConsole.Components;
using SFML.Window;
using static SFML.Graphics.Font;
using SadConsole.Instructions;
using Arch;
using Arch.System;
using Arch.Core;

namespace Shattered_Tides
{

    // Ai Systems



    // Movement Systems
    public class MovementSystem : BaseSystem<World, float>
    {
        private QueryDescription KeyboardInput = new QueryDescription().WithAll<Literal_Position_Component, Can_Move_Component, Player_Component>();
        public MovementSystem(World world) : base(world) { }

        public override void Update(in float deltatime)
        {
            World.Query(in KeyboardInput, (ref Literal_Position_Component Position) =>
            {
                SadConsole.GameHost e = SadConsole.GameHost.Instance;
                if (e.Keyboard.IsKeyPressed(Keys.W)) //Up
                {
                    if (Position.Y > 0)
                    {
                        Position.Y--;
                    }
                    else
                    {

                    }
                }
                if (e.Keyboard.IsKeyPressed(Keys.A)) //Left
                {
                    if (Position.X > 0)
                    {
                        Position.X--;
                    }
                    else
                    {

                    }
                }
                if (e.Keyboard.IsKeyPressed(Keys.S)) //Down
                {
                    if (Position.Y < (Program.Height - 1))
                    {
                        Position.Y++;
                    }
                    else
                    {

                    }
                }
                if (e.Keyboard.IsKeyPressed(Keys.D)) //Right
                {
                    if (Position.X < (Program.Width - 1))
                    {
                        Position.X++;
                    }
                    else
                    {

                    }
                }
            });

        }
    }


    // Render Systems
    public class RenderSystem : BaseSystem<World, float>
    {
        private QueryDescription Render = new QueryDescription().WithAll<Literal_Position_Component, Glyth_Component>();
        public RenderSystem(World world) : base(world) { }

        public override void Update(in float deltatime)
        {
            World.Query(in Render, (ref Literal_Position_Component Position, ref Glyth_Component Glyth) =>
            {
                Program.console1.SetGlyph(Position.X, Position.Y, Glyth.Glyth);
            });
        }
    }
}