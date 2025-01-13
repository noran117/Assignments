using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class BasicScript : MonoBehaviour
    {
              
        void Start()
        {
            var number1=1;
            var text="";
            var bool1=false;
            bool1= number1%2==1? bool1=true:bool1=false;
            text = bool1 ? $"the number {number1} is odd" : $"the number {number1} is even";
            Debug.Log(text);
            
            /*
            string checkNum= number1%2==2? $"the number {number1} is even" : $"the number {number1} is odd";
            Debug.Log(checkNum);
            */
           

            Debug.Log("Current date: " + DateTime.Now.Date);
            Debug.Log("Current time: " + DateTime.Now.TimeOfDay);
            Debug.Log("Current day: " + DateTime.Now.DayOfWeek);



        }
}

}