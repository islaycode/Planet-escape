using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemey : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Collider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = false;
    }
    void OnParticleCollision(GameObject other)
    {
        print("Particles collided with enemey" + gameObject.name);
        Destroy(gameObject); // To destroy the gameObject in game i.e Enemey ship. 
    }
}
