using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Assignment29
{
    public class SeparateScript : MonoBehaviour
    {
        CustomObject customObject;
        CustomObject customObject2;
        void Start()
        {
            customObject=new CustomObject(20,"Amal");
            customObject2=new CustomObject(30,"Adnan");

            print(customObject.ToString());


            //comparing
            print("Are objects equal?" + customObject.Equals(customObject2));
            print("Are objects notEqual?" + !customObject.Equals(customObject2));

            print($"Are objects equal? {customObject == customObject2}");
            print($"Are objects not equal? {customObject != customObject2}");
        }
    }

}