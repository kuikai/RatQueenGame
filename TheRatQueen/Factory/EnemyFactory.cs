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
    class EnemyFactory : Factorye
    {
        

        public static EnemyFactory instance;

        public static EnemyFactory Instance
        {
            get
            {
                if (instance == null)
                {

                    instance = new EnemyFactory();
                }
                return instance;
            }
        }

        private EnemyFactory()
        {

        }
        
        public override GameObject Create(string type)
        {
            GameObject go = new GameObject();

            switch (type)
            {
                case "ratQueen":

                    go.AddComponent(new Enemy());
                    go.AddComponent(new SpriteRendere(type));

                    break;

            }

            return go;
        }


        public override GameObject[] Creates(string type, int Howmeny)
        {



            GameObject[] gos = new GameObject[Howmeny];
            switch (type)
            {
                default:
                    break;
            }


            throw new NotImplementedException();
        }
    }
}
