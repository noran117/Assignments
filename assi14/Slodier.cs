using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment15
{
    public class Slodier : Character
    {
        public Slodier(string name, int health, Position position) : base(name, health, position)
        {

        }

        public override void DisplayInfo()
        {
            Debug.Log("Soldier");
            base.DisplayInfo();
        }

    }
}