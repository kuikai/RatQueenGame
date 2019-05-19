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
   public class Transform : Componet
    {

        public Vector2 Position { get; set; }

        public float rotetion { get; set; }
        public float Siz { get; set; }
        public SpriteEffects s { get; set; }
        public bool Ifalling { get; set; }
        





        public Transform(Vector2 transfrom)
        {
            Ifalling = true;
            this.Position = transfrom;
        }

     
        public void Translate(Vector2 velocity)
        {
            Position = velocity;
        } 
    }
}
