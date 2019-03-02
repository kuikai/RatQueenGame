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

namespace SpaceGame
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class GameWorld : Game
    {
        private static GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
     
        InputHandler inputHandler = new InputHandler();
        GameObject gameObject;
      
        GameObject Playergo;
        Texture2D sprite;
        SpriteRendere spriteRendere;
        Componet com;
        //Player player;
        //Player player2;
        
        private SpriteFont KillCount;
        public  int screensizeheigt;
       public  int screemSizewrith;


        public GameWorld()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        
            graphics.PreferredBackBufferWidth = 1280;
            graphics.PreferredBackBufferHeight = 720;
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
            screensizeheigt = graphics.PreferredBackBufferHeight;
            screemSizewrith = graphics.PreferredBackBufferWidth;

            Playergo = new GameObject();
            Playergo.AddComponent(new Player(new Vector2(200, 200)));
            Playergo.AddComponent(new SpriteRendere(5, "PlayerSheet"));
            base.Initialize();
        }
        public static Rectangle ScreenSize
        {
            get
            {
                return graphics.GraphicsDevice.Viewport.Bounds;
            }
        }


        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary
     
       
        protected override void LoadContent()
        {
            
         //   sprite = Content.Load<Texture2D>("PlayerSheet");
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Vector2 postion = new Vector2(screemSizewrith/2, 600);
            //player = new Player(new Vector2(screemSizewrith/2,screensizeheigt+100),5 , "PlayerSheet");         
           gameObject = new GameObject();
            Playergo.LoadContent(Content);
   
           //spriteRendere = new SpriteRendere(new Vector2(400, 400), 5, "PlayerSheet");
           //spriteRendere.LoadContet(Content);

           // player.LoadContet(Content);
            //gameObject.AddComponent(player);
            //gameObject.AddComponent(player2);
            gameObject.LoadContent(Content);
           // player.LoadContet(Content);
            inputHandler.inputHandler();
            KillCount = Content.Load<SpriteFont>("Text");

            //// TODO: use this.Content to load your game content here
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
         

            //inputHandler.Ecervute(gameTime,player );
         
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

        
            // TODO: Add your drawing code here
            spriteBatch.Begin();

            Playergo.draw(spriteBatch);
             //gameObject.draw(spriteBatch);
            spriteBatch.DrawString(KillCount, $"Rotetio", new Vector2(1160, 5), Color.Red);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
