using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

namespace Assignmet35
{
    public class UnityEventExample : MonoBehaviour
    {
        public UnityEvent onEventTriggered;

        void Start()
        {
            onEventTriggered = new UnityEvent();
            onEventTriggered.AddListener(OnEventResponse);

        }
        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                onEventTriggered?.Invoke();
            }
        }
        public void OnEventResponse()
        {
            Debug.Log("The event has been triggered!");
        }

    }
}