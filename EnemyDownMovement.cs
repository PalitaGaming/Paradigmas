using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class EnemyDownMovement
    {
        private Transform transform;
        private int speed = 2;

        public EnemyDownMovement(Transform transform)
        { 
            this.transform = transform;
        }

        public void Update()
        {
            transform.Translate(new Vector2(0, 1), speed);

            if (transform.Position.x > 1024 - 100 || transform.Position.x < 0)
            {
                speed = speed * -1;
            }
        }

    }
}
