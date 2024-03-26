using Celeste.Mod.Entities;
using Microsoft.Xna.Framework;
using MonoMod.Utils;
using System.Runtime.CompilerServices;
﻿using System;
using System.Collections.Generic;
using Celeste;
using Monocle;
using System.Reflection;

namespace Celeste.Mod.stupid_modded_objects.Objects.Entities
{
    [CustomEntity("stupid_modded_objects/CoffeeCar")]
    public class CoffeeCar : IntroCar{
        private FieldInfo bodySprInfo = typeof(IntroCar).GetField("bodySprite", BindingFlags.GetField | BindingFlags.NonPublic | BindingFlags.Instance);
        public CoffeeCar(EntityData data, Vector2 offset) : base(data.Position)
        {
            PlayerCollider pc = Get<PlayerCollider>();
            var orig = pc.OnCollide;
            pc.OnCollide = player => {
                if(Collidable&&(player.Dashes<player.MaxDashes||player.Stamina<=20))
                {
                    player.Speed.Y=-27;
                }
                orig(player);
            };
        }
        public override void Update()
        {
            base.Update();
        }
        private void UpdateVisualState()
        {
            Image bodySpr = bodySprInfo.GetValue(this) as Image;
            bodySpr.Color=Calc.HexToColor("5F3300");
        }
    }
}