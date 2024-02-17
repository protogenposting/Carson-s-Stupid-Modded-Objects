using Celeste.Mod.Entities;
using Microsoft.Xna.Framework;
using MonoMod.Utils;

namespace Celeste.Mod.stupid_modded_objects.Objects.Entities
{
    [CustomEntity("stupid_modded_objects/ReverseBumper")]
    public class ReverseBumper : Bumper{
        public ReverseBumper(EntityData data, Vector2 offset) : base(data, offset)
        {
            PlayerCollider pc = Get<PlayerCollider>();
            var orig = pc.OnCollide;
            pc.OnCollide = player => {
                orig(player);
                if(Collidable)
                {
                    player.Speed *= -1;
                }
            };
            // other stuff
        }
    }
}