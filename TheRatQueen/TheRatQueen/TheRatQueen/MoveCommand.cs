using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceGame
{

    class MoveCommand 
    {

    private Vector2 Velocity;


        public MoveCommand(Vector2 velocity)
        {
            this.Velocity = velocity;
        }

     

        public void Execute(GameTime gameTime,Player player,Vector2 velocity)
        {
            this.Velocity = velocity;

            player.Move(gameTime, velocity);
        }
    }
}
