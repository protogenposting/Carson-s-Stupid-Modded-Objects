using Celeste.Mod.Entities;
using Microsoft.Xna.Framework;
using MonoMod.Utils;
using System.Runtime.CompilerServices;

namespace Celeste.Mod.stupid_modded_objects.Objects.Entities
{
    [CustomEntity("stupid_modded_objects/ReverseRefill")]
    public class ReverseRefill : Refill{
        public ReverseRefill(EntityData data, Vector2 offset) : base(data.Position,false,false)
        {
            PlayerCollider pc = Get<PlayerCollider>();
            var orig = pc.OnCollide;
            pc.OnCollide = player => {
                if(Collidable&&(player.Dashes<player.MaxDashes||player.Stamina<=20))
                {
                    player.Speed*=-1;
                }
                orig(player);
            };
        }
        public override void Update()
        {
            base.Update();
        }
    }
}