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

        // playStats
        public float speed = 10; 
        public Vector2 StartPos;
        public float size = 1f;
     
        float deltaTime;
       

       
        /// <summary>
        /// Gravity
        /// </summary>
        public Vector2 gravity = Vector2.Zero;
        public float acceleration = 9.8f;


        public Vector2 jumpforce = new Vector2(0,-10);
        float startTime = 0;
         
        /// <summary>
        ///   jump
        /// </summary>
        public bool Jump;

   
        public Player( )
        {
          
            StartPos = new Vector2(GameWorld.ScreenSize.Width/2,GameWorld.ScreenSize.Height/2);
        }
        public Player(Vector2 pos)
        {
            this.StartPos = pos;
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
  
       
        
        public void Gravity(GameTime gameTime)
        {
            if (GameObject.transform.Ifalling == true)
            {
                startTime += (float)gameTime.ElapsedGameTime.TotalSeconds;
                gravity.Y += acceleration * startTime / 10;
                GameObject.transform.Position += gravity;
            }else if(GameObject.transform.Ifalling == false)
            {
                gravity = Vector2.Zero;
                startTime = 0;
                Jump = false;
            }
          
        }

        public void Move( Vector2 velocity)
        {        
            if(velocity != Vector2.Zero)
            {

                velocity.Normalize();
            }

            if (velocity.Y <= -0.01)
            {
                Jump = true;
            }

            GameObject.transform.Position += velocity *speed ;
            SetRotationAngle(velocity);
        }  
        
        public override void Update(GameTime gameTime)
        {

            if(Jump == true)
            {


                GameObject.transform.Position += jumpforce;
            }
           

            
            Gravity(gameTime);
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

        public override void DoColision(GameObject OtherObejt)
        {

        }

    }
}
