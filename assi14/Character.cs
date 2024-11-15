using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

namespace Assignment14
{
    public class Character
    {
        public string name
        {
            get;
            set;
        }
        public int health
        {
            get { return health; }
            set { health = Mathf.Clamp(value, 0, 100); }

        }
        //public int healthTest(int health)
        //{
        //    if (health <= 100 && health >= 0)
        //    {
        //        this.health = health;
        //    }
        //    return this.health;
        //}


        public Character(string name, int health)
        {
            this.name = name;
            this.health = health;
        }


    }
}