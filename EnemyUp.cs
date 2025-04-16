using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class EnemyUp
    {
        private Image enemyImage = Engine.LoadImage("assets/enemy.png");

        private EnemyUpMovement enemyUpMovement;
        private Transform transform;


        public EnemyUp(float positionX, float positionY)
        {
            transform = new Transform(new Vector2(positionX, positionY));
            enemyUpMovement = new EnemyUpMovement(transform);
        }

        public void Update()
        {
            enemyUpMovement.Update();
        }

        public void Render()
        {
            Engine.Draw(enemyImage, transform.Position.x, transform.Position.y);
        }
    }
}