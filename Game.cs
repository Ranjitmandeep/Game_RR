using System;

namespace SimpleGame
{
    public class Game
    {
        public int loadbullet, spinbullet, totalbullets = 6;
        public int win = 0, lose = 0, shootawaybullet = 2;
        Random rnd = new Random(); //Random variable used to pick value from 1 to 6
        public void Load() // Load funtion will load the Bullet
        {
            loadbullet = 1;
        }

        public void Spin() // Spin Function will spin Chamber
        {
            spinbullet = rnd.Next(1, 7);
        }

        public void Shoot() // Shoot function will shoot the bullet
        {
            if (totalbullets == 0)
            {
                lose = 1;
            }
            else
            {
                if (loadbullet == spinbullet)// if load bullet is equal to spin then we will loose the game.
                {
                    lose = 1;
                }
                else if (spinbullet == 6)
                {
                    spinbullet = 1;
                }
                else
                {
                    spinbullet++;
                }
                totalbullets--;
            }
        }

        public void ShootAway() // Shoot Away function will save the player
        {
            if (totalbullets == 0 || shootawaybullet == 0)
            {
                lose = 1;
            }
            else
            {
                shootawaybullet--;
                totalbullets--;
                if (loadbullet == spinbullet)
                {
                    win = 1;
                }
                else if (spinbullet == 6)
                {
                    spinbullet = 1;
                    if (shootawaybullet == 0)
                    {
                        lose = 1;
                    }
                }
                else
                {
                    spinbullet++;
                    if (shootawaybullet == 0)
                    {
                        lose = 1;
                    }
                }
            }
        }
    }
}
