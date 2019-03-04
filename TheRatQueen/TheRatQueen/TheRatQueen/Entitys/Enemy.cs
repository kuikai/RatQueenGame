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
   public class Enemy : Componet
    {

        private float speed;
        private Vector2 position;

        public Enemy()
        {
            speed = 100;
            position = new Vector2(100, 100);
        }

        public Enemy(Vector2 position, float speed)
        {
            this.position = position;
            this.speed = speed;
        }
        public Enemy(GameObject gameObject, Vector2 Position,float speed)
        {
            this.position = Position;
            this.speed = speed;
        }
       public virtual void move()
        {

        }
    }
}
