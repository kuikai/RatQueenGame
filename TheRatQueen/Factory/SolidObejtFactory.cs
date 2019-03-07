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
    public class SolidObejtFactory : Factorye
    {

        private static SolidObejtFactory instance;

        Random rand = new Random();
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


      
        
        public override GameObject Create(string type)
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

        public override GameObject[] Creates(string type, int Howmeny)
        {


            Random rand = new Random();
            int x=600;
            int y=600;
            GameObject[] gos = new GameObject[Howmeny];

            switch (type)
            {
                case "pipe":

                    for (int i =0; i < Howmeny; i++)
                    {
                       
                        gos[i] = new GameObject();
                        gos[i].AddComponent(new solidObjet1(new Vector2(x, y), 1));
                        gos[i].AddComponent(new SpriteRendere("pipe"));
                        gos[i].AddComponent(new Collision());


                        x = rand.Next(100, 1000);
                        y -= 200;

                    }

                    break;
                default:
                    break;
            }


            
            return gos;
        }
    }
}
