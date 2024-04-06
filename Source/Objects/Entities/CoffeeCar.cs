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
        public CoffeeCar(EntityData data, Vector2 offset) : base(data.Position + offset)
        {
            Position.Y+=16;
        }
        public override void Update()
        {
            Player player = GetPlayerRider();
            if(player!=null)
            {
                if(!player.DashAttacking)
                {
                    player.Speed.Y = -300;
                }
            }
            UpdateVisualState();
            base.Update();
        }
        private void UpdateVisualState()
        {
            Image bodySpr = bodySprInfo.GetValue(this) as Image;
            bodySpr.Color=Calc.HexToColor("5F3300");
        }
    }
}