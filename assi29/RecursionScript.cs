using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class RecursionScript : MonoBehaviour
    {
        private void Start()
        {
            Debug.Log("Recursive Fibonacci of 10= "+ FibonacciRecursive(10));
            Debug.Log("Recursive Fibonacci of 30= " + FibonacciRecursive(30));

            Debug.Log("Iterative Fibonacci of 10= " + FibonacciIterative(10));
            Debug.Log("Iterative Fibonacci of 30= " + FibonacciIterative(10));

        }
        public int FibonacciIterative(int n)
        {
            if (n < 0) return -1;
            if (n == 0) return 0;
            if (n == 1) return 1;

            int x = 0;
            int y = 1;
            for (int i = 2; i <= n; i++)
            {
                int temp = x + y;
                x = y;
                y = temp;
            }
            return y;

        }
        int FibonacciRecursive(int n)
        {

            //if (n < 0) return -1;
            //if (n == 0) return 0;
            //if (n == 1) return 1;

            if (n <= 1)
            {
                return n; 
            }
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

    }
}