using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignmet35
{
    public class BuiltInDelegatesExample : MonoBehaviour
{
     Action log = () => Debug.Log("Hello from Action delegate!");
     Func<int, int> square = num => num*num;
     Predicate<int> isEven =x=> x%2==0;


    void Start()
    {
       log();
       Debug.Log($"Square of 5: {square(5)} ");
       Debug.Log($"Is 4 even? {isEven(4)} ");
    }

  
}
}