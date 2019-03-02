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
    public class Transform : Componet
    {













        public Vector2 Position
        {
            get;
            set;
        }
        public Transform(Vector2 position) : base()
        {
            this.Position = position;
        }

        public void TransForm(Vector2 transform)
        {
            Position = transform;
        }
        public void Translate(Vector2 translation)
        {
            Position += translation;
        }









        // public Vector2 Position { get; set; }
        // public float Rotetion { get; set; }
        // public float Siz { get; set; }
        // /// <summary>
        // /// sets the position
        // /// </summary>
        // /// <param name="Position"></param>
        //public Transform(Vector2 Position) : base()
        // {
        //     this.Position = Position;
        // }
        /// <summary>
        /// overloard 1
        /// </summary>
        /// <param name="Position"></param>
        /// <param name="rotetion"></param>
        // public Transform(Vector2 Position,float rotetion) : base()
        //{
        //    this.Position = Position;
        //    this.Rotetion = rotetion;
        //}
        /// <summary>
        /// overloard 3
        /// </summary>
        /// <param name="Position"></param>
        /// <param name="rotetion"></param>
        /// <param name="Size"></param>
        //public Transform(Vector2 Position,float rotetion,float Size) : base()
        //{
        //    this.Position = Position;
        //    this.Rotetion = rotetion;
        //    this.Siz = Size;
        //}
        /// <summary>
        /// sits the rotetion
        /// </summary>
        /// <param name="rotetion"></param>
        //public void rotation(float rotetion)
        //{
        //    Rotetion = rotetion;

        //}
        /// <summary>
        /// sits the size
        /// </summary>
        /// <param name="size"></param>
        //public void Size(float size)
        //{

        //    this.Siz = size;
        //}
        /// <summary>
        /// sets the Position
        /// </summary>
        /// <param name="transform"></param>
        //public void Transfrom(Vector2 transform)
        //{
        //    Position = transform;
        //}

        ///// <summary>
        ///// moves postion
        ///// </summary>
        ///// <param name="translation"></param>
        //public void Translate(Vector2 translation)
        //{
        //    Position += translation;
        //}
    }
}
