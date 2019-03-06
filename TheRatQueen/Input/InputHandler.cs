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
    class InputHandler
    {

        KeyboardState laststate= new KeyboardState();
        private Dictionary<Keys, Vector2> Keybinds = new Dictionary<Keys, Vector2>();

        private Dictionary<Keys, Vector2> keyClicks = new Dictionary<Keys, Vector2>();

        private static InputHandler instance;

        internal static InputHandler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InputHandler();
                }

                return instance;
            }
        }
        public InputHandler()
        {
            Keybinds.Add(Keys.A, new Vector2(-1, 0));
            Keybinds.Add(Keys.D, new Vector2(1, 0));
            keyClicks.Add(Keys.Space, new Vector2(0, -1));
        }
        public void Execute( Player player)
        {

           KeyboardState keyStart = Keyboard.GetState();

            foreach (KeyValuePair<Keys, Vector2> item in Keybinds)
            {

                if (Keyboard.GetState().IsKeyDown(item.Key))
                {
                    player.Move( item.Value);
                }
            }
            foreach (KeyValuePair<Keys, Vector2> item  in keyClicks)
            {


                if (keyStart.IsKeyDown(item.Key)&& laststate.IsKeyUp(item.Key))
                {
                    player.Move(item.Value);

                }
                laststate = keyStart;
            }
        }
    }
}
