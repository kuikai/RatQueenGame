using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceGame
{
  public  class GameObject
    {
        List<Componet> Componets = new List<Componet>();


        
       public Transfrom Transfrom { get; private set; }

   
       public GameObject()
        {
            this.Transfrom = new Transfrom(Vector2.Zero);
           AddComponent(Transfrom);
        }
        public void AddComponent(Componet componet)
        {
            componet.Attach(this);
            Componets.Add(componet);
        }
        public Componet GetComponet(string Compent)
        {
          
            return Componets[1];
        }
        public void LoadContent(ContentManager content)
        {

            //  Componets[0].LoadContet(content);

            foreach (Componet Com in Componets)
            {
                Com.LoadContet(content);
            }

        } 
        public void update(GameTime gameTime)
        {

            //Componets[0].update(gameTime);
            //foreach (Componet Com in Componets)
            //{
            //    Com.update(gameTime);
            //}

        }

        public void draw(SpriteBatch spriteBatch)
        {
            foreach (Componet Com in Componets)
            {
                Com.Draw(spriteBatch);
            }
        }
        //public Componet GetComponent(string component)
        //{
        //    return Componets.Find(x => x.GetType().Name == component);
        //}
    }
}
