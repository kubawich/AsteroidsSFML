using System;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace AsteroidsSFML
{
    public class player
    {
        protected static Texture playerTexture = new Texture(@"C:\Users\Kuba\Desktop\Projekty\AsteroidsSFML\AsteroidsSFML\Resources\Player.png");
        public Sprite playerSprite = new Sprite();
        public Font font = new Font(@"C:\Windows\Fonts\Roboto-Thin.ttf");
        public Text TextOfPos = new Text();
        public static Vector2f pos;

        public player(Vector2f position, bool showPos)
        {
            pos = position;

            playerTexture.Smooth = true;
            playerSprite.Texture = playerTexture;
            playerSprite.Scale = new Vector2f(0.6f,0.6f);
            playerSprite.Origin = new Vector2f(playerTexture.Size.X / 2, playerTexture.Size.Y / 2);
            playerSprite.Position = position;

            if (showPos)
            {
                ShowPlayerPositionAsDebugText(position);
            }
            else Console.WriteLine("False");
        }

        private void ShowPlayerPositionAsDebugText(Vector2f position)
        {
            TextOfPos.Font = font;
            TextOfPos.CharacterSize = 20;
            TextOfPos.Position = new Vector2f(position.X - 100, position.Y + 45);
            TextOfPos.Color = Color.White;
            TextOfPos.DisplayedString = playerSprite.Position.ToString();
            Console.WriteLine("True " + playerSprite.Position + " " + TextOfPos.Position);
        }

        public void RotatePlayer()
        {
            const float PI = 3.141592653589f;
            var mousepos = Mouse.GetPosition(Setup.win);
            var playerrot = this.playerSprite.Position;

            float dx = mousepos.X - playerrot.X;
            float dy = mousepos.Y - playerrot.Y;

            float rot = -((float)Math.Atan2(dx, dy) * 180 / PI);

            this.playerSprite.Rotation = rot;
        }
    }
}
