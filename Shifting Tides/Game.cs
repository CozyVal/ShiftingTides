using SadConsole;
using SadRogue.Primitives;
using Console = SadConsole.Console;
using Arch.Core;
using Arch.System;
using AstrologyECS;
using SadConsole.Input;

namespace Shattered_Tides
{
    public class Program
    {
        public const int Width = 200;
        public const int Height = 50;
        public static Console console1;
        public static Group<float> _systems;

        private static void Main(string[] args)
        {
            // Setup the engine and create the main window.
            Game.Create(Width, Height);

            // Hook the start event so we can add consoles to the system.
            Game.Instance.OnStart = Init;

            // Start the game.
            Game.Instance.Run();
        }


        private static void Init()
        {

            World world = World.Create();
            _systems = new Group<float>(
                new RenderSystem(world),
                new MovementSystem(world));
            _systems.Initialize();


            CharacterInit(world);

            ScreenObject container = new();
            Game.Instance.Screen = container;
            Game.Instance.DestroyDefaultStartingConsole();

            console1 = new(Width, Height);
            console1.Position = new Point(0, 0);
            container.Children.Add(console1);
            console1.IsFocused = true;
            console1.UseKeyboard = true;

            Game.Instance.FrameUpdate += FrameUpdateEventRaise;
        }

        public static void FrameUpdateEventRaise(object sender, SadConsole.GameHost e)
        {
            console1.Clear();
            _systems.Update(0.05f);
        }

        public static void CharacterInit(World world)
        {
            var Player = world.Create(new Literal_Position_Component { X = 5, Y = 5, Z = 0 }, new Player_Component { }, new Glyth_Component { Glyth = 64 }, new Can_Move_Component { });
            var Enemy = world.Create(new Literal_Position_Component { X = 10, Y = 10, Z = 10 }, new Glyth_Component { Glyth = 35 }, new Can_Move_Component { });
        }
    }
}