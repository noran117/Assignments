using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment25
{
    public class CameraController  : MonoBehaviour
{
    public Transform target; 
    public float rotationSpeed = 20.0f; 
    public Vector3 offset = new Vector3(0, 3, -5); 
    public float zoomSpeed = 2.0f; 
        public float minDistance = 3.0f;
    public float maxDistance = 10.0f; 
    private bool isZooming = false; 

    private float currentZoom = 0.0f; 

    void Start()
    {

        transform.position = target.position + offset;
        transform.LookAt(target);
    }
    void Update()
    {
        RotateCamera();

        if (isZooming)
        {
            ZoomCamera();
        }
    }

    public void StartZoom()
    {
        isZooming = true;
    }

private void RotateCamera()
    {
        transform.RotateAround(target.position, Vector3.up, rotationSpeed * Time.deltaTime);


        transform.LookAt(target);
    }

    private void ZoomCamera()
    {
        currentZoom += zoomSpeed * Time.deltaTime;
        float distance = Mathf.Lerp(maxDistance, minDistance, currentZoom);

        transform.position = target.position + offset.normalized * distance;

        if (currentZoom >= 1.0f)
        {
            isZooming = false; 

       }

        
        transform.LookAt(target);
    }
}


}