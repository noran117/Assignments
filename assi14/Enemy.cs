using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment14
{
    public class Enemy : Character
    {
        public Enemy(string name, int health) : base(name, health)
        {

        }

        public void Attack(Character character, int amount)
        {
            character.health -= amount;

        }
    }
}

