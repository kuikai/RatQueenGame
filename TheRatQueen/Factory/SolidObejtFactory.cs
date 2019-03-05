using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace TheRatQueen.Factory
{
    class SolidObejtFactory
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
                case "surepipe":

                    go.AddComponent(new solidObjet1(new Vector2(100, 100), 1));
                    go.AddComponent(new SpriteRendere("surepipe"));
                   // go.AddComponent(new ); mangler colider
                    break;
                default:
                    break;
            }

            return go;

        }

    }
}
