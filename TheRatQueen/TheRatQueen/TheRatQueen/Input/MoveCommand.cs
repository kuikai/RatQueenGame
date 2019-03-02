using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace TheRatQueen
{
    class MoveCommand
    {

        private Vector2 Velocity;

        public MoveCommand(Vector2 velocity)
        {
            this.Velocity = velocity;
        }

        public void Execute(GameTime gameTime , Player player, Vector2 velocity)
        {
            this.Velocity = velocity;
            player.Move( velocity);

        }
    }
}
