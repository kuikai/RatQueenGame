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
    class InputHandler
    {

        private Dictionary<Keys, Vector2> keybinds = new Dictionary<Keys, Vector2>();
 

        public void inputHandler()
        {

            keybinds.Add(Keys.A, new Vector2(10,0));
            keybinds.Add(Keys.D,  new Vector2(-10,0));
        }
        public void Ecervute(GameTime gametime, Player player)

        {
          
            KeyboardState keyState = Keyboard.GetState();

            foreach (KeyValuePair<Keys ,Vector2> item in keybinds)
            {

                if (Keyboard.GetState().IsKeyDown(item.Key))
                {
                    player.Move(gametime, item.Value);
                }
            }
             
           
        }
    }
}
