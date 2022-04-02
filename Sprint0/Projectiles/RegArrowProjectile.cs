﻿using Microsoft.Xna.Framework;
using Poggus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poggus.Projectiles
{
    public class RegArrowProjectile : AbstractProjectile
    {
        public RegArrowProjectile(Point position, Point velocity, Point size) : base(position, velocity, size)
        {
            Life = ProjectileConstants.regArrowLife;
        }
        public override void Update(GameTime gameTime)
        {
            //Move the arrow according to its velocity.

            DestRect = new Rectangle(DestRect.Location + Velocity, DestRect.Size);

            Sprite.Update(gameTime);

            Life -= gameTime.ElapsedGameTime.Milliseconds;

        }
    }
}
