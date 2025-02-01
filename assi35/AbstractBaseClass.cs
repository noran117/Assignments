using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignmet35
{
    public class AbstractBaseClass : MonoBehaviour
    {
        private void Start()
        {
            DerivedClassExample derivedInstance = new DerivedClassExample();

            derivedInstance.PerformAction();

            derivedInstance.PrintInfo();
        }
        

    }
    public abstract class TestAbstractClass
    {
        public abstract void PerformAction();
        public void PrintInfo()
        {
            Debug.Log("This is a concrete method from the AbstractBaseClass.");

        }

    }
    public class DerivedClassExample : TestAbstractClass
    {
        public override void PerformAction()
        {
            Debug.Log("PerformAction method implemented in DerivedClassExample.");
        }
    }
}