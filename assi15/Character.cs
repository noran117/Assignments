using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

namespace Assignment15
{
    public class Character 
    {
        public string name;
        private int health;
        protected Position position;
        public int Health
        {
            get { return health; }
            set { health = Mathf.Clamp(value, 0, 100); }

        }
        public Character(string name, int health, Position position)
        {
            this.name = name;
            Health = health;
            this.position = position;
        }
        
        public Character(): this("No name", 100, new Position(0, 0, 0))
        {
        }
        
        public virtual void DisplayInfo()
        {
            Debug.Log($"Name: {name}, Health: {Health}");
            position.PrintPosition();
        }

        public void Attack(Character target, int damage) 
        {
            target.Health -= damage;

        }

       
        public void Attack(Character target, int damage,string AttackType)
        {
            Attack(target, damage);
            target.Health -= damage;

        }
    }
}