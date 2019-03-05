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
    class PlayerFactory : Factorye
    {
       private static PlayerFactory instance;

       
        
        public static PlayerFactory Instance
        {
            get
            {
                if (instance == null)
                {

                    instance = new PlayerFactory();
                }
                return instance;
            }
        }

        private PlayerFactory()
        {

        }

        public override GameObject Create(string type)
        {
            GameObject go = new GameObject();
            switch (type)
            {
                default:
                    go.AddComponent(new Player());
                    go.AddComponent(new SpriteRendere("ratQueen"));
                    break;

            }
            return go;
        }

    }
}
