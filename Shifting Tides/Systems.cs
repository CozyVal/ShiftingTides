using System.Collections.Generic;
using SadConsole;
using SadRogue.Primitives;
using AstrologyECS;
using Console = SadConsole.Console;
using SadConsole.Input;
using System;
using SadConsole.Components;
using SFML.Window;
using static SFML.Graphics.Font;
using SadConsole.Instructions;
using Shattered_Tides;

namespace Shattered_Tides
{
    //Rendering Systems
    class RenderSystem : AstrologyECS.System
    {
        // This filter is used to pick and choose what kind of entities this system should operate on.
        protected override ComponentFilter Filter => new ComponentFilter()
            .AddNecessary(typeof(Literal_Position_Component))
            .AddNecessary(typeof(Glyth_Component));


        // This method is run on every entity that passes through the filter.
        protected sealed override void OperateOnEntity(Entity entity)
        {

        }
    }
    class Do_not_Render : AstrologyECS.System
    {
        // This filter is used to pick and choose what kind of entities this system should operate on.
        protected override ComponentFilter Filter => new ComponentFilter()
            .AddNecessary(typeof(Should_Not_Be_Rendered_Component));


        // This method is run on every entity that passes through the filter.
        protected sealed override void OperateOnEntity(Entity entity)
        {
            entity.RemoveComponentsOfType<Can_Be_Seen_Component>();
        }
    }





    // AI Systems
    class FoVSystem : AstrologyECS.System
    {
        // This filter is used to pick and choose what kind of entities this system should operate on.
        protected override ComponentFilter Filter => new ComponentFilter();


        // This method is run on every entity that passes through the filter.
        protected sealed override void OperateOnEntity(Entity entity)
        {

        }
    }
    class AISystem : AstrologyECS.System
    {
        // This filter is used to pick and choose what kind of entities this system should operate on.
        protected override ComponentFilter Filter => new ComponentFilter();


        // This method is run on every entity that passes through the filter.
        protected sealed override void OperateOnEntity(Entity entity)
        {

        }
    }
    class MovementSystem : AstrologyECS.System
    {
        // This filter is used to pick and choose what kind of entities this system should operate on.
        protected override ComponentFilter Filter => new ComponentFilter()
            .AddNecessary(typeof(Can_Move_Component))
            .AddNecessary(typeof(Player_Component));


        // This method is run on every entity that passes through the filter.
        protected sealed override void OperateOnEntity(Entity entity)
        {

        }
    }


    //Combat Systems
    class DamageSystem : AstrologyECS.System
    {
        // This filter is used to pick and choose what kind of entities this system should operate on.
        protected override ComponentFilter Filter => new ComponentFilter();


        // This method is run on every entity that passes through the filter.
        protected sealed override void OperateOnEntity(Entity entity)
        {

        }
    }
}