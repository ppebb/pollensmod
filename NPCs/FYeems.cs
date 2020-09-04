using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;

using TAPI;
using Terraria;

namespace pollensmod.NPCs
{
    public class FYeems : ModNPC
    {
        public override bool CanSpawn(int x, int y, int type, Player spawnedOn) //This is called when an NPC is about to spawn.
        {
            if (y <= Main.worldSurface &&  //If the player is below the surface...
            ((!Main.dayTime && !Main.bloodMoon && Main.rand.Next(3) == 0) ||   //If there is a blood moon, it will have a 1/3 chance to spawn.
            (!Main.dayTime && Main.bloodMoon && Main.rand.Next(3) == 0)))  //If there is no blood moon, it will have a 1/3 chance to spawn.
            {
                return true; //If these conditions are true...
            }
            return false;  //Then the mob won't spawn.
        } //yeah this is just example code
    }
}