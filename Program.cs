using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Net.NetworkInformation;
using Tao.Sdl;



namespace MyGame
{

    class Program
    {
        static private List<EnemyDown> enemyDownList = new List<EnemyDown>();
        static private List<EnemyUp> enemyUpList = new List<EnemyUp>();
        static private List<Bullet> bulletList = new List<Bullet>();
        static private Image fondo = Engine.LoadImage("assets/street.png");
        static private Player player1;

        static void Main(string[] args)
        {
            Engine.Initialize();
            InitializeLevel();

            while (true)
            {
                Update();
                Render();
            }

        }

        static public void InitializeLevel()
        {
            player1 = new Player(0, 0);
            enemyDownList.Add(new EnemyDown(200,100));
            enemyDownList.Add(new EnemyDown(200, -200));
            enemyDownList.Add(new EnemyDown(200, -400));
            enemyDownList.Add(new EnemyDown(400, -0));
            enemyDownList.Add(new EnemyDown(400, -200));
            enemyUpList.Add(new EnemyUp(400, -400));
            enemyUpList.Add(new EnemyUp(600, -200));
        }

        static void Update()
        {
            
            player1.Update();
          
            for (int i = 0; i < enemyDownList.Count; i++)
            {
                enemyDownList[i].Update();
            }

            for (int i = 0; i < enemyUpList.Count; i++)
            {
                enemyUpList[i].Update();
            }

            for (int i = 0; i < bulletList.Count; i++)
            {
                bulletList[i].Update();
            }

        }
        static void Render()
        {
            Engine.Clear();
            Engine.Draw(fondo, 0, 0);
            player1.Render();

            for (int i = 0; i < enemyDownList.Count; i++)
            {
                enemyDownList[i].Render();
            }

            for (int i = 0; i < enemyUpList.Count; i++)
            {
                enemyUpList[i].Render();
            }

            for (int i = 0; i < bulletList.Count; i++)
            {
                bulletList[i].Render();
            }
            Engine.Show();
        }

        static public void AddBullet(float posX, float posY)
        {
            bulletList.Add(new Bullet(posX + 48,posY));
        }
    }
}