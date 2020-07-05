using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput; // For using cross platform input functions

public class Player : MonoBehaviour {

    [Tooltip("In m^-1")][SerializeField] float speed = 10f; // Multiply this for increasing speed of senstivity 
    [Tooltip("In m")] [SerializeField] float xRange = 3f;
    [Tooltip("In m")] [SerializeField] float yRange = 3f;
    [SerializeField] float positionPitch = -15;
    [SerializeField] float controlPitch = -30f;
    [SerializeField] float positionYaw = -10f;
    [SerializeField] float YawPitch = -5f;
    float xThrow, yThrow;

    // Use this for initialization
    void Start () {
		
	}	
	// Update is called once per frame
	void Update ()
    {
        ProcessTranslation();
        ProcessRotation();

    }

    private void ProcessRotation()
    {
        float pitch = transform.localPosition.y * positionPitch + yThrow *controlPitch;
        float yaw = transform.localPosition.x *positionYaw + xThrow *YawPitch ;
        float roll = 0;
        transform.localRotation = Quaternion.Euler(pitch,yaw,roll); 
    }

    private void ProcessTranslation()
    {
        xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float xOffset = xThrow * speed * Time.deltaTime;

        float rawPos = transform.localPosition.x + xOffset;
        float clampedXPos = Mathf.Clamp(rawPos, -xRange, xRange);

        yThrow = CrossPlatformInputManager.GetAxis("Vertical");
        float yOffset = yThrow * speed * Time.deltaTime;

        float rawPos2 = transform.localPosition.y + yOffset;
        float clampedYPos = Mathf.Clamp(rawPos2, -yRange, yRange);

        transform.localPosition = new Vector3(clampedXPos, clampedYPos, transform.localPosition.z); // for controlling the movement of the ship
    }
}
