using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Player
    {
        private Image playerImage = Engine.LoadImage("assets/player.png");

        private PlayerController playerController;
        private Transform transform;

        

        public Player(float positionX, float positionY)
        {
            transform = new Transform(new Vector2(positionX, positionY));
            playerController = new PlayerController(transform);
        }

        public void Update()
        {
            playerController.Update();
        }

        

        public void Render()
        {
            Engine.Draw(playerImage, transform.Position.x, transform.Position.y);
        }
    }
}

// PascalCase  => Clases, métodos
// camelCase   => atributos
