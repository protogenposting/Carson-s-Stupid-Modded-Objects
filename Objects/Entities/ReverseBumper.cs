
using System;
using Celeste;
using Microsoft.Xna.Framework;
using MonoMod.Utils;

namespace Celeste.Mod.Carson_s_Stupid_Modded_Objects.Objects.Entities
{
    [CustomEntity("Carson_s_Stupid_Modded_Objects/ReverseBumper")]
    public class ReverseBumper : Bumper{
        public ReverseBumper(EntityData data, Vector2 offset) : base(data, offset)
        {
            PlayerCollider pc = Get<PlayerCollider>();
            var orig = pc.OnCollide;
            pc.OnCollide = player => {
                orig(player);
                player.Speed *= -1;
            };
            // other stuff
        }
    }
}