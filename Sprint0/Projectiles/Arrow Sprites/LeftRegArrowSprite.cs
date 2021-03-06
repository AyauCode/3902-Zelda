using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Poggus.Player;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poggus
{
    public class LeftRegArrowSprite : AbstractSprite
    {
        public LeftRegArrowSprite(Texture2D spriteSheet) : base(spriteSheet, new Rectangle[1])
        {
            SourceRect[0] = new Rectangle(10, 189, 16, 8);  //Horizontal Red Arrow source Rectangle
            this.Interval = 500;
            this.effects = SpriteEffects.FlipHorizontally;
        }

        public override void Update(GameTime gameTime)
        {
            this.FrameStep(gameTime);
        }
    }

}
