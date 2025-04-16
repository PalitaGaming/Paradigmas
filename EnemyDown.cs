using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class EnemyDown
    {
        private Image enemyImage = Engine.LoadImage("assets/enemy.png");

        private EnemyDownMovement enemyDownMovement;
        private Transform transform;


        public EnemyDown(float positionX, float positionY)
        {
            transform = new Transform(new Vector2(positionX, positionY));
            enemyDownMovement = new EnemyDownMovement(transform);
        }

        public void Update()
        {
            enemyDownMovement.Update();
        }

        public void Render()
        {
            Engine.Draw(enemyImage, transform.Position.x, transform.Position.y);
        }
    }
}