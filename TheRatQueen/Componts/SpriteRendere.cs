﻿using System;
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
     public class SpriteRendere : Componet
    {

        public Rectangle rectangle;

        public Vector2 orgin;

        public string spriteName;

        public Texture2D sprite;

        public SpriteRendere(string SpriteName) 
        {
            this.spriteName = SpriteName;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
          
            spriteBatch.Draw(sprite, GameObject.transform.Position, rectangle, Color.White,GameObject.transform.rotetion , orgin, GameObject.transform.Siz, GameObject.transform.s, 0);
        }

        public override void LoadContent(ContentManager content)
        {

             sprite = content.Load<Texture2D>(spriteName);

            rectangle = new Rectangle(0, 0, sprite.Width , sprite.Height);

            orgin =  new Vector2(sprite.Width / 2, sprite.Height / 2);

        }    

    }
}