using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poggus.Player
{
    public class DownMagicalShieldMovingLinkSprite : AbstractSprite
    {
        public DownMagicalShieldMovingLinkSprite(Texture2D spriteSheet) : base(spriteSheet, new Rectangle[2])
        {
            SourceRect[0] = new Rectangle(306, 11, 16, 16);  //Set the frame for right idle link
            SourceRect[1] = new Rectangle(289, 11, 16, 16);

            this.Interval = LinkConstants.movementAnimInterval;

        }

        public override void Update(GameTime gameTime)
        {
            // Implement animation changes here
            this.FrameStep(gameTime);
        }


    }
}
