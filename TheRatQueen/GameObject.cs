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
   public  class GameObject
    {


        private List<Componet> componets = new List<Componet>();

        public Transform transform { get; private set; }
        


        public GameObject()
        {
            this.transform = new Transform(Vector2.Zero);
           
            AddComponent(transform);


        }

       public void AddComponent(Componet component)
        {
            component.Attach(this);
            componets.Add(component);
        }

        public void loadContent(ContentManager content)
        {
            foreach (Componet com in componets)
            {
                com.LoadContent(content);
            }
        }
       
        public void draw(SpriteBatch spriteBatch)
        {
            foreach  (Componet com in componets)
            {
                com.Draw(spriteBatch);
            }
        }


        public void Update(GameTime gameTime)
        {
            foreach(Componet com in componets)
            {
                com.Update(gameTime);
            }
        }

        

        public void RemoveComponet(Componet componet)
        {

        }

        public Componet GetComponet(string componet)
        {
            return componets.Find(x => x.GetType().Name == componet);
        }
    }


}
