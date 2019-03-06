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
    public class SolidObejtFactory
    {

        private static SolidObejtFactory instance;

        
        public static SolidObejtFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SolidObejtFactory();
                }
                return instance;
            }
      
        }

      
        
        public GameObject Create(string type)
        {
            GameObject go = new GameObject();

           
            switch (type)
            {
                case "pipe":

                    go.AddComponent(new solidObjet1(new Vector2(600,600), 1));
                    go.AddComponent(new SpriteRendere("pipe"));
                    go.AddComponent(new Collision() );
                    break;

         
           
                default:
                    break;
            }

            return go;

        }

    }
}
