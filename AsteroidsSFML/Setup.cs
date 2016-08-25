using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace AsteroidsSFML
{
    class Setup
    {
        public static RenderWindow win;
        public View view;
        public player Player;
        public Bullet bullet;
        Texture texbackground;
        Sprite background;

        public Setup(uint width, uint height, string title)
        {
            win = new RenderWindow(new VideoMode(width, height), title);
            VariablesSetup();
        }

        void Win_Setup()
        {
            win.DispatchEvents();
            win.SetView(view);
            win.Clear(Color.Cyan);
            win.Draw(background);
            win.Draw(Player.playerSprite);
            win.Draw(Player.TextOfPos);
            win.Display();
        }

        void VariablesSetup()
        {
            view = new View(new FloatRect(0, 0, win.Size.X, win.Size.Y));
            Player = new player(new Vector2f(win.Size.X / 2, win.Size.Y / 2), true);
            texbackground = new Texture(@"C:\Users\Kuba\Desktop\Projekty\AsteroidsSFML\AsteroidsSFML\Resources\background.jpg");
            background = new Sprite(texbackground) { Origin = new Vector2f(view.Size.X / 2, view.Size.Y / 2), Scale = (Vector2f)win.Size / 1500 };
            bullet = new Bullet();

            win.Closed += Win_Closed;
            win.MouseMoved += Win_MouseMoved;
            win.MouseButtonPressed += Win_MouseButtonPressed;

            while (win.IsOpen)
            {
                Win_Setup();
            }

        }

        void Win_Closed(object sender, EventArgs e)
        {
            win.Close();
        }

        private void Win_MouseMoved(object sender, MouseMoveEventArgs e)
        {
            Player.RotatePlayer();
        }

        private void Win_MouseButtonPressed(object sender, MouseButtonEventArgs e)
        {
            bullet.Shoot(win);
        }
    }
}
