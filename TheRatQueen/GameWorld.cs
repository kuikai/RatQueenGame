using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Audio;
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

        
        private static GameWorld instance;

        static  GraphicsDeviceManager graphics;

        public static List<GameObject> gameObjects  = new List<GameObject>();
        public static List<GameObject> TobeAddGo = new List<GameObject>();
        public static List<GameObject> RemoveObject = new List<GameObject>();
        public List<Collision> Colliders { get; set; } = new List<Collision>();

        
        public SpriteFont font;
      
        public Vector2 WorldZice;

        Camera camera;
        SpriteBatch spriteBatch;

        public Texture2D Background;

        //List<GameObject> gameObjects = new List<GameObject>();


        //GameObject player;
        //GameObject gameObject;

        InputHandler InputHandler;
        public static GameWorld Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameWorld();
                }

                return instance;
            }
        }

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


       static private Vector2 Playerposition;
        public Vector2 playerPositon
        {
            get { return Playerposition; }
        }
   public static void GetPlayerPosition(Vector2 position)
        {
            Playerposition = position;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        /// 
        Random rand = new Random();
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            WorldZice = new Vector2(GraphicsDevice.Viewport.Height, GraphicsDevice.Viewport.Height);
            InputHandler = new InputHandler();

            camera = new Camera(graphics.GraphicsDevice.Viewport);
            gameObjects.Add(PlayerFactory.Instance.Create("ratQueen"));


           gameObjects.Add(SolidObejtFactory.Instance.Create("pipe"));
           gameObjects.AddRange( SolidObejtFactory.Instance.Creates("pipe", 100));
           

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

            Song song = Content.Load<Song>("Rat_Song");  
            MediaPlayer.Play(song);

            Background = Content.Load<Texture2D>("cc_Cloaca-Massima_Cover-letter_PNAS_16x9");
            font = Content.Load<SpriteFont>("PlayerPosition");
      
            foreach (GameObject go in gameObjects)
            {
                go.loadContent(Content);
            }         
      
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

                //Checke For Colisitions
                foreach (GameObject other in gameObjects)
                {
                    
                }
            }
            camera.update(playerPositon);
       
            // TODO: Add your update logic here
            // RemoveObject.Clear();
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

            Rectangle Rectangle;
            spriteBatch.Draw(Background, Rectangle = new Rectangle(0, 0, Background.Width, Background.Height), Color.White);
            spriteBatch.End();
        
            
            spriteBatch.Begin(SpriteSortMode.Deferred,
              BlendState.AlphaBlend, null, null, null, null, camera.Transform);


            foreach(GameObject go in gameObjects)
            {
                go.draw(spriteBatch);
            }
           


            spriteBatch.End();

            // fonts
            spriteBatch.Begin();
            spriteBatch.DrawString(font, $"Player Position:{playerPositon}", new Vector2(580, 5), Color.Red);
        
           
            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
