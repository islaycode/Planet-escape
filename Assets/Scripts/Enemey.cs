using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemey : MonoBehaviour {

    [SerializeField] GameObject deathFx;
    [SerializeField] Transform parent; // 
	// Use this for initialization
	void Start () {

        Collider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = false;
    }
    void OnParticleCollision(GameObject other)
    {
        GameObject fx = Instantiate(deathFx, transform.position, Quaternion.identity);
        fx.transform.parent = parent;
        Destroy(gameObject); // To destroy the gameObject in game i.e Enemey ship. 
    }
}
