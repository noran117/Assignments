using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment27
{
    public class callByReference : MonoBehaviour
    {
    
    void Start()
    {
        int num1 = 5;
        int num2 = 10;

        Debug.Log("Before calling by value "+num1);
        callByValue(num1);
        Debug.Log("After calling by value " + num1);

        Debug.Log("Before calling by reference " + num2);
        callByreference(ref num2);
        Debug.Log("After calling by reference " + num2);

        int num3;
        usingOut(out num3);
        Debug.Log("After usingOut " + num3);

    }

    private void callByValue(int num)
    {
        num += 10;
    }
   
    private void callByreference(ref int num)
    {
        num += 10;
    }
     private void usingOut(out int num)
    {
        num = 20;
    }


    
}
}