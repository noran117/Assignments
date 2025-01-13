using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

namespace Assignment29
{
    public class ExeptionHandling : MonoBehaviour
    {
        void Start()
        {
            int playerScore=100;
            int diviser=0;
            try
            {
                Debug.Log("Attempting to calculate score multiplyer..");
                int playersTotalScore =playerScore/diviser;
            }
            catch (DivideByZeroException ex) 
            {
                Debug.LogError("Error: divide by zero exception" );
                Debug.LogError(ex.Message);
            }
            finally
            {
                //Score;
                Debug.Log("Score calculation complete. cleaning up resources");
            }

        }

        
    }
}