using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public float rotateSpeed = 1.0f; // Speed of camera rotation
    private Vector2 touchStartPosition; // Starting position of touch
    public GameObject marker;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1) // Check if there is only one touch
        {
            Touch touch = Input.GetTouch(0); // Get the first touch

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    touchStartPosition = touch.position; // Store the starting position of touch
                    break;
                case TouchPhase.Moved:
                    Vector2 touchDelta = touch.deltaPosition; // Get the change in touch position
                    float rotationY = -touchDelta.x * rotateSpeed * Time.deltaTime; // Calculate the rotation around Y axis

                    float myAngle = transform.eulerAngles.y;

                    //if(myAngle>270 )
                    //{
                    //    myAngle -= 270;
                    //}

                    //if (myAngle%90 + rotationY * 2 < 40)
                    //{

                    Debug.Log(rotationY);    

                    if(  (rotationY<0 && marker.transform.position.x >= -1.73f) || (rotationY > 0 && marker.transform.position.x <= 0.91))
                    {
                        transform.Rotate(0f, rotationY, 0f);
                    }
                   
                    else
                    {
                        if(marker.transform.position.x > 0.91)
                        {
                            Debug.Log("lock");
                        }
                        else
                        {
                            Debug.Log("AnoLock");
                        }
                    }




                     // Rotate the camera based on touch input

           
                    //}
                   


                    
                   
                    
                    break;
            }
        }
    }
}
