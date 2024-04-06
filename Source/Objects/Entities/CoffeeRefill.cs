using Celeste.Mod.Entities;
using Microsoft.Xna.Framework;
using MonoMod.Utils;
using MonoMod.ModInterop;
using System.Runtime.CompilerServices;
using Monocle;

namespace Celeste.Mod.stupid_modded_objects.Objects.Entities
{
    [CustomEntity("stupid_modded_objects/CoffeeRefill")]
    public class CoffeeRefill : Refill{
        public CoffeeRefill(EntityData data, Vector2 offset) : base(data.Position + offset,false,false)
        {
            PlayerCollider pc = Get<PlayerCollider>();
            var orig = pc.OnCollide;
            pc.OnCollide = player => {
                if(Collidable&&(player.Dashes<player.MaxDashes||player.Stamina<=20))
                {
                    stupid_modded_objectsModule.ExtendedVariantImports.TriggerFloatVariant("GameSpeed",0.5f,true);
                    stupid_modded_objectsModule.ExtendedVariantImports.TriggerFloatVariant("SpeedX",2f,true);
                    Alarm.Set(player, 1, () => {
                        stupid_modded_objectsModule.ExtendedVariantImports.TriggerFloatVariant("GameSpeed",1f,true);
                        stupid_modded_objectsModule.ExtendedVariantImports.TriggerFloatVariant("SpeedX",1f,true);
                    });
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