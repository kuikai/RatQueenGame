using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace TheRatQueen
<<<<<<< HEAD
{
    public class Collision : Componet
=======
    {
        class Collision : Componet

        {
            public SpriteRendere spriteRendere { get; private set; }
>>>>>>> parent of 22c1acc... Merge branch 'master' of https://github.com/kuikai/RatQueenGame

    {
        public SpriteRendere spriteRendere { get; private set; }

       

        public bool DoCollisionsChecks { get; set; }

        private Texture2D texture;

<<<<<<< HEAD
        public HashSet<Collision> otherColliders = new HashSet<Collision>();
=======
            private HashSet<Collision> otherColliders = new HashSet<Collision>();
>>>>>>> parent of 22c1acc... Merge branch 'master' of https://github.com/kuikai/RatQueenGame

        public Rectangle CollisionBox
        {
            get
            {
                return new Rectangle
                    (
                        (int)(GameObject.transform.Position.X - spriteRendere.orgin.X),
                        (int)(GameObject.transform.Position.Y - spriteRendere.orgin.Y),
                        spriteRendere.rectangle.Width,
                        spriteRendere.rectangle.Height
                    );
            }
        }

        public override void Attach(GameObject gameObject)
        {
            base.Attach(gameObject);

            DoCollisionsChecks = true;

            spriteRendere = (SpriteRendere)gameObject.GetComponet("SpriteRendere");

            GameWorld.Instance.Colliders.Add(this);
        }

        public override void LoadContent(ContentManager content)
        {
            texture = content.Load<Texture2D>("CollisionTexture");
        }

        public override void Update(GameTime gameTime)
        {
            CheckCollisions();
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
        
            Rectangle topLine = new Rectangle(CollisionBox.X, CollisionBox.Y, CollisionBox.Width,1);
            Rectangle bottomLine = new Rectangle(CollisionBox.X, CollisionBox.Y + CollisionBox.Height, CollisionBox.Width, 1);
            Rectangle rightLine = new Rectangle(CollisionBox.X + CollisionBox.Width, CollisionBox.Y, 1, CollisionBox.Height);
            Rectangle leftLine = new Rectangle(CollisionBox.X, CollisionBox.Y, 1, CollisionBox.Height);

            spriteBatch.Draw(texture, topLine, null, Color.Red, 0, Vector2.Zero, SpriteEffects.None, 1);
            spriteBatch.Draw(texture, bottomLine, null, Color.Red, 0, Vector2.Zero, SpriteEffects.None, 1);
            spriteBatch.Draw(texture, rightLine, null, Color.Red, 0, Vector2.Zero, SpriteEffects.None, 1);
            spriteBatch.Draw(texture, leftLine, null, Color.Red, 0, Vector2.Zero, SpriteEffects.None, 1);
          
        }
        private void CheckCollisions()
        {
            if (DoCollisionsChecks)
            {
                foreach (Collision other in GameWorld.Instance.Colliders)
                {
                    if (other != this)
                    {
                        if (CollisionBox.Intersects(other.CollisionBox))
                        {
                           
                            
                           GameObject.transform.Ifalling = false;
                            
                            if (!otherColliders.Contains(other))
                            {
                                
                                otherColliders.Add(other);
                            }
                           
                        }
                        else if ((otherColliders.Contains(other)))
                        {
                            otherColliders.Remove(other);

                            GameObject.transform.Ifalling = true;
                        }
                    }
                }
                   
                
            }
<<<<<<< HEAD
=======


>>>>>>> parent of 22c1acc... Merge branch 'master' of https://github.com/kuikai/RatQueenGame
        }
    }
}

