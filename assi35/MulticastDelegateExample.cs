using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignmet35{
    public delegate void MathOperation(int num);
public class MulticastDelegateExample : MonoBehaviour
{
        void DoubleNumber(int number) => Debug.Log($"The double of the number {number} = {number * 2}");
        void SquareNumber(int number) => Debug.Log($"The square of the number {number} = {number * number}");
        void CubeNumber(int number) => Debug.Log($"The cube of the number {number} = {number * number * number}");
        
    void Start()
    {
        MathOperation operation = null;
        operation += DoubleNumber;
        operation += SquareNumber;
        operation += CubeNumber;

        operation.Invoke(5);
    }

}
}
