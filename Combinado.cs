// Git by example.com


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
        private Texture2D personaje;
        private float velocidadGlobal = 5.0f;
        private Vector2 posicion = Vector2.Zero;
        private Rectangle[] frames;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            frames[0] = new Rectangle(0,0,48,64);
            frames[1] = new Rectangle(48, 64, 48, 64);
            frames[2] = new Rectangle(96, 128, 48, 64);
            frames[3] = new Rectangle(144, 192, 48, 64);
            frames[4] = new Rectangle(192, 256, 48, 64);
            frames[5] = new Rectangle(240, 320, 48, 64);
            frames[6] = new Rectangle(288, 384, 48, 64);
            frames[7] = new Rectangle(336, 448, 48, 64);
            frames[8] = new Rectangle(384, 512, 48, 64);
            frames[9] = new Rectangle(432, 576, 48, 64);
            frames[10] = new Rectangle(480, 640, 48, 64);
            frames[11] = new Rectangle(520, 704, 48, 64);



            base.Initialize();
        }




        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            personaje = Content.Load<Texture2D>("images/charaset");

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
            _spriteBatch.Draw(personaje, posicion, Color.Green);
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

