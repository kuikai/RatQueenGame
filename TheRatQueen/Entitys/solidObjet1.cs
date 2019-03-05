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
    class solidObjet1 : Componet
    {

        public Vector2 StartPos;
        public float size;

        /// <summary>
        ///  setter start Position og size
        /// </summary>
        /// <param name="Position"></param>
        /// <param name="Size"></param>
        public solidObjet1(Vector2 Position, float Size)
        {
            this.StartPos = Position;
            this.size = Size;
        }
        /// <summary>
        /// setter tranfromen
        /// </summary>
        /// <param name="gameObject"></param>
        public override void Attach(GameObject gameObject)
        {
            base.Attach(gameObject);
            gameObject.transform.Position = StartPos;
            gameObject.transform.Siz = size;
        }
    }
}
