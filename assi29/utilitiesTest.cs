using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class utilitiesTest : MonoBehaviour
    {
        
        void Start()
        {
            print("The sum of the numbers is: " + Utilities.Add(1, 2, 3, 4, 5));
            print(Utilities.RepeatString("Hello",3));
            print("Hello".RepeatString(3));

        }

    
    }

}