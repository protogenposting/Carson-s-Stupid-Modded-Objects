using Celeste.Mod.Entities;
using Microsoft.Xna.Framework;
using MonoMod.Utils;
using System.Runtime.CompilerServices;
using Monocle;

//pumber

namespace Celeste.Mod.stupid_modded_objects.Objects.Entities
{
    [CustomEntity("stupid_modded_objects/ReverseBumper")]
    public class ReverseBumper : Bumper{
        public readonly DynamicData BaseData;
        public double timer=0;

        public ReverseBumper(EntityData data, Vector2 offset) : base(data, offset)
        {
            BaseData = DynamicData.For(this);
            PlayerCollider pc = Get<PlayerCollider>();
            var orig = pc.OnCollide;
            pc.OnCollide = player => {
                orig(player);
                if (timer <= 0f)
                {
                    player.Speed *= -1;
                    timer=0.6;
                }
            };
            // other stuff
        }
        public override void Update()
        {
            timer -= Engine.DeltaTime;
            base.Update();
        }
    }
}