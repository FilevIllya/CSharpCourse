using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public class Point2D
    {
        private int x;
        private int y;

        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
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

        public string Race { get; private set; }
        public int Armor { get; private set; }
        public Character() //constructor. Basic is in any class if there isnt any constructors
        {

        }

        public Character(string race, int armor = 30 ) //our second constructor
        {
            Race = race;
            Armor = armor;
        }
        public Character(string race)
        {
            Race = race;
            //Armor = 30;
        }

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
