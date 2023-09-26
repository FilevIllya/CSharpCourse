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
        private readonly int speed; //read only its like const but there's no need assigned right now
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

        public Race Race { get; private set; }
        public int Armor { get; private set; }
        public Character() //constructor. Basic is in any class if there isnt any constructors
        {

        }

        public Character(Race race, int armor = 30 ) //our second constructor
        {
            Race = race;
            Armor = armor;
        }
        public Character(Race race)
        {
            Race = race;
            Armor = (int)race;

            //using enumiration
            switch (race)
            {
                case Race.Elf:
                    Armor = 30;
                    break;
                case Race.Ork:
                    Armor = 40;
                    break;
                case Race.Terrain:
                    Armor = 20;
                    break;
                default:
                    throw new ArgumentException("Unknow race.");
                    break;
            }

            //or

            if (race == Race.Terrain)
            {
                Armor = 20;
            }
            else if (race == Race.Ork)
            {
                Armor = 40;
            }
            else if (race == Race.Elf)
            {
                Armor = 30;
            }
            else
            {
                throw new ArgumentException("Unknow race.");
            }
        }

        public Character(Race race, int armor, int speed) //our second constructor
        {
            Race = race;
            Armor = armor;
            this.speed = speed;
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
            //speed += 10;
        }
    }
}
