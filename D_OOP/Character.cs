using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public class Character//default is internal
    {
        //without any text members will be private
        //property
        private static int speed = 10;
        public int Health { get; private set; } = 100;

        //its like:
        //public int GetHealth() 
        //{
        //    return health;
        //}
        //private void SetHealth(int value)//default is public
        //{
        //    health = value;
        //}

        public void Hit(int damage)
        {
            if (damage> Health)
            {
                damage = Health;
            }
            //health -= damage;
            Health -= damage;
        }

        public int PrintSpeed()
        {
           return speed;
        }

        public void IncreaseSpeed()
        {
            speed += 10;
        }
    }
}
