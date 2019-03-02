using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRatQueen.Componet
{
   public abstract class Componet
    {



        public GameObject GameObject { get; private set; }

        public Componet()
        {



        }

        public void GetGameObejt(GameObject gameObject)
        {

            this.GameObject = gameObject;
        }
        public void NewSpriteRender() { }


        public virtual void Attach(GameObject gameObject)
        {
            this.GameObject = gameObject;
        }

        internal void Attach(Player player)
        {
            throw new NotImplementedException();
        }

        public virtual void LoadContet(ContentManager content)
        {


        }
        public virtual void update(GameTime gameTime)
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {


        }

        //public GameObject GameObject { get; private set; }


        //public Componet()
        //{

        //}

        //public void GetGameObejt(GameObject gameObject)
        //{

        //    this.GameObject = gameObject;
        //}
        //public void NewSpriteRender() { }


        //public virtual void Attach(GameObject gameObject)
        //{
        //    this.GameObject = gameObject;
        //}

        //public virtual void LoadContet(ContentManager content)
        //{


        //}
        //public virtual void update(GameTime gameTime)
        //{

        //}

        //public virtual void Draw(SpriteBatch spriteBatch)
        //{


        //}
    }
}

