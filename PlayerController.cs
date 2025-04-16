using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class PlayerController
    {
        private DateTime timeLastShoot;
        private float timebetweetShoot = 1;
        private int speed = 2;

        private Transform tranform;

        public PlayerController(Transform transform)
        {
            this.tranform = transform;
        }

        public void Update()
        {
            if (Engine.GetKey(Engine.KEY_A) || (Engine.GetKey(Engine.KEY_LEFT)))
            {
                tranform.Translate(new Vector2(-1,0), speed);
            }

            if (Engine.GetKey(Engine.KEY_D) || (Engine.GetKey(Engine.KEY_RIGHT)))
            {
                tranform.Translate(new Vector2(1, 0), speed);
            }

            if (Engine.GetKey(Engine.KEY_W) || (Engine.GetKey(Engine.KEY_UP)))
            {
                tranform.Translate(new Vector2(0,-1), speed);
            }

            if (Engine.GetKey(Engine.KEY_S) || (Engine.GetKey(Engine.KEY_DOWN)))
            {
                tranform.Translate(new Vector2(0, 1), speed);
            }
            if (Engine.GetKey(Engine.KEY_ESP))
            {
                Shoot();

            }
        }
        private void Shoot()
        {
            if ((DateTime.Now - timeLastShoot).TotalSeconds > timebetweetShoot)
            {
                Program.AddBullet(tranform.Position.x, tranform.Position.y);
                timeLastShoot = DateTime.Now;
            }

        }


    }
}
