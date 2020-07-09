using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemey : MonoBehaviour {

    [SerializeField] GameObject deathFx;
    [SerializeField] Transform parent; 
    [SerializeField] int scorePerHit = 12;
    ScoreBoard scoreboard; //Creating Reference for the score board

	// Use this for initialization
	void Start ()
    {
        AddBoxCollider();
        scoreboard = FindObjectOfType<ScoreBoard>();
    }

    private void AddBoxCollider()
    {
        Collider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = false;
    }

    void OnParticleCollision(GameObject other)
    {
        scoreboard.scoreHit(scorePerHit); // It will access the method we created in scoreboard and hence will increase the score by 12
        GameObject fx = Instantiate(deathFx, transform.position, Quaternion.identity);
        fx.transform.parent = parent;
        Destroy(gameObject); // To destroy the gameObject in game i.e Enemey ship. 
    }
}
