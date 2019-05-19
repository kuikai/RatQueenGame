using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Windows.Input;
namespace TheRatQueen
{
   public class Player : Componet
    {


        

        public float speed = 100;
      
        public Vector2 StartPos;
        float deltaTime;


        public Player()
        {
          
            StartPos = new Vector2(GameWorld.ScreenSize.Width/2,GameWorld.ScreenSize.Height/2);
        }
        public void Move( Vector2 velocity)
        {
           

            GameObject.transform.Position += velocity;
        }
         
        public override void Update(GameTime gameTime)
        {

            InputHandler.Instance.Execute(this);

            deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
        }
        public override void Attach(GameObject gameObject)
        {
            base.Attach(gameObject);
            gameObject.transform.Position = StartPos;
        }
    }
}
