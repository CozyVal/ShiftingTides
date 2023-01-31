using System;
using SadConsole;
using SadConsole.Input;
using SadRogue.Primitives;
using Console = SadConsole.Console;
using AstrologyECS;
using System.Collections.Generic;

namespace Shattered_Tides
{
    class Program
    {
        public const int Width = 200;
        public const int Height = 50;
        public static Console console1;

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
            Characterinit();

            ScreenObject container = new();
            Game.Instance.Screen = container;
            Game.Instance.DestroyDefaultStartingConsole();

            console1 = new(Width, Height);
            console1.Position = new Point(0, 0);
            container.Children.Add(console1);
            console1.IsFocused = true;
            console1.UseKeyboard = true;

            EntityPool.AddSystem(new MovementSystem());
            Game.Instance.FrameUpdate += FrameUpdateEventRaise;
        }

        public static void FrameUpdateEventRaise(object sender, SadConsole.GameHost e)
        {
            List<Entity> entities = EntityPool.GetEntities();
            EntityPool.Tick();
            foreach (Entity actor in entities)
            {
                console1.Clear();
                if (actor.HasComponent<Can_Be_Seen_Component>())
                {
                    Keyboard(e, actor);
                    console1.Print(actor.GetComponent<Literal_Position_Component>().X, actor.GetComponent<Literal_Position_Component>().Y, actor.GetComponent<Glyth_Component>().Glyth);
                }
            }

        }

        public static void Keyboard(SadConsole.GameHost e, Entity actor)
        {
            if (e.Keyboard.IsKeyPressed(Keys.W)) //Up
            {
                actor.GetComponent<Literal_Position_Component>().Y -= 1;
            }
            if (e.Keyboard.IsKeyPressed(Keys.A)) //Left
            {
                actor.GetComponent<Literal_Position_Component>().X -= 1;
            }
            if (e.Keyboard.IsKeyPressed(Keys.S)) //Down
            {
                actor.GetComponent<Literal_Position_Component>().Y += 1;
            }
            if (e.Keyboard.IsKeyPressed(Keys.D)) //Right
            {
                actor.GetComponent<Literal_Position_Component>().X += 1;
            }
        }

        public static void Characterinit()
        {
            Entity Player = new Entity();
            Player.AddComponent(new Literal_Position_Component());
            Player.AddComponent(new Player_Component());
            Player.AddComponent(new Glyth_Component());
            Player.AddComponent(new Can_Move_Component());
            Player.AddComponent(new Can_Be_Seen_Component());
            Player.GetComponent<Literal_Position_Component>().X = 10;
            Player.GetComponent<Literal_Position_Component>().Y = 10;
            Player.GetComponent<Glyth_Component>().Glyth = "@";
            EntityPool.AddEntity(Player);
        }
    }
}