using System.Security.Cryptography.X509Certificates;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Project3
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D alien;
        private float velocidadGlobal = 5.0f;
        private Vector2 posicion = Vector2.Zero;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {

            base.Initialize();
        }




        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            alien = Content.Load<Texture2D>("C:\\Users\\Redes-20\\Desktop\\Project3\\alien");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            movimientoTeclado();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            _spriteBatch.Draw(alien, posicion, Color.Green);
            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }


        void movimientoTeclado()
        {
            float velocidadMovimiento = velocidadGlobal;
            KeyboardState teclaPresionada = Keyboard.GetState();

            if (teclaPresionada.IsKeyDown(Keys.W) || teclaPresionada.IsKeyDown(Keys.Up))
            {
                posicion.Y -= velocidadGlobal;
            }

            if (teclaPresionada.IsKeyDown(Keys.S) || teclaPresionada.IsKeyDown(Keys.Down))
            {
                posicion.Y += velocidadGlobal;
            }

            if (teclaPresionada.IsKeyDown(Keys.A) || teclaPresionada.IsKeyDown(Keys.Left))
            {
                posicion.X -= velocidadGlobal;
            }

            if (teclaPresionada.IsKeyDown(Keys.D) || teclaPresionada.IsKeyDown(Keys.Right))
            {
                posicion.X += velocidadGlobal;
            }
        }
        }



    } 


