using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TheRatQueen
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class GameWorld : Game
    {
        static  GraphicsDeviceManager graphics;

      public static List<GameObject> gameObjects = new List<GameObject>();
      public static List<GameObject> TobeAddGo = new List<GameObject>();
      public static List<GameObject> RemoveObject = new List<GameObject>();

        SpriteBatch spriteBatch;

       // List<GameObject> gameObjects = new List<GameObject>();
        GameObject player;
        GameObject gameObject;

        InputHandler InputHandler;
        public GameWorld()
        {
            graphics = new GraphicsDeviceManager(this);

            graphics.PreferredBackBufferWidth = 1280;
            graphics.PreferredBackBufferHeight = 720;
            Content.RootDirectory = "Content";
        }
         
        public static void addGameObject(GameObject game)
        {
            TobeAddGo.Add(game);
        }

        public static void RemoveGameObject(GameObject game)
        {
            RemoveObject.Add(game);

        }

        public static Rectangle ScreenSize
        {
            get
            {
                return graphics.GraphicsDevice.Viewport.Bounds;
            }
        }


        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            InputHandler = new InputHandler();
            player = new GameObject();
            player.AddComponent(new Player());
            player.AddComponent(new SpriteRendere("ratQueen"));

            gameObjects.Add(player);
     
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);


            foreach (GameObject go in gameObjects)
            {
                go.loadContent(Content);
            }

           // player.loadContent(Content);
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            foreach (GameObject go in gameObjects)
            {
                go.Update(gameTime);
            }

          //  player.Update(gameTime);
            // TODO: Add your update logic here

            RemoveObject.Clear();
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            foreach(GameObject go in gameObjects)
            {
                go.draw(spriteBatch);
            }

          //  player.draw(spriteBatch);

            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
