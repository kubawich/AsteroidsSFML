using System;
using SFML.Graphics;
using SFML.System;

namespace AsteroidsSFML
{   
    class Bullet
    {
        Texture bulletTexture;
        public Sprite bulletSprite;
        
        public Bullet() {
            bulletTexture = new Texture(@"C:\Users\Kuba\Desktop\Projekty\AsteroidsSFML\AsteroidsSFML\Resources\Bullet.png");
            bulletSprite = new Sprite(bulletTexture);
        }
        public void Shoot(RenderWindow w) {
            w.Draw(this.bulletSprite);
            this.bulletSprite.Position = player.pos;
        }
    }
}
