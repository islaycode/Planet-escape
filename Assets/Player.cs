using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput; // For using cross platform input functions

public class Player : MonoBehaviour {

    [Tooltip("In m^-1")][SerializeField] float speed = 10f; // Multiply this for increasing speed of senstivity 
    [Tooltip("In m")] [SerializeField] float xRange = 3f;
    [Tooltip("In m")] [SerializeField] float yRange = 3f;

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
        transform.localRotation = Quaternion.Euler(-30f,30f,0f); 
    }

    private void ProcessTranslation()
    {
        float xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float xOffset = xThrow * speed * Time.deltaTime;

        float rawPos = transform.localPosition.x + xOffset;
        float clampedXPos = Mathf.Clamp(rawPos, -xRange, xRange);

        float yThrow = CrossPlatformInputManager.GetAxis("Vertical");
        float yOffset = yThrow * speed * Time.deltaTime;

        float rawPos2 = transform.localPosition.y + yOffset;
        float clampedYPos = Mathf.Clamp(rawPos2, -yRange, yRange);

        transform.localPosition = new Vector3(clampedXPos, clampedYPos, transform.localPosition.z); // for controlling the movement of the ship
    }
}
