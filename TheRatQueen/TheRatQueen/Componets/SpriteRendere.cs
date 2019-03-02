using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace TheRatQueen.Componet
{
  public class SpriteRendere : Componet
    {


        private Rectangle Rectangle;
        private Texture2D sprite;
        protected Vector2 origin;
        public string spriteName;
        private float retetion = 4.6912f;
        private int frams;

        public SpriteRendere(int Frams, string SpriteName)
        {
            frams = Frams;
            this.spriteName = SpriteName;

        }

        public override void Draw(SpriteBatch spriteBatch)
        {

            Rectangle = new Rectangle(0, (sprite.Height / frams),
            sprite.Width, (sprite.Height / frams));


            spriteBatch.Draw(sprite, , 
                Rectangle, Color.White, retetion,
                new Vector2(Rectangle.Width * 0.5f, Rectangle.Height * 0.5f), 1f,
                new SpriteEffects(), 0f);

        }


        public override void LoadContet(ContentManager content)
        {
            sprite = content.Load<Texture2D>(spriteName);
            base.LoadContet(content);
        }










        //private Rectangle rectangle;
        //private Texture2D sprite;       
        //public  string spriteName;
        ///// <summary>
        ///// Constructore there gets the name of the sprite
        ///// </summary>
        ///// <param name="spriteName"></param>
        //public SpriteRendere(string spriteName)
        //{
        //    this.spriteName = spriteName;

        //}
        ///// <summary>
        /////  DrawSprite
        ///// </summary>
        ///// <param name="spriteBatch"></param>
        //public override void Draw(SpriteBatch spriteBatch)
        //{

        //    spriteBatch.Draw(sprite, GameObject.Transform.Position,
        //     new Rectangle(0, (sprite.Height),
        //    sprite.Width, (sprite.Height)), Color.White, 0, 
        //    new Vector2(rectangle.Width * 0.5f, rectangle.Height * 0.5f), 1f, 
        //    new SpriteEffects(), 0f);
        //}
        ///// <summary>
        ///// Loard the spirte
        ///// </summary>
        ///// <param name="content"></param>
        //public override void LoadContent(ContentManager content)
        //{

        //    sprite = content.Load<Texture2D>(spriteName);
        //    base.LoadContent(content);



        //}

    }
}
