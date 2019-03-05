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
        public float size = 0.2f;
        float deltaTime;
        public float RotationAngle { get; set; }

        public int force;
        public int gravity;

        public bool Jump;
     

        public Player( )
        {
          
            StartPos = new Vector2(GameWorld.ScreenSize.Width/2,GameWorld.ScreenSize.Height/2);
        }
        public Player(Vector2 pos)
        {
            this.StartPos = pos;
        }
        public void Gravity()
        {

        }
        public void SetRotationAngle(Vector2 directon)
        {    
            if(directon.X < 0 )
            {
                GameObject.transform.s = SpriteEffects.FlipHorizontally;
            }
            else
            {
                GameObject.transform.s = SpriteEffects.None;
            }            
         // GameObject.transform.rotetion =  (float)Math.Atan2(directon.Y, directon.X);
        }
        public void rotetion()
        {
           
        }
        public void Move( Vector2 velocity)
        {        
            GameObject.transform.Position += velocity;
            SetRotationAngle(velocity);
        }        
        public override void Update(GameTime gameTime)
        {          
            InputHandler.Instance.Execute(this);
            GameWorld.GetPlayerPosition(GameObject.transform.Position);
            deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
        }
        public override void Attach(GameObject gameObject)
        {
            base.Attach(gameObject);
            gameObject.transform.Position = StartPos;
            gameObject.transform.Siz = size;
        }
    }
}
