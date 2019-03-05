using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace TheRatQueen
    {
        class Collision : Componet

        {
            public SpriteRendere spriteRendere { get; private set; }



            public bool DoCollisionsChecks { get; set; }

            private Texture2D texture;

            private HashSet<Collision> otherColliders = new HashSet<Collision>();

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
                CheckColliders();
            }


        }
    }

}
