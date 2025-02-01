using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace  Assignmet35
{
    
public class BoxingUnboxing : MonoBehaviour
{
    int Health = 100;
    
    void Start()
    {
        object inBox = (int) Health;
        int unBoxing = (int)inBox;
        unBoxing -= 30;
         Debug.Log($"Original int value: {Health}");
        Debug.Log($"Boxed value: {inBox}");
        Debug.Log($"Unboxed and modified value: {unBoxing}");
    }
}
}