using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment14
{
    public class Playerr : Character
    {
        public Playerr(string name, int health) : base(name, health)
        {

        }

        public void heal(int amount)
        {
            health += amount;

        }
    }
}