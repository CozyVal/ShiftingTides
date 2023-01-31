using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AstrologyECS;

namespace Shattered_Tides
{
    //Creature components that can be/are inherent to all creatures
    class Skills_Component : AstrologyECS.Component { public int Acrobatics = 25, Athletics = 30, Celestial = 0, Coercion = 25, Computer = 40, First_Aid = 30, Heavy_Arms = 0, Insight = 25, Intimidate = 20, Leadership = 15, Long_Arms = 25, Mechanics = 20, Melee = 30, Piloting_Land = 20, Piloting_Air = 5, Piloting_Sea = 5, Piloting_Space = 0, Profession_Int = 25, Science = 15, Social_World = 20, Social_Sector = 25, Social_Adventurer = 15, Small_Arms = 20, Suit = 15, Survival = 25, Surgery = 20, Trickery = 20, Throwing = 30; public string Profession = ""; }
    class Saving_Throws_Component : AstrologyECS.Component { public int Endurance = 0, Willpower = 0, Reflex = 0; }
    class Species_Component : AstrologyECS.Component { public string Species = ""; public int Species_type = 0; }
    class Augment_Points_Component : AstrologyECS.Component { public int Points = 2; }
    class Health_Component : AstrologyECS.Component { public int Health = 1; }
    class Armour_Component : AstrologyECS.Component { public int Armour = 0; }
    class Mana_Component : AstrologyECS.Component { public int Mana = 0; }
    class Stamina_Component : AstrologyECS.Component { public int Stamina = 0; }
    class Shield_Component : AstrologyECS.Component { public int Shield = 0; }
    class Player_Component : AstrologyECS.Component { }
    class Bleed_Out_Timer_Component : AstrologyECS.Component { public int Bleed_Out_Timer = 0; }
    class Can_Bleed_Out_Component : AstrologyECS.Component { }
    class Glyth_Component : AstrologyECS.Component { public string Glyth; }
    class Field_Of_View_Component : AstrologyECS.Component { public int FoV = 5; }
    class In_Inventory_Component : AstrologyECS.Component { }
    class Credit_Components : AstrologyECS.Component { public int Amount = 0; }

    // Body Components
    class Can_See_Component : AstrologyECS.Component { }
    class Vision_Type_Component : AstrologyECS.Component { public string Vision = "Normal"; }
    class Arms_Component : AstrologyECS.Component { public int Arms = 2; }
    class Legs_Component : AstrologyECS.Component { public int Legs = 2; }
    class Head_Component : AstrologyECS.Component { public int Heads = 1; }
    class Skin_Type_Component : AstrologyECS.Component { public string Type = "Skin"; }

    //Body Type Components
    class Is_Intimidating_Component : AstrologyECS.Component { }

    //Location components
    class Literal_Position_Component : AstrologyECS.Component { public int X = 0, Y = 0, Z = 0; }
    class Last_Known_Position_Component : AstrologyECS.Component { public int X = 0, Y = 0, Z = 0; }
    class Is_Seen_Component : AstrologyECS.Component { }
    class Has_Been_Seen_Component : AstrologyECS.Component { }
    class Can_Be_Moved_Through_Component : AstrologyECS.Component { }
    class Can_Move_Component : AstrologyECS.Component { }

    //Render Components
    class Can_Be_Seen_Component : AstrologyECS.Component { }
    class Should_Not_Be_Rendered_Component : AstrologyECS.Component { }

    //Weapon and Item components
    class Weapon_Type_Component : AstrologyECS.Component { }
    class Weapon_Range_Component : AstrologyECS.Component { }
    class Weapon_Damage_Component : AstrologyECS.Component { }
    class Weapon_Damage_Type_Component : AstrologyECS.Component { }
    class Weapon_Area_Of_Effect_Component : AstrologyECS.Component { }
    class Weapon_Area_Of_Effect_Damage_Component : AstrologyECS.Component { }

    //Misc components
    class Has_Been_Damaged_Component : AstrologyECS.Component { }

}
