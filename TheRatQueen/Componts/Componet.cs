using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TheRatQueen
{
   public abstract class Componet
    {

         public  GameObject GameObject { get;private set; }


     
        public virtual void Attach(GameObject gameObject)
        {
            //Sets the parent
          this.GameObject = gameObject;
        }


        public virtual void LoadContent(ContentManager content)
        {
           
        }

        public virtual void Update(GameTime gameTime)
        {
            
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            
        }


    }
}
